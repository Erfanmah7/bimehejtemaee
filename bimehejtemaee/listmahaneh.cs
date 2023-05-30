using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bimehejtemaee
{
    public partial class listmahaneh : Form
    {
        public listmahaneh()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            newlistmahane m = new newlistmahane();
            m.Show();

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
