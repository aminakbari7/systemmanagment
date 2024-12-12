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
            hide_Subpanel();
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
            hide_Subpanel();

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            hide_Subpanel();
            this.BtnHome.BackColor = Color.FromArgb(19,164,150);
            this.panelmain.Controls.Clear();
           

        }
        private void hide_Subpanel()
        {
            PanelMainSubPersons.Visible=false;
            PanelMainSubSetting.Visible = false;
        }
        private void Reset_btn_color()
        {
            this.BtnHome.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnPersons.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnPersonList.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnSetting.BackColor = Color.FromArgb(136, 6, 56);
            this.BtnMyaccount.BackColor = Color.FromArgb(136, 6, 56);
        }

        private void BtnPersons_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            hide_Subpanel();
            this.BtnPersons.BackColor = Color.FromArgb(19, 164, 150);
            this.panelmain.Controls.Clear();
            PanelMainSubPersons.Visible = true;

        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            Reset_btn_color();
            this.BtnSetting.BackColor = Color.FromArgb(19, 164, 150);
            hide_Subpanel();
            PanelMainSubSetting.Visible = true;
        }

        private void BtnPersonList_Click(object sender, EventArgs e)
        {
            
            Form fm = new FormPersons();
            AddOwnedForm(fm);
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.panelmain.Tag = fm;
            this.panelmain.Controls.Add(fm);
            fm.BringToFront();
            fm.Show();


        }

        private void BtnMyaccount_Click(object sender, EventArgs e)
        {
            hide_Subpanel();
            Reset_btn_color();
            this.BtnMyaccount.BackColor = Color.FromArgb(19, 164, 150);
            this.panelmain.Controls.Clear();
           
        }

        private void panelreports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPersonSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
