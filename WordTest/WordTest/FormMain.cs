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

namespace WordTest
{
    public partial class FormMain : Form
    {
        public struct data
        {
            public Image imageData;
            public string des;
            public string title;
        }
        public FormInput formInput = null;

        public List<data> dataList = new List<data>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {


        }

        //private void buttonNew_Click(object sender, EventArgs e)
        //{
        //    Object oMissing = System.Reflection.Missing.Value;
        //    word.Application wordApp = new word.Application();

        //    wordApp.Visible = true;

        //    word.Document word = wordApp.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);


        //    DataTable dt = getDataTable();

        //    int colCount = dt.Columns.Count;

        //    int rowCount = dt.Rows.Count;

        //    word.Range range = word.Range(ref oMissing, ref oMissing);
        //    word.Table table = word.Content.Tables.Add(range, rowCount + 1, colCount, ref oMissing, ref oMissing);


        //    for (int i = 0; i < table.Columns.Count; i++)
        //    {
        //        table.Cell(1, i + 1).Range.Text = dt.Columns[i].ColumnName;
        //    }

        //    // 填入表格資料

        //    int rowIndex = 2;

        //    foreach (DataRow row in dt.Rows)

        //    {

        //        table.Cell(rowIndex, 1).Range.Text = row["學號"].ToString();

        //        table.Cell(rowIndex, 2).Range.Text = row["姓名"].ToString();

        //        table.Cell(rowIndex, 3).Range.Text = row["年齡"].ToString();

        //        rowIndex++;

        //    }



        //}

        private static DataTable getDataTable()

        {

            DataTable dt = new DataTable("學生資料");

            dt.Columns.Add(new DataColumn("學號"));

            dt.Columns.Add(new DataColumn("姓名"));

            dt.Columns.Add(new DataColumn("年齡"));



            DataRow row = dt.NewRow();

            row["學號"] = "001";

            row["姓名"] = "素還真";

            row["年齡"] = "1000";

            dt.Rows.Add(row);



            row = dt.NewRow();

            row["學號"] = "002";

            row["姓名"] = "葉小釵";

            row["年齡"] = "50";

            dt.Rows.Add(row);



            row = dt.NewRow();

            row["學號"] = "003";

            row["姓名"] = "一頁書";

            row["年齡"] = "2000";

            dt.Rows.Add(row);



            row = dt.NewRow();

            row["學號"] = "004";

            row["姓名"] = "秦假仙";

            row["年齡"] = "40";

            dt.Rows.Add(row);



            return dt;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            formInput = new FormInput();
            formInput.MdiParent = this.MdiParent;
            formInput.branchName = textBoxBranchName.Text;
            formInput.FormClosed += new FormClosedEventHandler(formInput_FormClosed);
            formInput.Show();
        }

        private void formInput_FormClosed(object sender, FormClosedEventArgs e)
        {

         string str=   dataList[0].title;

        }

        public void addList(data d)
        {
            dataList.Add(d);
        }

    }
    }

