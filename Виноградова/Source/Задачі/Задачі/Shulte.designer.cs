namespace Задачі
{
    partial class Shulte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shulte));
            this.lblres = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblres
            // 
            this.lblres.BackColor = System.Drawing.Color.Transparent;
            this.lblres.Location = new System.Drawing.Point(849, 288);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(286, 67);
            this.lblres.TabIndex = 63;
            this.lblres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(913, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 41);
            this.button2.TabIndex = 62;
            this.button2.Text = "Закінчити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(868, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Витрачено часу:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(913, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 41);
            this.button1.TabIndex = 59;
            this.button1.Text = "Почати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.panel1.Location = new System.Drawing.Point(73, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 64;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label3.Location = new System.Drawing.Point(796, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 97);
            this.label3.TabIndex = 65;
            this.label3.Text = "Вказати хаотично представлені у таблиці числа у порядку їх зростання.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Location = new System.Drawing.Point(1050, 511);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(51, 25);
            this.lbltime.TabIndex = 66;
            this.lbltime.Text = "0:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Shulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Shulte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблиця Шульте";
            this.Load += new System.EventHandler(this.Shulte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer2;
    }
}

