using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace bimehejtemaee
{
    public partial class search : Form
    {

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     // x-coordinate of upper-left corner
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // width of ellipse
                 int nHeightEllipse // height of ellipse
             );

        public search()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        crud_BLL bll = new crud_BLL();

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            moshakhasatekarkonan.text = bll.read(gunaTextBox1.Text);
            this.Close();

        }

        private void gunaTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.Focus();
            }
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    //عدد و نام فارسی
            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') && (e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }
    }
}
