namespace MyFirstProject
{
    partial class AquariumF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.NextDay = new System.Windows.Forms.Button();
            this.AddPlantButton = new System.Windows.Forms.Button();
            this.RemovePlantButton = new System.Windows.Forms.Button();
            this.DelKillB = new System.Windows.Forms.Button();
            this.DellKillF = new System.Windows.Forms.Button();
            this.DellKillP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить пузырёк";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить рыбку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Фоны";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить пузырёк";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "Удалить рыбку";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // NextDay
            // 
            this.NextDay.Location = new System.Drawing.Point(12, 787);
            this.NextDay.Name = "NextDay";
            this.NextDay.Size = new System.Drawing.Size(148, 40);
            this.NextDay.TabIndex = 7;
            this.NextDay.Text = "Следующий день";
            this.NextDay.UseVisualStyleBackColor = true;
            this.NextDay.Click += new System.EventHandler(this.NextDay_Click);
            // 
            // AddPlantButton
            // 
            this.AddPlantButton.Location = new System.Drawing.Point(12, 82);
            this.AddPlantButton.Name = "AddPlantButton";
            this.AddPlantButton.Size = new System.Drawing.Size(165, 29);
            this.AddPlantButton.TabIndex = 8;
            this.AddPlantButton.Text = "Добавить растение";
            this.AddPlantButton.UseVisualStyleBackColor = true;
            this.AddPlantButton.Click += new System.EventHandler(this.AddPlantButton_Click);
            // 
            // RemovePlantButton
            // 
            this.RemovePlantButton.Location = new System.Drawing.Point(183, 82);
            this.RemovePlantButton.Name = "RemovePlantButton";
            this.RemovePlantButton.Size = new System.Drawing.Size(165, 29);
            this.RemovePlantButton.TabIndex = 9;
            this.RemovePlantButton.Text = "Удалить растение";
            this.RemovePlantButton.UseVisualStyleBackColor = true;
            this.RemovePlantButton.Click += new System.EventHandler(this.RemovePlantButton_Click);
            // 
            // DelKillB
            // 
            this.DelKillB.Location = new System.Drawing.Point(354, 12);
            this.DelKillB.Name = "DelKillB";
            this.DelKillB.Size = new System.Drawing.Size(165, 29);
            this.DelKillB.TabIndex = 10;
            this.DelKillB.Text = "Удалить ядовитый п.";
            this.DelKillB.UseVisualStyleBackColor = true;
            this.DelKillB.Click += new System.EventHandler(this.DelKillB_Click);
            // 
            // DellKillF
            // 
            this.DellKillF.Location = new System.Drawing.Point(354, 47);
            this.DellKillF.Name = "DellKillF";
            this.DellKillF.Size = new System.Drawing.Size(165, 29);
            this.DellKillF.TabIndex = 11;
            this.DellKillF.Text = "Удалить мёртвую р.";
            this.DellKillF.UseVisualStyleBackColor = true;
            this.DellKillF.Click += new System.EventHandler(this.DellKillF_Click);
            // 
            // DellKillP
            // 
            this.DellKillP.Location = new System.Drawing.Point(354, 82);
            this.DellKillP.Name = "DellKillP";
            this.DellKillP.Size = new System.Drawing.Size(165, 29);
            this.DellKillP.TabIndex = 12;
            this.DellKillP.Text = "Удалить больное р.";
            this.DellKillP.UseVisualStyleBackColor = true;
            this.DellKillP.Click += new System.EventHandler(this.DellKillP_Click);
            // 
            // AquariumF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 839);
            this.Controls.Add(this.DellKillP);
            this.Controls.Add(this.DellKillF);
            this.Controls.Add(this.DelKillB);
            this.Controls.Add(this.RemovePlantButton);
            this.Controls.Add(this.AddPlantButton);
            this.Controls.Add(this.NextDay);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "AquariumF";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button NextDay;
        private System.Windows.Forms.Button AddPlantButton;
        private System.Windows.Forms.Button RemovePlantButton;
        private System.Windows.Forms.Button DelKillB;
        private System.Windows.Forms.Button DellKillF;
        private System.Windows.Forms.Button DellKillP;
    }
}

