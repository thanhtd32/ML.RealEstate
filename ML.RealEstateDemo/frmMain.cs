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
    public partial class frmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        string folder = "Models";
        RealEstateModel model = null;
        double testRatio = 0.2;
        TrainTestSet trainData=null;
        public frmMain()
        {
            InitializeComponent();
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
            string[] files = Directory.GetFiles(folder, "*.zip");
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                cboModel.Items.Add(fi.Name);
            }
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

        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            model = null;
            if (cboModel.SelectedIndex == -1)
                return;
            string modelName = folder + "\\" + cboModel.Text;
            model = IOFactory.LoadModel(modelName) as RealEstateModel;
            if (model != null)
            {
                lblStatusLoadModel.Text = "Load Model successfully";

                Metric metric = model.Metric;
                txtRSquared.Text = Math.Round(metric.RSquared * 100, 2) + "%";
                txtRMSE.Text = Math.Round(metric.RMSE, 2) + "";
                txtMSE.Text = Math.Round(metric.MSE, 2) + "";
                txtMAE.Text = Math.Round(metric.MAE, 2) + "";
            }
            else
                lblStatusLoadModel.Text = "Load Model failed";
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (model == null)
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
            double entrance = double.Parse(txtEntrance.Text);
            double floor = double.Parse(txtFloor.Text);
            double bedroom = double.Parse(txtBedRoom.Text);
            double restroom = double.Parse(txtToiletRoom.Text);
            //double pre = regModel.Predict(new double[,] { { HouseTypeId },{ WardId },{ DistrictId },{ CityId }, { area }, { frontiSpiece }, { entrance }, { floor }, { bedroom }, { restroom } });
            double pre = model.Predict(new double[,] { { area }, { frontiSpiece }, { entrance }, { floor }, { bedroom }, { restroom } });
            txtPrice.Text = pre + "";

        }

        private void btnImportAndCreateTrainTest_Click(object sender, EventArgs e)
        {
            try
            {
                RealEstateDatabase.LoadAllDataset();

            testRatio = double.Parse(txtRatio.Text);

            trainData = RealEstateDatabase.SplitTrainTest(RealEstateDatabase.HouseDataList, testRatio);

            if (trainData!=null)
                lblStatusImportData.Text = "Import and make train - test dataset successfully";
            else
                lblStatusImportData.Text = "Import and make train - test dataset failed";

            cboHouseType.DataSource = RealEstateDatabase.GetHouseTypes();
            cboHouseType.ValueMember = "Id";
            cboHouseType.DisplayMember = "TypeOfHouse";

            cboCity.DataSource = RealEstateDatabase.GetCities();
            cboCity.ValueMember = "Id";
            cboCity.DisplayMember = "CityName";

            }
            catch (Exception ex)
            {
                lblStatusImportData.Text = "Import and make train - test dataset failed";
            }
        }

        private void btnTrainModel_Click(object sender, EventArgs e)
        {
            try
            {
                model = new RealEstateModel();

                model.Fit( trainData.TrainSet.Features,trainData.TrainSet.Target);

                lblStatusBuildModel.Text = "Build Model successfully";
             
            }
            catch(Exception ex)
            {
                lblStatusBuildModel.Text = "Build Model failed";
            }
          
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                Metric metric = model.Evaluate(trainData.TestSet.Features,trainData.TestSet.Target);
                if(metric!= null)
                {
                    txtRSquared.Text = Math.Round(metric.RSquared * 100, 2) + "%";
                    txtRMSE.Text = Math.Round(metric.RMSE, 2) + "";
                    txtMSE.Text = Math.Round(metric.MSE, 2) + "";
                    txtMAE.Text = Math.Round(metric.MAE, 2) + "";
                }                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(folder) == false)
                {
                    Directory.CreateDirectory(folder);
                }
                string trainalgorithm = "_" + txtRatio.Text + "_";
                string path = folder + "\\ML.RealEstate" + trainalgorithm + DateTime.Now.ToString("MMddyyyy-hhmmss") + ".zip";
                bool ret = IOFactory.SaveModel(model, path);
                if (ret)
                    lblStatusSaveModel.Text = "Save Model successfully";
                else
                    lblStatusSaveModel.Text = "Save Model failed";
                LoadModelIntoCombo();
            }
            catch (Exception ex)
            {
                lblStatusSaveModel.Text = "Save Model failed";
            }
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Comparing\\ML.RealEstateDemo.exe");
        }

        private void btnDatabaseManagement_Click(object sender, EventArgs e)
        {
            frmDatabase frm = new frmDatabase();
            frm.Show();
        }
    }
}
