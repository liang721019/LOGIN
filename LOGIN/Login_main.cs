using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using function.lib;

namespace LOGIN
{
    public partial class Login_main : Form
    {

        init_function fun = new init_function();
        
        public Login_main()
        {
            InitializeComponent();
        }

        public virtual string Query_DB      //LOGIN登入用SQL語法
        {            
            set;
            get;
        }

        public virtual string ServerName
        {            
            get
            {
                return Login_ServerCB.Text;
            }            
        }

        public virtual string UID
        {
            get
            {
                return Login_ID_tb.Text ;
            }
        }

        public string ID_Login       //LOGIN登入用ID變數
        {
            set
            {
                Login_ID_tb.Text = value;
            }
            get
            {
                return Login_ID_tb.Text;
            }
        }

        public string App_LoginPW       //PW變數
        {
            set;
            get;
        }

        public virtual string App_LoginNewPW        //新PW變數 
        {
            set;
            get;
        }

        public virtual void V_login()       //開窗設定
        {
            //FileManager FM = new FileManager();
            //FM.DMS_Service_ENV = Login_ServerCB.Text;       //server
            //FM.DMS_UID = Login_ID_tb.Text;          //使用者ID
            //this.Hide();
            //FM.ShowDialog(this);
            //this.Close();
        }
        public virtual void V_login_Default()       //LOGIN需要用到的變數
        {
            App_LoginPW = fun.desEncrypt_A(Login_PWD_tb.Text, "naturalbiokeyLogin");
            
        }

        public virtual void PRD_login()     //PRD LOGIN虛擬判斷方法
        {
            V_login_Default();      //LOGIN需要用到的變數
            fun.ProductDB_ds(Query_DB);
            if (fun.ds_index.Tables[0].Rows.Count != 0)
            {                
                V_login();
            }
            else
            {
                MessageBox.Show("帳密不正確!!", this.Text);
            }            
        }

        private void Login_main_Load(object sender, EventArgs e)
        {
            this.Text = "Login System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;//視窗在中央打開
            Login_ServerCB.Items.Add("PRD");
            Login_ServerCB.Items.Add("QAS");
            Login_ServerCB.Items.Add("DEV");           
            LoginMOD_ServerCB.Items.Add("PRD");
            LoginMOD_ServerCB.Items.Add("QAS");
            LoginMOD_ServerCB.Items.Add("DEV");
        }

        private void DMS_Login_Button_Click(object sender, EventArgs e)     //登入
        {
            if (Login_ServerCB.Text != "")
            {
                if (Login_ServerCB.Text == "PRD")
                {
                    #region 內容
                    PRD_login();                    
                    
                    #endregion
                }
                else
                {
                    MessageBox.Show("伺服器目前沒開放!!\n請選擇其他伺服器", this.Text);
                }
                
            }
            else
            {
                MessageBox.Show("請選擇伺服器!!", this.Text);

            } 
        }

        private void DMS_Login_Cancel_Click(object sender, EventArgs e)     //取消
        {
            this.Close();
        }

        private void DMS_LoginMOD_Button_Click(object sender, EventArgs e)      //修改密碼<確定>
        {
            if (LoginMOD_ServerCB.Text != "")
            {                
                App_LoginPW = fun.desEncrypt_A(LoginOLD_PWD_tb.Text, "naturalbiokeyLogin");
                fun.Query_DB = @"exec [TEST_SLSYHI].[dbo].[SLS_DMS_Login] '" +
                                    LoginMOD_ID_tb.Text +
                                    @"','" + App_LoginPW + "'";
                fun.ProductDB_ds(fun.Query_DB);
                if (fun.ds_index.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("帳密不正確!!", this.Text);
                }
                else
                {
                    if (MessageBox.Show("確定要修改密碼？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        App_LoginNewPW = fun.desEncrypt_A(LoginNEW_PWD_tb.Text, "naturalbiokeyLogin");
                        fun.Query_DB = @"exec [TEST_SLSYHI].[dbo].[SLS_DMS_Login_ModifyPWD] '" +
                                        LoginMOD_ID_tb.Text +
                                        @"','" + App_LoginNewPW + "'";
                        fun.DMS_modify(fun.Query_DB);
                        if (!fun.Check_error)
                        {
                            MessageBox.Show("密碼修改成功!!", this.Text);
                            fun.clearAir(DMS_Modify_panel);
                            Login_tabControl.SelectedIndex = 0;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇伺服器!!", this.Text);
            }
        }

        private void DMS_LoginCancel_Button_Click(object sender, EventArgs e)       //修改密碼<取消>
        {
            fun.clearAir(DMS_Modify_panel);            
            Login_tabControl.SelectedIndex = 0;
        }
    }    
    
}
