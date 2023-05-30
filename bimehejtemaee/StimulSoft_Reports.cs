using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft;
using System.Data.SqlClient;
using BE_ToseGar;
using DevComponents.DotNetBar.Controls;

namespace ToseGar_Help_Source
{
    public partial class StimulSoft_Reports : UserControl
    {
        public StimulSoft_Reports()
        {
            InitializeComponent();
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            stiReport1.Dictionary.Variables["SellName"].Value = label1.Text;
            stiReport1.Dictionary.Variables["FactorNum"].Value = label4.Text;
            stiReport1.Dictionary.Variables["CustName"].Value = label1.Text;

            stiReport1.RegBusinessObject("DT1", guna2DataGridView1.DataSource);

            stiReport1.Render();
            stiReport1.Show();
        }








        List<Report_Sample_Class> ss = new List<Report_Sample_Class>();
        private void StimulSoft_Reports_Load(object sender, EventArgs e)
        {

            Report_Sample_Class s = new Report_Sample_Class() { Name = "کالا نمونه یک", Count = 12, Price = "1,000,000", PriceCount = "12,000,000" };
            Report_Sample_Class s1 = new Report_Sample_Class() { Name = "کالا نمونه دو", Count = 10, Price = "800,000", PriceCount = "8,000,000" };
            Report_Sample_Class s2 = new Report_Sample_Class() { Name = "کالا نمونه سه", Count = 6, Price = "600,000", PriceCount = "3,600,000" };

            ss.Add(s);
            ss.Add(s1);
            ss.Add(s2);

            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = ss;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBoxX2.Text = (Convert.ToDecimal(textBoxX3.Text) * numericUpDown1.Value).ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var a = groupBox3.Controls.OfType<TextBoxX>().Any(i=> i.Text == "");
            if (a)
            {
                MessageBox.Show("لطفا ابتدا تمام اطلاعات کالا را تکمیل کنید");
            }
            else
            {
                Report_Sample_Class s = new Report_Sample_Class() { Name = textBoxX1.Text, Count = Convert.ToInt32(numericUpDown1.Value), Price = textBoxX3.Text, PriceCount = textBoxX2.Text };
                ss.Add(s);

                guna2DataGridView1.DataSource = null;
                guna2DataGridView1.DataSource = ss;
            }
        }






        private void guna2Button3_Click(object sender, EventArgs e)
        {
            stiReport2.Show();
        }
    }
}
