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

        dbappEntities1 db = new dbappEntities1();
        public int x = 0;
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
            db=new dbappEntities1();
            refreshgrid();
            dataGridViewpersons.Rows[x].Selected = true;
            x = 0;
            dataGridViewpersons.Rows[x].Selected = false;
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
            x = dataGridViewpersons.CurrentCell.RowIndex;
        }

        private void BtnUserCancel_Click(object sender, EventArgs e)
        {
            refreshgrid();
        }

        private void BtnPrsonsPrint_Click(object sender, EventArgs e)
        {
        copyAlltoClipboard();
        
        Microsoft.Office.Interop.Excel.Application xlexcel;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        object misValue = System.Reflection.Missing.Value;
        xlexcel = new Microsoft.Office.Interop.Excel.Application();
        xlexcel.Visible = true;
        xlWorkBook = xlexcel.Workbooks.Add(misValue);
        xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
        CR.Select();
        xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true); 
            
        }

        //
        private void copyAlltoClipboard()
        {
            dataGridViewpersons.SelectAll();
            DataObject dataObj = dataGridViewpersons.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }




        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>




        private void button1_Click(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void dataGridViewpersons_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
