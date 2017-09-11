using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生成剩余订单
{
    class 产品类
    {
        private string _大类;
        private string _品名;
        private string _标准名;
        private string _尺寸;
        private string _订单号;
        private int _数量;

        public 产品类(string 大类, string 品名, string 标准名, string 尺寸, string 订单号, int 数量)
        {
            this._大类 = 大类;
            this._品名 = 品名;
            this._标准名 = 标准名;
            this._尺寸 = 尺寸;
            this._订单号 = 订单号;
            this._数量 = 数量;
        }

        public string 大类 { get => _大类; }
        public string 品名 { get => _品名; }
        public string 标准名 { get => _标准名; }
        public string 尺寸 { get => _尺寸; }
        public string 订单号 { get => _订单号; }
        public int 数量 { get => _数量; }
    }
}
