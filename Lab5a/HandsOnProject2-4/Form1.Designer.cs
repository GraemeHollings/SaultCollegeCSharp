namespace HandsOnProject2_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.germany = new System.Windows.Forms.PictureBox();
            this.france = new System.Windows.Forms.PictureBox();
            this.finland = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.germany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.france)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finland)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click the flag to see the name of the country";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(349, 330);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(13, 13);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = ":)";
            this.countryLabel.Click += new System.EventHandler(this.countryLabel_Click);
            // 
            // germany
            // 
            this.germany.Image = global::HandsOnProject2_4.Properties.Resources.germany;
            this.germany.Location = new System.Drawing.Point(501, 123);
            this.germany.Name = "germany";
            this.germany.Size = new System.Drawing.Size(194, 134);
            this.germany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germany.TabIndex = 3;
            this.germany.TabStop = false;
            this.germany.Click += new System.EventHandler(this.germany_Click);
            // 
            // france
            // 
            this.france.Image = global::HandsOnProject2_4.Properties.Resources.france;
            this.france.Location = new System.Drawing.Point(275, 123);
            this.france.Name = "france";
            this.france.Size = new System.Drawing.Size(194, 134);
            this.france.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.france.TabIndex = 2;
            this.france.TabStop = false;
            this.france.Click += new System.EventHandler(this.france_Click);
            // 
            // finland
            // 
            this.finland.Image = global::HandsOnProject2_4.Properties.Resources.finland;
            this.finland.Location = new System.Drawing.Point(38, 117);
            this.finland.Name = "finland";
            this.finland.Size = new System.Drawing.Size(204, 140);
            this.finland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finland.TabIndex = 1;
            this.finland.TabStop = false;
            this.finland.Click += new System.EventHandler(this.finland_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germany);
            this.Controls.Add(this.france);
            this.Controls.Add(this.finland);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.france)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finland)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox finland;
        private System.Windows.Forms.PictureBox france;
        private System.Windows.Forms.PictureBox germany;
        private System.Windows.Forms.Label countryLabel;
    }
}

