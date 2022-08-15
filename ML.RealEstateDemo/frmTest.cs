using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Double;
using ML.RealEstate.Data;
using ML.RealEstate.Predict;
using System.IO;
using System.ComponentModel;

namespace ML.RealEstateDemo
{
    public partial class frmTest : Form
    {
        string folder = "Models";
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RealEstateModel regModel = new RealEstateModel();
            var trendingdata = Enumerable.Range(0, 1000).Select(x => (double)x);
            int slope = 10;
            int offsett = 50;
            int quadraticTransform = 4;
            DenseVector y = DenseVector.OfEnumerable(trendingdata.Select(x => x * x * x + offsett - x * x * quadraticTransform));
            DenseVector x1 = DenseVector.OfEnumerable(trendingdata.Select(x => x));
            DenseVector x2 = DenseVector.OfEnumerable(trendingdata.Select(x => x * x));
            DenseVector x3 = DenseVector.OfEnumerable(trendingdata.Select(x => x * x * x / slope));
            regModel.Fit(DenseMatrix.OfColumnVectors(x1, x2, x3),y);
            double[] betaValues = regModel.coeficients.ToArray();
            if (Math.Abs(betaValues[0] - offsett) > 0.0001 | Math.Abs(betaValues[1]) > 0.0001 | Math.Abs(betaValues[2] + quadraticTransform) > 0.0001 | Math.Abs(betaValues[3] - slope) > 0.0001)
            { throw new Exception("Regression is calculating biased estimators for the multiple non-linear case!"); }
            else { Console.WriteLine("Multiple Regression test for estimator values passed!"); }
            var errorsOFestimatorsWithGoodFit = regModel.CoeficientsStandardDeviation().ToArray();
            // now now compare the Se for random inputs
            Random r = new Random();
            x3 = DenseVector.OfEnumerable(Enumerable.Repeat(r.NextDouble() * 100, y.Count));
            regModel.Fit(DenseMatrix.OfColumnVectors(x1, x2, x3),y);
            var errorsOFestimatorsWithBadFit = regModel.CoeficientsStandardDeviation().ToArray();
            bool goodEstimate(int i)
            {
                return errorsOFestimatorsWithGoodFit[i] * 10 < errorsOFestimatorsWithBadFit[i];
            }
            if (!goodEstimate(0) | !goodEstimate(1) | !goodEstimate(2)) // after changing one variable with random noise, the standard errors of the relevant inputs should blow up
            { throw new Exception("Regression is calculating suspicious estimates for the standard errors of the regression parameters!"); }
            else { Console.WriteLine("Multiple Regression test for reasonable standard errors passed!"); }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            int offsett = 50;
            RealEstateModel regModel = new RealEstateModel();
            RealEstateDatabase.LoadAllDataset();
            RealEstateDatabase.HouseDataList = RealEstateDatabase.HouseDataList.Take(2000).ToList();

