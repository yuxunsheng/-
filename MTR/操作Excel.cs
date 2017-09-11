using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace MTR
{
    
    class 操作Excel
    {
        private Application app = new Application();
        private Dictionary<string, string> 品名 = new Dictionary<string, string>();
        private Dictionary<string, string> 尺寸 = new Dictionary<string, string>();
        private Dictionary<string, string> 客户 = new Dictionary<string, string>();

        public 操作Excel()
        {
            初始化品名();
            初始化尺寸();
            初始化客户();
            

        }

        private void 初始化品名()
        {
            品名.Add("G1", "G1");
            品名.Add("G2E", "G2E");
            品名.Add("G2DM", "G2-DM");
            品名.Add("G2ED", "G2-ED");
            品名.Add("G2250", "G2-250");
            品名.Add("G3", "G3");
            品名.Add("G3SW", "G3-SW");
            品名.Add("G3TSW", "G3-TSW");
            品名.Add("G3ED", "G3-ED");
            品名.Add("G3HDFS", "G3-HDFS");
            品名.Add("G3HDFSSW", "G3-HDFS-SW");
            品名.Add("G3HDFSTSW", "G3-HDFS-TSW");
            品名.Add("G3HD6G", "G3-HD-6G");
            品名.Add("G3HDPK", "G3-HDPK");
            品名.Add("G37", "G3-7");
            品名.Add("G3BW", "G3-BW");
            品名.Add("G3LL", "G3-LL");
            品名.Add("G4", "G4");
            品名.Add("CSSDR1", "CSSDR1");
            品名.Add("CSSDR15", "CSSDR1-5");
            品名.Add("CSCR2", "CSCR2");
            品名.Add("CSCR2DM", "CSCR2-DM");
            品名.Add("CSCR2250", "CSCR2-250");
            品名.Add("CSSF2", "CSSF2");
            品名.Add("CSSF3N", "CSSF3-N");
            品名.Add("CSSF3N250", "CSSF3-N-250");
            品名.Add("CSSF3NSW", "CSSF3-N-SW");
            品名.Add("CSSF3NSW250", "CSSF3-N-SW-250");
            品名.Add("CSSF3TSW", "CSSF3-N-TSW");
            品名.Add("CSSF3NTSW", "CSSF3-N-TSW");
            品名.Add("CSSF3HDFSN", "CSSF3-HDFS-N");
            品名.Add("CSSF3HDFSNSW", "CSSF3-HDFS-N-SW");
            品名.Add("CSSF3HDFSNTSW", "CSSF3-HDFS-N-TSW");//F3-HDFS-N-TSW标准名字已经改,原为F3-HDFS-TSW
            品名.Add("LSSR2", "LSSR2");

            品名.Add("HM3ART", "HM3-ART");
            品名.Add("HM3LRT", "HM3-LRT");
            品名.Add("HM3AFT", "HM3-AFT");
            品名.Add("HM3LFT", "HM3-LFT");
            品名.Add("HM3LFSW", "HM3-LFSW");
            品名.Add("HM3SFT", "HM3-SFT");
            品名.Add("HM6SFT", "HM6-SFT-P");
            品名.Add("HM6ART", "HM6-ART");
            品名.Add("HM6LRT", "HM6-LRT");
            品名.Add("HM6AFT", "HM6-AFT");
            品名.Add("HM6LFT", "HM6-LFT");
            品名.Add("3K19F", "3K19F");
            品名.Add("3K29F", "3K29F");
            品名.Add("6K19F", "6K19F");

            品名.Add("F150CSFSSFSN", "F150-CSF-SS-FS-N");
            品名.Add("F300CSFSSFSN", "F300-CSF-SS-FS-N");
            品名.Add("F600CSFSSFSN", "F600-CSF-SS-FS-N");
            品名.Add("F600CSFSSFSDN", "F600-CSF-SS-FS-D-N");
            品名.Add("F150CSRSSFSN", "F150-CSR-SS-FS-N");
            品名.Add("F300CSRSSFSN", "F300-CSR-SS-FS-N");
            品名.Add("F600CSRSSFSN", "F600-CSR-SS-FS-N");
            品名.Add("F150LCFSSFSN", "F150-LCF-SS-FS-N");
            品名.Add("F300LCFSSFSN", "F300-LCF-SS-FS-N");
            品名.Add("F600LCFSSFSN", "F600-LCF-SS-FS-N");
            品名.Add("F150LCRSSFSN", "F150-LCR-SS-FS-N");
            品名.Add("F300LCRSSFSN", "F300-LCR-SS-FS-N");
            品名.Add("F600LCRSSFSN", "F600-LCR-SS-FS-N");
            品名.Add("F150SSFFSN", "F150-SSF-FS-N");
            品名.Add("F300SSFFSN", "F300-SSF-FS-N");
            品名.Add("F600SSFFSN", "F600-SSF-FS-N");
            品名.Add("F150SSRFSN", "F150-SSR-FS-N");
            品名.Add("F300SSRFSN", "F300-SSR-FS-N");
            品名.Add("F600SSRFSN", "F600-SSR-FS-N");
        }
            
        private void 初始化尺寸()
        {
            //正常的英文引号
            尺寸.Add("1/4\"", "02");
            尺寸.Add("3/8\"", "03");
            尺寸.Add("1/2\"", "04");
            尺寸.Add("3/4\"", "06");
            尺寸.Add("1\"", "10");
            尺寸.Add("11/4\"", "12");
            尺寸.Add("1-1/4\"", "12");
            尺寸.Add("11/2\"", "15");
            尺寸.Add("1-1/2\"", "15");
            尺寸.Add("2\"", "20");
            尺寸.Add("21/2\"", "25");
            尺寸.Add("2-1/2\"", "25");
            尺寸.Add("3\"", "30");
            尺寸.Add("4\"", "40");
            尺寸.Add("6\"", "60");
            //中文”引号
            尺寸.Add("1/4”", "02");
            尺寸.Add("3/8”", "03");
            尺寸.Add("1/2”", "04");
            尺寸.Add("3/4”", "06");
            尺寸.Add("1”", "10");
            尺寸.Add("11/4”", "12");
            尺寸.Add("11/2”", "15");
            尺寸.Add("2”", "20");
            尺寸.Add("21/2”", "25");
            尺寸.Add("3”", "30");
            尺寸.Add("4”", "40");
            尺寸.Add("6”", "60");
            //中文“引号
            尺寸.Add("1/4“", "02");
            尺寸.Add("3/8“", "03");
            尺寸.Add("1/2“", "04");
            尺寸.Add("3/4“", "06");
            尺寸.Add("1“", "10");
            尺寸.Add("11/4“", "12");
            尺寸.Add("11/2“", "15");
            尺寸.Add("2“", "20");
            尺寸.Add("21/2“", "25");
            尺寸.Add("3“", "30");
            尺寸.Add("4“", "40");
            尺寸.Add("6“", "60");
        }

        private void 初始化客户()
        {
            //由于不同地址的客户实际上都MAS，所以我以目的港为判定依据
            客户.Add("VANCOUVER,B.C.,CANADA", "温哥华");
            客户.Add("VANCOUVERCANADA","温哥华");
            客户.Add("CHARLOTTEAMERICA", "夏洛特");           
            客户.Add("LONGBEACH,CA,U.S.A.","BKT");
            客户.Add("HOUSTON,AMERICA","KCA");

        }



        public string 生成出货炉号表(string path)  //外部可以调用此方法来生成出货炉号表，此方法会把出货炉号表保存在软件当前位置，此方法需要一个路径参数，并返回出货炉号表的路径位置
        {
            return null;
        }

        public string[] 生成MTR(string path)  //外部可以调用此方法来生成MTR,会保存在当前位置，此方法需要一个路径参数，并返回未找到的炉号
        {
            return null;
        }
    }
}
