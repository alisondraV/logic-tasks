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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPictures = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblNumberTurns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Location = new System.Drawing.Point(1046, 241);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 41);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.label1.Text = "There are 24 squares, which hide pictures beneath them. You have to turn them, so" +
    " as to find a pair for each one.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1006, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Time left:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlPictures
            // 
            this.pnlPictures.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlPictures.Location = new System.Drawing.Point(35, 24);
            this.pnlPictures.Name = "pnlPictures";
            this.pnlPictures.Size = new System.Drawing.Size(935, 625);
            this.pnlPictures.TabIndex = 59;
            this.pnlPictures.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Snow;
            this.btnFinish.Location = new System.Drawing.Point(1046, 292);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(162, 41);
            this.btnFinish.TabIndex = 60;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
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
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.BackColor = System.Drawing.Color.Transparent;
            this.lblTurns.Location = new System.Drawing.Point(980, 387);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(229, 36);
            this.lblTurns.TabIndex = 62;
            this.lblTurns.Text = "Number of turns:";
            this.lblTurns.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Location = new System.Drawing.Point(1202, 568);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(72, 36);
            this.lbltime.TabIndex = 68;
            this.lbltime.Text = "4:00";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblNumberTurns
            // 
            this.lblNumberTurns.AutoSize = true;
            this.lblNumberTurns.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberTurns.Location = new System.Drawing.Point(1222, 387);
            this.lblNumberTurns.Name = "lblNumberTurns";
            this.lblNumberTurns.Size = new System.Drawing.Size(31, 36);
            this.lblNumberTurns.TabIndex = 69;
            this.lblNumberTurns.Text = "_";
            this.lblNumberTurns.Visible = false;
            // 
            // Same
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.lblNumberTurns);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.pnlPictures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Same";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Same";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlPictures;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblNumberTurns;
    }
}

