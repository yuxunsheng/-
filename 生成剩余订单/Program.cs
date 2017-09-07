using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 生成剩余订单
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// 这是为佶业公司编写的剩余订单生成软件，版本号为1.0.0；
        /// 如只修改数据库连接不修改版本号
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
