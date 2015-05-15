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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(117, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Write to Text";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Location = new System.Drawing.Point(12, 34);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "select Key,Comment,Indonesian,Japanese,Khmer,Korean,Brazil,English,Thai,Vietnames" +
    "e,Chinese from";
            // 
            // BtnWrite2Message
            // 
            this.BtnWrite2Message.Location = new System.Drawing.Point(223, 60);
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
            this.PreviewText.Location = new System.Drawing.Point(11, 60);
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
            this.richTextBox2.Location = new System.Drawing.Point(880, 99);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(169, 229);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 336);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(843, 233);
            this.richTextBox1.TabIndex = 9;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 5);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(99, 23);
            this.btnSelectFolder.TabIndex = 10;
            this.btnSelectFolder.Text = "SelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.Location = new System.Drawing.Point(118, 5);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.Size = new System.Drawing.Size(501, 20);
            this.txtSelectFolder.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 581);
            this.Controls.Add(this.txtSelectFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.PreviewText);
            this.Controls.Add(this.BtnWrite2Message);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelectExcel);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "ResxGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

