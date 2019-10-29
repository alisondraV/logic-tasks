namespace Задачі
{
    partial class Words
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Words));
            this.label1 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblres = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(161, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вам буде представлений список різних слів. Через 10 секунд ці слова будуть змішан" +
    "і, але до них додасться ще одне слово, яке Вам потрібно знайти. Це завдання повт" +
    "ориться тричі.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Location = new System.Drawing.Point(1128, 584);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(51, 25);
            this.lbltime.TabIndex = 71;
            this.lbltime.Text = "3:00";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(987, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 41);
            this.button2.TabIndex = 70;
            this.button2.Text = "Закінчити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(945, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Залишилось часу:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(987, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 41);
            this.button1.TabIndex = 68;
            this.button1.Text = "Почати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblres
            // 
            this.lblres.BackColor = System.Drawing.Color.Transparent;
            this.lblres.Location = new System.Drawing.Point(927, 395);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(286, 67);
            this.lblres.TabIndex = 72;
            this.lblres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(60, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 464);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Words";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слова";
            this.Load += new System.EventHandler(this.Words_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}