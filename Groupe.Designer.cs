namespace apk
{
    partial class Groupe
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
            this.panelG = new System.Windows.Forms.Panel();
            this.labelG = new System.Windows.Forms.Label();
            this.panelG2 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridViewG = new System.Windows.Forms.DataGridView();
            this.textSearchG = new System.Windows.Forms.TextBox();
            this.pictureBoxG = new System.Windows.Forms.PictureBox();
            this.btnNewG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelG.SuspendLayout();
            this.panelG2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelG
            // 
            this.panelG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelG.Controls.Add(this.labelG);
            this.panelG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelG.Location = new System.Drawing.Point(0, 0);
            this.panelG.Margin = new System.Windows.Forms.Padding(2);
            this.panelG.Name = "panelG";
            this.panelG.Size = new System.Drawing.Size(631, 105);
            this.panelG.TabIndex = 1;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.ForeColor = System.Drawing.Color.White;
            this.labelG.Location = new System.Drawing.Point(226, 42);
            this.labelG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(156, 27);
            this.labelG.TabIndex = 0;
            this.labelG.Text = "Group Infos";
            this.labelG.Click += new System.EventHandler(this.labelG_Click);
            // 
            // panelG2
            // 
            this.panelG2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelG2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelG2.Controls.Add(this.refresh);
            this.panelG2.Controls.Add(this.dataGridViewG);
            this.panelG2.Controls.Add(this.textSearchG);
            this.panelG2.Controls.Add(this.pictureBoxG);
            this.panelG2.Controls.Add(this.btnNewG);
            this.panelG2.Location = new System.Drawing.Point(26, 136);
            this.panelG2.Margin = new System.Windows.Forms.Padding(2);
            this.panelG2.Name = "panelG2";
            this.panelG2.Size = new System.Drawing.Size(561, 309);
            this.panelG2.TabIndex = 2;
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
            // dataGridViewG
            // 
            this.dataGridViewG.AllowUserToAddRows = false;
            this.dataGridViewG.AllowUserToDeleteRows = false;
            this.dataGridViewG.AllowUserToResizeColumns = false;
            this.dataGridViewG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewG.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dataGridViewG.GridColor = System.Drawing.Color.White;
            this.dataGridViewG.Location = new System.Drawing.Point(30, 82);
            this.dataGridViewG.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewG.MultiSelect = false;
            this.dataGridViewG.Name = "dataGridViewG";
            this.dataGridViewG.ReadOnly = true;
            this.dataGridViewG.RowHeadersVisible = false;
            this.dataGridViewG.RowHeadersWidth = 51;
            this.dataGridViewG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewG.RowTemplate.Height = 24;
            this.dataGridViewG.ShowEditingIcon = false;
            this.dataGridViewG.Size = new System.Drawing.Size(506, 201);
            this.dataGridViewG.TabIndex = 0;
            // 
            // textSearchG
            // 
            this.textSearchG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchG.Location = new System.Drawing.Point(310, 35);
            this.textSearchG.Margin = new System.Windows.Forms.Padding(2);
            this.textSearchG.Name = "textSearchG";
            this.textSearchG.Size = new System.Drawing.Size(182, 23);
            this.textSearchG.TabIndex = 2;
            // 
            // pictureBoxG
            // 
            this.pictureBoxG.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxG.Image = global::apk.Properties.Resources.search;
            this.pictureBoxG.Location = new System.Drawing.Point(489, 35);
            this.pictureBoxG.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxG.Name = "pictureBoxG";
            this.pictureBoxG.Size = new System.Drawing.Size(36, 23);
            this.pictureBoxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxG.TabIndex = 2;
            this.pictureBoxG.TabStop = false;
            // 
            // btnNewG
            // 
            this.btnNewG.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNewG.FlatAppearance.BorderSize = 0;
            this.btnNewG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewG.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewG.ForeColor = System.Drawing.Color.White;
            this.btnNewG.Location = new System.Drawing.Point(44, 32);
            this.btnNewG.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewG.Name = "btnNewG";
            this.btnNewG.Size = new System.Drawing.Size(81, 28);
            this.btnNewG.TabIndex = 1;
            this.btnNewG.Text = "New";
            this.btnNewG.UseVisualStyleBackColor = false;
            this.btnNewG.Click += new System.EventHandler(this.btnNewG_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 477);
            this.panel1.TabIndex = 3;
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
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Modifier";
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
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Supprimer";
            // 
            // Groupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(631, 477);
            this.Controls.Add(this.panelG2);
            this.Controls.Add(this.panelG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Groupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groupe";
            this.panelG.ResumeLayout(false);
            this.panelG.PerformLayout();
            this.panelG2.ResumeLayout(false);
            this.panelG2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelG;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Panel panelG2;
        private System.Windows.Forms.DataGridView dataGridViewG;
        private System.Windows.Forms.TextBox textSearchG;
        private System.Windows.Forms.PictureBox pictureBoxG;
        private System.Windows.Forms.Button btnNewG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}