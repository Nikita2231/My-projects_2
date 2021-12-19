namespace MyFirstProject
{
    partial class ImF
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
            this.ButtAqua3 = new System.Windows.Forms.Button();
            this.ButtAqua2 = new System.Windows.Forms.Button();
            this.ButtAqua1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtAqua3
            // 
            this.ButtAqua3.BackgroundImage = global::MyFirstProject.Resource1._8b544d713911eb6c5bb4eb2e3c370e44__2_;
            this.ButtAqua3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtAqua3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtAqua3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtAqua3.Location = new System.Drawing.Point(13, 72);
            this.ButtAqua3.Name = "ButtAqua3";
            this.ButtAqua3.Size = new System.Drawing.Size(76, 53);
            this.ButtAqua3.TabIndex = 2;
            this.ButtAqua3.UseVisualStyleBackColor = true;
            this.ButtAqua3.Click += new System.EventHandler(this.ButtAqua3_Click);
            // 
            // ButtAqua2
            // 
            this.ButtAqua2.BackgroundImage = global::MyFirstProject.Resource1.Im3__2_;
            this.ButtAqua2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtAqua2.Location = new System.Drawing.Point(95, 13);
            this.ButtAqua2.Name = "ButtAqua2";
            this.ButtAqua2.Size = new System.Drawing.Size(81, 53);
            this.ButtAqua2.TabIndex = 1;
            this.ButtAqua2.UseVisualStyleBackColor = true;
            this.ButtAqua2.Click += new System.EventHandler(this.ButtAqua2_Click);
            // 
            // ButtAqua1
            // 
            this.ButtAqua1.BackgroundImage = global::MyFirstProject.Resource1.Im2__2_;
            this.ButtAqua1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtAqua1.Location = new System.Drawing.Point(13, 13);
            this.ButtAqua1.Name = "ButtAqua1";
            this.ButtAqua1.Size = new System.Drawing.Size(76, 53);
            this.ButtAqua1.TabIndex = 0;
            this.ButtAqua1.UseVisualStyleBackColor = true;
            this.ButtAqua1.Click += new System.EventHandler(this.ButtAqua1_Click);
            // 
            // ImF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 140);
            this.Controls.Add(this.ButtAqua3);
            this.Controls.Add(this.ButtAqua2);
            this.Controls.Add(this.ButtAqua1);
            this.Name = "ImF";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtAqua1;
        private System.Windows.Forms.Button ButtAqua2;
        private System.Windows.Forms.Button ButtAqua3;
    }
}