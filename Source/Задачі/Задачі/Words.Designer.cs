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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblres = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pbWords = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(161, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(917, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "You will be presented with a list of different words. After 10 seconds, these wor" +
    "ds will be mixed, and on word will be added. You need to find the new one. This " +
    "task will be repeated three times.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(1128, 584);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 36);
            this.lblTime.TabIndex = 71;
            this.lblTime.Text = "3:00";
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Snow;
            this.btnFinish.Location = new System.Drawing.Point(987, 237);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(162, 41);
            this.btnFinish.TabIndex = 70;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(945, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Time left:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Location = new System.Drawing.Point(987, 186);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 41);
            this.btnStart.TabIndex = 68;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            // pbWords
            // 
            this.pbWords.BackColor = System.Drawing.Color.Transparent;
            this.pbWords.Location = new System.Drawing.Point(60, 159);
            this.pbWords.Name = "pbWords";
            this.pbWords.Size = new System.Drawing.Size(120, 464);
            this.pbWords.TabIndex = 73;
            this.pbWords.TabStop = false;
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.pbWords);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Words";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Words";
            this.Load += new System.EventHandler(this.Words_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pbWords;
    }
}