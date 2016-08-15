using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace WordTest
{
    public partial class FormMain : Form
    {
        public double pixelToMm = 0.353;
        [Serializable]
        public struct data
        {
            public Image imageData;
            public Image oriImage;
            public string des;
            public string title;
            public string date;
            public string filePath;
            public bool dataIsEmpty;

        }
        [Serializable]
        private struct saveData
        {
            public byte[] imageData;
            public byte[] oriImage;
            public string des;
            public string title;
            public string date;
            public string filePath;

        }
        public FormInput formInput = null;

        public List<data> dataList = new List<data>();

        private List<saveData> saveDataList = new List<saveData>();
        private object fileName;
        private int saveSuccess;
        private CircularProgress cpLoading;
        private CircularProgress cpSave;
        private int dataGridViewIndex = 0;

        public FormMain()
        {

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (textBoxBranchName.Text == "")
            {
                MessageBox.Show("請輸入名稱");
                return;
            }
            formInput = new FormInput();
            formInput.Owner = this;
            formInput.MdiParent = this.MdiParent;
            formInput.type = (int)fileClass.type.NEW;
            formInput.branchName = textBoxBranchName.Text;
            formInput.FormClosed += new FormClosedEventHandler(formInput_FormClosed);
            formInput.Show();
        }

        private void formInput_FormClosed(object sender, FormClosedEventArgs e)
        {

            updateGridView();
        }

        public void addList(data d)
        {
            d.dataIsEmpty = false;
            dataList.Add(d);
        }
        public void editList(data d, int index)
        {
            d.dataIsEmpty = false;
            dataList[index] = d;
        }

        public void insertList(data d, int index)
        {
            d.dataIsEmpty = false;
            dataList.Insert(index, d);
        }

        private void dataGridViewShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            return;

            int index = e.RowIndex;
            if (dataList.Count == 0)
            {
                return;
            }
            if (index < 0)
            {
                return;
            }
            formInput = new FormInput();
            formInput.Owner = this;
            formInput.MdiParent = this.MdiParent;
            formInput.type = (int)fileClass.type.EDIT;
            formInput.branchName = dataList[index].title;
            formInput.des = dataList[index].des;
            formInput.zoomImage = dataList[index].imageData;
            formInput.date = dataList[index].date;
            formInput.fileName = dataList[index].filePath;
            formInput.oriImage = dataList[index].oriImage;
            formInput.index = index;
            formInput.FormClosed += new FormClosedEventHandler(formInput_FormClosed);
            formInput.Show();


        }

        private int saveDocx(object filePath)
        {
            Microsoft.Office.Interop.Word.Application wrdApp;
            Object oMissing = System.Reflection.Missing.Value;
            Object oEndOfDoc = "\\endofdoc";

            wrdApp = new Microsoft.Office.Interop.Word.Application();
            wrdApp.Visible = false;    //執行過程不在畫面上開啟 Word            
            Microsoft.Office.Interop.Word._Document myDoc;
            myDoc = wrdApp.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            myDoc.PageSetup.TopMargin = wrdApp.CentimetersToPoints(float.Parse("1"));
            myDoc.PageSetup.BottomMargin = wrdApp.CentimetersToPoints(float.Parse("1"));
            myDoc.PageSetup.LeftMargin = wrdApp.CentimetersToPoints(float.Parse("1"));
            myDoc.PageSetup.RightMargin = wrdApp.CentimetersToPoints(float.Parse("1"));


            Microsoft.Office.Interop.Word.Table myTable;
            Microsoft.Office.Interop.Word.Range wrdRng = myDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;




            int dataCount = dataList.Count;


            if (dataCount % 3 == 0)
            {
                myTable = myDoc.Tables.Add(wrdRng, dataCount, 3, ref oMissing, ref oMissing);// 新增表格
            }
            else
            {
                dataCount = dataCount + (3 - (dataCount % 3));
                myTable = myDoc.Tables.Add(wrdRng, dataCount, 3, ref oMissing, ref oMissing);// 新增表格
            }
            myTable.Select();
            wrdApp.Selection.Tables[1].Rows.Alignment = word.WdRowAlignment.wdAlignRowCenter; // 表格置中

            //設定表格寬高
            myTable.Rows.Height = (float)(88.4 / pixelToMm);
            myTable.Cell(1, 1).Column.SetWidth((float)(152.5 / pixelToMm), 0);
            myTable.Cell(1, 2).Column.SetWidth((float)(12.5 / pixelToMm), 0);
            myTable.Cell(1, 3).Column.SetWidth((float)(12.5 / pixelToMm), 0);


            for (int i = 0; i < dataList.Count; i++)
            {
                myTable.Range.Font.Name = "標楷體";
                myTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
                myTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;

                //設定表格內直書
                myTable.Cell(i + 1, 2).Range.Orientation = word.WdTextOrientation.wdTextOrientationVerticalFarEast;
                myTable.Cell(i + 1, 3).Range.Orientation = word.WdTextOrientation.wdTextOrientationVerticalFarEast;
                if (dataList[i].dataIsEmpty == true)
                {
                    continue;
                }

                //填入表格內文字
                myTable.Cell(i + 1, 2).Range.Text = dataList[i].des;
                myTable.Cell(i + 1, 3).Range.Text = dataList[i].title;
                //剪貼簿複製圖片過去

                if (dataList[i].imageData == null)
                {
                    continue;
                }
                Microsoft.Office.Interop.Word.Range a = myDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                Clipboard.SetImage(dataList[i].imageData);
                myTable.Cell(i + 1, 1).Range.InsertParagraphAfter();
                myTable.Cell(i + 1, 1).Range.Select();
                myTable.Cell(i + 1, 1).Range.Paste();
                //設定表格置中
                myTable.Cell(i + 1, 1).VerticalAlignment = word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                myTable.Cell(i + 1, 1).Range.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;

            }

            Object oFormat = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument;    //格式
            myDoc.SaveAs(ref filePath, ref oFormat,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing
        );
            Object oFalse = false;
            myDoc.Close(ref oFalse, ref oMissing, ref oMissing);
            return 1;
        }


        private void bwLoading_Run(Object sender, DoWorkEventArgs e)
        {
            int ret = 0;
            saveSuccess = 0;
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    ret = saveDocx(fileName);
                    saveSuccess = 1;
                }
                catch
                {
                    MessageBox.Show("儲存失敗");
                }

            });
        }

        private void bwLoading_Completed(Object sender, RunWorkerCompletedEventArgs e)
        {
            if (saveSuccess == 1)
            {
                MessageBox.Show("儲存完成");
            }


            if (cpLoading != null)
            {
                cpLoading.Stop();
                this.Controls.Remove(cpLoading);
                cpLoading = null;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult myDialog = MessageBox.Show("是否清除資料???", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myDialog == DialogResult.Yes)
            {
                dataList.Clear();
                dataGridViewShow.Rows.Clear();
                textBoxBranchName.Text = "";
            }
            else
            {

            }

        }

        private void dataGridViewShow_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridViewIndex = e.RowIndex;
                for (int i = 0; i < dataGridViewShow.RowCount; i++)
                {
                    if (i == dataGridViewIndex)
                    {
                        dataGridViewShow.Rows[i].Selected = true;
                    }
                    else
                    {
                        dataGridViewShow.Rows[i].Selected = false;
                    }

                }

            }
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                return;
            }
            if (dataGridViewIndex < 0)
            {
                return;
            }
            formInput = new FormInput();
            formInput.Owner = this;
            formInput.MdiParent = this.MdiParent;
            formInput.type = (int)fileClass.type.EDIT;
            formInput.branchName = dataList[dataGridViewIndex].title;
            formInput.des = dataList[dataGridViewIndex].des;
            formInput.zoomImage = dataList[dataGridViewIndex].imageData;
            formInput.date = dataList[dataGridViewIndex].date;
            formInput.fileName = dataList[dataGridViewIndex].filePath;
            formInput.oriImage = dataList[dataGridViewIndex].oriImage;
            formInput.index = dataGridViewIndex;
            formInput.FormClosed += new FormClosedEventHandler(formInput_FormClosed);
            formInput.Show();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewIndex < 0)
            {
                return;
            }

            if (MessageBox.Show("是否刪除", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<data> tempList = new List<data>();

                for (int i = 0; i < dataList.Count; i++)
                {
                    if (i != dataGridViewIndex)
                    {
                        tempList.Add(dataList[i]);
                    }
                }
                dataList = tempList;

                updateGridView();

            }

        }

        private void toolStripMenuItemInsert_Click(object sender, EventArgs e)
        {
            formInput = new FormInput();
            formInput.Owner = this;
            formInput.MdiParent = this.MdiParent;
            formInput.type = (int)fileClass.type.INSERT;
            formInput.branchName = textBoxBranchName.Text;
            formInput.index = dataGridViewIndex;
            formInput.FormClosed += new FormClosedEventHandler(formInput_FormClosed);
            formInput.Show();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                MessageBox.Show("無資料儲存");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Doc|*.doc";
            dlg.Title = "Save an Image File";
            // If the file name is not an empty string open it for saving.
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != "")
            {
                fileName = dlg.FileName;
                cpLoading = new CircularProgress();
                cpLoading.Dock = DockStyle.Fill;
                this.Controls.Add(cpLoading);
                cpLoading.BringToFront();
                cpLoading.Start();

                BackgroundWorker bwLoading = new BackgroundWorker();
                bwLoading.WorkerSupportsCancellation = true;
                bwLoading.DoWork += new DoWorkEventHandler(bwLoading_Run);
                bwLoading.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwLoading_Completed);
                bwLoading.RunWorkerAsync();

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataList.Count == 0)
            {
                MessageBox.Show("無資料儲存");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "sav|*.sav";
            dlg.Title = "Save an Image File";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != "")
            {

                fileName = dlg.FileName;
                cpSave = new CircularProgress();
                cpSave.Dock = DockStyle.Fill;
                this.Controls.Add(cpSave);
                cpSave.BringToFront();
                cpSave.Start();

                BackgroundWorker bwLoading = new BackgroundWorker();
                bwLoading.WorkerSupportsCancellation = true;
                bwLoading.DoWork += new DoWorkEventHandler(bwSave_Run);
                bwLoading.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwSave_Completed);
                bwLoading.RunWorkerAsync();

            }
        }

        private void bwSave_Run(Object sender, DoWorkEventArgs e)
        {
            saveSuccess = 0;
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    using (Stream stream = File.Open((string)fileName, FileMode.Create))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();


                        bformatter.Serialize(stream, dataList);
                    }
                    saveSuccess = 1;
                }
                catch
                {
                    MessageBox.Show("儲存失敗");
                }

            });
        }

        private void bwSave_Completed(Object sender, RunWorkerCompletedEventArgs e)
        {
            if (saveSuccess == 1)
            {
                MessageBox.Show("儲存完成");
            }


            if (cpSave != null)
            {
                cpSave.Stop();
                this.Controls.Remove(cpSave);
                cpSave = null;
            }
        }





        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Open Image File";
            opd.Filter = "sav|*.sav";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK && opd.FileName != null)
            {
                using (Stream stream = File.Open(opd.FileName, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    dataList = (List<data>)bformatter.Deserialize(stream);
                }

                // dataList = changeToData(saveDataList);

                if (dataList.Count == 0)
                {
                    return;
                }
                dataGridViewShow.Rows.Clear();
                foreach (data i in dataList)
                {
                    dataGridViewShow.Rows.Add(i.title, i.des, i.imageData);

                }
            }
        }

        private List<saveData> changeToSaveData(List<data> dataList)
        {
            List<saveData> tempData = new List<saveData>();
            foreach (data i in dataList)
            {

                saveData temp = new saveData();

                temp.imageData = ImageToBuffer(i.imageData, ImageFormat.Jpeg);
                temp.oriImage = ImageToBuffer(i.oriImage, ImageFormat.Jpeg);
                temp.title = i.title;
                temp.des = i.des;
                temp.filePath = i.filePath;
                temp.date = i.date;
                tempData.Add(temp);
            }


            return tempData;
        }


        private List<data> changeToData(List<saveData> saveDataList)
        {
            List<data> tempData = new List<data>();
            foreach (saveData i in saveDataList)
            {

                data temp = new data();

                temp.imageData = BufferToImage(i.imageData);
                temp.oriImage = BufferToImage(i.oriImage);
                temp.title = i.title;
                temp.des = i.des;
                temp.filePath = i.filePath;
                temp.date = i.date;
                tempData.Add(temp);
            }


            return tempData;
        }



        public static byte[] ImageToBuffer(Image Image, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            if (Image == null) { return null; }
            byte[] data = null;
            using (MemoryStream oMemoryStream = new MemoryStream())
            {
                //建立副本
                using (Bitmap oBitmap = new Bitmap(Image))
                {
                    //儲存圖片到 MemoryStream 物件，並且指定儲存影像之格式
                    oBitmap.Save(oMemoryStream, imageFormat);
                    //設定資料流位置
                    oMemoryStream.Position = 0;
                    //設定 buffer 長度
                    data = new byte[oMemoryStream.Length];
                    //將資料寫入 buffer
                    oMemoryStream.Read(data, 0, Convert.ToInt32(oMemoryStream.Length));
                    //將所有緩衝區的資料寫入資料流
                    oMemoryStream.Flush();
                }
            }
            return data;
        }


        /// 將 Byte 陣列轉換為 Image。
        /// </summary>
        /// <param name="Buffer">Byte 陣列。</param>        
        public static Image BufferToImage(byte[] Buffer)
        {
            if (Buffer == null || Buffer.Length == 0) { return null; }
            byte[] data = null;
            Image oImage = null;
            Bitmap oBitmap = null;
            //建立副本
            data = (byte[])Buffer.Clone();
            try
            {
                MemoryStream oMemoryStream = new MemoryStream(Buffer);
                //設定資料流位置
                oMemoryStream.Position = 0;
                oImage = System.Drawing.Image.FromStream(oMemoryStream);
                //建立副本
                oBitmap = new Bitmap(oImage);
            }
            catch
            {
                throw;
            }
            //return oImage;
            return oBitmap;
        }

        private void ToolStripMenuItemNull_Click(object sender, EventArgs e)
        {
            data d = new data();

            d.dataIsEmpty = true;
            dataList.Add(d);
            updateGridView();

        }

        private void updateGridView()
        {
            if (dataList.Count == 0)
            {
                return;
            }
            dataGridViewShow.Rows.Clear();
            int count = 0;
            bool change = true;
            Color color = Color.Red;
            foreach (data i in dataList)
            {
                if (count % 3 == 0)
                {
                    if (change == true)
                    {
                        color = Color.LightBlue;
                        change = false;
                    }
                    else
                    {
                        color = Color.LightCoral;
                        change = true;
                    }

                }
                dataGridViewShow.Rows.Add(i.title, i.des, i.imageData);
                dataGridViewShow.Rows[count].DefaultCellStyle.BackColor = color;
                count++;
            }
        }
    }
}

