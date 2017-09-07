using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 公有类库;

namespace 生成剩余订单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            数据库连接 连接 = new 数据库连接();
            bool 成功与否 = 连接.打开数据库();
            if (成功与否 == true)
            {
                this.label_连接反馈.Text = "连接成功";
                this.button_生成剩余订单.Enabled = true;
            }
            else
            {
                this.label_连接反馈.ForeColor = Color.Red;
                this.label_连接反馈.Text = "连接失败,请查看网络与服务器是否正常";
            }
        }
    }
}
