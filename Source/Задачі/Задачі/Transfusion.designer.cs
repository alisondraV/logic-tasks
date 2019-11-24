namespace Задачі
{
    partial class Transfusion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfusion));
            this.label1 = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pc8litr = new System.Windows.Forms.PictureBox();
            this.pc3litr = new System.Windows.Forms.PictureBox();
            this.pc5litr = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pc8litr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3litr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5litr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1131, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(1073, 162);
            this.txttime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(124, 45);
            this.txttime.TabIndex = 1;
            this.txttime.Text = "3:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pc8litr
            // 
            this.pc8litr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc8litr.Enabled = false;
            this.pc8litr.Location = new System.Drawing.Point(54, 127);
            this.pc8litr.Name = "pc8litr";
            this.pc8litr.Size = new System.Drawing.Size(261, 480);
            this.pc8litr.TabIndex = 12;
            this.pc8litr.TabStop = false;
            this.pc8litr.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pc3litr
            // 
            this.pc3litr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc3litr.Enabled = false;
            this.pc3litr.Location = new System.Drawing.Point(380, 427);
            this.pc3litr.Name = "pc3litr";
            this.pc3litr.Size = new System.Drawing.Size(261, 180);
            this.pc3litr.TabIndex = 13;
            this.pc3litr.TabStop = false;
            this.pc3litr.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pc5litr
            // 
            this.pc5litr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc5litr.Enabled = false;
            this.pc5litr.Location = new System.Drawing.Point(696, 307);
            this.pc5litr.Name = "pc5litr";
            this.pc5litr.Size = new System.Drawing.Size(261, 300);
            this.pc5litr.TabIndex = 14;
            this.pc5litr.TabStop = false;
            this.pc5litr.Click += new System.EventHandler(this.pc5litr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(689, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 29;
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.Snow;
            this.Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Finish.Location = new System.Drawing.Point(1052, 307);
            this.Finish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(162, 41);
            this.Finish.TabIndex = 59;
            this.Finish.Text = "Закінчити";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Visible = false;
            this.Finish.Click += new System.EventHandler(this.button3_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Snow;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Location = new System.Drawing.Point(1052, 256);
            this.Start.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(162, 41);
            this.Start.TabIndex = 58;
            this.Start.Text = "Почати";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Perel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pc5litr);
            this.Controls.Add(this.pc3litr);
            this.Controls.Add(this.pc8litr);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Perel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переливання";
            ((System.ComponentModel.ISupportInitialize)(this.pc8litr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3litr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5litr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pc8litr;
        private System.Windows.Forms.PictureBox pc3litr;
        private System.Windows.Forms.PictureBox pc5litr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer2;
    }
}

