﻿
namespace Onitway_Final_Project
{
    partial class View_Salary1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.DGVvs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVvs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 154;
            this.label1.Text = "<<Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-26, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 23);
            this.panel2.TabIndex = 153;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Location = new System.Drawing.Point(59, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 432);
            this.panel1.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Salary";
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(36, 190);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(87, 36);
            this.btnview.TabIndex = 0;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // DGVvs
            // 
            this.DGVvs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVvs.Location = new System.Drawing.Point(256, 92);
            this.DGVvs.Name = "DGVvs";
            this.DGVvs.Size = new System.Drawing.Size(526, 277);
            this.DGVvs.TabIndex = 151;
            // 
            // View_Salary1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVvs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Salary1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Salary1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVvs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView DGVvs;
    }
}