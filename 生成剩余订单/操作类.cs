using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生成剩余订单
{
    class 操作类
    {
        Dictionary<string, int> 排序索引 = new Dictionary<string, int>();
        int 排序总数=0;
        客户类 温哥华;
        客户类 夏洛特;
        客户类 BKT;
        客户类 KCA;

        public 操作类()
        {
            初始化排序();


        }

        private void 初始化排序()
        {         
            StreamReader srf = new StreamReader("排序文件.txt", Encoding.Unicode);
            string 每行字符串;
            while (!string.IsNullOrEmpty(每行字符串 = srf.ReadLine()))
            {
                string[] 切分字符 = 每行字符串.Split(',');
                排序索引.Add(切分字符[0], int.Parse(切分字符[1]));
                this.排序总数++;
            }
        }

    }
}
