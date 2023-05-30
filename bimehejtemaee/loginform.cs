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
    public partial class loginform : Form
    {

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
   
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // width of ellipse
                 int nHeightEllipse // height of ellipse
             );

        public loginform()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        user_BLL bll = new user_BLL();

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (bll.Login(textBoxX1.Text, textBoxX2.Text) == 1)
            {
                Globa.userLog = bll.ReadIDUser(textBoxX1.Text);
                label1.Text = "خوش آمدید";
                main m = new main();
                m.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "نام کاربری و یا کلمه عبور اشتباه است";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

            rigesterform r = new rigesterform();
            r.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //public static string karbar;
        private void loginform_Load(object sender, EventArgs e)
        {


            //rigesterform rgs = new rigesterform();
            //rgs.ShowDialog();
            //textBoxX1.Text = karbar;

            if (bll.Login("", "") == 0)
            {
                
                label3.Visible = true;
            }
        }

        private void loginform_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.Focus();
            }
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
