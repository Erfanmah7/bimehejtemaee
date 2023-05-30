
namespace bimehejtemaee
{
    partial class disck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disck));
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaWinCircleProgressIndicator1 = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circularProgress1
            // 
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(161, 424);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.PieBorderDark = System.Drawing.Color.White;
            this.circularProgress1.ProgressColor = System.Drawing.Color.White;
            this.circularProgress1.Size = new System.Drawing.Size(44, 40);
            this.circularProgress1.SpokeBorderDark = System.Drawing.Color.White;
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 17;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DarkBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(52, 352);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(262, 51);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "بازیابی اطلاعات";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.BorderColor = System.Drawing.Color.White;
            this.guna2Button6.BorderRadius = 20;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.LightCoral;
            this.guna2Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.Location = new System.Drawing.Point(52, 295);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(262, 51);
            this.guna2Button6.TabIndex = 15;
            this.guna2Button6.Text = "تهیه فایل پشتیبان";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bimehejtemaee.Properties.Resources.BackupPic;
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gunaWinCircleProgressIndicator1
            // 
            this.gunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaWinCircleProgressIndicator1.Location = new System.Drawing.Point(156, 412);
            this.gunaWinCircleProgressIndicator1.Name = "gunaWinCircleProgressIndicator1";
            this.gunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.gunaWinCircleProgressIndicator1.Size = new System.Drawing.Size(55, 52);
            this.gunaWinCircleProgressIndicator1.TabIndex = 18;
            this.gunaWinCircleProgressIndicator1.Visible = false;
            // 
            // disck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 477);
            this.Controls.Add(this.gunaWinCircleProgressIndicator1);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "disck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دیسک";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator gunaWinCircleProgressIndicator1;
    }
}