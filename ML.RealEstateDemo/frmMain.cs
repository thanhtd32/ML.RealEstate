using ML.RealEstate.Data;
using ML.RealEstate.Predict;

namespace ML.RealEstateDemo
{
    public partial class frmMain : Form
    {
        BrokerRealEstate broker = new BrokerRealEstate();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            RealEstateDatabase.LoadAllDataset();
            ShowDataInUI();
        }
        private void ShowDataInUI()
        {
            cboHouseType.DataSource = RealEstateDatabase.GetHouseTypes();
            cboHouseType.ValueMember = "Id";
            cboHouseType.DisplayMember = "TypeOfHouse";

            cboCity.DataSource = RealEstateDatabase.GetCities();
            cboCity.ValueMember = "Id";
            cboCity.DisplayMember = "CityName";
        }
        //Step 1. Import Data and create Train - Test Set
        private void btnImportData_Click(object sender, EventArgs e)
        {
            double ratio = double.Parse(txtRatio.Text);
            int seed = int.Parse(txtSeed.Text);
            bool ret = broker.ImportDataset(RealEstateDatabase.HouseDataList!, ratio, seed);
            if (ret)
                lblStatusImportData.Text = "Import and make train - test dataset successfully";
            else
                lblStatusImportData.Text = "Import and make train - test dataset failed";
        }
        //Step 2. Build Model
        private void btnBuildModel_Click(object sender, EventArgs e)
        {
            string[] features ={ "HouseTypeId", "WardId", "DistrictId", "CityId",
                    "Area", "FrontiSpiece","Entrance","Floor","BedRoom","ToiletRoom" };
            int iterator = 100;
            bool ret = broker.BuildModel(features, iterator);
            if (ret)
                lblStatusBuildModel.Text = "Build Model successfully";
            else
                lblStatusBuildModel.Text = "Build Model failed";
        }
        //Step 3. Evaluate
        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Metric metric = broker.Evaluate();
            txtRSquared.Text = metric.RSquared.ToString();
            txtMSE.Text = metric.MSE.ToString();
            txtRMSE.Text = metric.RMSE.ToString();
            txtMAE.Text = metric.MAE.ToString();
            txtLossFunction.Text = metric.LossFunction.ToString();
        }
        //Step 4. Save Model
        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            bool ret = broker.SaveModel(RealEstateDatabase.SaveModelName);
            if (ret)
                lblStatusSaveModel.Text = "Save Model successfully";
            else
                lblStatusSaveModel.Text = "Save Model failed";
        }
        //Step 5. Load Model
        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            bool ret = broker.LoadModel(RealEstateDatabase.SaveModelName);
            if (ret)
                lblStatusLoadModel.Text = "Load Model successfully";
            else
                lblStatusLoadModel.Text = "Load Model failed";
        }
        //6.Predict
        private void btnPredict_Click(object sender, EventArgs e)
        {
            if (cboDistrict.SelectedItem == null ||
                cboCity.SelectedItem == null)
                return;
            House inputData = new House();
            inputData.HouseTypeId = (cboHouseType.SelectedItem as HouseType)!.Id;
            inputData.WardId = (cboWard.SelectedItem as Ward)!.Id;
            inputData.DistrictId = (cboDistrict.SelectedItem as District)!.Id;
            inputData.CityId = (cboCity.SelectedItem as City)!.Id;
            inputData.Area = float.Parse(txtArea.Text);
            inputData.FrontiSpiece = float.Parse(txtFrontiSpiece.Text);
            inputData.Entrance = float.Parse(txtEntrance.Text);
            inputData.Floor = float.Parse(txtFloor.Text);
            inputData.BedRoom = float.Parse(txtBedRoom.Text);
            inputData.ToiletRoom = float.Parse(txtToiletRoom.Text);
            Prediction result = broker.Predict(inputData);
            txtPrice.Text = result.Price.ToString();
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCity.SelectedIndex == -1)
                return;
            City? city = cboCity.SelectedItem as City;
            cboDistrict.DataSource = RealEstateDatabase.GetDistricts(city!.Id);
            cboDistrict.DisplayMember = "DistrictName";
            cboDistrict.ValueMember = "Id";
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrict.SelectedIndex == -1)
                return;
            District? district = cboDistrict.SelectedItem as District;
            cboWard.DataSource = RealEstateDatabase.GetWards(district!.Id);
            cboWard.DisplayMember = "WardName";
            cboWard.ValueMember = "Id";
        }
    }
}