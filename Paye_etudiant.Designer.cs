﻿namespace apk
{
    partial class Paye_etudiant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelpe3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelpe1 = new System.Windows.Forms.Label();
            this.panelpe4 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridViewpe1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textSearchpe = new System.Windows.Forms.TextBox();
            this.pictureBoxpe1 = new System.Windows.Forms.PictureBox();
            this.btnNewpe = new System.Windows.Forms.Button();
            this.panelpe3.SuspendLayout();
            this.panelpe4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpe1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelpe3
            // 
            this.panelpe3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelpe3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpe3.Controls.Add(this.button1);
            this.panelpe3.Controls.Add(this.labelpe1);
            this.panelpe3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelpe3.Location = new System.Drawing.Point(0, 0);
            this.panelpe3.Margin = new System.Windows.Forms.Padding(2);
            this.panelpe3.Name = "panelpe3";
            this.panelpe3.Size = new System.Drawing.Size(658, 105);
            this.panelpe3.TabIndex = 1;
            this.panelpe3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpe3_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(627, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelpe1
            // 
            this.labelpe1.AutoSize = true;
            this.labelpe1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpe1.ForeColor = System.Drawing.Color.White;
            this.labelpe1.Location = new System.Drawing.Point(232, 41);
            this.labelpe1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpe1.Name = "labelpe1";
            this.labelpe1.Size = new System.Drawing.Size(175, 27);
            this.labelpe1.TabIndex = 0;
            this.labelpe1.Text = "Payment Info";
            // 
            // panelpe4
            // 
            this.panelpe4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpe4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelpe4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpe4.Controls.Add(this.refresh);
            this.panelpe4.Controls.Add(this.dataGridViewpe1);
            this.panelpe4.Controls.Add(this.textSearchpe);
            this.panelpe4.Controls.Add(this.pictureBoxpe1);
            this.panelpe4.Controls.Add(this.btnNewpe);
            this.panelpe4.Location = new System.Drawing.Point(25, 124);
            this.panelpe4.Margin = new System.Windows.Forms.Padding(2);
            this.panelpe4.Name = "panelpe4";
            this.panelpe4.Size = new System.Drawing.Size(607, 304);
            this.panelpe4.TabIndex = 2;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(129, 32);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(81, 28);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataGridViewpe1
            // 
            this.dataGridViewpe1.AllowUserToAddRows = false;
            this.dataGridViewpe1.AllowUserToResizeColumns = false;
            this.dataGridViewpe1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewpe1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewpe1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewpe1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpe1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dataGridViewpe1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewpe1.Location = new System.Drawing.Point(30, 82);
            this.dataGridViewpe1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewpe1.MultiSelect = false;
            this.dataGridViewpe1.Name = "dataGridViewpe1";
            this.dataGridViewpe1.RowHeadersVisible = false;
            this.dataGridViewpe1.RowHeadersWidth = 51;
            this.dataGridViewpe1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewpe1.RowTemplate.Height = 24;
            this.dataGridViewpe1.ShowEditingIcon = false;
            this.dataGridViewpe1.Size = new System.Drawing.Size(545, 207);
            this.dataGridViewpe1.TabIndex = 0;
            this.dataGridViewpe1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpe1_CellClick);
            this.dataGridViewpe1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpe1_CellContentClick);
            // 
            // Column7
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Text = "Update";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Text = "Supprimer";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // textSearchpe
            // 
            this.textSearchpe.BackColor = System.Drawing.SystemColors.Control;
            this.textSearchpe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchpe.Location = new System.Drawing.Point(272, 35);
            this.textSearchpe.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchpe.Name = "textSearchpe";
            this.textSearchpe.Size = new System.Drawing.Size(182, 23);
            this.textSearchpe.TabIndex = 2;
            // 
            // pictureBoxpe1
            // 
            this.pictureBoxpe1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxpe1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxpe1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxpe1.Image = global::apk.Properties.Resources.search;
            this.pictureBoxpe1.Location = new System.Drawing.Point(452, 35);
            this.pictureBoxpe1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxpe1.Name = "pictureBoxpe1";
            this.pictureBoxpe1.Size = new System.Drawing.Size(94, 23);
            this.pictureBoxpe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxpe1.TabIndex = 2;
            this.pictureBoxpe1.TabStop = false;
            this.pictureBoxpe1.Click += new System.EventHandler(this.pictureBoxpe1_Click);
            // 
            // btnNewpe
            // 
            this.btnNewpe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNewpe.FlatAppearance.BorderSize = 0;
            this.btnNewpe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewpe.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewpe.ForeColor = System.Drawing.Color.White;
            this.btnNewpe.Location = new System.Drawing.Point(44, 32);
            this.btnNewpe.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewpe.Name = "btnNewpe";
            this.btnNewpe.Size = new System.Drawing.Size(81, 28);
            this.btnNewpe.TabIndex = 1;
            this.btnNewpe.Text = "New";
            this.btnNewpe.UseVisualStyleBackColor = false;
            this.btnNewpe.Click += new System.EventHandler(this.btnNewpe_Click);
            // 
            // Paye_etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(658, 446);
            this.Controls.Add(this.panelpe4);
            this.Controls.Add(this.panelpe3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Paye_etudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paye_etudiant";
            this.panelpe3.ResumeLayout(false);
            this.panelpe3.PerformLayout();
            this.panelpe4.ResumeLayout(false);
            this.panelpe4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpe1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelpe3;
        private System.Windows.Forms.Label labelpe1;
        private System.Windows.Forms.Panel panelpe4;
        private System.Windows.Forms.DataGridView dataGridViewpe1;
        private System.Windows.Forms.TextBox textSearchpe;
        private System.Windows.Forms.PictureBox pictureBoxpe1;
        private System.Windows.Forms.Button btnNewpe;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}