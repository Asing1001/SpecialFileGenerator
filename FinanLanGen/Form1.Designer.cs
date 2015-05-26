namespace FinanLanGen
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnWrite2Message = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.PreviewText = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtSelectFolder = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_selectJsFolder = new System.Windows.Forms.TextBox();
            this.TargetJSFolder = new System.Windows.Forms.Button();
            this.btn_JSReadWrite = new System.Windows.Forms.Button();
            this.txt_JSSQL = new System.Windows.Forms.TextBox();
            this.JSdataGridView = new System.Windows.Forms.DataGridView();
            this.btn_JSImportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JSdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(112, 32);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Write to Text";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(7, 6);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(100, 23);
            this.btnSelectExcel.TabIndex = 1;
            this.btnSelectExcel.Text = "ImportExcel";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "select Key,Comment,Indonesian,Japanese,Khmer,Korean,Brazil,English,Thai,Vietnames" +
    "e,Chinese from";
            // 
            // BtnWrite2Message
            // 
            this.BtnWrite2Message.Location = new System.Drawing.Point(218, 32);
            this.BtnWrite2Message.Name = "BtnWrite2Message";
            this.BtnWrite2Message.Size = new System.Drawing.Size(100, 23);
            this.BtnWrite2Message.TabIndex = 5;
            this.BtnWrite2Message.Text = "Write to Message";
            this.BtnWrite2Message.UseVisualStyleBackColor = true;
            this.BtnWrite2Message.Click += new System.EventHandler(this.BtnWrite2Message_Click);
            // 
            // PreviewText
            // 
            this.PreviewText.AllowDrop = true;
            this.PreviewText.Location = new System.Drawing.Point(6, 32);
            this.PreviewText.Name = "PreviewText";
            this.PreviewText.Size = new System.Drawing.Size(100, 23);
            this.PreviewText.TabIndex = 7;
            this.PreviewText.Text = "PreviewResx";
            this.PreviewText.UseVisualStyleBackColor = true;
            this.PreviewText.Click += new System.EventHandler(this.PreviewText_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(875, 71);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(169, 229);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 308);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(843, 233);
            this.richTextBox1.TabIndex = 9;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(-17, -21);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(99, 23);
            this.btnSelectFolder.TabIndex = 10;
            this.btnSelectFolder.Text = "SelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.Location = new System.Drawing.Point(89, -21);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.Size = new System.Drawing.Size(501, 20);
            this.txtSelectFolder.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 581);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PreviewText);
            this.tabPage1.Controls.Add(this.txtSelectFolder);
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Controls.Add(this.btnSelectFolder);
            this.tabPage1.Controls.Add(this.btnSelectExcel);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.BtnWrite2Message);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ResxGenerator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_selectJsFolder);
            this.tabPage2.Controls.Add(this.TargetJSFolder);
            this.tabPage2.Controls.Add(this.btn_JSReadWrite);
            this.tabPage2.Controls.Add(this.txt_JSSQL);
            this.tabPage2.Controls.Add(this.JSdataGridView);
            this.tabPage2.Controls.Add(this.btn_JSImportExcel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LocalizeJSGenerator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_selectJsFolder
            // 
            this.txt_selectJsFolder.Location = new System.Drawing.Point(142, 55);
            this.txt_selectJsFolder.Name = "txt_selectJsFolder";
            this.txt_selectJsFolder.Size = new System.Drawing.Size(501, 20);
            this.txt_selectJsFolder.TabIndex = 10;
            this.txt_selectJsFolder.Text = "D:\\\\Project\\\\DEV\\\\star2\\\\src\\\\AgileBet.Cash.Portal.WebSite\\\\Public\\\\JS\\\\Language\\" +
    "\\";
            // 
            // TargetJSFolder
            // 
            this.TargetJSFolder.Location = new System.Drawing.Point(41, 52);
            this.TargetJSFolder.Name = "TargetJSFolder";
            this.TargetJSFolder.Size = new System.Drawing.Size(75, 23);
            this.TargetJSFolder.TabIndex = 9;
            this.TargetJSFolder.Text = "SelectFolder";
            this.TargetJSFolder.UseVisualStyleBackColor = true;
            this.TargetJSFolder.Click += new System.EventHandler(this.TargetJSFolder_Click);
            // 
            // btn_JSReadWrite
            // 
            this.btn_JSReadWrite.Location = new System.Drawing.Point(41, 81);
            this.btn_JSReadWrite.Name = "btn_JSReadWrite";
            this.btn_JSReadWrite.Size = new System.Drawing.Size(75, 23);
            this.btn_JSReadWrite.TabIndex = 8;
            this.btn_JSReadWrite.Text = "ReadWrite";
            this.btn_JSReadWrite.UseVisualStyleBackColor = true;
            this.btn_JSReadWrite.Click += new System.EventHandler(this.btn_JSReadWrite_Click);
            // 
            // txt_JSSQL
            // 
            this.txt_JSSQL.Location = new System.Drawing.Point(142, 25);
            this.txt_JSSQL.Name = "txt_JSSQL";
            this.txt_JSSQL.Size = new System.Drawing.Size(501, 20);
            this.txt_JSSQL.TabIndex = 7;
            this.txt_JSSQL.Text = "select * from";
            // 
            // JSdataGridView
            // 
            this.JSdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JSdataGridView.Location = new System.Drawing.Point(41, 131);
            this.JSdataGridView.Name = "JSdataGridView";
            this.JSdataGridView.Size = new System.Drawing.Size(852, 229);
            this.JSdataGridView.TabIndex = 6;
            // 
            // btn_JSImportExcel
            // 
            this.btn_JSImportExcel.Location = new System.Drawing.Point(41, 23);
            this.btn_JSImportExcel.Name = "btn_JSImportExcel";
            this.btn_JSImportExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_JSImportExcel.TabIndex = 5;
            this.btn_JSImportExcel.Text = "Excel";
            this.btn_JSImportExcel.UseVisualStyleBackColor = true;
            this.btn_JSImportExcel.Click += new System.EventHandler(this.btn_JSImportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ResxGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JSdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnWrite2Message;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button PreviewText;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtSelectFolder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_JSReadWrite;
        private System.Windows.Forms.TextBox txt_JSSQL;
        private System.Windows.Forms.DataGridView JSdataGridView;
        private System.Windows.Forms.Button btn_JSImportExcel;
        private System.Windows.Forms.TextBox txt_selectJsFolder;
        private System.Windows.Forms.Button TargetJSFolder;
    }
}

