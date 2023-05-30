using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft;

namespace bimehejtemaee
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void مشخصاتکارکنانToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            moshakhasatekarkonan m = new moshakhasatekarkonan();
            m.Show();

        }
        private void مشخصاتکارگاهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("درحال بروزرسانی");
            //moshakhasatekargah m = new moshakhasatekargah();
            //m.Show();
        }

        private void لیستماهانهToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("درحال بروزرسانی");
           // listmahaneh m = new listmahaneh();
            //m.Show();

        }

        private void دریافتخدماتToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void دربارهماToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("\t         سایت : www.mahseven.com\n\t         ایمیل : Info@mahseven.com\n        .کلیه حقوق این نرم افزار متعلق به همیارماهسون می باشد");

        }

        private void بازیابیاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("آیا میخواهید از برنامه خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    this.Close();

                }

            }
        }

        private void دیسکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disck disk = new disck();
            disk.Show();
        }

        private void پنلکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karbar k = new karbar();
            k.Show();
        }

        private void چاپToolStripMenuItem_Click(object sender, EventArgs e)
        {


            stiReport1.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mahseven.com");
        }
    }
}
