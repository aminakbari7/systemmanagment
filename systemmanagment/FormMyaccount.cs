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
    public partial class FormMyaccount : Form
    {

        dbappEntities2 db = new dbappEntities2();

        public FormMyaccount()
        {
            InitializeComponent();
            refreshgrid();
        }
        private void refreshgrid()
        {

            var q = db.MyHistory(3);
            this.dataGridViewmyaccount.DataSource = q.ToList();
            //.ColumnHeadersVisible = false;
            //dataGridViewpersons.Rows.Add(new object[] { "1", "amin", "akbari", "dddrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr", "dddd", "iuiuiu" });
            // dataGridViewpersons.Rows.Add(new object[] { "2", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
            //dataGridViewpersons.Rows.Add(new object[] { "3", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
            // dataGridViewpersons.Rows.Add(new object[] { "4", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
        }
        private void BtnUserEdit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewpersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
