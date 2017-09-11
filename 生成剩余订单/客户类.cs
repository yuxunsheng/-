using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生成剩余订单
{
    class 客户类
    {
        private string _客户名;
        private List<订单类> 订单 = new List<订单类>();
        

        public 客户类(string 客户名)
        {
            this._客户名 = 客户名;
        }

        public string 客户名 { get => _客户名; }
    }
}
