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

       dbappEntities db=new dbappEntities();
        public FormPersons()
        {
            InitializeComponent();
            refreshgrid();
        }


        private void refreshgrid()
        {
          
            BtnUserSave.Enabled = false;
            BtnUserAdd.Enabled = true;
            textBoxid.Visible = false; 
            var q = db.vwpersons;
            dataGridViewpersons.DataSource = q.ToList();
            textBoxname.Text = "";
            textBoxfamily.Text = "";
            textBoxcodm.Text = "";
            textBoxphone.Text = "";
            textBoxaddress.Text = "";
            //.ColumnHeadersVisible = false;
            //dataGridViewpersons.Rows.Add(new object[] { "1", "amin", "akbari", "dddrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr", "dddd", "iuiuiu" });
            // dataGridViewpersons.Rows.Add(new object[] { "2", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
            //dataGridViewpersons.Rows.Add(new object[] { "3", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
            // dataGridViewpersons.Rows.Add(new object[] { "4", "amin", "akbari", "ddd", "dddd", "iuiuiu" });
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

        private void dataGridViewpersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnUserDelete_Click(object sender, EventArgs e)
        {
            int ide = Convert.ToInt32(dataGridViewpersons.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("آیا مطمئن هستید؟?", "system message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var s = db.delete_person(ide);
                db.SaveChanges();
                MessageBox.Show("با موفقیت حذف شد", "system message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshgrid();
            }
        }

        private void textBoxusersearch_TextChanged(object sender, EventArgs e)
        {
            var q = db.find_person(textBoxusersearch.Text);

            dataGridViewpersons.DataSource = q.ToList();

        }

        private void BtnUserSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnUserAdd_Click(object sender, EventArgs e)
        {
            
            var a = db.add_person(textBoxname.Text, textBoxfamily.Text, textBoxphone.Text, textBoxcodm.Text, textBoxaddress.Text);
            refreshgrid();

        }

        private void BtnUserSave_Click_1(object sender, EventArgs e)
        {
            db.update_person(Convert.ToInt32(textBoxid.Text), textBoxname.Text, textBoxfamily.Text, textBoxphone.Text, textBoxcodm.Text, textBoxaddress.Text);
            db.SaveChanges();
            db.Dispose();
            db=new dbappEntities();
            refreshgrid();
            


        }
        public void cleartextboxpersons()
        {

        }

        private void BtnUserEdit_Click(object sender, EventArgs e)
        {
            BtnUserSave.Enabled = true;
            BtnUserAdd.Enabled = false;
            textBoxid.Visible = true;
            textBoxid.Text= Convert.ToString(dataGridViewpersons.CurrentRow.Cells[0].Value);
            textBoxname.Text = Convert.ToString(dataGridViewpersons.CurrentRow.Cells[1].Value);
            textBoxfamily.Text = Convert.ToString(dataGridViewpersons.CurrentRow.Cells[2].Value);
            textBoxcodm.Text = Convert.ToString(dataGridViewpersons.CurrentRow.Cells[3].Value);
            textBoxphone.Text = Convert.ToString(dataGridViewpersons.CurrentRow.Cells[4].Value);
            textBoxaddress.Text = Convert.ToString(dataGridViewpersons.CurrentRow.Cells[5].Value);
        }

        private void BtnUserCancel_Click(object sender, EventArgs e)
        {
            refreshgrid();
        }
    }
}
