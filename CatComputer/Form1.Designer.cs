namespace CatComputer
{
    partial class Form1
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
            this.GoButton = new System.Windows.Forms.Button();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.graphLevel = new CatControls.CatGraph();
            this.graphRooms = new CatControls.CatGraph();
            this.graphCats = new CatControls.CatGraph();
            this.graphHardware = new CatControls.CatGraph();
            this.graphCoin = new CatControls.CatGraph();
            this.graphXP = new CatControls.CatGraph();
            this.labelTime = new System.Windows.Forms.Label();
            this.passiveCoinNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playCoinNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.wanderCoinNumber = new System.Windows.Forms.NumericUpDown();
            this.wanderCoinPct = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wanderHardwarePct = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.wanderHardwareNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.playXPNumber = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.passiveXPNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passiveCoinNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playCoinNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderCoinNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderCoinPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderHardwarePct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderHardwareNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playXPNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passiveXPNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(12, 465);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // trackBarTime
            // 
            this.trackBarTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarTime.Location = new System.Drawing.Point(716, 322);
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(236, 45);
            this.trackBarTime.TabIndex = 9;
            this.trackBarTime.Scroll += new System.EventHandler(this.trackBarTime_Scroll);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(716, 12);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(236, 290);
            this.listBoxEvents.TabIndex = 10;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // graphLevel
            // 
            this.graphLevel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphLevel.Location = new System.Drawing.Point(474, 202);
            this.graphLevel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.graphLevel.Name = "graphLevel";
            this.graphLevel.Size = new System.Drawing.Size(210, 168);
            this.graphLevel.TabIndex = 6;
            // 
            // graphRooms
            // 
            this.graphRooms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphRooms.Location = new System.Drawing.Point(243, 202);
            this.graphRooms.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.graphRooms.Name = "graphRooms";
            this.graphRooms.Size = new System.Drawing.Size(210, 168);
            this.graphRooms.TabIndex = 5;
            // 
            // graphCats
            // 
            this.graphCats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphCats.Location = new System.Drawing.Point(12, 202);
            this.graphCats.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.graphCats.Name = "graphCats";
            this.graphCats.Size = new System.Drawing.Size(210, 168);
            this.graphCats.TabIndex = 4;
            // 
            // graphHardware
            // 
            this.graphHardware.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphHardware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphHardware.Location = new System.Drawing.Point(474, 12);
            this.graphHardware.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.graphHardware.Name = "graphHardware";
            this.graphHardware.Size = new System.Drawing.Size(210, 168);
            this.graphHardware.TabIndex = 3;
            // 
            // graphCoin
            // 
            this.graphCoin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphCoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphCoin.Location = new System.Drawing.Point(243, 12);
            this.graphCoin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.graphCoin.Name = "graphCoin";
            this.graphCoin.Size = new System.Drawing.Size(210, 168);
            this.graphCoin.TabIndex = 2;
            // 
            // graphXP
            // 
            this.graphXP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphXP.Location = new System.Drawing.Point(12, 12);
            this.graphXP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.graphXP.Name = "graphXP";
            this.graphXP.Size = new System.Drawing.Size(210, 168);
            this.graphXP.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(716, 355);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(13, 13);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "0";
            // 
            // passiveCoinNumber
            // 
            this.passiveCoinNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.passiveCoinNumber.Location = new System.Drawing.Point(185, 414);
            this.passiveCoinNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.passiveCoinNumber.Name = "passiveCoinNumber";
            this.passiveCoinNumber.Size = new System.Drawing.Size(120, 20);
            this.passiveCoinNumber.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "PassiveCoin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PlayCoin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playCoinNumber
            // 
            this.playCoinNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playCoinNumber.Location = new System.Drawing.Point(185, 440);
            this.playCoinNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.playCoinNumber.Name = "playCoinNumber";
            this.playCoinNumber.Size = new System.Drawing.Size(120, 20);
            this.playCoinNumber.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "WanderCoin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wanderCoinNumber
            // 
            this.wanderCoinNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wanderCoinNumber.Location = new System.Drawing.Point(185, 466);
            this.wanderCoinNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.wanderCoinNumber.Name = "wanderCoinNumber";
            this.wanderCoinNumber.Size = new System.Drawing.Size(120, 20);
            this.wanderCoinNumber.TabIndex = 16;
            // 
            // wanderCoinPct
            // 
            this.wanderCoinPct.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wanderCoinPct.Location = new System.Drawing.Point(307, 466);
            this.wanderCoinPct.Name = "wanderCoinPct";
            this.wanderCoinPct.Size = new System.Drawing.Size(67, 20);
            this.wanderCoinPct.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "%";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wanderHardwarePct
            // 
            this.wanderHardwarePct.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wanderHardwarePct.Location = new System.Drawing.Point(596, 466);
            this.wanderHardwarePct.Name = "wanderHardwarePct";
            this.wanderHardwarePct.Size = new System.Drawing.Size(67, 20);
            this.wanderHardwarePct.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "WanderHW";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wanderHardwareNumber
            // 
            this.wanderHardwareNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wanderHardwareNumber.Location = new System.Drawing.Point(474, 466);
            this.wanderHardwareNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.wanderHardwareNumber.Name = "wanderHardwareNumber";
            this.wanderHardwareNumber.Size = new System.Drawing.Size(120, 20);
            this.wanderHardwareNumber.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "PlayXP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playXPNumber
            // 
            this.playXPNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.playXPNumber.Location = new System.Drawing.Point(474, 440);
            this.playXPNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.playXPNumber.Name = "playXPNumber";
            this.playXPNumber.Size = new System.Drawing.Size(120, 20);
            this.playXPNumber.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "PassiveXP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passiveXPNumber
            // 
            this.passiveXPNumber.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.passiveXPNumber.Location = new System.Drawing.Point(474, 414);
            this.passiveXPNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.passiveXPNumber.Name = "passiveXPNumber";
            this.passiveXPNumber.Size = new System.Drawing.Size(120, 20);
            this.passiveXPNumber.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1065, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wanderHardwarePct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wanderHardwareNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playXPNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passiveXPNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wanderCoinPct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wanderCoinNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playCoinNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passiveCoinNumber);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.trackBarTime);
            this.Controls.Add(this.graphLevel);
            this.Controls.Add(this.graphRooms);
            this.Controls.Add(this.graphCats);
            this.Controls.Add(this.graphHardware);
            this.Controls.Add(this.graphCoin);
            this.Controls.Add(this.graphXP);
            this.Controls.Add(this.GoButton);
            this.Name = "Form1";
            this.Text = "Cat Computer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passiveCoinNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playCoinNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderCoinNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderCoinPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderHardwarePct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderHardwareNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playXPNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passiveXPNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private CatControls.CatGraph graphXP;
        private CatControls.CatGraph graphCoin;
        private CatControls.CatGraph graphHardware;
        private CatControls.CatGraph graphLevel;
        private CatControls.CatGraph graphRooms;
        private CatControls.CatGraph graphCats;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown passiveCoinNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown playCoinNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown wanderCoinNumber;
        private System.Windows.Forms.NumericUpDown wanderCoinPct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown wanderHardwarePct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown wanderHardwareNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown playXPNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown passiveXPNumber;
    }
}

