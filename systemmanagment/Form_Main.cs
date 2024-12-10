using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemmanagment
{
    public partial class Form_Main : Form
    {

       
        public Form_Main()
        {
            InitializeComponent();
            label1.Text = ClassUser.UserName+"   " +ClassUser.Password +"  "+ClassUser.RoleName;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            this.BtnHome.BackColor = Color.FromArgb(19,164,150);
            this.panelmain.Controls.Clear();
           

        }
        private void Reset_btn_color()
        {
            this.BtnHome.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnPersons.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnReports.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnSetting.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnMyaccount.BackColor = Color.FromArgb(136, 6, 56);
        }

        private void BtnPersons_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            this.BtnPersons.BackColor = Color.FromArgb(19, 164, 150);
            this.panelmain.Controls.Clear();
            Form fm = new FormPersons();
            AddOwnedForm(fm);
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panelmain.Tag = fm;
            this.panelmain.Controls.Add(fm);
            fm.BringToFront();
            fm.Show();

        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            this.BtnSetting.BackColor = Color.FromArgb(19, 164, 150);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            this.BtnReports.BackColor = Color.FromArgb(19, 164, 150);
        }

        private void BtnMyaccount_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            this.BtnMyaccount.BackColor = Color.FromArgb(19, 164, 150);
            this.panelmain.Controls.Clear();
            Form fm = new FormMyaccount();
            AddOwnedForm(fm);
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panelmain.Tag = fm;
            this.panelmain.Controls.Add(fm);
            fm.BringToFront();
            fm.Show();
        }
    }
}
