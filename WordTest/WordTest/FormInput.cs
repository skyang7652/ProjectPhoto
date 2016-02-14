using System;
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
        public string des;
        public string fileName;
        public string date;
        public int index;
        public int type;
        private int width = 472;
        private int height = 302;
        public Image zoomImage;
        public Image oriImage = null;
        public FormMain.data addData = new FormMain.data();
        private Graphics g;
        private void FormInput_Load(object sender, EventArgs e)
        {            
            if(type == (int)fileClass.type.NEW)
            {
                textBoxBranchName.Text = branchName;
            }
            else
            {
                textBoxBranchName.Text = branchName;
                textBoxDes.Text = des;
                pictureBoxView.Image = zoomImage;
                labelImageName.Text = fileName;
                textBoxDate.Text = date;
            }



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
                pictureBoxView.BackgroundImage = null;
                zoomImage = null;
                zoomImage = resizeImage(oriImage);
                pictureBoxView.Image = zoomImage;

            }
            else
            {
                MessageBox.Show("Load Image Error!");
            }
        }

        private Image inputImageDate(Image img)
        {
            Image result = img;
            string text = textBoxDate.Text;
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
            if(oriImage == null)
            {
                MessageBox.Show("請先選擇圖片");
                return;
            }
            monthCalendarDate.Visible = true;
            monthCalendarDate.BringToFront();
            monthCalendarDate.Location = buttonDate.Location;
            monthCalendarDate.DateSelected += new DateRangeEventHandler(monthCalendar_DateSelected);
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDate.Text = e.Start.ToShortDateString();
            monthCalendarDate.Visible = false;
            //Image test = null;
            zoomImage = resizeImage(oriImage);
            zoomImage = inputImageDate(zoomImage);          
            pictureBoxView.Image = zoomImage;

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            FormMain.data Data = new FormMain.data();
            Data.imageData = zoomImage;
            Data.title = textBoxBranchName.Text;
            Data.des = textBoxDes.Text;
            Data.filePath = labelImageName.Text;
            Data.date = textBoxDate.Text;
            Data.oriImage = oriImage;

            FormMain formMain = (FormMain)this.Owner;
            switch (type)
            {
                case (int)fileClass.type.NEW:
                    {
                        formMain.addList(Data);
                        break;
                    }
                case (int)fileClass.type.EDIT:
                    {
                        formMain.editList(Data, index);
                        break;
                    }
                case (int)fileClass.type.INSERT:
                    {
                        formMain.insertList(Data, index);
                        break;
                    }
            }

          this.Close();

            

        }
    }
}


