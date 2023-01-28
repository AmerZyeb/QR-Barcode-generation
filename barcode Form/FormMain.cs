using barcode_Form.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ZXing;



namespace barcode_Form
{
    public partial class FormMain : Form
    {
        public BarcodeFormat BacodeFormat { get; private set; }
        private Color forecolor = Color.Black;
        private Color Backcolor = Color.White;
        private QRCoder.QRCodeGenerator.ECCLevel level = QRCoder.QRCodeGenerator.ECCLevel.M;
        public FormMain()
        {
            InitializeComponent();
        }
        private void SettingsQRcode()
        {
            if (!RBForeColorinfo.Checked)
            {
                if (RBForeColorWhite.Checked)
                {
                    forecolor = Color.White;
                }
                else
                {
                    forecolor = Color.Black;
                }
            }
            if (!RBBackColorinfo.Checked)
            {
                if (RBBackColorWhite.Checked)
                {
                    Backcolor = Color.White;
                }
                else
                {
                    Backcolor = Color.Black;
                }
            }
            if (RBlevel0.Checked)
            {
                level = QRCoder.QRCodeGenerator.ECCLevel.L;
            }
            else if (RBlevel1.Checked)
            {
                level = QRCoder.QRCodeGenerator.ECCLevel.M;
            }
            if (RBlevel2.Checked)
            {
                level = QRCoder.QRCodeGenerator.ECCLevel.Q;
            }
            if (RBlevel3.Checked)
            {
                level = QRCoder.QRCodeGenerator.ECCLevel.H;
            }
        }
        private Bitmap GeneretorQR()
        {
            SettingsQRcode();
            QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
            string qr = string.Format(textBox1.Text);
            QRCoder.QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(qr, level);
            QRCoder.QRCode qRCode = new QRCoder.QRCode(qRCodeData);
            Bitmap bitmap;
            if (checkBox1.Checked)
            {
                Bitmap logo = new Bitmap("logo.png");
                bitmap = qRCode.GetGraphic(25,forecolor,Backcolor,logo,20,0,true,null);
                
            }
            else
            {
                bitmap = qRCode.GetGraphic(25, forecolor, Backcolor,null);
            }
            pictureBox1.BackgroundImage = bitmap;
            return bitmap;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.TrimEnd();
            textBox1.Text = textBox1.Text.TrimStart();
            if (textBox1.Text != "")
            {
                Bitmap bitmap = GeneretorQR();
                saveFileDialog.Filter = "Png Image (.png)|*.png";
                saveFileDialog.FileName = textBox1.Text;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                bitmap.Save(saveFileDialog.FileName);
                
            }
            else MessageBox.Show("لا يوجد لديك نص", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.TrimEnd();
            textBox1.Text = textBox1.Text.TrimStart();
            if (textBox1.Text != "")
            {
                GeneretorQR();
            }
            else MessageBox.Show("لا يوجد لديك نص", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RBForeColorinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBForeColorinfo.Checked)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    forecolor = colorDialog1.Color;
                }
            }
            else
            {
                forecolor = Color.Black;
                
            }
        }

        private void RBBackColorinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBBackColorinfo.Checked)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    Backcolor = colorDialog1.Color;
                }
            }
            else
            {
                Backcolor = Color.Black;

            }
        }

        private void btnEditicon_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                  
                    dlg.Title = "Open Image";
                    dlg.Filter = "Png Image (.png)|*.png";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bitmap = new Bitmap(dlg.FileName);
                        bitmap.Save("logo.png", ImageFormat.Png);
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message);
                MessageBox.Show("\nفشلت العملية" +ex.Message, "رسالة خطأ");
            }
        }
    }
    
} 

