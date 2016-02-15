namespace WordTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxBranchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNew.Location = new System.Drawing.Point(656, 40);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(124, 30);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "新增";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExport.Location = new System.Drawing.Point(656, 167);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(124, 30);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "匯出";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxBranchName
            // 
            this.textBoxBranchName.Font = new System.Drawing.Font("PMingLiU", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxBranchName.Location = new System.Drawing.Point(284, 40);
            this.textBoxBranchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBranchName.Name = "textBoxBranchName";
            this.textBoxBranchName.Size = new System.Drawing.Size(274, 30);
            this.textBoxBranchName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(199, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "支線 :";
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToDeleteRows = false;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.Image});
            this.dataGridViewShow.ContextMenuStrip = this.contextMenu;
            this.dataGridViewShow.Location = new System.Drawing.Point(157, 99);
            this.dataGridViewShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            this.dataGridViewShow.RowTemplate.Height = 27;
            this.dataGridViewShow.Size = new System.Drawing.Size(469, 451);
            this.dataGridViewShow.TabIndex = 4;
            this.dataGridViewShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShow_CellClick);
            this.dataGridViewShow.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShow_CellMouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemInsert,
            this.toolStripMenuItemDelete});
            this.contextMenu.Name = "contextMenuStripT";
            this.contextMenu.Size = new System.Drawing.Size(99, 70);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemEdit.Text = "修改";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemInsert
            // 
            this.toolStripMenuItemInsert.Name = "toolStripMenuItemInsert";
            this.toolStripMenuItemInsert.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemInsert.Text = "插入";
            this.toolStripMenuItemInsert.Click += new System.EventHandler(this.toolStripMenuItemInsert_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItemDelete.Text = "刪除";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.Location = new System.Drawing.Point(656, 209);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSave.Location = new System.Drawing.Point(656, 84);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(124, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "儲存設定";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("DFKai-SB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLoad.Location = new System.Drawing.Point(656, 125);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(124, 30);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "讀取設定";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 604);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBranchName);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxBranchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInsert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}

