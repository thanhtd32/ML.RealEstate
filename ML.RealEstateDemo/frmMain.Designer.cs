namespace ML.RealEstateDemo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboHouseType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToiletRoom = new System.Windows.Forms.TextBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboDistrict = new System.Windows.Forms.ComboBox();
            this.txtFrontiSpiece = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboWard = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtBedRoom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEntrance = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.txtLossFunction = new System.Windows.Forms.TextBox();
            this.txtRMSE = new System.Windows.Forms.TextBox();
            this.txtMSE = new System.Windows.Forms.TextBox();
            this.txtMAE = new System.Windows.Forms.TextBox();
            this.txtRSquared = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatusLoadModel = new System.Windows.Forms.Label();
            this.lblStatusSaveModel = new System.Windows.Forms.Label();
            this.lblStatusEvaluate = new System.Windows.Forms.Label();
            this.lblStatusBuildModel = new System.Windows.Forms.Label();
            this.lblStatusImportData = new System.Windows.Forms.Label();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnBuildModel = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.txtRatio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboHouseType
            // 
            this.cboHouseType.FormattingEnabled = true;
            this.cboHouseType.Location = new System.Drawing.Point(96, 22);
            this.cboHouseType.Name = "cboHouseType";
            this.cboHouseType.Size = new System.Drawing.Size(154, 23);
            this.cboHouseType.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "House Type:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(96, 357);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 23);
            this.txtPrice.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "City:";
            // 
            // txtToiletRoom
            // 
            this.txtToiletRoom.Location = new System.Drawing.Point(96, 289);
            this.txtToiletRoom.Name = "txtToiletRoom";
            this.txtToiletRoom.Size = new System.Drawing.Size(121, 23);
            this.txtToiletRoom.TabIndex = 12;
            this.txtToiletRoom.Text = "2";
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(96, 51);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(154, 23);
            this.cboCity.TabIndex = 10;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(96, 232);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(121, 23);
            this.txtFloor.TabIndex = 12;
            this.txtFloor.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "District:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "Price:";
            // 
            // cboDistrict
            // 
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Location = new System.Drawing.Point(96, 80);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(154, 23);
            this.cboDistrict.TabIndex = 10;
            this.cboDistrict.SelectedIndexChanged += new System.EventHandler(this.cboDistrict_SelectedIndexChanged);
            // 
            // txtFrontiSpiece
            // 
            this.txtFrontiSpiece.Location = new System.Drawing.Point(96, 174);
            this.txtFrontiSpiece.Name = "txtFrontiSpiece";
            this.txtFrontiSpiece.Size = new System.Drawing.Size(121, 23);
            this.txtFrontiSpiece.TabIndex = 12;
            this.txtFrontiSpiece.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ward:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "RestRoom:";
            // 
            // cboWard
            // 
            this.cboWard.FormattingEnabled = true;
            this.cboWard.Location = new System.Drawing.Point(96, 109);
            this.cboWard.Name = "cboWard";
            this.cboWard.Size = new System.Drawing.Size(154, 23);
            this.cboWard.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Floor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Area:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "FrontiSpiece:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(96, 145);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(121, 23);
            this.txtArea.TabIndex = 12;
            this.txtArea.Text = "50";
            // 
            // txtBedRoom
            // 
            this.txtBedRoom.Location = new System.Drawing.Point(96, 260);
            this.txtBedRoom.Name = "txtBedRoom";
            this.txtBedRoom.Size = new System.Drawing.Size(121, 23);
            this.txtBedRoom.TabIndex = 12;
            this.txtBedRoom.Text = "3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Entrance:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "BedRoom:";
            // 
            // txtEntrance
            // 
            this.txtEntrance.Location = new System.Drawing.Point(96, 203);
            this.txtEntrance.Name = "txtEntrance";
            this.txtEntrance.Size = new System.Drawing.Size(121, 23);
            this.txtEntrance.TabIndex = 12;
            this.txtEntrance.Text = "6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboHouseType);
            this.groupBox1.Controls.Add(this.btnPredict);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtToiletRoom);
            this.groupBox1.Controls.Add(this.cboCity);
            this.groupBox1.Controls.Add(this.txtFloor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cboDistrict);
            this.groupBox1.Controls.Add(this.txtFrontiSpiece);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cboWard);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtBedRoom);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(312, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 394);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "House Input && Predict Information:";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(103, 325);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 13;
            this.btnPredict.Text = "6.Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // txtLossFunction
            // 
            this.txtLossFunction.Location = new System.Drawing.Point(105, 333);
            this.txtLossFunction.Name = "txtLossFunction";
            this.txtLossFunction.Size = new System.Drawing.Size(136, 23);
            this.txtLossFunction.TabIndex = 38;
            // 
            // txtRMSE
            // 
            this.txtRMSE.Location = new System.Drawing.Point(105, 301);
            this.txtRMSE.Name = "txtRMSE";
            this.txtRMSE.Size = new System.Drawing.Size(136, 23);
            this.txtRMSE.TabIndex = 37;
            // 
            // txtMSE
            // 
            this.txtMSE.Location = new System.Drawing.Point(105, 271);
            this.txtMSE.Name = "txtMSE";
            this.txtMSE.Size = new System.Drawing.Size(136, 23);
            this.txtMSE.TabIndex = 36;
            // 
            // txtMAE
            // 
            this.txtMAE.Location = new System.Drawing.Point(105, 240);
            this.txtMAE.Name = "txtMAE";
            this.txtMAE.Size = new System.Drawing.Size(136, 23);
            this.txtMAE.TabIndex = 35;
            // 
            // txtRSquared
            // 
            this.txtRSquared.Location = new System.Drawing.Point(105, 210);
            this.txtRSquared.Name = "txtRSquared";
            this.txtRSquared.Size = new System.Drawing.Size(136, 23);
            this.txtRSquared.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Loss Function:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "RMSE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "MSE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "MAE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "R-Squared:";
            // 
            // lblStatusLoadModel
            // 
            this.lblStatusLoadModel.AutoSize = true;
            this.lblStatusLoadModel.Location = new System.Drawing.Point(316, 32);
            this.lblStatusLoadModel.Name = "lblStatusLoadModel";
            this.lblStatusLoadModel.Size = new System.Drawing.Size(0, 15);
            this.lblStatusLoadModel.TabIndex = 28;
            // 
            // lblStatusSaveModel
            // 
            this.lblStatusSaveModel.AutoSize = true;
            this.lblStatusSaveModel.Location = new System.Drawing.Point(14, 406);
            this.lblStatusSaveModel.Name = "lblStatusSaveModel";
            this.lblStatusSaveModel.Size = new System.Drawing.Size(0, 15);
            this.lblStatusSaveModel.TabIndex = 27;
            // 
            // lblStatusEvaluate
            // 
            this.lblStatusEvaluate.AutoSize = true;
            this.lblStatusEvaluate.Location = new System.Drawing.Point(16, 194);
            this.lblStatusEvaluate.Name = "lblStatusEvaluate";
            this.lblStatusEvaluate.Size = new System.Drawing.Size(0, 15);
            this.lblStatusEvaluate.TabIndex = 26;
            // 
            // lblStatusBuildModel
            // 
            this.lblStatusBuildModel.AutoSize = true;
            this.lblStatusBuildModel.Location = new System.Drawing.Point(16, 149);
            this.lblStatusBuildModel.Name = "lblStatusBuildModel";
            this.lblStatusBuildModel.Size = new System.Drawing.Size(0, 15);
            this.lblStatusBuildModel.TabIndex = 25;
            // 
            // lblStatusImportData
            // 
            this.lblStatusImportData.AutoSize = true;
            this.lblStatusImportData.Location = new System.Drawing.Point(14, 101);
            this.lblStatusImportData.Name = "lblStatusImportData";
            this.lblStatusImportData.Size = new System.Drawing.Size(0, 15);
            this.lblStatusImportData.TabIndex = 24;
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Location = new System.Drawing.Point(312, 4);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(114, 23);
            this.btnLoadModel.TabIndex = 23;
            this.btnLoadModel.Text = "5. Load Model";
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Location = new System.Drawing.Point(10, 368);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(239, 23);
            this.btnSaveModel.TabIndex = 22;
            this.btnSaveModel.Text = "4. Save Model";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(10, 165);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(239, 23);
            this.btnEvaluate.TabIndex = 21;
            this.btnEvaluate.Text = "3. Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnBuildModel
            // 
            this.btnBuildModel.Location = new System.Drawing.Point(10, 121);
            this.btnBuildModel.Name = "btnBuildModel";
            this.btnBuildModel.Size = new System.Drawing.Size(239, 23);
            this.btnBuildModel.TabIndex = 20;
            this.btnBuildModel.Text = "2. Build Model";
            this.btnBuildModel.UseVisualStyleBackColor = true;
            this.btnBuildModel.Click += new System.EventHandler(this.btnBuildModel_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(57, 41);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(100, 23);
            this.txtSeed.TabIndex = 19;
            this.txtSeed.Text = "0";
            // 
            // txtRatio
            // 
            this.txtRatio.Location = new System.Drawing.Point(57, 12);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(100, 23);
            this.txtRatio.TabIndex = 18;
            this.txtRatio.Text = "0.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ratio:";
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(10, 73);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(239, 23);
            this.btnImportData.TabIndex = 15;
            this.btnImportData.Text = "1. Import Data and create Train - Test Set";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(285, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 449);
            this.panel1.TabIndex = 40;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLossFunction);
            this.Controls.Add(this.txtRMSE);
            this.Controls.Add(this.txtMSE);
            this.Controls.Add(this.txtMAE);
            this.Controls.Add(this.txtRSquared);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatusLoadModel);
            this.Controls.Add(this.lblStatusSaveModel);
            this.Controls.Add(this.lblStatusEvaluate);
            this.Controls.Add(this.lblStatusBuildModel);
            this.Controls.Add(this.lblStatusImportData);
            this.Controls.Add(this.btnLoadModel);
            this.Controls.Add(this.btnSaveModel);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnBuildModel);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.txtRatio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportData);
            this.Name = "frmMain";
            this.Text = "ML.RealEstate - KMOU - Data Science Lab - 407";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboHouseType;
        private Label label8;
        private TextBox txtPrice;
        private Label label9;
        private TextBox txtToiletRoom;
        private ComboBox cboCity;
        private TextBox txtFloor;
        private Label label10;
        private Label label18;
        private ComboBox cboDistrict;
        private TextBox txtFrontiSpiece;
        private Label label11;
        private Label label17;
        private ComboBox cboWard;
        private Label label15;
        private Label label12;
        private Label label13;
        private TextBox txtArea;
        private TextBox txtBedRoom;
        private Label label14;
        private Label label16;
        private TextBox txtEntrance;
        private GroupBox groupBox1;
        private Button btnPredict;
        private TextBox txtLossFunction;
        private TextBox txtRMSE;
        private TextBox txtMSE;
        private TextBox txtMAE;
        private TextBox txtRSquared;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblStatusLoadModel;
        private Label lblStatusSaveModel;
        private Label lblStatusEvaluate;
        private Label lblStatusBuildModel;
        private Label lblStatusImportData;
        private Button btnLoadModel;
        private Button btnSaveModel;
        private Button btnEvaluate;
        private Button btnBuildModel;
        private TextBox txtSeed;
        private TextBox txtRatio;
        private Label label2;
        private Label label1;
        private Button btnImportData;
        private Panel panel1;
    }
}