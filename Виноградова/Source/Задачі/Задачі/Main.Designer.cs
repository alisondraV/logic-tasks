namespace Задачі
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.lbli = new System.Windows.Forms.Label();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.txtim = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblkukr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(403, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 137);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перед тестуванням у вас є можливість зареєструватися для збереження результатів н" +
    "а комп\'ютері. Для цього введіть своє прізвище та ім\'я у відповідні поля й натисн" +
    "іть кнопку \"Далі\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.BackColor = System.Drawing.Color.Transparent;
            this.lblp.Location = new System.Drawing.Point(484, 396);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(102, 25);
            this.lblp.TabIndex = 3;
            this.lblp.Text = "Прізвище";
            // 
            // lbli
            // 
            this.lbli.AutoSize = true;
            this.lbli.BackColor = System.Drawing.Color.Transparent;
            this.lbli.Location = new System.Drawing.Point(766, 396);
            this.lbli.Name = "lbli";
            this.lbli.Size = new System.Drawing.Size(46, 25);
            this.lbli.TabIndex = 4;
            this.lbli.Text = "Ім\'я";
            // 
            // txtpr
            // 
            this.txtpr.Location = new System.Drawing.Point(418, 424);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(225, 32);
            this.txtpr.TabIndex = 5;
            // 
            // txtim
            // 
            this.txtim.Location = new System.Drawing.Point(708, 424);
            this.txtim.Name = "txtim";
            this.txtim.Size = new System.Drawing.Size(152, 32);
            this.txtim.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "7 клас",
            "8 клас"});
            this.comboBox1.Location = new System.Drawing.Point(576, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "7 клас";
            // 
            // lblkukr
            // 
            this.lblkukr.AutoSize = true;
            this.lblkukr.BackColor = System.Drawing.Color.Transparent;
            this.lblkukr.Location = new System.Drawing.Point(607, 269);
            this.lblkukr.Name = "lblkukr";
            this.lblkukr.Size = new System.Drawing.Size(58, 25);
            this.lblkukr.TabIndex = 7;
            this.lblkukr.Text = "Клас";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(919, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(365, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblkukr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtim);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.lbli);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lbli;
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.TextBox txtim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblkukr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}