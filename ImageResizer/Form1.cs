using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class Form1 : Form
    {
        //create new image
        Image img;

        //array of file extensions
        string[] exten = { ".PNG", ".JPG", ".JPEG", ".GIF" };
        Point mosloc;

        PictureBox org;
        bool pan = false;//when true can pan
        

        Image ZoomPicture(Image img2, Size size)
        {
            Bitmap bm = new Bitmap(img2, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < exten.Length; i++)
            {
                comboBox.Items.Add(exten[i]);
            }


            //assigning values and initializing variables (this is all done here just for testing stuff)
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            this.DoubleBuffered = true;
            org = new PictureBox();
            mosloc = new Point();
            ResizePanel.HorizontalScroll.Value = 10;
            ResizePanel.HorizontalScroll.SmallChange = 1;
            ResizePanel.VerticalScroll.SmallChange = 1;
            //

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //getting image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images | *.png;*jpg;*jpeg;*gif";

            //checking ofd info
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtslct.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
                pictureBox.Image = img;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Saving Image
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtsv.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //resizing image
            int
                w = Convert.ToInt32(txtw.Text),
                h = Convert.ToInt32(txth.Text);

            img = Resize(img, w, h);

            ((Button)sender).Enabled = false;
            
            MessageBox.Show("image resized");

        }

        Image Resize(Image image, int w, int h)
        {
            
            //creating new bitmap and graphic from that bitmap
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);

            //drawing image / disposing it
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();

            pictureBox_Resized.Image = bmp;
            //return the new bmp
            return bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Saving Image
            int
                dot = 0,
                slash = 0;

            //using a longer way to store index of a . and \ of the path of selected image
            for (int j = txtslct.Text.Length-1; j >= 0; j--)
            {
                if (txtslct.Text[j] == '.')
                {
                    dot = j;
                }
                else if (txtslct.Text[j] == '\\')
                {
                    slash = j;
                    break; //leaves for loop
                }
            }

            //rebuilding the saving path and name and fileextension of edited image
            img.Save(txtsv.Text + "\\" + txtslct.Text.Substring(slash + 1, dot - slash - 1) + exten[comboBox.SelectedIndex]);
            ((Button)sender).Enabled = false;
            MessageBox.Show("Image Saved");
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //When the Compressor button is pressed
        private void ImageCompressor_Click(object sender, EventArgs e)
        {
            //this method handles the compressing process of the image
            CompressImage(txtslct.Text, 50, txtsv.Text);
        }

        #region MethodsForCreatingCompression
        //The Compressing Process / Proceedure for the image
        private string CompressImage(string InputImage, int Quality, string OutPutDirectory)
        {
            using (Bitmap mybitmab = new Bitmap(@InputImage))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, Quality);
                myEncoderParameters.Param[0] = myEncoderParameter;

                string NewOutPutPath = OutPutDirectory + "\\" + Path.GetFileNameWithoutExtension(InputImage) + Path.GetExtension(InputImage);

                mybitmab.Save(NewOutPutPath, jpgEncoder, myEncoderParameters);

                return NewOutPutPath;
            }
        }

        //Gets the encoder that will be used for the image
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        #endregion

        //Allowing the trackbar to zoom the image
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (org.Image == null)
            {
                org.Image = pictureBox_Resized.Image;
            }
            
            //creating the zooming behaviour
            if (trackBar1.Value != 0)
            {
                pictureBox_Resized.Image = null;
                pictureBox_Resized.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        //Mouse Down/Up/Move all handles the process of allowing user to pan the image around in the picturebox
        private void ResizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            pan = true;
            mosloc = e.Location;
        }

        private void ResizePanel_MouseUp(object sender, MouseEventArgs e)
        {
            pan = false;
            mosloc = new Point();
        }

        private void ResizePanel_MouseMove(object sender, MouseEventArgs e)
        {//set last position to new mosue position every second
            if (pan == true)
            {
                if (e.Location.X < mosloc.X)
                {
                    if (ResizePanel.HorizontalScroll.Value <= ResizePanel.HorizontalScroll.Maximum-5)
                    {

                        if (ResizePanel.HorizontalScroll.Value < ResizePanel.HorizontalScroll.Maximum - 5)
                        {
                            ResizePanel.HorizontalScroll.Value += 5;
                            mosloc = e.Location;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else if (e.Location.X > mosloc.X)
                {
                    if (ResizePanel.HorizontalScroll.Value >= 0+5)
                    {
                        
                        if (ResizePanel.HorizontalScroll.Value <= 0+5)
                        {
                            return;
                        }
                        else
                        {
                            ResizePanel.HorizontalScroll.Value -= 5;
                            mosloc = e.Location;
                        }
                    }
                    
                }

            }
        }
    }
}
