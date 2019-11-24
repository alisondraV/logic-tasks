namespace Задачі
{
    partial class Crossing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crossing));
            this.label1 = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.Koza = new System.Windows.Forms.PictureBox();
            this.Wolk = new System.Windows.Forms.PictureBox();
            this.Kapusta = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Koza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wolk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kapusta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(1031, 24);
            this.txttime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(96, 45);
            this.txttime.TabIndex = 1;
            this.txttime.Text = "3:00";
            // 
            // Koza
            // 
            this.Koza.BackColor = System.Drawing.Color.Transparent;
            this.Koza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Koza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Koza.Enabled = false;
            this.Koza.Image = ((System.Drawing.Image)(resources.GetObject("Koza.Image")));
            this.Koza.Location = new System.Drawing.Point(968, 228);
            this.Koza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Koza.Name = "Koza";
            this.Koza.Size = new System.Drawing.Size(142, 130);
            this.Koza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Koza.TabIndex = 6;
            this.Koza.TabStop = false;
            this.Koza.Click += new System.EventHandler(this.Koza_Click);
            // 
            // Wolk
            // 
            this.Wolk.BackColor = System.Drawing.Color.Transparent;
            this.Wolk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wolk.Enabled = false;
            this.Wolk.Image = ((System.Drawing.Image)(resources.GetObject("Wolk.Image")));
            this.Wolk.Location = new System.Drawing.Point(1055, 84);
            this.Wolk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Wolk.Name = "Wolk";
            this.Wolk.Size = new System.Drawing.Size(142, 130);
            this.Wolk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wolk.TabIndex = 7;
            this.Wolk.TabStop = false;
            this.Wolk.Click += new System.EventHandler(this.Wolk_Click);
            // 
            // Kapusta
            // 
            this.Kapusta.BackColor = System.Drawing.Color.Transparent;
            this.Kapusta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Kapusta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kapusta.Enabled = false;
            this.Kapusta.Image = ((System.Drawing.Image)(resources.GetObject("Kapusta.Image")));
            this.Kapusta.Location = new System.Drawing.Point(1118, 277);
            this.Kapusta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Kapusta.Name = "Kapusta";
            this.Kapusta.Size = new System.Drawing.Size(142, 130);
            this.Kapusta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kapusta.TabIndex = 8;
            this.Kapusta.TabStop = false;
            this.Kapusta.Click += new System.EventHandler(this.Kapusta_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 722);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кількість ходів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(219, 722);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "_";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 63);
            this.label4.TabIndex = 11;
            this.label4.Text = "Як йому переправити усі придбання через річку, якщо коза не може залишатися наоди" +
    "нці з капустою, \r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(468, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "а вовк – наодинці з козою?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(200, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 130);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(74, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 130);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(33, 162);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(142, 130);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(693, 267);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(142, 130);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(23, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 41);
            this.button3.TabIndex = 63;
            this.button3.Text = "Закінчити";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(23, 24);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 41);
            this.button4.TabIndex = 62;
            this.button4.Text = "Почати";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Pereprava
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Koza);
            this.Controls.Add(this.Wolk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kapusta);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Pereprava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переправа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Koza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wolk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kapusta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.PictureBox Koza;
        private System.Windows.Forms.PictureBox Wolk;
        private System.Windows.Forms.PictureBox Kapusta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer2;
    }
}

