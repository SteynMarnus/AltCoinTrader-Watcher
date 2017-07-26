namespace AltCoinWatcher
{
    partial class CfrmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.btnSave = new CloudToolkitN6.CloudButton();
            this.lblInterval = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trbrInterval = new System.Windows.Forms.TrackBar();
            this.txtAlertBelow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlertAbove = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurrentLow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentHigh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCurrentBuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentSell = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedCryptcurreny = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnSelectBTC = new CloudToolkitN6.W7Button();
            this.btnSelectLTC = new CloudToolkitN6.W7Button();
            this.btnSelectNMC = new CloudToolkitN6.W7Button();
            this.btnSelectXRP = new CloudToolkitN6.W7Button();
            this.btnSelectETH = new CloudToolkitN6.W7Button();
            this.btnSelectDASH = new CloudToolkitN6.W7Button();
            this.btnSelectZEC = new CloudToolkitN6.W7Button();
            this.btnClose = new CloudToolkitN6.CloudButton();
            this.w7Button1 = new CloudToolkitN6.W7Button();
            this.w7Button2 = new CloudToolkitN6.W7Button();
            this.w7Button3 = new CloudToolkitN6.W7Button();
            this.w7Button4 = new CloudToolkitN6.W7Button();
            this.w7Button5 = new CloudToolkitN6.W7Button();
            this.w7Button6 = new CloudToolkitN6.W7Button();
            this.w7Button7 = new CloudToolkitN6.W7Button();
            this.lblBTCPrice = new System.Windows.Forms.Label();
            this.lblLTCPrice = new System.Windows.Forms.Label();
            this.lblNMCPrice = new System.Windows.Forms.Label();
            this.lblXRPPrice = new System.Windows.Forms.Label();
            this.lblETHPrice = new System.Windows.Forms.Label();
            this.lblDASHPrice = new System.Windows.Forms.Label();
            this.lblZECPrice = new System.Windows.Forms.Label();
            this.tmrInterval = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.lblTimeToRefresh = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.pnlDetails.Controls.Add(this.lblCurrentPrice);
            this.pnlDetails.Controls.Add(this.btnSave);
            this.pnlDetails.Controls.Add(this.lblInterval);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.trbrInterval);
            this.pnlDetails.Controls.Add(this.txtAlertBelow);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtAlertAbove);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.lblCurrentLow);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.lblCurrentHigh);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.lblCurrentBuy);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.lblCurrentSell);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.lblSelectedCryptcurreny);
            this.pnlDetails.Controls.Add(this.shapeContainer1);
            this.pnlDetails.Location = new System.Drawing.Point(13, 210);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1193, 312);
            this.pnlDetails.TabIndex = 8;
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPrice.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPrice.Location = new System.Drawing.Point(104, 77);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(70, 36);
            this.lblCurrentPrice.TabIndex = 21;
            this.lblCurrentPrice.Text = "0.00";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(152)))));
            this.btnSave.Icon = null;
            this.btnSave.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left;
            this.btnSave.IconSpacingX = 5;
            this.btnSave.IconSpacingY = 5;
            this.btnSave.IconTransparency = 0F;
            this.btnSave.Location = new System.Drawing.Point(630, 237);
            this.btnSave.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnSave.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnSave.Name = "btnSave";
            this.btnSave.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnSave.Size = new System.Drawing.Size(530, 52);
            this.btnSave.TabIndex = 20;
            this.btnSave.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnSave.TextSpacingX = 5;
            this.btnSave.TextSpacingY = 5;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.ForeColor = System.Drawing.Color.White;
            this.lblInterval.Location = new System.Drawing.Point(1102, 203);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(58, 21);
            this.lblInterval.TabIndex = 19;
            this.lblInterval.Text = "10 sec";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(624, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "Refresh Interval:";
            // 
            // trbrInterval
            // 
            this.trbrInterval.Location = new System.Drawing.Point(872, 197);
            this.trbrInterval.Maximum = 8;
            this.trbrInterval.Name = "trbrInterval";
            this.trbrInterval.Size = new System.Drawing.Size(229, 45);
            this.trbrInterval.TabIndex = 17;
            this.trbrInterval.Scroll += new System.EventHandler(this.trbrInterval_Scroll);
            // 
            // txtAlertBelow
            // 
            this.txtAlertBelow.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlertBelow.Location = new System.Drawing.Point(872, 139);
            this.txtAlertBelow.Multiline = true;
            this.txtAlertBelow.Name = "txtAlertBelow";
            this.txtAlertBelow.Size = new System.Drawing.Size(288, 34);
            this.txtAlertBelow.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(624, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "Below or equal:";
            // 
            // txtAlertAbove
            // 
            this.txtAlertAbove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlertAbove.Location = new System.Drawing.Point(872, 84);
            this.txtAlertAbove.Multiline = true;
            this.txtAlertAbove.Name = "txtAlertAbove";
            this.txtAlertAbove.Size = new System.Drawing.Size(288, 34);
            this.txtAlertAbove.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(624, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Above or equal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(829, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 56);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alert";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Low:";
            // 
            // lblCurrentLow
            // 
            this.lblCurrentLow.AutoSize = true;
            this.lblCurrentLow.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLow.ForeColor = System.Drawing.Color.White;
            this.lblCurrentLow.Location = new System.Drawing.Point(104, 226);
            this.lblCurrentLow.Name = "lblCurrentLow";
            this.lblCurrentLow.Size = new System.Drawing.Size(70, 36);
            this.lblCurrentLow.TabIndex = 10;
            this.lblCurrentLow.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "High:";
            // 
            // lblCurrentHigh
            // 
            this.lblCurrentHigh.AutoSize = true;
            this.lblCurrentHigh.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHigh.ForeColor = System.Drawing.Color.White;
            this.lblCurrentHigh.Location = new System.Drawing.Point(104, 190);
            this.lblCurrentHigh.Name = "lblCurrentHigh";
            this.lblCurrentHigh.Size = new System.Drawing.Size(70, 36);
            this.lblCurrentHigh.TabIndex = 8;
            this.lblCurrentHigh.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buy:";
            // 
            // lblCurrentBuy
            // 
            this.lblCurrentBuy.AutoSize = true;
            this.lblCurrentBuy.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBuy.ForeColor = System.Drawing.Color.White;
            this.lblCurrentBuy.Location = new System.Drawing.Point(104, 153);
            this.lblCurrentBuy.Name = "lblCurrentBuy";
            this.lblCurrentBuy.Size = new System.Drawing.Size(70, 36);
            this.lblCurrentBuy.TabIndex = 6;
            this.lblCurrentBuy.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sell:";
            // 
            // lblCurrentSell
            // 
            this.lblCurrentSell.AutoSize = true;
            this.lblCurrentSell.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSell.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSell.Location = new System.Drawing.Point(104, 115);
            this.lblCurrentSell.Name = "lblCurrentSell";
            this.lblCurrentSell.Size = new System.Drawing.Size(70, 36);
            this.lblCurrentSell.TabIndex = 4;
            this.lblCurrentSell.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // lblSelectedCryptcurreny
            // 
            this.lblSelectedCryptcurreny.AutoSize = true;
            this.lblSelectedCryptcurreny.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCryptcurreny.ForeColor = System.Drawing.Color.White;
            this.lblSelectedCryptcurreny.Location = new System.Drawing.Point(210, 10);
            this.lblSelectedCryptcurreny.Name = "lblSelectedCryptcurreny";
            this.lblSelectedCryptcurreny.Size = new System.Drawing.Size(181, 56);
            this.lblSelectedCryptcurreny.TabIndex = 1;
            this.lblSelectedCryptcurreny.Text = "Bitcoin";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1193, 312);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 595;
            this.lineShape1.X2 = 595;
            this.lineShape1.Y1 = 10;
            this.lineShape1.Y2 = 301;
            // 
            // btnSelectBTC
            // 
            this.btnSelectBTC.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectBTC.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectBTC.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectBTC.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectBTC.ControlOpacity = 255;
            this.btnSelectBTC.CornerRadius = 3;
            this.btnSelectBTC.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectBTC.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(112)))));
            this.btnSelectBTC.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(112)))));
            this.btnSelectBTC.Icon = global::AltCoinWatcher.Properties.Resources.BTC_000;
            this.btnSelectBTC.IconOpacity = 0F;
            this.btnSelectBTC.Location = new System.Drawing.Point(13, 64);
            this.btnSelectBTC.Name = "btnSelectBTC";
            this.btnSelectBTC.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectBTC.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnSelectBTC.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnSelectBTC.Size = new System.Drawing.Size(165, 90);
            this.btnSelectBTC.TabIndex = 7;
            this.btnSelectBTC.Tag = "";
            this.btnSelectBTC.ButtonClicked += new System.EventHandler(this.btnSelectBTC_ButtonClicked);
            // 
            // btnSelectLTC
            // 
            this.btnSelectLTC.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectLTC.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectLTC.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectLTC.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectLTC.ControlOpacity = 255;
            this.btnSelectLTC.CornerRadius = 3;
            this.btnSelectLTC.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectLTC.Hover_FillColor1 = System.Drawing.Color.DarkGray;
            this.btnSelectLTC.Hover_FillColor2 = System.Drawing.Color.DarkGray;
            this.btnSelectLTC.Icon = global::AltCoinWatcher.Properties.Resources.LTC_000;
            this.btnSelectLTC.IconOpacity = 0F;
            this.btnSelectLTC.Location = new System.Drawing.Point(184, 64);
            this.btnSelectLTC.Name = "btnSelectLTC";
            this.btnSelectLTC.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectLTC.Normal_FillColor1 = System.Drawing.Color.DimGray;
            this.btnSelectLTC.Normal_FillColor2 = System.Drawing.Color.DimGray;
            this.btnSelectLTC.Size = new System.Drawing.Size(165, 90);
            this.btnSelectLTC.TabIndex = 6;
            this.btnSelectLTC.ButtonClicked += new System.EventHandler(this.btnSelectLTC_ButtonClicked);
            // 
            // btnSelectNMC
            // 
            this.btnSelectNMC.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectNMC.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectNMC.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectNMC.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectNMC.ControlOpacity = 255;
            this.btnSelectNMC.CornerRadius = 3;
            this.btnSelectNMC.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectNMC.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(226)))));
            this.btnSelectNMC.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(189)))), ((int)(((byte)(226)))));
            this.btnSelectNMC.Icon = global::AltCoinWatcher.Properties.Resources.NMC_000;
            this.btnSelectNMC.IconOpacity = 0F;
            this.btnSelectNMC.Location = new System.Drawing.Point(355, 64);
            this.btnSelectNMC.Name = "btnSelectNMC";
            this.btnSelectNMC.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectNMC.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.btnSelectNMC.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.btnSelectNMC.Size = new System.Drawing.Size(165, 90);
            this.btnSelectNMC.TabIndex = 5;
            this.btnSelectNMC.ButtonClicked += new System.EventHandler(this.btnSelectNMC_ButtonClicked);
            // 
            // btnSelectXRP
            // 
            this.btnSelectXRP.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectXRP.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectXRP.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectXRP.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectXRP.ControlOpacity = 255;
            this.btnSelectXRP.CornerRadius = 3;
            this.btnSelectXRP.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectXRP.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(164)))), ((int)(((byte)(193)))));
            this.btnSelectXRP.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(164)))), ((int)(((byte)(193)))));
            this.btnSelectXRP.Icon = global::AltCoinWatcher.Properties.Resources.XRP_000;
            this.btnSelectXRP.IconOpacity = 0F;
            this.btnSelectXRP.Location = new System.Drawing.Point(526, 64);
            this.btnSelectXRP.Name = "btnSelectXRP";
            this.btnSelectXRP.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectXRP.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnSelectXRP.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.btnSelectXRP.Size = new System.Drawing.Size(165, 90);
            this.btnSelectXRP.TabIndex = 4;
            this.btnSelectXRP.ButtonClicked += new System.EventHandler(this.btnSelectXRP_ButtonClicked);
            // 
            // btnSelectETH
            // 
            this.btnSelectETH.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectETH.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectETH.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectETH.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectETH.ControlOpacity = 255;
            this.btnSelectETH.CornerRadius = 3;
            this.btnSelectETH.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectETH.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.btnSelectETH.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(176)))), ((int)(((byte)(212)))));
            this.btnSelectETH.Icon = global::AltCoinWatcher.Properties.Resources.ETH_000;
            this.btnSelectETH.IconOpacity = 0F;
            this.btnSelectETH.Location = new System.Drawing.Point(697, 64);
            this.btnSelectETH.Name = "btnSelectETH";
            this.btnSelectETH.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectETH.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.btnSelectETH.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.btnSelectETH.Size = new System.Drawing.Size(165, 90);
            this.btnSelectETH.TabIndex = 3;
            this.btnSelectETH.ButtonClicked += new System.EventHandler(this.btnSelectETH_ButtonClicked);
            // 
            // btnSelectDASH
            // 
            this.btnSelectDASH.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectDASH.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectDASH.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectDASH.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectDASH.ControlOpacity = 255;
            this.btnSelectDASH.CornerRadius = 3;
            this.btnSelectDASH.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectDASH.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.btnSelectDASH.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.btnSelectDASH.Icon = global::AltCoinWatcher.Properties.Resources.DASH_000;
            this.btnSelectDASH.IconOpacity = 0F;
            this.btnSelectDASH.Location = new System.Drawing.Point(868, 64);
            this.btnSelectDASH.Name = "btnSelectDASH";
            this.btnSelectDASH.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectDASH.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.btnSelectDASH.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.btnSelectDASH.Size = new System.Drawing.Size(165, 90);
            this.btnSelectDASH.TabIndex = 2;
            this.btnSelectDASH.ButtonClicked += new System.EventHandler(this.btnSelectDASH_ButtonClicked);
            // 
            // btnSelectZEC
            // 
            this.btnSelectZEC.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectZEC.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectZEC.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.btnSelectZEC.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.btnSelectZEC.ControlOpacity = 255;
            this.btnSelectZEC.CornerRadius = 3;
            this.btnSelectZEC.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSelectZEC.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(180)))), ((int)(((byte)(124)))));
            this.btnSelectZEC.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(180)))), ((int)(((byte)(124)))));
            this.btnSelectZEC.Icon = global::AltCoinWatcher.Properties.Resources.ZEC_000;
            this.btnSelectZEC.IconOpacity = 0F;
            this.btnSelectZEC.Location = new System.Drawing.Point(1039, 64);
            this.btnSelectZEC.Name = "btnSelectZEC";
            this.btnSelectZEC.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnSelectZEC.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.btnSelectZEC.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.btnSelectZEC.Size = new System.Drawing.Size(165, 90);
            this.btnSelectZEC.TabIndex = 1;
            this.btnSelectZEC.ButtonClicked += new System.EventHandler(this.btnSelectZEC_ButtonClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))))};
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(105)))), ((int)(((byte)(152)))));
            this.btnClose.Icon = global::AltCoinWatcher.Properties.Resources._32_000;
            this.btnClose.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Center;
            this.btnClose.IconSpacingX = 5;
            this.btnClose.IconSpacingY = 5;
            this.btnClose.IconTransparency = 0F;
            this.btnClose.Location = new System.Drawing.Point(1172, 12);
            this.btnClose.MouseDown_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(193)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(208)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(220)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))))};
            this.btnClose.MouseOn_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(168)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(151)))))};
            this.btnClose.Name = "btnClose";
            this.btnClose.Normal_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(189)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(214)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(208)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))))};
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage;
            this.btnClose.TextSpacingX = 5;
            this.btnClose.TextSpacingY = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // w7Button1
            // 
            this.w7Button1.BackColor = System.Drawing.Color.Transparent;
            this.w7Button1.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button1.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button1.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button1.ControlOpacity = 255;
            this.w7Button1.CornerRadius = 3;
            this.w7Button1.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button1.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.w7Button1.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.w7Button1.Icon = null;
            this.w7Button1.IconOpacity = 0F;
            this.w7Button1.Location = new System.Drawing.Point(12, 160);
            this.w7Button1.Name = "w7Button1";
            this.w7Button1.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button1.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.w7Button1.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.w7Button1.Size = new System.Drawing.Size(165, 35);
            this.w7Button1.TabIndex = 9;
            this.w7Button1.Tag = "";
            // 
            // w7Button2
            // 
            this.w7Button2.BackColor = System.Drawing.Color.Transparent;
            this.w7Button2.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button2.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button2.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button2.ControlOpacity = 255;
            this.w7Button2.CornerRadius = 3;
            this.w7Button2.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button2.Hover_FillColor1 = System.Drawing.Color.DimGray;
            this.w7Button2.Hover_FillColor2 = System.Drawing.Color.DimGray;
            this.w7Button2.Icon = null;
            this.w7Button2.IconOpacity = 0F;
            this.w7Button2.Location = new System.Drawing.Point(184, 160);
            this.w7Button2.Name = "w7Button2";
            this.w7Button2.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button2.Normal_FillColor1 = System.Drawing.Color.DimGray;
            this.w7Button2.Normal_FillColor2 = System.Drawing.Color.DimGray;
            this.w7Button2.Size = new System.Drawing.Size(165, 35);
            this.w7Button2.TabIndex = 10;
            this.w7Button2.Tag = "";
            // 
            // w7Button3
            // 
            this.w7Button3.BackColor = System.Drawing.Color.Transparent;
            this.w7Button3.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button3.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button3.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button3.ControlOpacity = 255;
            this.w7Button3.CornerRadius = 3;
            this.w7Button3.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button3.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.w7Button3.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.w7Button3.Icon = null;
            this.w7Button3.IconOpacity = 0F;
            this.w7Button3.Location = new System.Drawing.Point(355, 160);
            this.w7Button3.Name = "w7Button3";
            this.w7Button3.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button3.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.w7Button3.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.w7Button3.Size = new System.Drawing.Size(165, 35);
            this.w7Button3.TabIndex = 11;
            this.w7Button3.Tag = "";
            // 
            // w7Button4
            // 
            this.w7Button4.BackColor = System.Drawing.Color.Transparent;
            this.w7Button4.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button4.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button4.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button4.ControlOpacity = 255;
            this.w7Button4.CornerRadius = 3;
            this.w7Button4.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button4.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.w7Button4.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.w7Button4.Icon = null;
            this.w7Button4.IconOpacity = 0F;
            this.w7Button4.Location = new System.Drawing.Point(526, 160);
            this.w7Button4.Name = "w7Button4";
            this.w7Button4.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button4.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.w7Button4.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.w7Button4.Size = new System.Drawing.Size(165, 35);
            this.w7Button4.TabIndex = 12;
            this.w7Button4.Tag = "";
            // 
            // w7Button5
            // 
            this.w7Button5.BackColor = System.Drawing.Color.Transparent;
            this.w7Button5.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button5.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button5.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button5.ControlOpacity = 255;
            this.w7Button5.CornerRadius = 3;
            this.w7Button5.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button5.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.w7Button5.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.w7Button5.Icon = null;
            this.w7Button5.IconOpacity = 0F;
            this.w7Button5.Location = new System.Drawing.Point(697, 160);
            this.w7Button5.Name = "w7Button5";
            this.w7Button5.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button5.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.w7Button5.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.w7Button5.Size = new System.Drawing.Size(165, 35);
            this.w7Button5.TabIndex = 13;
            this.w7Button5.Tag = "";
            // 
            // w7Button6
            // 
            this.w7Button6.BackColor = System.Drawing.Color.Transparent;
            this.w7Button6.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button6.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button6.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button6.ControlOpacity = 255;
            this.w7Button6.CornerRadius = 3;
            this.w7Button6.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button6.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.w7Button6.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.w7Button6.Icon = null;
            this.w7Button6.IconOpacity = 0F;
            this.w7Button6.Location = new System.Drawing.Point(868, 160);
            this.w7Button6.Name = "w7Button6";
            this.w7Button6.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button6.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.w7Button6.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.w7Button6.Size = new System.Drawing.Size(165, 35);
            this.w7Button6.TabIndex = 14;
            this.w7Button6.Tag = "";
            // 
            // w7Button7
            // 
            this.w7Button7.BackColor = System.Drawing.Color.Transparent;
            this.w7Button7.Clicked_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button7.Clicked_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.w7Button7.Clicked_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.w7Button7.ControlOpacity = 255;
            this.w7Button7.CornerRadius = 3;
            this.w7Button7.Hover_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.w7Button7.Hover_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.w7Button7.Hover_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.w7Button7.Icon = null;
            this.w7Button7.IconOpacity = 0F;
            this.w7Button7.Location = new System.Drawing.Point(1039, 160);
            this.w7Button7.Name = "w7Button7";
            this.w7Button7.Normal_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.w7Button7.Normal_FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.w7Button7.Normal_FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.w7Button7.Size = new System.Drawing.Size(165, 35);
            this.w7Button7.TabIndex = 15;
            this.w7Button7.Tag = "";
            // 
            // lblBTCPrice
            // 
            this.lblBTCPrice.AutoSize = true;
            this.lblBTCPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblBTCPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTCPrice.ForeColor = System.Drawing.Color.White;
            this.lblBTCPrice.Location = new System.Drawing.Point(14, 166);
            this.lblBTCPrice.Name = "lblBTCPrice";
            this.lblBTCPrice.Size = new System.Drawing.Size(65, 22);
            this.lblBTCPrice.TabIndex = 16;
            this.lblBTCPrice.Text = "R 0.00";
            // 
            // lblLTCPrice
            // 
            this.lblLTCPrice.AutoSize = true;
            this.lblLTCPrice.BackColor = System.Drawing.Color.DimGray;
            this.lblLTCPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTCPrice.ForeColor = System.Drawing.Color.White;
            this.lblLTCPrice.Location = new System.Drawing.Point(186, 166);
            this.lblLTCPrice.Name = "lblLTCPrice";
            this.lblLTCPrice.Size = new System.Drawing.Size(65, 22);
            this.lblLTCPrice.TabIndex = 17;
            this.lblLTCPrice.Text = "R 0.00";
            // 
            // lblNMCPrice
            // 
            this.lblNMCPrice.AutoSize = true;
            this.lblNMCPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(169)))), ((int)(((byte)(227)))));
            this.lblNMCPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNMCPrice.ForeColor = System.Drawing.Color.White;
            this.lblNMCPrice.Location = new System.Drawing.Point(357, 166);
            this.lblNMCPrice.Name = "lblNMCPrice";
            this.lblNMCPrice.Size = new System.Drawing.Size(65, 22);
            this.lblNMCPrice.TabIndex = 18;
            this.lblNMCPrice.Text = "R 0.00";
            // 
            // lblXRPPrice
            // 
            this.lblXRPPrice.AutoSize = true;
            this.lblXRPPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(171)))));
            this.lblXRPPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXRPPrice.ForeColor = System.Drawing.Color.White;
            this.lblXRPPrice.Location = new System.Drawing.Point(528, 166);
            this.lblXRPPrice.Name = "lblXRPPrice";
            this.lblXRPPrice.Size = new System.Drawing.Size(65, 22);
            this.lblXRPPrice.TabIndex = 19;
            this.lblXRPPrice.Text = "R 0.00";
            // 
            // lblETHPrice
            // 
            this.lblETHPrice.AutoSize = true;
            this.lblETHPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(111)))), ((int)(((byte)(169)))));
            this.lblETHPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETHPrice.ForeColor = System.Drawing.Color.White;
            this.lblETHPrice.Location = new System.Drawing.Point(699, 166);
            this.lblETHPrice.Name = "lblETHPrice";
            this.lblETHPrice.Size = new System.Drawing.Size(65, 22);
            this.lblETHPrice.TabIndex = 20;
            this.lblETHPrice.Text = "R 0.00";
            // 
            // lblDASHPrice
            // 
            this.lblDASHPrice.AutoSize = true;
            this.lblDASHPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.lblDASHPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDASHPrice.ForeColor = System.Drawing.Color.White;
            this.lblDASHPrice.Location = new System.Drawing.Point(870, 166);
            this.lblDASHPrice.Name = "lblDASHPrice";
            this.lblDASHPrice.Size = new System.Drawing.Size(65, 22);
            this.lblDASHPrice.TabIndex = 21;
            this.lblDASHPrice.Text = "R 0.00";
            // 
            // lblZECPrice
            // 
            this.lblZECPrice.AutoSize = true;
            this.lblZECPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(132)))), ((int)(((byte)(42)))));
            this.lblZECPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZECPrice.ForeColor = System.Drawing.Color.White;
            this.lblZECPrice.Location = new System.Drawing.Point(1041, 166);
            this.lblZECPrice.Name = "lblZECPrice";
            this.lblZECPrice.Size = new System.Drawing.Size(65, 22);
            this.lblZECPrice.TabIndex = 22;
            this.lblZECPrice.Text = "R 0.00";
            // 
            // tmrInterval
            // 
            this.tmrInterval.Enabled = true;
            this.tmrInterval.Interval = 1000;
            this.tmrInterval.Tick += new System.EventHandler(this.tmrInterval_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Time to next refresh:";
            // 
            // lblTimeToRefresh
            // 
            this.lblTimeToRefresh.AutoSize = true;
            this.lblTimeToRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeToRefresh.Location = new System.Drawing.Point(169, 24);
            this.lblTimeToRefresh.Name = "lblTimeToRefresh";
            this.lblTimeToRefresh.Size = new System.Drawing.Size(19, 21);
            this.lblTimeToRefresh.TabIndex = 24;
            this.lblTimeToRefresh.Text = "0";
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 533);
            this.ControlBox = false;
            this.Controls.Add(this.lblTimeToRefresh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblZECPrice);
            this.Controls.Add(this.lblDASHPrice);
            this.Controls.Add(this.lblETHPrice);
            this.Controls.Add(this.lblXRPPrice);
            this.Controls.Add(this.lblNMCPrice);
            this.Controls.Add(this.lblLTCPrice);
            this.Controls.Add(this.lblBTCPrice);
            this.Controls.Add(this.w7Button7);
            this.Controls.Add(this.w7Button6);
            this.Controls.Add(this.w7Button5);
            this.Controls.Add(this.w7Button4);
            this.Controls.Add(this.w7Button3);
            this.Controls.Add(this.w7Button2);
            this.Controls.Add(this.w7Button1);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnSelectBTC);
            this.Controls.Add(this.btnSelectLTC);
            this.Controls.Add(this.btnSelectNMC);
            this.Controls.Add(this.btnSelectXRP);
            this.Controls.Add(this.btnSelectETH);
            this.Controls.Add(this.btnSelectDASH);
            this.Controls.Add(this.btnSelectZEC);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CfrmMain";
            this.Text = "AltCoin Watcher";
            this.Load += new System.EventHandler(this.CfrmMain_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbrInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CloudToolkitN6.CloudButton btnClose;
        private CloudToolkitN6.W7Button btnSelectZEC;
        private CloudToolkitN6.W7Button btnSelectDASH;
        private CloudToolkitN6.W7Button btnSelectETH;
        private CloudToolkitN6.W7Button btnSelectXRP;
        private CloudToolkitN6.W7Button btnSelectNMC;
        private CloudToolkitN6.W7Button btnSelectLTC;
        private CloudToolkitN6.W7Button btnSelectBTC;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentLow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentHigh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedCryptcurreny;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtAlertAbove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlertBelow;
        private System.Windows.Forms.Label label8;
        private CloudToolkitN6.CloudButton btnSave;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trbrInterval;
        private CloudToolkitN6.W7Button w7Button1;
        private CloudToolkitN6.W7Button w7Button2;
        private CloudToolkitN6.W7Button w7Button3;
        private CloudToolkitN6.W7Button w7Button4;
        private CloudToolkitN6.W7Button w7Button5;
        private CloudToolkitN6.W7Button w7Button6;
        private CloudToolkitN6.W7Button w7Button7;
        private System.Windows.Forms.Label lblBTCPrice;
        private System.Windows.Forms.Label lblLTCPrice;
        private System.Windows.Forms.Label lblNMCPrice;
        private System.Windows.Forms.Label lblXRPPrice;
        private System.Windows.Forms.Label lblETHPrice;
        private System.Windows.Forms.Label lblDASHPrice;
        private System.Windows.Forms.Label lblZECPrice;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Timer tmrInterval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimeToRefresh;



    }
}

