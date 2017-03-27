namespace LOGIN
{
    partial class Login_main
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
            this.LB_DMS_Login_ID = new System.Windows.Forms.Label();
            this.DMS_Login_panel = new System.Windows.Forms.Panel();
            this.Login_Cancel = new System.Windows.Forms.Button();
            this.Login_ServerCB = new System.Windows.Forms.ComboBox();
            this.LB_DMS_Login_Server = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Login_PWD_tb = new System.Windows.Forms.TextBox();
            this.LB_DMS_Login_PW = new System.Windows.Forms.Label();
            this.Login_ID_tb = new System.Windows.Forms.TextBox();
            this.Login_tabControl = new System.Windows.Forms.TabControl();
            this.Login_tabPage = new System.Windows.Forms.TabPage();
            this.Modify_tabPage = new System.Windows.Forms.TabPage();
            this.DMS_Modify_panel = new System.Windows.Forms.Panel();
            this.LoginMOD_ID_tb = new System.Windows.Forms.TextBox();
            this.LoginMOD_Button = new System.Windows.Forms.Button();
            this.LoginCancel_Button = new System.Windows.Forms.Button();
            this.LoginNEW_PWD_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginMOD_ServerCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginOLD_PWD_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DMS_Login_panel.SuspendLayout();
            this.Login_tabControl.SuspendLayout();
            this.Login_tabPage.SuspendLayout();
            this.Modify_tabPage.SuspendLayout();
            this.DMS_Modify_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_DMS_Login_ID
            // 
            this.LB_DMS_Login_ID.AutoSize = true;
            this.LB_DMS_Login_ID.Location = new System.Drawing.Point(42, 76);
            this.LB_DMS_Login_ID.Name = "LB_DMS_Login_ID";
            this.LB_DMS_Login_ID.Size = new System.Drawing.Size(72, 24);
            this.LB_DMS_Login_ID.TabIndex = 0;
            this.LB_DMS_Login_ID.Text = "帳   號 :";
            // 
            // DMS_Login_panel
            // 
            this.DMS_Login_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DMS_Login_panel.Controls.Add(this.Login_Cancel);
            this.DMS_Login_panel.Controls.Add(this.Login_ServerCB);
            this.DMS_Login_panel.Controls.Add(this.LB_DMS_Login_Server);
            this.DMS_Login_panel.Controls.Add(this.Login_Button);
            this.DMS_Login_panel.Controls.Add(this.Login_PWD_tb);
            this.DMS_Login_panel.Controls.Add(this.LB_DMS_Login_PW);
            this.DMS_Login_panel.Controls.Add(this.Login_ID_tb);
            this.DMS_Login_panel.Controls.Add(this.LB_DMS_Login_ID);
            this.DMS_Login_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DMS_Login_panel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DMS_Login_panel.Location = new System.Drawing.Point(3, 3);
            this.DMS_Login_panel.Name = "DMS_Login_panel";
            this.DMS_Login_panel.Size = new System.Drawing.Size(363, 253);
            this.DMS_Login_panel.TabIndex = 1;
            // 
            // Login_Cancel
            // 
            this.Login_Cancel.Location = new System.Drawing.Point(45, 187);
            this.Login_Cancel.Name = "Login_Cancel";
            this.Login_Cancel.Size = new System.Drawing.Size(106, 29);
            this.Login_Cancel.TabIndex = 5;
            this.Login_Cancel.Text = "取消";
            this.Login_Cancel.UseVisualStyleBackColor = true;
            this.Login_Cancel.Click += new System.EventHandler(this.DMS_Login_Cancel_Click);
            // 
            // Login_ServerCB
            // 
            this.Login_ServerCB.FormattingEnabled = true;
            this.Login_ServerCB.Location = new System.Drawing.Point(119, 31);
            this.Login_ServerCB.Name = "Login_ServerCB";
            this.Login_ServerCB.Size = new System.Drawing.Size(188, 32);
            this.Login_ServerCB.TabIndex = 1;
            // 
            // LB_DMS_Login_Server
            // 
            this.LB_DMS_Login_Server.AutoSize = true;
            this.LB_DMS_Login_Server.Location = new System.Drawing.Point(42, 34);
            this.LB_DMS_Login_Server.Name = "LB_DMS_Login_Server";
            this.LB_DMS_Login_Server.Size = new System.Drawing.Size(71, 24);
            this.LB_DMS_Login_Server.TabIndex = 5;
            this.LB_DMS_Login_Server.Text = "Server:";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(201, 187);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(106, 29);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "登入";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.DMS_Login_Button_Click);
            // 
            // Login_PWD_tb
            // 
            this.Login_PWD_tb.Location = new System.Drawing.Point(119, 120);
            this.Login_PWD_tb.Name = "Login_PWD_tb";
            this.Login_PWD_tb.PasswordChar = '*';
            this.Login_PWD_tb.Size = new System.Drawing.Size(188, 33);
            this.Login_PWD_tb.TabIndex = 3;
            // 
            // LB_DMS_Login_PW
            // 
            this.LB_DMS_Login_PW.AutoSize = true;
            this.LB_DMS_Login_PW.Location = new System.Drawing.Point(42, 123);
            this.LB_DMS_Login_PW.Name = "LB_DMS_Login_PW";
            this.LB_DMS_Login_PW.Size = new System.Drawing.Size(72, 24);
            this.LB_DMS_Login_PW.TabIndex = 2;
            this.LB_DMS_Login_PW.Text = "密   碼 :";
            // 
            // Login_ID_tb
            // 
            this.Login_ID_tb.Location = new System.Drawing.Point(119, 73);
            this.Login_ID_tb.Name = "Login_ID_tb";
            this.Login_ID_tb.Size = new System.Drawing.Size(188, 33);
            this.Login_ID_tb.TabIndex = 2;
            // 
            // Login_tabControl
            // 
            this.Login_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_tabControl.Controls.Add(this.Login_tabPage);
            this.Login_tabControl.Controls.Add(this.Modify_tabPage);
            this.Login_tabControl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Login_tabControl.Location = new System.Drawing.Point(12, 12);
            this.Login_tabControl.Name = "Login_tabControl";
            this.Login_tabControl.SelectedIndex = 0;
            this.Login_tabControl.Size = new System.Drawing.Size(377, 292);
            this.Login_tabControl.TabIndex = 6;
            // 
            // Login_tabPage
            // 
            this.Login_tabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Login_tabPage.Controls.Add(this.DMS_Login_panel);
            this.Login_tabPage.Location = new System.Drawing.Point(4, 29);
            this.Login_tabPage.Name = "Login_tabPage";
            this.Login_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Login_tabPage.Size = new System.Drawing.Size(369, 259);
            this.Login_tabPage.TabIndex = 0;
            this.Login_tabPage.Text = "登入";
            // 
            // Modify_tabPage
            // 
            this.Modify_tabPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Modify_tabPage.Controls.Add(this.DMS_Modify_panel);
            this.Modify_tabPage.Location = new System.Drawing.Point(4, 29);
            this.Modify_tabPage.Name = "Modify_tabPage";
            this.Modify_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Modify_tabPage.Size = new System.Drawing.Size(369, 259);
            this.Modify_tabPage.TabIndex = 1;
            this.Modify_tabPage.Text = "修改密碼";
            // 
            // DMS_Modify_panel
            // 
            this.DMS_Modify_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DMS_Modify_panel.Controls.Add(this.LoginMOD_ID_tb);
            this.DMS_Modify_panel.Controls.Add(this.LoginMOD_Button);
            this.DMS_Modify_panel.Controls.Add(this.LoginCancel_Button);
            this.DMS_Modify_panel.Controls.Add(this.LoginNEW_PWD_tb);
            this.DMS_Modify_panel.Controls.Add(this.label4);
            this.DMS_Modify_panel.Controls.Add(this.LoginMOD_ServerCB);
            this.DMS_Modify_panel.Controls.Add(this.label1);
            this.DMS_Modify_panel.Controls.Add(this.LoginOLD_PWD_tb);
            this.DMS_Modify_panel.Controls.Add(this.label2);
            this.DMS_Modify_panel.Controls.Add(this.label3);
            this.DMS_Modify_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DMS_Modify_panel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DMS_Modify_panel.Location = new System.Drawing.Point(3, 3);
            this.DMS_Modify_panel.Name = "DMS_Modify_panel";
            this.DMS_Modify_panel.Size = new System.Drawing.Size(363, 253);
            this.DMS_Modify_panel.TabIndex = 0;
            // 
            // LoginMOD_ID_tb
            // 
            this.LoginMOD_ID_tb.Location = new System.Drawing.Point(119, 56);
            this.LoginMOD_ID_tb.Name = "LoginMOD_ID_tb";
            this.LoginMOD_ID_tb.Size = new System.Drawing.Size(188, 33);
            this.LoginMOD_ID_tb.TabIndex = 9;
            // 
            // LoginMOD_Button
            // 
            this.LoginMOD_Button.Location = new System.Drawing.Point(201, 187);
            this.LoginMOD_Button.Name = "LoginMOD_Button";
            this.LoginMOD_Button.Size = new System.Drawing.Size(106, 29);
            this.LoginMOD_Button.TabIndex = 15;
            this.LoginMOD_Button.Text = "確定";
            this.LoginMOD_Button.UseVisualStyleBackColor = true;
            this.LoginMOD_Button.Click += new System.EventHandler(this.DMS_LoginMOD_Button_Click);
            // 
            // LoginCancel_Button
            // 
            this.LoginCancel_Button.Location = new System.Drawing.Point(45, 187);
            this.LoginCancel_Button.Name = "LoginCancel_Button";
            this.LoginCancel_Button.Size = new System.Drawing.Size(106, 29);
            this.LoginCancel_Button.TabIndex = 14;
            this.LoginCancel_Button.Text = "取消";
            this.LoginCancel_Button.UseVisualStyleBackColor = true;
            this.LoginCancel_Button.Click += new System.EventHandler(this.DMS_LoginCancel_Button_Click);
            // 
            // LoginNEW_PWD_tb
            // 
            this.LoginNEW_PWD_tb.Location = new System.Drawing.Point(119, 134);
            this.LoginNEW_PWD_tb.Name = "LoginNEW_PWD_tb";
            this.LoginNEW_PWD_tb.PasswordChar = '*';
            this.LoginNEW_PWD_tb.Size = new System.Drawing.Size(188, 33);
            this.LoginNEW_PWD_tb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "新密碼 :";
            // 
            // LoginMOD_ServerCB
            // 
            this.LoginMOD_ServerCB.FormattingEnabled = true;
            this.LoginMOD_ServerCB.Location = new System.Drawing.Point(119, 18);
            this.LoginMOD_ServerCB.Name = "LoginMOD_ServerCB";
            this.LoginMOD_ServerCB.Size = new System.Drawing.Size(188, 32);
            this.LoginMOD_ServerCB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Server:";
            // 
            // LoginOLD_PWD_tb
            // 
            this.LoginOLD_PWD_tb.Location = new System.Drawing.Point(119, 95);
            this.LoginOLD_PWD_tb.Name = "LoginOLD_PWD_tb";
            this.LoginOLD_PWD_tb.PasswordChar = '*';
            this.LoginOLD_PWD_tb.Size = new System.Drawing.Size(188, 33);
            this.LoginOLD_PWD_tb.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "舊密碼 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "帳   號 :";
            // 
            // Login_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(401, 316);
            this.Controls.Add(this.Login_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_main";
            this.Load += new System.EventHandler(this.Login_main_Load);
            this.DMS_Login_panel.ResumeLayout(false);
            this.DMS_Login_panel.PerformLayout();
            this.Login_tabControl.ResumeLayout(false);
            this.Login_tabPage.ResumeLayout(false);
            this.Modify_tabPage.ResumeLayout(false);
            this.DMS_Modify_panel.ResumeLayout(false);
            this.DMS_Modify_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_DMS_Login_ID;
        private System.Windows.Forms.Panel DMS_Login_panel;
        private System.Windows.Forms.Label LB_DMS_Login_PW;
        private System.Windows.Forms.TextBox Login_ID_tb;
        private System.Windows.Forms.ComboBox Login_ServerCB;
        private System.Windows.Forms.Label LB_DMS_Login_Server;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox Login_PWD_tb;
        private System.Windows.Forms.Button Login_Cancel;
        private System.Windows.Forms.TabControl Login_tabControl;
        private System.Windows.Forms.TabPage Login_tabPage;
        private System.Windows.Forms.TabPage Modify_tabPage;
        private System.Windows.Forms.Panel DMS_Modify_panel;
        private System.Windows.Forms.ComboBox LoginMOD_ServerCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginOLD_PWD_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginMOD_ID_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginNEW_PWD_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoginMOD_Button;
        private System.Windows.Forms.Button LoginCancel_Button;
    }
}