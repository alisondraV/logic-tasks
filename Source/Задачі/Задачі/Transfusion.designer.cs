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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbEightL = new System.Windows.Forms.PictureBox();
            this.pbThreeL = new System.Windows.Forms.PictureBox();
            this.pbFiveL = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEightL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveL)).BeginInit();
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbEightL
            // 
            this.pbEightL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEightL.Enabled = false;
            this.pbEightL.Location = new System.Drawing.Point(54, 127);
            this.pbEightL.Name = "pbEightL";
            this.pbEightL.Size = new System.Drawing.Size(261, 480);
            this.pbEightL.TabIndex = 12;
            this.pbEightL.TabStop = false;
            this.pbEightL.Click += new System.EventHandler(this.pbEightL_Click);
            // 
            // pbThreeL
            // 
            this.pbThreeL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbThreeL.Enabled = false;
            this.pbThreeL.Location = new System.Drawing.Point(380, 427);
            this.pbThreeL.Name = "pbThreeL";
            this.pbThreeL.Size = new System.Drawing.Size(261, 180);
            this.pbThreeL.TabIndex = 13;
            this.pbThreeL.TabStop = false;
            this.pbThreeL.Click += new System.EventHandler(this.pbThreeL_Click);
            // 
            // pbFiveL
            // 
            this.pbFiveL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFiveL.Enabled = false;
            this.pbFiveL.Location = new System.Drawing.Point(696, 307);
            this.pbFiveL.Name = "pbFiveL";
            this.pbFiveL.Size = new System.Drawing.Size(261, 300);
            this.pbFiveL.TabIndex = 14;
            this.pbFiveL.TabStop = false;
            this.pbFiveL.Click += new System.EventHandler(this.pbFiveL_Click);
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
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Snow;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Location = new System.Drawing.Point(1052, 307);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(162, 41);
            this.btnFinish.TabIndex = 59;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(1052, 256);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 41);
            this.btnStart.TabIndex = 58;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(854, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 62;
            this.label3.Text = "Time left:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(1045, 171);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 37);
            this.lblTime.TabIndex = 72;
            this.lblTime.Text = "3:00";
            // 
            // Transfusion
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbFiveL);
            this.Controls.Add(this.pbThreeL);
            this.Controls.Add(this.pbEightL);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Transfusion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfusion";
            ((System.ComponentModel.ISupportInitialize)(this.pbEightL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbEightL;
        private System.Windows.Forms.PictureBox pbThreeL;
        private System.Windows.Forms.PictureBox pbFiveL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
    }
}

