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
            this.graphCoin = new CatControls.CatGraph();
            this.graphXP = new CatControls.CatGraph();
            this.graphHardware = new CatControls.CatGraph();
            this.graphLevel = new CatControls.CatGraph();
            this.graphRooms = new CatControls.CatGraph();
            this.graphCats = new CatControls.CatGraph();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(12, 391);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // graphCoin
            // 
            this.graphCoin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphCoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphCoin.Location = new System.Drawing.Point(243, 12);
            this.graphCoin.Name = "graphCoin";
            this.graphCoin.Size = new System.Drawing.Size(210, 168);
            this.graphCoin.TabIndex = 2;
            // 
            // graphXP
            // 
            this.graphXP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphXP.Location = new System.Drawing.Point(12, 12);
            this.graphXP.Name = "graphXP";
            this.graphXP.Size = new System.Drawing.Size(210, 168);
            this.graphXP.TabIndex = 1;
            // 
            // graphHardware
            // 
            this.graphHardware.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphHardware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphHardware.Location = new System.Drawing.Point(474, 12);
            this.graphHardware.Name = "graphHardware";
            this.graphHardware.Size = new System.Drawing.Size(210, 168);
            this.graphHardware.TabIndex = 3;
            // 
            // graphLevel
            // 
            this.graphLevel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphLevel.Location = new System.Drawing.Point(474, 202);
            this.graphLevel.Name = "graphLevel";
            this.graphLevel.Size = new System.Drawing.Size(210, 168);
            this.graphLevel.TabIndex = 6;
            // 
            // graphRooms
            // 
            this.graphRooms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphRooms.Location = new System.Drawing.Point(243, 202);
            this.graphRooms.Name = "graphRooms";
            this.graphRooms.Size = new System.Drawing.Size(210, 168);
            this.graphRooms.TabIndex = 5;
            // 
            // graphCats
            // 
            this.graphCats.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphCats.Location = new System.Drawing.Point(12, 202);
            this.graphCats.Name = "graphCats";
            this.graphCats.Size = new System.Drawing.Size(210, 168);
            this.graphCats.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 426);
            this.Controls.Add(this.graphLevel);
            this.Controls.Add(this.graphRooms);
            this.Controls.Add(this.graphCats);
            this.Controls.Add(this.graphHardware);
            this.Controls.Add(this.graphCoin);
            this.Controls.Add(this.graphXP);
            this.Controls.Add(this.GoButton);
            this.Name = "Form1";
            this.Text = "Cat Computer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private CatControls.CatGraph graphXP;
        private CatControls.CatGraph graphCoin;
        private CatControls.CatGraph graphHardware;
        private CatControls.CatGraph graphLevel;
        private CatControls.CatGraph graphRooms;
        private CatControls.CatGraph graphCats;
    }
}

