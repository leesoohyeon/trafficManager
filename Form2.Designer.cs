﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btn_FS = new System.Windows.Forms.Button();
            this.btn_FSB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fSeoulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSeoulBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FS
            // 
            this.btn_FS.Location = new System.Drawing.Point(14, 15);
            this.btn_FS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FS.Name = "btn_FS";
            this.btn_FS.Size = new System.Drawing.Size(86, 29);
            this.btn_FS.TabIndex = 0;
            this.btn_FS.Text = "자가용";
            this.btn_FS.UseVisualStyleBackColor = true;
            this.btn_FS.Click += new System.EventHandler(this.btn_FS_Click);
            // 
            // btn_FSB
            // 
            this.btn_FSB.Location = new System.Drawing.Point(364, 13);
            this.btn_FSB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_FSB.Name = "btn_FSB";
            this.btn_FSB.Size = new System.Drawing.Size(86, 29);
            this.btn_FSB.TabIndex = 1;
            this.btn_FSB.Text = "버스";
            this.btn_FSB.UseVisualStyleBackColor = true;
            this.btn_FSB.Click += new System.EventHandler(this.btn_FSB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(295, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(364, 69);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(304, 333);
            this.dataGridView2.TabIndex = 3;
            // 
            // fSeoulBindingSource
            // 
            this.fSeoulBindingSource.DataSource = typeof(WindowsFormsApp1.FSeoul);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 437);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_FSB);
            this.Controls.Add(this.btn_FS);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fSeoulBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FS;
        private System.Windows.Forms.Button btn_FSB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fSeoulBindingSource;
    }
}