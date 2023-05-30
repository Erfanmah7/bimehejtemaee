using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace bimehejtemaee
{
    public partial class moshakhasatekarkonan : Form
    {
        public moshakhasatekarkonan()
        {
            InitializeComponent();
        }

        int id; bool flagh = true;
        crud_BLL bll = new crud_BLL();
        Model h = new Model();
        public void DGV()
        {

            gunaDataGridView1.DataSource = null;
            gunaDataGridView1.DataSource = bll.read();
            gunaDataGridView1.Columns[0].Visible = false;
            gunaDataGridView1.Columns[1].HeaderText = "شماره بیمه";
            gunaDataGridView1.Columns[1].Width = 45;
            gunaDataGridView1.Columns[2].HeaderText = "شماره پرسنلی";
            gunaDataGridView1.Columns[2].Width = 47;
            gunaDataGridView1.Columns[3].HeaderText = "نام";
            gunaDataGridView1.Columns[3].Width = 25;
            gunaDataGridView1.Columns[4].HeaderText = "نام خانوادگی";
            gunaDataGridView1.Columns[4].Width = 45;
            gunaDataGridView1.Columns[5].Visible = false;
            gunaDataGridView1.Columns[9].HeaderText = "شغل";
            gunaDataGridView1.Columns[9].Width = 25;
            gunaDataGridView1.Columns[7].Visible = false;
            gunaDataGridView1.Columns[8].Visible = false;
            gunaDataGridView1.Columns[6].HeaderText = "کدملی";
            gunaDataGridView1.Columns[6].Width = 60;
            gunaDataGridView1.Columns[10].Visible = false;
            gunaDataGridView1.Columns[11].Visible = false;
            gunaDataGridView1.Columns[12].Visible = false;

        }
        public void CLEAR()
        {

            errorProvider1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePickerX1.Text = "1400/10/05"; //خالیش کنم یا بیارمش به تاریخ الان شمسی;
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Checked = false;

            ///خراب
            //foreach (var item in Controls)
            //{

            //    if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
            //    {
            //        (item as TextBox).Clear();
            //    }

            //}
        }
        private void create(object sender, EventArgs e)
        {

            gunaDataGridView1.Enabled = true;
            
            //اگر ثبت نام بود
            if (flagh)
            {

                if (textBox1.Text.Trim().Length != 0 && textBox2.Text.Trim().Length != 0 && textBox3.Text.Trim().Length != 0 && textBox4.Text.Trim().Length != 0 && textBox5.Text.Trim().Length != 0 && textBox6.Text.Trim().Length != 0 && dateTimePickerX1.Text.Trim().Length != 0 && textBox8.Text.Trim().Length != 0 && textBox9.Text.Trim().Length != 0 && textBox10.Text.Trim().Length != 0 && radioButton1.Checked == true || radioButton2.Checked == true && radioButton3.Checked == true || radioButton4.Checked == true)
                {

                    h.shomarebime = textBox1.Text;
                    h.shomarepersonely = textBox2.Text;
                    h.name = textBox3.Text;
                    h.family = textBox4.Text;
                    h.namefather = textBox5.Text;
                    h.shenasname = textBox6.Text;
                    bll.datechangeage(h.date = dateTimePickerX1.Text);
                    h.codemeli = textBox9.Text;
                    h.job = textBox10.Text;
                    h.mahalesodor = textBox8.Text;

                    //اگر تعداد ارقام درست بود
                    if (textBox1.Text.Length == 10 && textBox2.Text.Length == 10 && textBox9.Text.Length == 10 && textBox6.Text.Length > 0)
                    {

                        //اگر تکراری نبود
                        if (bll.read(h) == false)
                        {

                            //اگر سنتان بالای 18 بود
                            if (bll.create(h))
                            {

                                MessageBox.Show("ثبت نام با موفقیت انجام شد");
                                gunaGroupBox1.Enabled = false;
                                CLEAR();
                                gunaGroupBox1.Enabled = false;
                                guna2Button4.Enabled = false;
                                guna2Button5.Enabled = false;
                                guna2Button6.Enabled = false;
                                guna2Button3.Enabled = false;
                                DGV();

                                //اگر زیر 18 سال بود
                            }
                            else
                            {
                                MessageBox.Show("سن شما کمتر از 18 سال است");
                            }

                        }
                        //اگر تکراری بود
                        else
                        {
                            MessageBox.Show("اطلاعات وارد شده تکراری است");
                        }

                        //اگر تعداد ارقام نادرست بود
                    }
                    else { MessageBox.Show("مقادیر صحیح نمی باشد"); }



                }
                else
                {
                    MessageBox.Show("لطفا اطلاعات خود را تکمیل کنید");
                }


            }

            //اگر ثبت نام نبود
            else if (!flagh)
            {

                h.shomarebime = textBox1.Text;
                h.shomarepersonely = textBox2.Text;
                h.name = textBox3.Text;
                h.family = textBox4.Text;
                h.namefather = textBox5.Text;
                h.shenasname = textBox6.Text;
                bll.datechangeage(h.date = dateTimePickerX1.Text);
                h.codemeli = textBox9.Text;
                h.job = textBox10.Text;
                h.mahalesodor = textBox8.Text;
                if (textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0 || textBox3.Text.Trim().Length == 0 || textBox4.Text.Trim().Length == 0 || textBox5.Text.Trim().Length == 0 || textBox6.Text.Trim().Length == 0 || dateTimePickerX1.Text.Trim().Length == 0 || textBox8.Text.Trim().Length == 0 || textBox9.Text.Trim().Length == 0 || textBox10.Text.Trim().Length == 0 || (radioButton1.Checked != true && radioButton2.Checked != true || radioButton3.Checked != true && radioButton4.Checked != true))
                {
                    MessageBox.Show("لطفا اطلاعات خود را تکمیل کنید");
                    return;
                }
                if (textBox1.Text.Length != 10 || textBox2.Text.Length != 10 || textBox9.Text.Length != 10)
                {
                    MessageBox.Show("مقادیر صحیح نمی باشد");
                    return;
                }

                if (bll.read(id, h) == true)
                {
                    MessageBox.Show("اطلاعات وارد شده تکراری است");
                    return;
                }
                if (bll.datechangeage(h.date) < 18)
                {
                    MessageBox.Show("سن شما کمتر از 18 سال است");
                    return;
                }
                if (bll.update(id, h))
                {
                    MessageBox.Show("ویرایش با موفقیت انجام شد");
                    CLEAR();
                    guna2Button7.Enabled = true;
                    gunaGroupBox1.Enabled = false;
                    guna2Button4.Enabled = false;
                    guna2Button5.Enabled = false;
                    guna2Button6.Enabled = false;
                    guna2Button3.Enabled = false;
                    gunaDataGridView1.DataSource = bll.read();
                    flagh = true;
                    DGV();
                }
            }

        }
        private void newform(object sender, EventArgs e)
        {

            gunaDataGridView1.Enabled = false;
            guna2Button6.Enabled = false;
            guna2Button5.Enabled = false;
            CLEAR();

            //flagh = true;

            gunaGroupBox1.Enabled = true;
            guna2Button4.Enabled = true;
            guna2Button3.Enabled = true;


        }
        private void update(object sender, EventArgs e)
        {
            if (id > 0)
            {
                guna2Button7.Enabled = false;
                guna2Button5.Enabled = false;
                h = bll.read(id);
                textBox1.Text = h.shomarebime;
                textBox2.Text = h.shomarepersonely;
                textBox3.Text = h.name;
                textBox4.Text = h.family;
                textBox5.Text = h.namefather;
                textBox6.Text = h.shenasname;
                dateTimePickerX1.Text = h.date;
                textBox8.Text = h.mahalesodor;
                textBox9.Text = h.codemeli;
                textBox10.Text = h.job;

                gunaGroupBox1.Enabled = true;
                guna2Button6.Enabled = false;
                guna2Button4.Enabled = true;
                guna2Button3.Enabled = true;
                flagh = false;
            }
            

        }
        private void moshakhasatekarkonan_Load(object sender, EventArgs e)
        {

            DGV();

        }
        private void ESC(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("آیا میخواهید از فرم خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    this.Close();

                }

            }
        }
        private void cansel(object sender, EventArgs e)
        {

            if (MessageBox.Show("تمامی اطلاعات فرم پاک خواهد شد", "لغو", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CLEAR();
                guna2Button7.Enabled = true;
                gunaDataGridView1.Enabled = false;
                gunaGroupBox1.Enabled = false;
                guna2Button4.Enabled = false;
                guna2Button5.Enabled = false;
                guna2Button6.Enabled = false;
                guna2Button3.Enabled = false;
            }
            gunaDataGridView1.Enabled = true;
        }
        public void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentRow != null)
            {
                id = Convert.ToInt32(gunaDataGridView1.Rows[gunaDataGridView1.CurrentRow.Index].Cells["id"].Value);

                //guna2Button4.Enabled = false;
                //guna2Button3.Enabled = false;

                guna2Button5.Enabled = true;
                guna2Button6.Enabled = true;
            }
        }
        private void delete(object sender, EventArgs e)
        {

            if (MessageBox.Show("اطلاعات این فیلد پاک شوند؟", "پرسش", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show(bll.delete(id));
                DGV();
                id = 0;
            }

        }
        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //??
            //comboBox1.Items
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("درحال بروزرسانی");

        }
        public static List<Model> text;
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            search search = new search();
            search.ShowDialog();
            gunaDataGridView1.DataSource = text;

        }
        private void CN(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                CLEAR();
                gunaGroupBox1.Enabled = true;
                guna2Button4.Enabled = true;
                guna2Button3.Enabled = true;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 10)
            {


                errorProvider1.SetError(textBox1, "تعداد اعداد وارد شده صحیح نمی باشد");
                // MessageBox.Show("تعداد اعداد وارد شده صحیح نمی باشد");

            }
            else { errorProvider1.Clear(); }

        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 10)
            {


                errorProvider1.SetError(textBox2, "تعداد اعداد وارد شده صحیح نمی باشد");
                // MessageBox.Show("تعداد اعداد وارد شده صحیح نمی باشد");

            }
            else { errorProvider1.Clear(); }
        }
        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text.Length != 10)
            {


                errorProvider1.SetError(textBox9, "تعداد اعداد وارد شده صحیح نمی باشد");
                // MessageBox.Show("تعداد اعداد وارد شده صحیح نمی باشد");

            }
            else { errorProvider1.Clear(); }
        }
        private void radioButton3_Click(object sender, EventArgs e)
        {

            if (flagh)
            {
                h.jens = radioButton3.Text;
            }


        }
        private void radioButton4_Click(object sender, EventArgs e)
        {

            if (flagh)
            {
                h.jens = radioButton4.Text;
            }

        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (flagh)
            {
                h.meleyat = radioButton2.Text;
            }
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (flagh)
            {
                h.meleyat = radioButton1.Text;
            }

        }
        private void guna2Button7_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Focus();
        }
        private void guna2Button4_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Focus();
        }
        private void guna2Button6_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Focus();
        }
        #region textBox_keyPress

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                e.Handled = true;

            else

                e.Handled = false;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                e.Handled = true;

            else

                e.Handled = false;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))

                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))

                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))

                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                e.Handled = true;

            else

                e.Handled = false;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))

                e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 'آ' || e.KeyChar > 'ی') && (e.KeyChar < 'a' || e.KeyChar > 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))

                if ((!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }

                

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                e.Handled = true;

            else

                e.Handled = false;
        }

        #endregion 
    }
}
