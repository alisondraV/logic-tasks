namespace Задачі
{
    partial class Same
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Same));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lbln = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1046, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Почати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(1006, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 184);
            this.label1.TabIndex = 4;
            this.label1.Text = "Представлено 24 квадрата, за кожним з яких знаходиться малюнок. Треба знайти пару" +
    " до кожного малюнку.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1006, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Залишилось часу:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(35, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 625);
            this.panel1.TabIndex = 59;
            this.panel1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(1046, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 41);
            this.button2.TabIndex = 60;
            this.button2.Text = "Закінчити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblres
            // 
            this.lblres.BackColor = System.Drawing.Color.Transparent;
            this.lblres.Location = new System.Drawing.Point(984, 481);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(286, 67);
            this.lblres.TabIndex = 61;
            this.lblres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(980, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 31);
            this.label3.TabIndex = 62;
            this.label3.Text = "Кількість переворотів:";
            this.label3.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Location = new System.Drawing.Point(1202, 568);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(62, 31);
            this.lbltime.TabIndex = 68;
            this.lbltime.Text = "4:00";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.BackColor = System.Drawing.Color.Transparent;
            this.lbln.Location = new System.Drawing.Point(1222, 387);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(28, 31);
            this.lbln.TabIndex = 69;
            this.lbln.Text = "_";
            this.lbln.Visible = false;
            // 
            // Same
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.lbln);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Same";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дві однакові";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lbln;
    }
}

