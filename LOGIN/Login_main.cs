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

        LOGIN_function fun = new LOGIN_function();
        LOGIN_DS LOGINDS = new LOGIN_DS();
        
        public Login_main()
        {
            InitializeComponent();
        }

        private void Login_main_Load(object sender, EventArgs e)
        {
            this.Text = "Login System";
            fun.ServiceName = Login_ServerCB.Text.Trim();       //設定DB連線server
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;//視窗在中央打開
            Login_ServerCB.Items.Add("PRD");
            Login_ServerCB.Items.Add("QAS");
            Login_ServerCB.Items.Add("DEV");
            LoginMOD_ServerCB.Items.Add("PRD");
            LoginMOD_ServerCB.Items.Add("QAS");
            LoginMOD_ServerCB.Items.Add("DEV");
        }

        #region 變數
        //************************************************************************//
        public string Query_DB      //LOGIN登入用SQL語法
        {
            set;
            get;
        }

        public string Query_DB_LoginPW      //LOGIN修改密碼用SQL語法-舊
        {
            set;
            get;
        }

        public string Query_DB_LoginNewPW       //LOGIN修改密碼用SQL語法-新
        {
            set;
            get;
        }

        public string ServerName        //取得伺服器名稱
        {
            get
            {
                return Login_ServerCB.Text.Trim();
            }
        }

        public string UID           //取得LOGIN使用者ID
        {
            get
            {
                return Login_ID_tb.Text;
            }
        }

        public string ID_Login       //LOGIN登入用ID變數**
        {            
            get
            {
                return Login_ID_tb.Text;
            }
        }

        public string Modify_ID_Login       //取得LoginMOD_ID_tb字串
        {            
            get
            {
                return LoginMOD_ID_tb.Text;
            }            
        }

        public string App_LoginPW       //PW加密變數
        {
            set;
            get;
        }

        public string App_LoginOldPW        //舊PW變數
        {
            set;
            get;
        }

        public string App_LoginNewPW        //新PW變數 
        {
            set;
            get;
        }

        public LOGIN_DS LOD                  //dataset變數
        {            
            get
            {
                return LOGINDS;
            }
        }

        public DataTable LOD_DT             //Login登入用DataTable變數
        {
            set;
            get;
        }
        //************************************************************************//
        #endregion

        #region 方法
        //************************************************************************//        

        public virtual void V_login_open()       //開窗設定
        {
            
            //FileManager FM = new FileManager();
            //FM.DMS_Service_ENV = Login_ServerCB.Text;       //server
            //FM.DMS_UID = Login_ID_tb.Text;          //使用者ID
            //this.Hide();
            //FM.ShowDialog(this);
            //this.Close();
        }

        public virtual void V_login_SetENV()       //LOGIN設定變數用
        {
            App_LoginPW = fun.desEncrypt_A(Login_PWD_tb.Text, "naturalbiokeyLogin");
            Query_DB = @"";
        }

        public virtual void V_LOGPW_Modify_SetENV()       //ModifyPW設定變數用
        {
            App_LoginOldPW = fun.desEncrypt_A(LoginOLD_PWD_tb.Text, "naturalbiokeyLogin");
            App_LoginNewPW = fun.desEncrypt_A(LoginNEW_PWD_tb.Text, "naturalbiokeyLogin");
            Query_DB_LoginPW = @"exec [dbo].[SLS_LOGIN_Check] '" +
                                    Modify_ID_Login +
                                    @"','" + App_LoginOldPW + "'";
            Query_DB_LoginNewPW = @"exec [dbo].[SLS_LOGIN_ModifyPWD] '" +
                                    Modify_ID_Login +
                                    @"','" + App_LoginNewPW + "'";
        }

        public virtual void PRD_login()     //PRD LOGIN-虛擬判斷方法
        {
            //LOD_DT = LOD.SLS_QS_LOGIN;
            fun.ServiceName = Login_ServerCB.Text.Trim();       //設定DB連線server
            fun.Check_error = false;
            V_login_SetENV();      //LOGIN需要用到的變數            
            fun.LOGIN_Connection(Query_DB, LOD_DT);
            if (!fun.Check_error)
            {
                #region 內容
                //fun.ds_index.Tables[0].Rows.Count != 0
                if (LOD_DT.Rows.Count != 0)
                {
                    V_login_open();
                }
                else
                {
                    MessageBox.Show("密碼不正確!!", this.Text);
                }
                #endregion
            }
        }

        public virtual void DEV_login()     //DEV LOGIN-虛擬判斷方法
        {
            //LOD_DT = LOD.SLS_QS_LOGIN;
            //fun.ServiceName = Login_ServerCB.Text.Trim();       //設定DB連線server
            fun.Check_error = false;
            V_login_SetENV();      //LOGIN需要用到的變數
            fun.LOGIN_Connection(Query_DB, LOD_DT);
            if (!fun.Check_error)
            {
                #region 內容
                //fun.ds_index.Tables[0].Rows.Count != 0
                if (LOD_DT.Rows.Count != 0)
                {
                    V_login_open();
                }
                else
                {
                    MessageBox.Show("密碼不正確!!", this.Text);
                }
                #endregion
            }
        }

        public virtual void PRD_login_modify()          //PRD 修改密碼-虛擬判斷方法
        {
            #region 內容
            fun.Check_error = false;
            V_LOGPW_Modify_SetENV();       //ModifyPW設定變數用
            fun.LOGIN_Connection(Query_DB_LoginPW);            
            if (!fun.Check_error)
            {
                #region 內容
                if (fun.ds_index.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("帳號不存在or密碼不正確!!", this.Text);
                }
                else
                {
                    if (MessageBox.Show("確定要修改密碼？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        fun.LOGIN_Connection(Query_DB_LoginNewPW);
                        if (!fun.Check_error)
                        {
                            MessageBox.Show("密碼修改成功!!", this.Text);
                            fun.clearAir(DMS_Modify_panel);
                            Login_tabControl.SelectedIndex = 0;
                        }
                    }
                }
                #endregion
            }
            
            #endregion
        }

        public virtual void DEV_login_modify()          //DEV 修改密碼-虛擬判斷方法
        {
            #region 內容
            fun.Check_error = false;
            V_LOGPW_Modify_SetENV();       //ModifyPW設定變數用
            fun.LOGIN_Connection(Query_DB_LoginPW);
            if (!fun.Check_error)
            {
                #region 內容
                if (fun.ds_index.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("密碼不正確!!", this.Text);
                }
                else
                {
                    if (MessageBox.Show("確定要修改密碼？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        fun.LOGIN_Connection(Query_DB_LoginNewPW);
                        if (!fun.Check_error)
                        {
                            MessageBox.Show("密碼修改成功!!", this.Text);
                            fun.clearAir(DMS_Modify_panel);
                            Login_tabControl.SelectedIndex = 0;
                        }
                    }
                }
                #endregion
            }
            #endregion
        }

        private void SLS_Login()            //登入方法
        {
            #region 內容
            if (Login_ServerCB.Text != "")
            {
                if (Login_ServerCB.Text == "PRD")
                {                    
                    PRD_login();        //PRD LOGIN虛擬判斷方法                    
                }
                else if (Login_ServerCB.Text == "DEV")
                {
                    DEV_login();        //DEV LOGIN虛擬判斷方法 
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
            #endregion
        }

        private void SLS_LoginModify()         //修改密碼<確定>的方法
        {
            #region 內容

            if (LoginMOD_ServerCB.Text != "")
            {
                if (LoginMOD_ServerCB.Text == "PRD")
                {
                    PRD_login_modify();          //PRD 修改密碼-虛擬判斷方法
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
            #endregion
        }

        private void SLS_Login_Cancel()         //取消方法
        {
            this.Close();
        }

        private void SLS_LoginModify_Cancel()          //修改密碼<取消>的方法
        {
            fun.clearAir(DMS_Modify_panel);
            Login_tabControl.SelectedIndex = 0;
        }

        //************************************************************************//
        #endregion

        #region Button
        //************************************************************************//
        private void Login_Button_Click(object sender, EventArgs e)     //登入
        {
            SLS_Login();            //登入方法
        }

        private void Login_Cancel_Button_Click(object sender, EventArgs e)     //取消
        {
            SLS_Login_Cancel();         //取消方法            
        }

        private void LoginMOD_Button_Click(object sender, EventArgs e)      //修改密碼<確定>
        {
            SLS_LoginModify();         //修改密碼<確定>的方法
        }

        private void LoginModify_Cancel_Button_Click(object sender, EventArgs e)       //修改密碼<取消>
        {
            SLS_LoginModify_Cancel();          //修改密碼<取消>的方法            
        }

        //************************************************************************//
        #endregion

        #region 事件
        //************************************************************************//
        private void Login_tabControl_SelectedIndexChanged(object sender, EventArgs e)      //Login_tabControl切換分頁時的事件
        {
            if (Login_tabControl.SelectedIndex == 0)
            {
                Login_ServerCB.SelectedItem = LoginMOD_ServerCB.SelectedItem;
                Login_ID_tb.Text = LoginMOD_ID_tb.Text;
            }
            else if (Login_tabControl.SelectedIndex == 1)
            {
                LoginMOD_ServerCB.SelectedItem = Login_ServerCB.SelectedItem;
                LoginMOD_ID_tb.Text = Login_ID_tb.Text;
            }
        }
        //************************************************************************//
        #endregion
    }    
    
}
