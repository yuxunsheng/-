using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace 生成剩余订单
{
    class 客户表类
    {
        string 客户名;
        Excel.Workbook wb;

        public 客户表类(string 客户名, Excel.Workbook wb)
        {
            this.客户名 = 客户名;
            this.wb = wb;
        }
    }
}
