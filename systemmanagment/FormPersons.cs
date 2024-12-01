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
    public partial class FormPersons : Form
    {
        public FormPersons()
        {
            InitializeComponent();
            refreshgrid();
        }

        private void refreshgrid()
        {
            dataGridViewpersons.Rows.Add(new object[] { "1", "amin", "akbari", "dddrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr", "dddd", "iuiuiu" });
            dataGridViewpersons.Rows.Add(new object[] { "2", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
            dataGridViewpersons.Rows.Add(new object[] { "3", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
            dataGridViewpersons.Rows.Add(new object[] { "4", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void panelgriduser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
