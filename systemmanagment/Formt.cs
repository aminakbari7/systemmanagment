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
    public partial class Formt : Form
    {
        public Formt()
        {
            InitializeComponent();
        }

        private void panelt1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formt_Load(object sender, EventArgs e)
        {

            hidsub();
        }
        public void hidsub()
        {
            panelts1.Visible=false;
            panelts2.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidsub();
            panelts1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidsub();
            panelts2.Visible = true;
        }
    }
}
