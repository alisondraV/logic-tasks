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
            this.pbGoat = new System.Windows.Forms.PictureBox();
            this.pbWolf = new System.Windows.Forms.PictureBox();
            this.pbCabbage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPlaceTwo = new System.Windows.Forms.PictureBox();
            this.pbPlaceThree = new System.Windows.Forms.PictureBox();
            this.pbPlaceOne = new System.Windows.Forms.PictureBox();
            this.pbShuttle = new System.Windows.Forms.PictureBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuttle)).BeginInit();
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
            this.label1.Text = "The farmer bought a goat, a cabbage and a wolf on the fair. On his way home he ha" +
    "d to cross the river. The peasant had a small shuttle, in which only one of his " +
    "purchases could be accommodated.\r\n";
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
            // pbGoat
            // 
            this.pbGoat.BackColor = System.Drawing.Color.Transparent;
            this.pbGoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbGoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGoat.Enabled = false;
            this.pbGoat.Image = ((System.Drawing.Image)(resources.GetObject("pbGoat.Image")));
            this.pbGoat.Location = new System.Drawing.Point(968, 228);
            this.pbGoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbGoat.Name = "pbGoat";
            this.pbGoat.Size = new System.Drawing.Size(142, 130);
            this.pbGoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGoat.TabIndex = 6;
            this.pbGoat.TabStop = false;
            this.pbGoat.Click += new System.EventHandler(this.pbGoat_Click);
            // 
            // pbWolf
            // 
            this.pbWolf.BackColor = System.Drawing.Color.Transparent;
            this.pbWolf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWolf.Enabled = false;
            this.pbWolf.Image = ((System.Drawing.Image)(resources.GetObject("pbWolf.Image")));
            this.pbWolf.Location = new System.Drawing.Point(818, 122);
            this.pbWolf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbWolf.Name = "pbWolf";
            this.pbWolf.Size = new System.Drawing.Size(142, 130);
            this.pbWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWolf.TabIndex = 7;
            this.pbWolf.TabStop = false;
            this.pbWolf.Click += new System.EventHandler(this.pbWolf_Click);
            // 
            // pbCabbage
            // 
            this.pbCabbage.BackColor = System.Drawing.Color.Transparent;
            this.pbCabbage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCabbage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCabbage.Enabled = false;
            this.pbCabbage.Image = ((System.Drawing.Image)(resources.GetObject("pbCabbage.Image")));
            this.pbCabbage.Location = new System.Drawing.Point(1073, 101);
            this.pbCabbage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbCabbage.Name = "pbCabbage";
            this.pbCabbage.Size = new System.Drawing.Size(142, 130);
            this.pbCabbage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCabbage.TabIndex = 8;
            this.pbCabbage.TabStop = false;
            this.pbCabbage.Click += new System.EventHandler(this.pbCabbage_Click);
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
            this.label4.Text = "How can he get all the acquisitions across the river if the goat can\'t stay alone" +
    " with the cabbage,";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(439, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = " and the wolf - alone with the goat?";
            // 
            // pbPlaceTwo
            // 
            this.pbPlaceTwo.BackColor = System.Drawing.Color.Transparent;
            this.pbPlaceTwo.Location = new System.Drawing.Point(200, 162);
            this.pbPlaceTwo.Name = "pbPlaceTwo";
            this.pbPlaceTwo.Size = new System.Drawing.Size(142, 130);
            this.pbPlaceTwo.TabIndex = 14;
            this.pbPlaceTwo.TabStop = false;
            // 
            // pbPlaceThree
            // 
            this.pbPlaceThree.BackColor = System.Drawing.Color.Transparent;
            this.pbPlaceThree.Location = new System.Drawing.Point(74, 311);
            this.pbPlaceThree.Name = "pbPlaceThree";
            this.pbPlaceThree.Size = new System.Drawing.Size(142, 130);
            this.pbPlaceThree.TabIndex = 15;
            this.pbPlaceThree.TabStop = false;
            // 
            // pbPlaceOne
            // 
            this.pbPlaceOne.BackColor = System.Drawing.Color.Transparent;
            this.pbPlaceOne.Location = new System.Drawing.Point(33, 162);
            this.pbPlaceOne.Name = "pbPlaceOne";
            this.pbPlaceOne.Size = new System.Drawing.Size(142, 130);
            this.pbPlaceOne.TabIndex = 17;
            this.pbPlaceOne.TabStop = false;
            // 
            // pbShuttle
            // 
            this.pbShuttle.BackColor = System.Drawing.Color.Transparent;
            this.pbShuttle.Location = new System.Drawing.Point(693, 267);
            this.pbShuttle.Name = "pbShuttle";
            this.pbShuttle.Size = new System.Drawing.Size(142, 130);
            this.pbShuttle.TabIndex = 18;
            this.pbShuttle.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Snow;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinish.Location = new System.Drawing.Point(23, 75);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(162, 41);
            this.btnFinish.TabIndex = 63;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(23, 24);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 41);
            this.btnStart.TabIndex = 62;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Crossing
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 644);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbShuttle);
            this.Controls.Add(this.pbPlaceOne);
            this.Controls.Add(this.pbGoat);
            this.Controls.Add(this.pbWolf);
            this.Controls.Add(this.pbPlaceThree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCabbage);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPlaceTwo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Crossing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabbage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShuttle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.PictureBox pbGoat;
        private System.Windows.Forms.PictureBox pbWolf;
        private System.Windows.Forms.PictureBox pbCabbage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbPlaceTwo;
        private System.Windows.Forms.PictureBox pbPlaceThree;
        private System.Windows.Forms.PictureBox pbPlaceOne;
        private System.Windows.Forms.PictureBox pbShuttle;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer2;
    }
}

