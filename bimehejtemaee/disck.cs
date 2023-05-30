using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace bimehejtemaee
{
    public partial class disck : Form
    {
        public disck()
        {
            InitializeComponent();
        }

        #region Connection Strings
        private string BackUpConString = @"data source=.;initial catalog=bimyar;integrated security=True;multipleactiveresultsets=True"; // کانکشن استرینگ برای دسترسی به دیتابیس اصلی
        private string ReStoreConString = "Data Source=.;Initial Catalog=master;Integrated Security=True"; // کانکشن استرینگ برای دسترسی به دیتابیس مستر
        #endregion

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            gunaWinCircleProgressIndicator1.Visible = true;
            
            using (SqlConnection con = new SqlConnection(BackUpConString))
            {
                ServerConnection srvConn = new ServerConnection(con);
                Server srvr = new Server(srvConn);

                if (srvr != null)
                {
                    try
                    {
                        Backup bkpDatabase = new Backup();
                        bkpDatabase.Action = BackupActionType.Database;
                        bkpDatabase.Database = "bimyar"; // باید هم نام با دیتابیس برنامه تنظیم شود
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "BackUp File|*.araDB";
                        sfd.FileName = "BackUp_" + (DateTime.Now.ToShortDateString().Replace('/', '.'));
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            BackupDeviceItem bkpDevice = new BackupDeviceItem(sfd.FileName, DeviceType.File);
                            bkpDatabase.Devices.Add(bkpDevice);
                            bkpDatabase.SqlBackup(srvr);
                            MessageBox.Show("!فایل پشتیبان با موفقیت ذخیره شد", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception s) { MessageBox.Show("!لطفا فایل بشتیبان را در درایوی غیر از درایو ویندوز ذخیره کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }

            gunaWinCircleProgressIndicator1.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            gunaWinCircleProgressIndicator1.Visible = true;

                if (MessageBox.Show("!!!ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند \n !اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection.ClearAllPools();
                    using (SqlConnection con = new SqlConnection(ReStoreConString))
                    {
                        ServerConnection srvConn = new ServerConnection(con);
                        Server srvr = new Server(srvConn);

                        srvr.KillAllProcesses("bimyar");
                        if (srvr != null)
                        {
                            try
                            {
                                Restore rstDatabase = new Restore();
                                rstDatabase.Action = RestoreActionType.Database;
                                rstDatabase.Database = "bimyar"; // باید هم نام با دیتابیس برنامه تنظیم شود
                                OpenFileDialog opfd = new OpenFileDialog();
                                opfd.Filter = "BackUp File|*.araDB";

                                if (opfd.ShowDialog() == DialogResult.OK)
                                {
                                    BackupDeviceItem bkpDevice = new BackupDeviceItem(opfd.FileName, DeviceType.File);
                                    rstDatabase.Devices.Add(bkpDevice);

                                    rstDatabase.ReplaceDatabase = true;
                                    rstDatabase.SqlRestore(srvr);
                                    MessageBox.Show("!اطلاعات با موفقیت بازیابی شد", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception f)
                            {
                                MessageBox.Show(f.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            gunaWinCircleProgressIndicator1.Visible = false;

            }

      
    }


    }

