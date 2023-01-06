namespace apk
{
    partial class Professeur
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
            this.panelG3p = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1p = new System.Windows.Forms.Label();
            this.panelG4p = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridView1p = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textSearchp = new System.Windows.Forms.TextBox();
            this.pictureBox1p = new System.Windows.Forms.PictureBox();
            this.btnNewp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelG3p.SuspendLayout();
            this.panelG4p.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1p)).BeginInit();
            this.SuspendLayout();
            // 
            // panelG3p
            // 
            this.panelG3p.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelG3p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG3p.Controls.Add(this.button1);
            this.panelG3p.Controls.Add(this.label1p);
            this.panelG3p.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelG3p.Location = new System.Drawing.Point(0, 0);
            this.panelG3p.Margin = new System.Windows.Forms.Padding(2);
            this.panelG3p.Name = "panelG3p";
            this.panelG3p.Size = new System.Drawing.Size(622, 105);
            this.panelG3p.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Payement";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1p
            // 
            this.label1p.AutoSize = true;
            this.label1p.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1p.ForeColor = System.Drawing.Color.White;
            this.label1p.Location = new System.Drawing.Point(217, 41);
            this.label1p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1p.Name = "label1p";
            this.label1p.Size = new System.Drawing.Size(188, 27);
            this.label1p.TabIndex = 0;
            this.label1p.Text = "Teachers Infos";
            // 
            // panelG4p
            // 
            this.panelG4p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelG4p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelG4p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG4p.Controls.Add(this.refresh);
            this.panelG4p.Controls.Add(this.dataGridView1p);
            this.panelG4p.Controls.Add(this.textSearchp);
            this.panelG4p.Controls.Add(this.pictureBox1p);
            this.panelG4p.Controls.Add(this.btnNewp);
            this.panelG4p.Location = new System.Drawing.Point(16, 120);
            this.panelG4p.Margin = new System.Windows.Forms.Padding(2);
            this.panelG4p.Name = "panelG4p";
            this.panelG4p.Size = new System.Drawing.Size(592, 300);
            this.panelG4p.TabIndex = 2;
            this.panelG4p.Paint += new System.Windows.Forms.PaintEventHandler(this.panelG4_Paint);
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
            // dataGridView1p
            // 
            this.dataGridView1p.AllowUserToAddRows = false;
            this.dataGridView1p.AllowUserToResizeColumns = false;
            this.dataGridView1p.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1p.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1p.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1p.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dataGridView1p.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1p.Location = new System.Drawing.Point(17, 82);
            this.dataGridView1p.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1p.MultiSelect = false;
            this.dataGridView1p.Name = "dataGridView1p";
            this.dataGridView1p.RowHeadersVisible = false;
            this.dataGridView1p.RowHeadersWidth = 51;
            this.dataGridView1p.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1p.RowTemplate.Height = 24;
            this.dataGridView1p.ShowEditingIcon = false;
            this.dataGridView1p.Size = new System.Drawing.Size(556, 203);
            this.dataGridView1p.TabIndex = 0;
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
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Text = "Supprimer";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // textSearchp
            // 
            this.textSearchp.BackColor = System.Drawing.SystemColors.Control;
            this.textSearchp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchp.Location = new System.Drawing.Point(272, 35);
            this.textSearchp.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchp.Name = "textSearchp";
            this.textSearchp.Size = new System.Drawing.Size(182, 23);
            this.textSearchp.TabIndex = 2;
            // 
            // pictureBox1p
            // 
            this.pictureBox1p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1p.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1p.Image = global::apk.Properties.Resources.search;
            this.pictureBox1p.Location = new System.Drawing.Point(451, 35);
            this.pictureBox1p.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1p.Name = "pictureBox1p";
            this.pictureBox1p.Size = new System.Drawing.Size(37, 23);
            this.pictureBox1p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1p.TabIndex = 2;
            this.pictureBox1p.TabStop = false;
            this.pictureBox1p.Click += new System.EventHandler(this.pictureBox1p_Click);
            // 
            // btnNewp
            // 
            this.btnNewp.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNewp.FlatAppearance.BorderSize = 0;
            this.btnNewp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewp.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewp.ForeColor = System.Drawing.Color.White;
            this.btnNewp.Location = new System.Drawing.Point(44, 32);
            this.btnNewp.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewp.Name = "btnNewp";
            this.btnNewp.Size = new System.Drawing.Size(81, 28);
            this.btnNewp.TabIndex = 1;
            this.btnNewp.Text = "New";
            this.btnNewp.UseVisualStyleBackColor = false;
            this.btnNewp.Click += new System.EventHandler(this.btnNewp_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 438);
            this.panel1.TabIndex = 4;
            // 
            // Professeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(622, 438);
            this.Controls.Add(this.panelG4p);
            this.Controls.Add(this.panelG3p);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Professeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professeur";
            this.panelG3p.ResumeLayout(false);
            this.panelG3p.PerformLayout();
            this.panelG4p.ResumeLayout(false);
            this.panelG4p.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelG3p;
        private System.Windows.Forms.Label label1p;
        private System.Windows.Forms.Panel panelG4p;
        private System.Windows.Forms.DataGridView dataGridView1p;
        private System.Windows.Forms.TextBox textSearchp;
        private System.Windows.Forms.PictureBox pictureBox1p;
        private System.Windows.Forms.Button btnNewp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}