using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginEx
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void 退出TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 系统管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 库存管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult key = MessageBox.Show("确定要关闭窗体吗？", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel=(key==DialogResult.No);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            setRight();
            tslb_name.Text = "登录信息：欢迎您！" + LoginInfo.Xm;
            tslb_time.Text = DateTime.Now.ToString("yyyy年MM月dd日");
        }
        private void setRight()
        {
            //设置权限
            //管理员权限
            if ("0".Equals(LoginInfo.Qx))
            {
               
                MnuJh.Enabled = false;
                MnuXs.Enabled = false;
                MnuKc.Enabled = false;

            }
            else if ("20".Equals(LoginInfo.Qx))
            {
                //采购部负责人
                MnuXs.Enabled = false;
                MnuXt.Enabled = false;
            }
            else if ("30".Equals(LoginInfo.Qx))
            {
                //销售部负责人
                MnuJh.Enabled = false;
                MnuXt.Enabled = false;

            }
            else if ("21".Equals(LoginInfo.Qx))
            {
                //采购部普通员工
                //MnuFz.Enabled = false;
                MnuXs.Enabled = false;
                MnuXt.Enabled = false;
                MnuKc.Enabled = false;
            }
            else if ("31".Equals(LoginInfo.Qx))
            {
                //销售部普通员工}
                //MnuFz.Enabled = false;
                MnuJh.Enabled = false;
                MnuXt.Enabled = false;
                MnuKc.Enabled = false;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuZg_Click(object sender, EventArgs e)
        {
            FrmZG fmzg = new FrmZG();
            fmzg.Show();
        }

        private void MnuBm_Click(object sender, EventArgs e)
        {
            FrmBm fmBm = new FrmBm();
            fmBm.Show();

        }

        private void MnuZy_Click(object sender, EventArgs e)
        {
            FrmZy fmZy = new FrmZy();
            fmZy.Show();
        }

        private void MnuKhCys_Click(object sender, EventArgs e)
        {
            FrmKhGys fmKhGys = new FrmKhGys();
            fmKhGys.Show();
        }

        private void MnuSp_Click(object sender, EventArgs e)
        {
            FrmSp fmSp = new FrmSp();
            fmSp.Show();
        }
    }
}