            DenseVector y = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x=>x.Price*1.0));
            DenseVector HouseId = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.HouseTypeId*1.0));
            DenseVector CityId = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.CityId * 1.0));
            DenseVector DistrictId = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.DistrictId * 1.0));
            DenseVector WardId = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.WardId * 1.0));
            DenseVector Area = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.Area * 1.0));
            DenseVector FrontiSpiece = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.FrontiSpiece * 1.0));
            DenseVector Entrance= DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.Entrance * 1.0));
            DenseVector Floor= DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.Floor * 1.0));
            DenseVector Bedroom = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.BedRoom * 1.0));
            DenseVector RestRoom = DenseVector.OfEnumerable(RealEstateDatabase.HouseDataList.Select(x => x.ToiletRoom * 1.0));
            /* DenseMatrix features = DenseMatrix.OfColumnVectors(
                 HouseId, CityId, DistrictId, WardId, 
                 Area, FrontiSpiece, Entrance, Floor, Bedroom, RestRoom);
             regModel.Fit(y, features);*/

            DenseMatrix features = DenseMatrix.OfColumnVectors(                 
                 Area, FrontiSpiece, Entrance, Floor, Bedroom, RestRoom);
            regModel.Fit(features,y);
            double[] betaValues = regModel.coeficients.ToArray();
            string sss = "";

            double pre = regModel.Predict(new double[,] {  { 100 }, { 4 }, { 6 }, { 5 }, { 3 }, { 2 } });

            txtPrice.Text = pre + "";

            RealEstateDatabase.HouseDataList = RealEstateDatabase.HouseDataList.Take(2000).ToList();

            Metric metric = regModel.Evaluate();
            lblRSquared.Text = Math.Round(metric.RSquared*100,2) + "%";
            lblRMSE.Text = Math.Round(metric.RMSE,2) + "";
            lblMSE.Text = Math.Round(metric.MSE, 2) + "";
            lblMAE.Text= Math.Round(metric.MAE, 2) + "";
        }
        RealEstateModel regModel = null;
        BackgroundWorker worker;
        int loop = 10000;
        double rexpected = 90;
        double testRatio = 0.2;
        List<RealEstateModel> models = null;
        private void button5_Click(object sender, EventArgs e)
        {
            stop = false;
            
            RealEstateDatabase.LoadAllDataset();
            models = new List<RealEstateModel>();
            loop = int.Parse(txtLoop.Text);
            rexpected = double.Parse(txtExpected.Text);
            testRatio=double.Parse(txtTestRatio.Text);
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerAsync();


           
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RealEstateModel realEstate =e.UserState as RealEstateModel;
            if(realEstate!=null)
            {
                Metric metric = realEstate.Metric;
                lblRSquared.Text = Math.Round(metric.RSquared * 100, 2) + "%";
                lblRMSE.Text = Math.Round(metric.RMSE, 2) + "";
                lblMSE.Text = Math.Round(metric.MSE, 2) + "";
                lblMAE.Text = Math.Round(metric.MAE, 2) + "";

                models.Add(realEstate);
            }            
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < loop; i++)
            {
                TrainTestSet trainData = RealEstateDatabase.SplitTrainTest(RealEstateDatabase.HouseDataList, testRatio);
                
                regModel = new RealEstateModel();

                regModel.TrainTestData = trainData;

                regModel.Fit(trainData.TrainSet.Features,trainData.TrainSet.Target);

                Metric metric = regModel.Evaluate(trainData.TestSet.Features,trainData.TestSet.Target);
               

                worker.ReportProgress(i, regModel);

                System.Threading.Thread.Sleep(1);
                
                if (metric.RSquared * 100 >= rexpected || stop==true)
                    break;
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Building completed!");
            if (models != null)
            {
                regModel =models.OrderByDescending(x => x.Metric.RSquared).FirstOrDefault();
               
                Metric metric = regModel.Metric;
                lblRSquared.Text = Math.Round(metric.RSquared * 100, 2) + "%";
                lblRMSE.Text = Math.Round(metric.RMSE, 2) + "";
                lblMSE.Text = Math.Round(metric.MSE, 2) + "";
                lblMAE.Text = Math.Round(metric.MAE, 2) + "";

                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (Directory.Exists(folder) == false)
            {
                Directory.CreateDirectory(folder);
            }
            string trainalgorithm = "_" + txtTestRatio.Text + "_";
            string path = folder + "\\ML.RealEstate" + trainalgorithm + DateTime.Now.ToString("MMddyyyy"); 
            bool ret = IOFactory.SaveModel(regModel,path + ".zip");

            IOFactory.ParseJson(regModel.TrainTestData.TrainSet.Houses, path+"_train.json");
            IOFactory.ParseJson(regModel.TrainTestData.TestSet.Houses, path + "_test.json");

            if (ret)
                lblSaveModelStatus.Text = "Save Model successfully";
            else
                lblSaveModelStatus.Text = "Save Model failed";
            LoadModelIntoCombo();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadModelIntoCombo();

            cboHouseType.DataSource = RealEstateDatabase.GetHouseTypes();
            cboHouseType.ValueMember = "Id";
            cboHouseType.DisplayMember = "TypeOfHouse";

            cboCity.DataSource = RealEstateDatabase.GetCities();
            cboCity.ValueMember = "Id";
            cboCity.DisplayMember = "CityName";
        }
        private void LoadModelIntoCombo()
        {
            cboModel.Items.Clear();

            if (Directory.Exists(folder) == false)
            {
                return;
            }
            string[] files = Directory.GetFiles(folder,"*.zip");
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                cboModel.Items.Add(fi.Name);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            regModel = null;
            if (cboModel.SelectedIndex == -1)
                return;
            string modelName = folder + "\\" + cboModel.Text;
            regModel = IOFactory.LoadModel(modelName) as RealEstateModel;
            if (regModel != null)
            {
                lblLoadModelStatus.Text = "Load Model successfully";

                Metric metric = regModel.Metric;
                lblRSquared.Text = Math.Round(metric.RSquared * 100, 2) + "%";
                lblRMSE.Text = Math.Round(metric.RMSE, 2) + "";
                lblMSE.Text = Math.Round(metric.MSE, 2) + "";
                lblMAE.Text = Math.Round(metric.MAE, 2) + "";
            }
            else
                lblLoadModelStatus.Text = "Load Model failed";
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if(regModel==null)
            {
                MessageBox.Show("Must Load model before");
                return;
            }
            double HouseTypeId = (cboHouseType.SelectedItem as HouseType).Id;
            double WardId = (cboWard.SelectedItem as Ward).Id;
            double DistrictId = (cboDistrict.SelectedItem as District).Id;
            double CityId = (cboCity.SelectedItem as City).Id;

            double area = double.Parse(txtArea.Text);
            double frontiSpiece = double.Parse(txtFrontiSpiece.Text);
            double entrance=double.Parse(txtEntrance.Text);
            double floor = double.Parse(txtFloor.Text);
            double bedroom = double.Parse(txtBedRoom.Text);
            double restroom = double.Parse(txtRestRoom.Text);
            //double pre = regModel.Predict(new double[,] { { HouseTypeId },{ WardId },{ DistrictId },{ CityId }, { area }, { frontiSpiece }, { entrance }, { floor }, { bedroom }, { restroom } });
            double pre = regModel.Predict(new double[,] { { area }, { frontiSpiece }, { entrance }, { floor }, { bedroom }, { restroom } });
            txtPrice.Text = pre + "";
        }
        bool stop = false;
        private void button6_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCity.SelectedIndex == -1)
                return;
            City city = cboCity.SelectedItem as City;
            cboDistrict.DataSource = RealEstateDatabase.GetDistricts(city.Id);
            cboDistrict.DisplayMember = "DistrictName";
            cboDistrict.ValueMember = "Id";
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrict.SelectedIndex == -1)
                return;
            District district = cboDistrict.SelectedItem as District;
            cboWard.DataSource = RealEstateDatabase.GetWards(district.Id);
            cboWard.DisplayMember = "WardName";
            cboWard.ValueMember = "Id";
        }
    }
}
