namespace ML.RealEstateDemo
{
    partial class frmTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblRSquared = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRMSE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMSE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMAE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestRatio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSaveModelStatus = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.lblLoadModelStatus = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtFrontiSpiece = new System.Windows.Forms.TextBox();
            this.txtEntrance = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtBedRoom = new System.Windows.Forms.TextBox();
            this.txtRestRoom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtExpected = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cboHouseType = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboDistrict = new System.Windows.Forms.ComboBox();
            this.cboWard = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Multiple Linear Regression Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "Multiple Linear Regression with RealEstate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblRSquared
            // 
            this.lblRSquared.AutoSize = true;
            this.lblRSquared.Location = new System.Drawing.Point(323, 95);
            this.lblRSquared.Name = "lblRSquared";
            this.lblRSquared.Size = new System.Drawing.Size(58, 13);
            this.lblRSquared.TabIndex = 5;
            this.lblRSquared.Text = "R-Squared";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R-Squared:";
            // 
            // lblRMSE
            // 
            this.lblRMSE.AutoSize = true;
            this.lblRMSE.Location = new System.Drawing.Point(323, 125);
            this.lblRMSE.Name = "lblRMSE";
            this.lblRMSE.Size = new System.Drawing.Size(38, 13);
            this.lblRMSE.TabIndex = 5;
            this.lblRMSE.Text = "RMSE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RMSE:";
            // 
            // lblMSE
            // 
            this.lblMSE.AutoSize = true;
            this.lblMSE.Location = new System.Drawing.Point(323, 160);
            this.lblMSE.Name = "lblMSE";
            this.lblMSE.Size = new System.Drawing.Size(30, 13);
            this.lblMSE.TabIndex = 5;
            this.lblMSE.Text = "MSE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MSE:";
            // 
            // lblMAE
            // 
            this.lblMAE.AutoSize = true;
            this.lblMAE.Location = new System.Drawing.Point(323, 194);
            this.lblMAE.Name = "lblMAE";
            this.lblMAE.Size = new System.Drawing.Size(30, 13);
            this.lblMAE.TabIndex = 5;
            this.lblMAE.Text = "MAE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MAE:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(253, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "Build Model";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test Ratio:";
            // 
            // txtTestRatio
            // 
            this.txtTestRatio.Location = new System.Drawing.Point(316, 15);
            this.txtTestRatio.Name = "txtTestRatio";
            this.txtTestRatio.Size = new System.Drawing.Size(100, 20);
            this.txtTestRatio.TabIndex = 8;
            this.txtTestRatio.Text = "0.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSaveModelStatus
            // 
            this.lblSaveModelStatus.AutoSize = true;
            this.lblSaveModelStatus.Location = new System.Drawing.Point(390, 234);
            this.lblSaveModelStatus.Name = "lblSaveModelStatus";
            this.lblSaveModelStatus.Size = new System.Drawing.Size(35, 13);
            this.lblSaveModelStatus.TabIndex = 10;
            this.lblSaveModelStatus.Text = "label6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Load Model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(384, 286);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(229, 21);
            this.cboModel.TabIndex = 12;
            // 
            // lblLoadModelStatus
            // 
            this.lblLoadModelStatus.AutoSize = true;
            this.lblLoadModelStatus.Location = new System.Drawing.Point(381, 332);
            this.lblLoadModelStatus.Name = "lblLoadModelStatus";
            this.lblLoadModelStatus.Size = new System.Drawing.Size(35, 13);
            this.lblLoadModelStatus.TabIndex = 10;
            this.lblLoadModelStatus.Text = "label6";
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(360, 661);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(75, 23);
            this.btnPredict.TabIndex = 13;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Area:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "FrontiSpiece:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Entrance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Floor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bed Room:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 625);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Rest Room:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(360, 489);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 15;
            this.txtArea.Text = "50";
            // 
            // txtFrontiSpiece
            // 
            this.txtFrontiSpiece.Location = new System.Drawing.Point(360, 518);
            this.txtFrontiSpiece.Name = "txtFrontiSpiece";
            this.txtFrontiSpiece.Size = new System.Drawing.Size(100, 20);
            this.txtFrontiSpiece.TabIndex = 15;
            this.txtFrontiSpiece.Text = "4";
            // 
            // txtEntrance
            // 
            this.txtEntrance.Location = new System.Drawing.Point(360, 543);
            this.txtEntrance.Name = "txtEntrance";
            this.txtEntrance.Size = new System.Drawing.Size(100, 20);
            this.txtEntrance.TabIndex = 15;
            this.txtEntrance.Text = "6";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(360, 571);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(100, 20);
            this.txtFloor.TabIndex = 15;
            this.txtFloor.Text = "3";
            // 
            // txtBedRoom
            // 
            this.txtBedRoom.Location = new System.Drawing.Point(360, 598);
            this.txtBedRoom.Name = "txtBedRoom";
            this.txtBedRoom.Size = new System.Drawing.Size(100, 20);
            this.txtBedRoom.TabIndex = 15;
            this.txtBedRoom.Text = "3";
            // 
            // txtRestRoom
            // 
            this.txtRestRoom.Location = new System.Drawing.Point(360, 625);
            this.txtRestRoom.Name = "txtRestRoom";
            this.txtRestRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRestRoom.TabIndex = 15;
            this.txtRestRoom.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 693);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(360, 693);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "loop:";
            // 
            // txtLoop
            // 
            this.txtLoop.Location = new System.Drawing.Point(421, 53);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.Size = new System.Drawing.Size(39, 20);
            this.txtLoop.TabIndex = 17;
            this.txtLoop.Text = "5000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(483, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Expected:";
            // 
            // txtExpected
            // 
            this.txtExpected.Location = new System.Drawing.Point(544, 53);
            this.txtExpected.Name = "txtExpected";
            this.txtExpected.Size = new System.Drawing.Size(39, 20);
            this.txtExpected.TabIndex = 17;
            this.txtExpected.Text = "95";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(599, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cboHouseType
            // 
            this.cboHouseType.FormattingEnabled = true;
            this.cboHouseType.Location = new System.Drawing.Point(360, 372);
            this.cboHouseType.Name = "cboHouseType";
            this.cboHouseType.Size = new System.Drawing.Size(229, 21);
            this.cboHouseType.TabIndex = 12;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(360, 399);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(229, 21);
            this.cboCity.TabIndex = 12;
            this.cboCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // cboDistrict
            // 
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Location = new System.Drawing.Point(360, 426);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(229, 21);
            this.cboDistrict.TabIndex = 12;
            this.cboDistrict.SelectedIndexChanged += new System.EventHandler(this.cboDistrict_SelectedIndexChanged);
            // 
            // cboWard
            // 
            this.cboWard.FormattingEnabled = true;
            this.cboWard.Location = new System.Drawing.Point(360, 453);
            this.cboWard.Name = "cboWard";
            this.cboWard.Size = new System.Drawing.Size(229, 21);
            this.cboWard.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(285, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "House Type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "City:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "District:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(285, 461);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Ward:";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 748);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtExpected);
            this.Controls.Add(this.txtLoop);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRestRoom);
            this.Controls.Add(this.txtBedRoom);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtEntrance);
            this.Controls.Add(this.txtFrontiSpiece);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.cboWard);
            this.Controls.Add(this.cboDistrict);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.cboHouseType);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLoadModelStatus);
            this.Controls.Add(this.lblSaveModelStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTestRatio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMAE);
            this.Controls.Add(this.lblMSE);
            this.Controls.Add(this.lblRMSE);
            this.Controls.Add(this.lblRSquared);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "frmTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblRSquared;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRMSE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMSE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMAE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestRatio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSaveModelStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.Label lblLoadModelStatus;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtFrontiSpiece;
        private System.Windows.Forms.TextBox txtEntrance;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtBedRoom;
        private System.Windows.Forms.TextBox txtRestRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLoop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtExpected;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cboHouseType;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboDistrict;
        private System.Windows.Forms.ComboBox cboWard;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

