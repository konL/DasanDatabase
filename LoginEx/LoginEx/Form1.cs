using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
   public void loginValidate() {
       Boolean bResult = false;
       int loginCount = 0;
            if (txtUserName.Text.Trim() == "" || string.IsNullOrEmpty(txtUserName.Text)) {
                MessageBox.Show("用户名不能为空!","登录提示");
                txtUserName.Focus();
            }else if(txtUserName.Text.Trim() == "" || string.IsNullOrEmpty(txtUserName.Text)){
                MessageBox.Show("密码不能为空!","登录提示");
                txtPassword.Focus();
            }else{
                SqlConnection con=new SqlConnection(DBHelper.conStr);
                try
                {
                    con.Open();
                    if ("admin".Equals(txtUserName.Text.Trim()))
                    {
                        //高级管理员可以进行的操作
                    }
                    else
                    {
                        //非高级
                        string sql = string.Format("select * from t_zg where " + "bh='{0}'and kl='{1}'", txtUserName.Text, txtPassword.Text);
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            LoginInfo.Bh = Convert.ToString(dr["bh"]);
                            LoginInfo.Xm = Convert.ToString(dr["xm"]);
                            LoginInfo.Qx = Convert.ToString(dr["qx"]);
                            LoginInfo.Bmbh = Convert.ToString(dr["bmbh"]);
                            LoginInfo.Zybh = Convert.ToString(dr["zybh"]);
                                //其他需要的
                            bResult = true;

                        }
                        else
                        {
                            loginCount++;
                            tips.ForeColor = Color.Red;
                            tips.Text = "第" + loginCount + "次输入密码错误";
                        }
                        dr.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally{con.Close();}
                //显示主窗体
                if(bResult){
                this.Visible=false;
                Frm_Main fm=new Frm_Main();
                fm.Show();
                }
                if(loginCount==3){
                MessageBox.Show("登陆错误次数超出限制，程序退出","登录提示");
                    Application.Exit();
                
                }
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "") 
                    loginValidate();
                else
                    SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginValidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
