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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(24, 752);
            this.GoButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(150, 44);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // trackBarTime
            // 
            this.trackBarTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarTime.Location = new System.Drawing.Point(1432, 619);
            this.trackBarTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(472, 90);
            this.trackBarTime.TabIndex = 9;
            this.trackBarTime.Scroll += new System.EventHandler(this.trackBarTime_Scroll);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 25;
            this.listBoxEvents.Location = new System.Drawing.Point(1432, 23);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(468, 554);
            this.listBoxEvents.TabIndex = 10;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // graphLevel
            // 
            this.graphLevel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphLevel.Location = new System.Drawing.Point(948, 388);
            this.graphLevel.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.graphLevel.Name = "graphLevel";
            this.graphLevel.Size = new System.Drawing.Size(418, 321);
            this.graphLevel.TabIndex = 6;
            // 
            // graphRooms
            // 
            this.graphRooms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphRooms.Location = new System.Drawing.Point(486, 388);
            this.graphRooms.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.graphRooms.Name = "graphRooms";
            this.graphRooms.Size = new System.Drawing.Size(418, 321);
            this.graphRooms.TabIndex = 5;
            // 
            // graphCats
            // 
            this.graphCats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphCats.Location = new System.Drawing.Point(24, 388);
            this.graphCats.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.graphCats.Name = "graphCats";
            this.graphCats.Size = new System.Drawing.Size(418, 321);
            this.graphCats.TabIndex = 4;
            // 
            // graphHardware
            // 
            this.graphHardware.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphHardware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphHardware.Location = new System.Drawing.Point(948, 23);
            this.graphHardware.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.graphHardware.Name = "graphHardware";
            this.graphHardware.Size = new System.Drawing.Size(418, 321);
            this.graphHardware.TabIndex = 3;
            // 
            // graphCoin
            // 
            this.graphCoin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphCoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphCoin.Location = new System.Drawing.Point(486, 23);
            this.graphCoin.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.graphCoin.Name = "graphCoin";
            this.graphCoin.Size = new System.Drawing.Size(418, 321);
            this.graphCoin.TabIndex = 2;
            // 
            // graphXP
            // 
            this.graphXP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphXP.Location = new System.Drawing.Point(24, 23);
            this.graphXP.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.graphXP.Name = "graphXP";
            this.graphXP.Size = new System.Drawing.Size(418, 321);
            this.graphXP.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(1432, 683);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(24, 25);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(2130, 819);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Cat Computer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
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
    }
}

