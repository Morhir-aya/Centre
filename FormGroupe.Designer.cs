﻿namespace apk
{
    partial class FormGroupe
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
            this.panelG3 = new System.Windows.Forms.Panel();
            this.lbltextG = new System.Windows.Forms.Label();
            this.panelG4 = new System.Windows.Forms.Panel();
            this.btnAddG = new System.Windows.Forms.Button();
            this.labelG4 = new System.Windows.Forms.Label();
            this.textPrenomG = new System.Windows.Forms.TextBox();
            this.labelG1 = new System.Windows.Forms.Label();
            this.textNomG = new System.Windows.Forms.TextBox();
            this.panelG3.SuspendLayout();
            this.panelG4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelG3
            // 
            this.panelG3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG3.Controls.Add(this.lbltextG);
            this.panelG3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelG3.Location = new System.Drawing.Point(0, 0);
            this.panelG3.Name = "panelG3";
            this.panelG3.Size = new System.Drawing.Size(489, 139);
            this.panelG3.TabIndex = 1;
            // 
            // lbltextG
            // 
            this.lbltextG.AutoSize = true;
            this.lbltextG.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextG.ForeColor = System.Drawing.Color.White;
            this.lbltextG.Location = new System.Drawing.Point(97, 59);
            this.lbltextG.Name = "lbltextG";
            this.lbltextG.Size = new System.Drawing.Size(257, 35);
            this.lbltextG.TabIndex = 0;
            this.lbltextG.Text = "Ajouter Groupe";
            this.lbltextG.Click += new System.EventHandler(this.lbltext_Click);
            // 
            // panelG4
            // 
            this.panelG4.BackColor = System.Drawing.Color.White;
            this.panelG4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG4.Controls.Add(this.btnAddG);
            this.panelG4.Controls.Add(this.labelG4);
            this.panelG4.Controls.Add(this.textPrenomG);
            this.panelG4.Controls.Add(this.labelG1);
            this.panelG4.Controls.Add(this.textNomG);
            this.panelG4.Location = new System.Drawing.Point(52, 169);
            this.panelG4.Name = "panelG4";
            this.panelG4.Size = new System.Drawing.Size(386, 267);
            this.panelG4.TabIndex = 2;
            // 
            // btnAddG
            // 
            this.btnAddG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddG.FlatAppearance.BorderSize = 0;
            this.btnAddG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddG.ForeColor = System.Drawing.Color.White;
            this.btnAddG.Location = new System.Drawing.Point(53, 186);
            this.btnAddG.Name = "btnAddG";
            this.btnAddG.Size = new System.Drawing.Size(103, 39);
            this.btnAddG.TabIndex = 6;
            this.btnAddG.Text = "Ajouter";
            this.btnAddG.UseVisualStyleBackColor = false;
            this.btnAddG.Click += new System.EventHandler(this.btnAddG_Click);
            // 
            // labelG4
            // 
            this.labelG4.AutoSize = true;
            this.labelG4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG4.Location = new System.Drawing.Point(49, 97);
            this.labelG4.Name = "labelG4";
            this.labelG4.Size = new System.Drawing.Size(135, 20);
            this.labelG4.TabIndex = 0;
            this.labelG4.Text = "Nombre d\'etudiant";
            // 
            // textPrenomG
            // 
            this.textPrenomG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenomG.Location = new System.Drawing.Point(53, 120);
            this.textPrenomG.Name = "textPrenomG";
            this.textPrenomG.Size = new System.Drawing.Size(252, 27);
            this.textPrenomG.TabIndex = 2;
            // 
            // labelG1
            // 
            this.labelG1.AutoSize = true;
            this.labelG1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG1.Location = new System.Drawing.Point(49, 29);
            this.labelG1.Name = "labelG1";
            this.labelG1.Size = new System.Drawing.Size(42, 20);
            this.labelG1.TabIndex = 0;
            this.labelG1.Text = "Nom";
            this.labelG1.Click += new System.EventHandler(this.labelG1_Click);
            // 
            // textNomG
            // 
            this.textNomG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomG.Location = new System.Drawing.Point(53, 52);
            this.textNomG.Name = "textNomG";
            this.textNomG.Size = new System.Drawing.Size(252, 27);
            this.textNomG.TabIndex = 1;
            // 
            // FormGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 468);
            this.Controls.Add(this.panelG4);
            this.Controls.Add(this.panelG3);
            this.Name = "FormGroupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroupe";
            this.panelG3.ResumeLayout(false);
            this.panelG3.PerformLayout();
            this.panelG4.ResumeLayout(false);
            this.panelG4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelG3;
        private System.Windows.Forms.Label lbltextG;
        private System.Windows.Forms.Panel panelG4;
        private System.Windows.Forms.Button btnAddG;
        private System.Windows.Forms.Label labelG4;
        private System.Windows.Forms.TextBox textPrenomG;
        private System.Windows.Forms.Label labelG1;
        private System.Windows.Forms.TextBox textNomG;
    }
}