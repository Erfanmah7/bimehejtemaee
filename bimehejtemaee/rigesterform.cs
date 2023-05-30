using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;
using BE;
using BLL;

namespace bimehejtemaee
{
    public partial class rigesterform : Form
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

        public rigesterform()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        const int ProductCode = 1;
        user_BLL bll = new user_BLL();
        private void rigesterform_Load(object sender, EventArgs e)
        {
            textBoxX1.Text = ComputerInfo.GetComputerId();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(textBoxX1.Text);
            string productKey = textBoxX2.Text;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "Personal accounting";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }

                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("فعال سازی برنامه با موفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox2.Enabled = true;
                }
            }
            else
                MessageBox.Show("کد لایسنس نامعتبر است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (textBoxX3.Text.Trim().Length !=0 && textBoxX4.Text.Trim().Length != 0 && textBoxX4.Text.Trim().Length != 0 && textBoxX5.Text.Trim().Length != 0 && textBoxX6.Text.Trim().Length != 0)
            {
                if (textBoxX5.Text == textBoxX6.Text)
                {
                    bll.Register(new User_Login() { Name = textBoxX3.Text, UserName = textBoxX4.Text, Password = textBoxX5.Text});
                    MessageBox.Show("اطلاعات ادمین ایجاد شد");
                    //loginform.karbar = textBoxX4.Text;
                    //this.Close();
                    ((loginform)Application.OpenForms["loginform"]).label3.Visible = false;
                    this.Close();

                }
            }
            else
            {
                label1.Text = "لطفا اطلاعات را کامل کنید";
            }
           
        }

        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))

                e.Handled = true;
        }

        private void textBoxX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
