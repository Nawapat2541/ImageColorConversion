using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ImageColorConversion
{
    public partial class ImageColorConversionForm : Form
    {
        Image<Bgr, byte> imgInput;
        public ImageColorConversionForm()
        {
            InitializeComponent();
        }

        private void ImageColorConversionForm_Load(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bGRGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput==null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Gray, byte> imgOutput = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            imgOutput = imgInput.Convert<Gray, byte>();

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            pictureBox2.Image = imgOutput.Bitmap;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                pictureBox1.Image = imgInput.Bitmap;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bGRYCrCbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Ycc, byte> imgOutput = new Image<Ycc, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2YCrCb);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.Bitmap;
        }

        private void bGRHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Hsv, byte> imgOutput = new Image<Hsv, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.Bitmap;
        }

        private void bGRLUVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Luv, byte> imgOutput = new Image<Luv, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Luv);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.Bitmap;
        }

        private void bGRLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Lab, byte> imgOutput = new Image<Lab, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Lab);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.Bitmap;
        }

        private void bGRHLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            Image<Hls, byte> imgOutput = new Image<Hls, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutput = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Hls);
            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.Bitmap;
        }
    }
}
