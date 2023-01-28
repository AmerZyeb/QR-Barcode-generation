namespace barcode_Form
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RBlevel0 = new System.Windows.Forms.RadioButton();
            this.RBlevel1 = new System.Windows.Forms.RadioButton();
            this.RBlevel2 = new System.Windows.Forms.RadioButton();
            this.RBlevel3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RBForeColorinfo = new System.Windows.Forms.RadioButton();
            this.RBForeColorBlack = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RBForeColorWhite = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RBBackColorinfo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RBBackColorBlack = new System.Windows.Forms.RadioButton();
            this.RBBackColorWhite = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnEditicon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(488, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "تصدير الباركود";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 263);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(152, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(169, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "نص الباركود";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(488, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 37);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "إضافة لوغو";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(488, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "معاينة الباركود";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RBlevel0
            // 
            this.RBlevel0.AutoSize = true;
            this.RBlevel0.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBlevel0.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBlevel0.Location = new System.Drawing.Point(265, 0);
            this.RBlevel0.Name = "RBlevel0";
            this.RBlevel0.Size = new System.Drawing.Size(45, 40);
            this.RBlevel0.TabIndex = 5;
            this.RBlevel0.Text = "0";
            this.RBlevel0.UseVisualStyleBackColor = true;
            // 
            // RBlevel1
            // 
            this.RBlevel1.AutoSize = true;
            this.RBlevel1.Checked = true;
            this.RBlevel1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBlevel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBlevel1.Location = new System.Drawing.Point(205, 0);
            this.RBlevel1.Name = "RBlevel1";
            this.RBlevel1.Size = new System.Drawing.Size(40, 40);
            this.RBlevel1.TabIndex = 5;
            this.RBlevel1.TabStop = true;
            this.RBlevel1.Text = "1";
            this.RBlevel1.UseVisualStyleBackColor = true;
            // 
            // RBlevel2
            // 
            this.RBlevel2.AutoSize = true;
            this.RBlevel2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBlevel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBlevel2.Location = new System.Drawing.Point(138, 0);
            this.RBlevel2.Name = "RBlevel2";
            this.RBlevel2.Size = new System.Drawing.Size(45, 40);
            this.RBlevel2.TabIndex = 5;
            this.RBlevel2.Text = "2";
            this.RBlevel2.UseVisualStyleBackColor = true;
            // 
            // RBlevel3
            // 
            this.RBlevel3.AutoSize = true;
            this.RBlevel3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBlevel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBlevel3.Location = new System.Drawing.Point(73, 0);
            this.RBlevel3.Name = "RBlevel3";
            this.RBlevel3.Size = new System.Drawing.Size(45, 40);
            this.RBlevel3.TabIndex = 5;
            this.RBlevel3.Text = "3";
            this.RBlevel3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::barcode_Form.Properties.Resources.Layer_12;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(488, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 263);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(321, 1);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "درجة الباركود:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBlevel3);
            this.panel1.Controls.Add(this.RBlevel0);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RBlevel1);
            this.panel1.Controls.Add(this.RBlevel2);
            this.panel1.Location = new System.Drawing.Point(19, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 39);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RBForeColorinfo);
            this.panel2.Controls.Add(this.RBForeColorBlack);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.RBForeColorWhite);
            this.panel2.Location = new System.Drawing.Point(19, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 39);
            this.panel2.TabIndex = 6;
            // 
            // RBForeColorinfo
            // 
            this.RBForeColorinfo.AutoSize = true;
            this.RBForeColorinfo.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBForeColorinfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBForeColorinfo.Location = new System.Drawing.Point(29, -1);
            this.RBForeColorinfo.Name = "RBForeColorinfo";
            this.RBForeColorinfo.Size = new System.Drawing.Size(103, 40);
            this.RBForeColorinfo.TabIndex = 5;
            this.RBForeColorinfo.Text = "غير ذلك";
            this.RBForeColorinfo.UseVisualStyleBackColor = true;
            this.RBForeColorinfo.CheckedChanged += new System.EventHandler(this.RBForeColorinfo_CheckedChanged);
            // 
            // RBForeColorBlack
            // 
            this.RBForeColorBlack.AutoSize = true;
            this.RBForeColorBlack.Checked = true;
            this.RBForeColorBlack.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBForeColorBlack.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBForeColorBlack.Location = new System.Drawing.Point(224, -1);
            this.RBForeColorBlack.Name = "RBForeColorBlack";
            this.RBForeColorBlack.Size = new System.Drawing.Size(77, 40);
            this.RBForeColorBlack.TabIndex = 5;
            this.RBForeColorBlack.TabStop = true;
            this.RBForeColorBlack.Text = "أسود";
            this.RBForeColorBlack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(335, 1);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(124, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "لون الباركود:";
            // 
            // RBForeColorWhite
            // 
            this.RBForeColorWhite.AutoSize = true;
            this.RBForeColorWhite.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBForeColorWhite.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBForeColorWhite.Location = new System.Drawing.Point(138, -1);
            this.RBForeColorWhite.Name = "RBForeColorWhite";
            this.RBForeColorWhite.Size = new System.Drawing.Size(80, 40);
            this.RBForeColorWhite.TabIndex = 5;
            this.RBForeColorWhite.Text = "أبيض";
            this.RBForeColorWhite.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RBBackColorinfo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.RBBackColorBlack);
            this.panel3.Controls.Add(this.RBBackColorWhite);
            this.panel3.Location = new System.Drawing.Point(12, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 39);
            this.panel3.TabIndex = 6;
            // 
            // RBBackColorinfo
            // 
            this.RBBackColorinfo.AutoSize = true;
            this.RBBackColorinfo.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBackColorinfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBBackColorinfo.Location = new System.Drawing.Point(29, -3);
            this.RBBackColorinfo.Name = "RBBackColorinfo";
            this.RBBackColorinfo.Size = new System.Drawing.Size(103, 40);
            this.RBBackColorinfo.TabIndex = 5;
            this.RBBackColorinfo.Text = "غير ذلك";
            this.RBBackColorinfo.UseVisualStyleBackColor = true;
            this.RBBackColorinfo.CheckedChanged += new System.EventHandler(this.RBBackColorinfo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(310, -1);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(148, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "خلفية الباركود:";
            // 
            // RBBackColorBlack
            // 
            this.RBBackColorBlack.AutoSize = true;
            this.RBBackColorBlack.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBackColorBlack.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBBackColorBlack.Location = new System.Drawing.Point(224, -3);
            this.RBBackColorBlack.Name = "RBBackColorBlack";
            this.RBBackColorBlack.Size = new System.Drawing.Size(77, 40);
            this.RBBackColorBlack.TabIndex = 5;
            this.RBBackColorBlack.Text = "أسود";
            this.RBBackColorBlack.UseVisualStyleBackColor = true;
            // 
            // RBBackColorWhite
            // 
            this.RBBackColorWhite.AutoSize = true;
            this.RBBackColorWhite.Checked = true;
            this.RBBackColorWhite.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBackColorWhite.ForeColor = System.Drawing.Color.Gainsboro;
            this.RBBackColorWhite.Location = new System.Drawing.Point(138, -3);
            this.RBBackColorWhite.Name = "RBBackColorWhite";
            this.RBBackColorWhite.Size = new System.Drawing.Size(80, 40);
            this.RBBackColorWhite.TabIndex = 5;
            this.RBBackColorWhite.TabStop = true;
            this.RBBackColorWhite.Text = "أبيض";
            this.RBBackColorWhite.UseVisualStyleBackColor = true;
            // 
            // btnEditicon
            // 
            this.btnEditicon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditicon.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Bold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditicon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditicon.Location = new System.Drawing.Point(638, 21);
            this.btnEditicon.Name = "btnEditicon";
            this.btnEditicon.Size = new System.Drawing.Size(132, 48);
            this.btnEditicon.TabIndex = 7;
            this.btnEditicon.Text = "تغيير اللوغو";
            this.btnEditicon.UseVisualStyleBackColor = true;
            this.btnEditicon.Click += new System.EventHandler(this.btnEditicon_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(787, 470);
            this.Controls.Add(this.btnEditicon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج توليد الباركود";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RBlevel0;
        private System.Windows.Forms.RadioButton RBlevel1;
        private System.Windows.Forms.RadioButton RBlevel2;
        private System.Windows.Forms.RadioButton RBlevel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RBForeColorinfo;
        private System.Windows.Forms.RadioButton RBForeColorBlack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBForeColorWhite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RBBackColorinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RBBackColorBlack;
        private System.Windows.Forms.RadioButton RBBackColorWhite;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnEditicon;
    }
}

