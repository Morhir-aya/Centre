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
            this.panelM3.Controls.Add(this.lbltextM);
            this.panelM3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelM3.Location = new System.Drawing.Point(0, 0);
            this.panelM3.Name = "panelM3";
            this.panelM3.Size = new System.Drawing.Size(497, 139);
            this.panelM3.TabIndex = 2;
            // 
            // lbltextM
            // 
            this.lbltextM.AutoSize = true;
            this.lbltextM.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextM.ForeColor = System.Drawing.Color.White;
            this.lbltextM.Location = new System.Drawing.Point(97, 59);
            this.lbltextM.Name = "lbltextM";
            this.lbltextM.Size = new System.Drawing.Size(260, 35);
            this.lbltextM.TabIndex = 0;
            this.lbltextM.Text = "Ajouter Matière";
            // 
            // panelM4
            // 
            this.panelM4.BackColor = System.Drawing.Color.White;
            this.panelM4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelM4.Controls.Add(this.btnAddM);
            this.panelM4.Controls.Add(this.labelM4);
            this.panelM4.Controls.Add(this.textPrenomM);
            this.panelM4.Controls.Add(this.labelM1);
            this.panelM4.Controls.Add(this.textNomM);
            this.panelM4.Location = new System.Drawing.Point(58, 171);
            this.panelM4.Name = "panelM4";
            this.panelM4.Size = new System.Drawing.Size(386, 267);
            this.panelM4.TabIndex = 3;
            // 
            // btnAddM
            // 
            this.btnAddM.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddM.FlatAppearance.BorderSize = 0;
            this.btnAddM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddM.ForeColor = System.Drawing.Color.White;
            this.btnAddM.Location = new System.Drawing.Point(53, 186);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(103, 39);
            this.btnAddM.TabIndex = 6;
            this.btnAddM.Text = "Ajouter";
            this.btnAddM.UseVisualStyleBackColor = false;
            // 
            // labelM4
            // 
            this.labelM4.AutoSize = true;
            this.labelM4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM4.Location = new System.Drawing.Point(49, 97);
            this.labelM4.Name = "labelM4";
            this.labelM4.Size = new System.Drawing.Size(135, 20);
            this.labelM4.TabIndex = 0;
            this.labelM4.Text = "Nombre d\'etudiant";
            // 
            // textPrenomM
            // 
            this.textPrenomM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenomM.Location = new System.Drawing.Point(53, 120);
            this.textPrenomM.Name = "textPrenomM";
            this.textPrenomM.Size = new System.Drawing.Size(252, 27);
            this.textPrenomM.TabIndex = 2;
            // 
            // labelM1
            // 
            this.labelM1.AutoSize = true;
            this.labelM1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM1.Location = new System.Drawing.Point(49, 29);
            this.labelM1.Name = "labelM1";
            this.labelM1.Size = new System.Drawing.Size(42, 20);
            this.labelM1.TabIndex = 0;
            this.labelM1.Text = "Nom";
            // 
            // textNomM
            // 
            this.textNomM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomM.Location = new System.Drawing.Point(53, 52);
            this.textNomM.Name = "textNomM";
            this.textNomM.Size = new System.Drawing.Size(252, 27);
            this.textNomM.TabIndex = 1;
            // 
            // FormMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 474);
            this.Controls.Add(this.panelM4);
            this.Controls.Add(this.panelM3);
            this.Name = "FormMatiere";
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
    }
}