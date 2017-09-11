using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生成剩余订单
{
    class 订单类
    {
        private string _订单号;
        private DateTime _预交日期;
        private double 排序号;
        private List<产品类> 牙口 = new List<产品类>();
        private List<产品类> 法兰 = new List<产品类>();
        private List<产品类> HM = new List<产品类>();
        private List<产品类> 配件 = new List<产品类>();

        

        public void paixu()
        {
            牙口.Sort()
        }

        
    }
    
}
