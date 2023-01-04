namespace apk
{
    partial class Matiere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelM = new System.Windows.Forms.Panel();
            this.labelM = new System.Windows.Forms.Label();
            this.panelM2 = new System.Windows.Forms.Panel();
            this.dataGridViewM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textSearchM = new System.Windows.Forms.TextBox();
            this.pictureBoxM = new System.Windows.Forms.PictureBox();
            this.btnNewM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelM.SuspendLayout();
            this.panelM2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelM
            // 
            this.panelM.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelM.Controls.Add(this.button1);
            this.panelM.Controls.Add(this.labelM);
            this.panelM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelM.Location = new System.Drawing.Point(0, 0);
            this.panelM.Name = "panelM";
            this.panelM.Size = new System.Drawing.Size(800, 129);
            this.panelM.TabIndex = 2;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.Color.White;
            this.labelM.Location = new System.Drawing.Point(241, 50);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(301, 35);
            this.labelM.TabIndex = 0;
            this.labelM.Text = "Gestion de Matière";
            // 
            // panelM2
            // 
            this.panelM2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelM2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelM2.Controls.Add(this.dataGridViewM);
            this.panelM2.Controls.Add(this.textSearchM);
            this.panelM2.Controls.Add(this.pictureBoxM);
            this.panelM2.Controls.Add(this.btnNewM);
            this.panelM2.Location = new System.Drawing.Point(27, 153);
            this.panelM2.Name = "panelM2";
            this.panelM2.Size = new System.Drawing.Size(747, 359);
            this.panelM2.TabIndex = 3;
            // 
            // dataGridViewM
            // 
            this.dataGridViewM.AllowUserToAddRows = false;
            this.dataGridViewM.AllowUserToDeleteRows = false;
            this.dataGridViewM.AllowUserToResizeColumns = false;
            this.dataGridViewM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewM.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8});
            this.dataGridViewM.GridColor = System.Drawing.Color.White;
            this.dataGridViewM.Location = new System.Drawing.Point(40, 101);
            this.dataGridViewM.MultiSelect = false;
            this.dataGridViewM.Name = "dataGridViewM";
            this.dataGridViewM.ReadOnly = true;
            this.dataGridViewM.RowHeadersVisible = false;
            this.dataGridViewM.RowHeadersWidth = 51;
            this.dataGridViewM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewM.RowTemplate.Height = 24;
            this.dataGridViewM.ShowEditingIcon = false;
            this.dataGridViewM.Size = new System.Drawing.Size(674, 226);
            this.dataGridViewM.TabIndex = 0;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom_Matière";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom_Prof";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Modifier";
            // 
            // Column8
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Supprimer";
            // 
            // textSearchM
            // 
            this.textSearchM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchM.Location = new System.Drawing.Point(413, 43);
            this.textSearchM.Name = "textSearchM";
            this.textSearchM.Size = new System.Drawing.Size(242, 27);
            this.textSearchM.TabIndex = 2;
            // 
            // pictureBoxM
            // 
            this.pictureBoxM.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxM.Image = global::apk.Properties.Resources.search;
            this.pictureBoxM.Location = new System.Drawing.Point(652, 43);
            this.pictureBoxM.Name = "pictureBoxM";
            this.pictureBoxM.Size = new System.Drawing.Size(46, 27);
            this.pictureBoxM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxM.TabIndex = 2;
            this.pictureBoxM.TabStop = false;
            // 
            // btnNewM
            // 
            this.btnNewM.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNewM.FlatAppearance.BorderSize = 0;
            this.btnNewM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewM.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewM.ForeColor = System.Drawing.Color.White;
            this.btnNewM.Location = new System.Drawing.Point(58, 39);
            this.btnNewM.Name = "btnNewM";
            this.btnNewM.Size = new System.Drawing.Size(108, 35);
            this.btnNewM.TabIndex = 1;
            this.btnNewM.Text = "Nouveau";
            this.btnNewM.UseVisualStyleBackColor = false;
            this.btnNewM.Click += new System.EventHandler(this.btnNewM_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.Location = new System.Drawing.Point(750, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.panelM2);
            this.Controls.Add(this.panelM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matiere";
            this.panelM.ResumeLayout(false);
            this.panelM.PerformLayout();
            this.panelM2.ResumeLayout(false);
            this.panelM2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelM;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Panel panelM2;
        private System.Windows.Forms.DataGridView dataGridViewM;
        private System.Windows.Forms.TextBox textSearchM;
        private System.Windows.Forms.PictureBox pictureBoxM;
        private System.Windows.Forms.Button btnNewM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.Button button1;
    }
}