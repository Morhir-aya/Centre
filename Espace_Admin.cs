﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;


namespace apk
{
    public partial class Espace_Admin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Espace_Admin()
        {
            InitializeComponent();
            random = new Random();
            if (!Login.statut)
            {
                   this.user.Hide();
                   this.pictureBox2.Hide();
            }
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PanelTitleBaru.BackColor = color;
                    panelLogou.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    /*ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;*/
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPaneu.Controls.Add(childForm);
            this.panelDesktopPaneu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleu.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1u.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Login(), sender);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Groupe(), sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users(), sender);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Professeur(), sender);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Matiere(), sender);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCentre(), sender);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Etudiant(), sender);


        }

        private void Espace_Admin_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelTitleBaru_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
