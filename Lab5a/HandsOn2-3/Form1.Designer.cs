namespace HandsOn2_3
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
            this.translationLabel = new System.Windows.Forms.TextBox();
            this.italian = new System.Windows.Forms.Button();
            this.Spanish = new System.Windows.Forms.Button();
            this.German = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a language and I will say Good Morning.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // translationLabel
            // 
            this.translationLabel.Location = new System.Drawing.Point(189, 79);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(237, 20);
            this.translationLabel.TabIndex = 1;
            // 
            // italian
            // 
            this.italian.Location = new System.Drawing.Point(189, 140);
            this.italian.Name = "italian";
            this.italian.Size = new System.Drawing.Size(75, 23);
            this.italian.TabIndex = 2;
            this.italian.Text = "Italian";
            this.italian.UseVisualStyleBackColor = true;
            this.italian.Click += new System.EventHandler(this.italian_Click);
            // 
            // Spanish
            // 
            this.Spanish.Location = new System.Drawing.Point(270, 140);
            this.Spanish.Name = "Spanish";
            this.Spanish.Size = new System.Drawing.Size(75, 23);
            this.Spanish.TabIndex = 3;
            this.Spanish.Text = "Spanish";
            this.Spanish.UseVisualStyleBackColor = true;
            this.Spanish.Click += new System.EventHandler(this.Spanish_Click);
            // 
            // German
            // 
            this.German.Location = new System.Drawing.Point(351, 140);
            this.German.Name = "German";
            this.German.Size = new System.Drawing.Size(75, 23);
            this.German.TabIndex = 4;
            this.German.Text = "German";
            this.German.UseVisualStyleBackColor = true;
            this.German.Click += new System.EventHandler(this.German_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 314);
            this.Controls.Add(this.German);
            this.Controls.Add(this.Spanish);
            this.Controls.Add(this.italian);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox translationLabel;
        private System.Windows.Forms.Button italian;
        private System.Windows.Forms.Button Spanish;
        private System.Windows.Forms.Button German;
    }
}

