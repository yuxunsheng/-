using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 生成剩余订单
{
    public partial class Form1 : Form
    {
        private 数据库连接 连接;
        private 操作类 操作;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开加载窗体后发生,连接数据库,已知问题是,当连接数据库异常时,等待时机很长
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            连接 = new 数据库连接();
            bool 成功与否 = 连接.打开数据库();
            if (成功与否 == true)
            {
                this.label_连接反馈.ForeColor = Color.Black;
                this.label_连接反馈.Text = "连接成功";
                this.button_生成剩余订单.Enabled = true;
                try
                {
                    操作 = new 操作类(连接.getSqlCommand());
                }
                catch (Exception)
                {
                    this.label_连接反馈.ForeColor = Color.Red;
                    this.label_连接反馈.Text = "初始化异常";
                }
            }
            else
            {
                this.label_连接反馈.ForeColor = Color.Red;
                this.label_连接反馈.Text = "连接失败,请查看网络与服务器是否正常";
            }
            
            
        }

        /// <summary>
        /// 点击按钮后发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_生成剩余订单_Click(object sender, EventArgs e)
        {
            //打开文件夹选择器
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "选择需要保存的位置";
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            Directory.CreateDirectory(path + "\\剩余订单表");
            操作.开始生成订单();
            操作.保存表(path+ "\\剩余订单表");
            this.label_连接反馈.Text = "保存数据成功";
            
            
        }

        /// <summary>
        /// 关闭窗体时发生,关闭数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            连接.关闭数据库();
        }
    }
}
