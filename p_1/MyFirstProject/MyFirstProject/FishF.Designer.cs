namespace MyFirstProject
{
    partial class FishF
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
            this.ButtFish3 = new System.Windows.Forms.Button();
            this.ButtFish2 = new System.Windows.Forms.Button();
            this.ButtFish1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtFish3
            // 
            this.ButtFish3.BackgroundImage = global::MyFirstProject.Resource1.WhiteM1__2_;
            this.ButtFish3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtFish3.Location = new System.Drawing.Point(13, 70);
            this.ButtFish3.Name = "ButtFish3";
            this.ButtFish3.Size = new System.Drawing.Size(83, 51);
            this.ButtFish3.TabIndex = 2;
            this.ButtFish3.UseVisualStyleBackColor = true;
            this.ButtFish3.Click += new System.EventHandler(this.ButtFish3_Click);
            // 
            // ButtFish2
            // 
            this.ButtFish2.BackgroundImage = global::MyFirstProject.Resource1.Neon1;
            this.ButtFish2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtFish2.Location = new System.Drawing.Point(102, 13);
            this.ButtFish2.Name = "ButtFish2";
            this.ButtFish2.Size = new System.Drawing.Size(82, 51);
            this.ButtFish2.TabIndex = 1;
            this.ButtFish2.UseVisualStyleBackColor = true;
            this.ButtFish2.Click += new System.EventHandler(this.ButtFish2_Click);
            // 
            // ButtFish1
            // 
            this.ButtFish1.BackgroundImage = global::MyFirstProject.Resource1.FishC1;
            this.ButtFish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtFish1.Location = new System.Drawing.Point(13, 13);
            this.ButtFish1.Name = "ButtFish1";
            this.ButtFish1.Size = new System.Drawing.Size(82, 51);
            this.ButtFish1.TabIndex = 0;
            this.ButtFish1.UseVisualStyleBackColor = true;
            this.ButtFish1.Click += new System.EventHandler(this.ButtFish1_Click);
            // 
            // FishF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 162);
            this.Controls.Add(this.ButtFish3);
            this.Controls.Add(this.ButtFish2);
            this.Controls.Add(this.ButtFish1);
            this.Name = "FishF";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtFish1;
        private System.Windows.Forms.Button ButtFish2;
        private System.Windows.Forms.Button ButtFish3;
    }
}