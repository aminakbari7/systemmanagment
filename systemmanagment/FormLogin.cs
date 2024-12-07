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
    public partial class FormLogin : Form
    {
        dbappEntities1 db = new dbappEntities1();
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            comboBoxroll.DataSource = db.TB_Roles.ToList();
            comboBoxroll.ValueMember = "RoleName";
            comboBoxroll.DisplayMember = "RoleName";
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            var r= db.isadmin(textBoxusername.Text, textBoxpassword.Text, comboBoxroll.SelectedValue.ToString()).ToList();
            //var r = from a in db.TB_Users .ToList()
                   // where a.Name == textBoxusername.Text && a.Password == textBoxpassword.Text
                    //select new {a.Name,a.Family};
            if (r.Count()>0)
            {
                Form_Main form2 = new Form_Main();
                this.Hide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLog_Click_1(object sender, EventArgs e)
        {
            var r = db.isadmin(textBoxusername.Text, textBoxpassword.Text, comboBoxroll.SelectedValue.ToString()).ToList();

            //var r = from a in db.TB_Users.ToList()
            //where a.Name == textBoxusername.Text && a.Password == textBoxpassword.Text
            // select new { a.Name, a.Family };
            if (r.Count() > 0)
            {
                Form_Main form2 = new Form_Main();
                db.Dispose();
                this.Hide();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }
    }
}
