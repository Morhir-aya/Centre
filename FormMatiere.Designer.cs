﻿namespace apk
{
    partial class FormMatiere
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
            this.panelM3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltextM = new System.Windows.Forms.Label();
            this.panelM4 = new System.Windows.Forms.Panel();
            this.btnAddM = new System.Windows.Forms.Button();
            this.labelM4 = new System.Windows.Forms.Label();
            this.textPrenomM = new System.Windows.Forms.TextBox();
            this.labelM1 = new System.Windows.Forms.Label();
            this.textNomM = new System.Windows.Forms.TextBox();
            this.panelM3.SuspendLayout();
            this.panelM4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelM3
            // 
            this.panelM3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelM3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelM3.Controls.Add(this.button1);
            this.panelM3.Controls.Add(this.lbltextM);
            this.panelM3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelM3.Location = new System.Drawing.Point(0, 0);
            this.panelM3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelM3.Name = "panelM3";
            this.panelM3.Size = new System.Drawing.Size(373, 113);
            this.panelM3.TabIndex = 2;
            this.panelM3.Click += new System.EventHandler(this.panelM3_Click);
            this.panelM3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelM3_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.Location = new System.Drawing.Point(340, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltextM
            // 
            this.lbltextM.AutoSize = true;
            this.lbltextM.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextM.ForeColor = System.Drawing.Color.White;
            this.lbltextM.Location = new System.Drawing.Point(124, 46);
            this.lbltextM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltextM.Name = "lbltextM";
            this.lbltextM.Size = new System.Drawing.Size(132, 27);
            this.lbltextM.TabIndex = 0;
            this.lbltextM.Text = "Add Class";
            this.lbltextM.Click += new System.EventHandler(this.lbltextM_Click);
            // 
            // panelM4
            // 
            this.panelM4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelM4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelM4.Controls.Add(this.btnAddM);
            this.panelM4.Controls.Add(this.labelM4);
            this.panelM4.Controls.Add(this.textPrenomM);
            this.panelM4.Controls.Add(this.labelM1);
            this.panelM4.Controls.Add(this.textNomM);
            this.panelM4.Location = new System.Drawing.Point(44, 139);
            this.panelM4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelM4.Name = "panelM4";
            this.panelM4.Size = new System.Drawing.Size(290, 217);
            this.panelM4.TabIndex = 3;
            // 
            // btnAddM
            // 
            this.btnAddM.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddM.FlatAppearance.BorderSize = 0;
            this.btnAddM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddM.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddM.ForeColor = System.Drawing.Color.White;
            this.btnAddM.Location = new System.Drawing.Point(106, 154);
            this.btnAddM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(77, 32);
            this.btnAddM.TabIndex = 6;
            this.btnAddM.Text = "Add";
            this.btnAddM.UseVisualStyleBackColor = false;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // labelM4
            // 
            this.labelM4.AutoSize = true;
            this.labelM4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM4.ForeColor = System.Drawing.Color.White;
            this.labelM4.Location = new System.Drawing.Point(53, 80);
            this.labelM4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelM4.Name = "labelM4";
            this.labelM4.Size = new System.Drawing.Size(106, 15);
            this.labelM4.TabIndex = 0;
            this.labelM4.Text = "Students Number";
            // 
            // textPrenomM
            // 
            this.textPrenomM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenomM.Location = new System.Drawing.Point(56, 99);
            this.textPrenomM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPrenomM.Name = "textPrenomM";
            this.textPrenomM.Size = new System.Drawing.Size(190, 23);
            this.textPrenomM.TabIndex = 2;
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM1.ForeColor = System.Drawing.Color.White;
            this.labelM1.Location = new System.Drawing.Point(53, 25);
            this.labelM1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(40, 15);
            this.labelM1.TabIndex = 0;
            this.labelM1.Text = "Name";
            // 
            // textNomM
            // 
            this.textNomM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomM.Location = new System.Drawing.Point(56, 44);
            this.textNomM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNomM.Name = "textNomM";
            this.textNomM.Size = new System.Drawing.Size(190, 23);
            this.textNomM.TabIndex = 1;
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(373, 385);
            this.Controls.Add(this.panelM4);
            this.Controls.Add(this.panelM3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMatiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMatiere";
            this.panelM3.ResumeLayout(false);
            this.panelM3.PerformLayout();
            this.panelM4.ResumeLayout(false);
            this.panelM4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelM3;
        private System.Windows.Forms.Label lbltextM;
        private System.Windows.Forms.Panel panelM4;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.Label labelM4;
        private System.Windows.Forms.TextBox textPrenomM;
        private System.Windows.Forms.Label labelM1;
        private System.Windows.Forms.TextBox textNomM;
        private System.Windows.Forms.Button button1;
    }
}