using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;

namespace bimehejtemaee
{
    public partial class moshakhasatekargah : Form
    {
        public moshakhasatekargah()
        {
            InitializeComponent();
        }

        int id; bool flagh = true;
        crud_BLL bll = new crud_BLL();
        Model1 h = new Model1();
        public void CLEAR()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            
            
           

            ///خراب
            //foreach (var item in Controls)
            //{

            //    if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
            //    {
            //        (item as TextBox).Clear();
            //    }

            //}
        }
        public void DGV()
        {

            gunaDataGridView1.DataSource = null;
            gunaDataGridView1.DataSource = bll.read();
            gunaDataGridView1.Columns[0].Visible = false;
            gunaDataGridView1.Columns[1].HeaderText = "کد کارگاه";
            gunaDataGridView1.Columns[2].HeaderText = "ردیف پیمان";
            gunaDataGridView1.Columns[3].HeaderText = "نام کارگاه";
            gunaDataGridView1.Columns[4].HeaderText = "نام کارفرما";

        }
        private void new_file(object sender, EventArgs e)
        {

            CLEAR();
            gunaGroupBox1.Enabled = true;
            guna2Button4.Enabled = true;
            guna2Button3.Enabled = true;

        }

        private void del(object sender, EventArgs e)
        {
            MessageBox.Show(bll.delete(id));
            DGV();
        }
    }
}
