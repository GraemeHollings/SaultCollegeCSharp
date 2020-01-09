namespace HandsOn2_5
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
            this.showBack = new System.Windows.Forms.Button();
            this.showFace = new System.Windows.Forms.Button();
            this.frontCard = new System.Windows.Forms.PictureBox();
            this.backCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.frontCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCard)).BeginInit();
            this.SuspendLayout();
            // 
            // showBack
            // 
            this.showBack.Location = new System.Drawing.Point(119, 350);
            this.showBack.Name = "showBack";
            this.showBack.Size = new System.Drawing.Size(75, 47);
            this.showBack.TabIndex = 2;
            this.showBack.Text = "Show The Card Back";
            this.showBack.UseVisualStyleBackColor = true;
            this.showBack.Click += new System.EventHandler(this.showBack_Click);
            // 
            // showFace
            // 
            this.showFace.Location = new System.Drawing.Point(628, 362);
            this.showFace.Name = "showFace";
            this.showFace.Size = new System.Drawing.Size(81, 35);
            this.showFace.TabIndex = 3;
            this.showFace.Text = "Show the Card Face";
            this.showFace.UseVisualStyleBackColor = true;
            this.showFace.Click += new System.EventHandler(this.showFace_Click);
            // 
            // frontCard
            // 
            this.frontCard.Image = global::HandsOn2_5.Properties.Resources.vma_4_black_lotus;
            this.frontCard.Location = new System.Drawing.Point(559, 44);
            this.frontCard.Name = "frontCard";
            this.frontCard.Size = new System.Drawing.Size(217, 300);
            this.frontCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frontCard.TabIndex = 1;
            this.frontCard.TabStop = false;
            // 
            // backCard
            // 
            this.backCard.Image = global::HandsOn2_5.Properties.Resources._220px_Magic_the_gathering_card_back;
            this.backCard.Location = new System.Drawing.Point(53, 44);
            this.backCard.Name = "backCard";
            this.backCard.Size = new System.Drawing.Size(213, 300);
            this.backCard.TabIndex = 0;
            this.backCard.TabStop = false;
            this.backCard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showFace);
            this.Controls.Add(this.showBack);
            this.Controls.Add(this.frontCard);
            this.Controls.Add(this.backCard);
            this.Name = "Form1";
            this.Text = "CardFlip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frontCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backCard;
        private System.Windows.Forms.PictureBox frontCard;
        private System.Windows.Forms.Button showBack;
        private System.Windows.Forms.Button showFace;
    }
}

