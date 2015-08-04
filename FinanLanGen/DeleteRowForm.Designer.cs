namespace FinanLanGen
{
    partial class DeleteRowForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.priviewDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_selectJsFolder = new System.Windows.Forms.TextBox();
            this.selectTargetFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priviewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ReadExcel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 265);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ImportDeleteList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "deleteAndShow";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // priviewDataGridView
            // 
            this.priviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priviewDataGridView.Location = new System.Drawing.Point(13, 100);
            this.priviewDataGridView.Name = "priviewDataGridView";
            this.priviewDataGridView.Size = new System.Drawing.Size(240, 177);
            this.priviewDataGridView.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "writeJS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_selectJsFolder
            // 
            this.txt_selectJsFolder.Location = new System.Drawing.Point(94, 285);
            this.txt_selectJsFolder.Name = "txt_selectJsFolder";
            this.txt_selectJsFolder.Size = new System.Drawing.Size(100, 20);
            this.txt_selectJsFolder.TabIndex = 7;
            // 
            // selectTargetFolder
            // 
            this.selectTargetFolder.Location = new System.Drawing.Point(13, 283);
            this.selectTargetFolder.Name = "selectTargetFolder";
            this.selectTargetFolder.Size = new System.Drawing.Size(75, 23);
            this.selectTargetFolder.TabIndex = 8;
            this.selectTargetFolder.Text = "selectTargetFolder";
            this.selectTargetFolder.UseVisualStyleBackColor = true;
            this.selectTargetFolder.Click += new System.EventHandler(this.selectTargetFolder_Click);
            // 
            // DeleteRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 314);
            this.Controls.Add(this.selectTargetFolder);
            this.Controls.Add(this.txt_selectJsFolder);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.priviewDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "DeleteRowForm";
            this.Text = "DeleteRowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priviewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView priviewDataGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_selectJsFolder;
        private System.Windows.Forms.Button selectTargetFolder;
    }
}