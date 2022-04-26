namespace bk_restore
{
    partial class frm_Login
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
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbServer
            // 
            this.cbbServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(164, 43);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(171, 21);
            this.cbbServer.TabIndex = 0;
            this.cbbServer.DropDown += new System.EventHandler(this.cbbServer_SelectedIndexChangedAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(164, 70);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(171, 21);
            this.tbUser.TabIndex = 1;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(164, 105);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(171, 21);
            this.tbPass.TabIndex = 2;
            // 
            // pb_loading
            // 
            this.pb_loading.BackColor = System.Drawing.Color.Transparent;
            this.pb_loading.Image = global::bk_restore.Properties.Resources.kOnzy;
            this.pb_loading.Location = new System.Drawing.Point(197, 44);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(71, 62);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_loading.TabIndex = 4;
            this.pb_loading.TabStop = false;
            this.pb_loading.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = global::bk_restore.Properties.Resources.icons8_connected_32;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_connected_32;
            this.btnConnect.Location = new System.Drawing.Point(100, 170);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(99, 31);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Đăng nhập";
            this.btnConnect.Click += new System.EventHandler(this.login_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::bk_restore.Properties.Resources.icons8_connected_32;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.ImageOptions.Image = global::bk_restore.Properties.Resources.icons8_logout_32;
            this.btnExit.Location = new System.Drawing.Point(248, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.Location = new System.Drawing.Point(100, 138);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(91, 17);
            this.checkRemember.TabIndex = 7;
            this.checkRemember.Text = "Lưu mật khẩu";
            this.checkRemember.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 243);
            this.Controls.Add(this.checkRemember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pb_loading);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.label1);
            this.Name = "frm_Login";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.PictureBox pb_loading;
        private System.Windows.Forms.ComboBox cbbServer;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.CheckBox checkRemember;
    }
}