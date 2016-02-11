﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordTest
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        public double pixelToMm = 0.26458333333333;
        public string branchName;
        public string fileName;
        private int width = 472;
        private int height = 302;
        private Image zoomImage;
        private Image oriImage = null;
        public FormMain.data addData = new FormMain.data();
        private Graphics g;
        private void FormInput_Load(object sender, EventArgs e)
        {
            labelBranchName.Text = branchName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Open Image File";
            opd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK && opd.FileName != null)
            {
                // Open document
                fileName = opd.FileName;

                labelImageName.Text = fileName;
                oriImage = Image.FromFile(fileName);
                int imgWidth = oriImage.Width;
                int imgheight = oriImage.Height;

                // g.InterpolationMode = InterpolationMode.Bilinear;

                zoomImage = resizeImage(oriImage);
                pictureBoxView.BackgroundImage = zoomImage;

            }
            else
            {
                MessageBox.Show("Load Image Error!");
            }
        }

        private Image inputImageDate(Image img)
        {
            Image result = img;
            string text = labelDate.Text;
            int fontSize = 16;

            int x = img.Width - 50;
            int y = img.Height - 30;
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.FormatFlags = StringFormatFlags.NoWrap;
            Graphics myGrapgics = Graphics.FromImage(result);
            myGrapgics.DrawString(text, new Font("Times New Roman", fontSize, FontStyle.Bold), new SolidBrush(Color.Yellow), x, y, drawFormat);
            myGrapgics.Dispose();
            return result;
        }

        private Image resizeImage(Image img)
        {
            Image resultImg = new Bitmap(width, height);

            g = Graphics.FromImage(resultImg);
            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return resultImg;
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            monthCalendarDate.Visible = true;
            monthCalendarDate.Location = buttonDate.Location;
            monthCalendarDate.DateSelected += new DateRangeEventHandler(monthCalendar_DateSelected);
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelDate.Text = e.Start.ToShortDateString();
            monthCalendarDate.Visible = false;
            //Image test = null;
            zoomImage = resizeImage(oriImage);
            zoomImage = inputImageDate(zoomImage);
            zoomImage.Save(@"temp.jpg");
            pictureBoxView.BackgroundImage = zoomImage;

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            FormMain.data Data = new FormMain.data();
            Data.imageData = zoomImage;
            Data.title = labelBranchName.Text;
            Data.des = textBoxDes.Text;

            FormMain forMain = null;

            forMain.addList(Data);
            this.Close();

            

        }
    }
}

