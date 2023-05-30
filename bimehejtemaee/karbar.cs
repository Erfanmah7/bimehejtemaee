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
    public partial class karbar : Form
    {
        public karbar()
        {
            InitializeComponent();
        }

        user_BLL bll = new user_BLL();
        User_Login user = new User_Login();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //user.Name = textBoxX3.Text;
            user.UserName = textBoxX1.Text;
            user.Password = textBoxX2.Text;

            if (textBoxX1.Text.Trim().Length != 0 && textBoxX2.Text.Trim().Length != 0 && textBoxX3.Text.Trim().Length != 0 && textBoxX4.Text.Trim().Length != 0)
            {
                if (bll.readPassOld(Globa.userLog, textBoxX4.Text) == false)
                {
                    MessageBox.Show("رمز قبلی اشتباه است");
                    return;
                }

                if (textBoxX2.Text == textBoxX3.Text)
                {



                    if (bll.update(Globa.userLog, user))
                    {
                        MessageBox.Show("اطلاعات کاربری با موفقیت تغییر یافت");
                    }
                    else
                    {

                        MessageBox.Show("اطلاعات نامعتبر است");

                    }


                }
                else
                {

                    MessageBox.Show("رمز ها برابر نیستند");

                }
            }
            else
            {
                MessageBox.Show("اطلاعات کاربری را تکمیل کنید");
            }
        }

        private void textBoxX3_KeyDown(object sender, KeyEventArgs e)
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

        //private void label2_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("!!!تمامی اطلاعات شما حذف خواهند شد \n !اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {

        //        if (bll.sql())
        //        {

        //            Application.Exit();

        //        }
                
        //    }
        //}
    }
}
