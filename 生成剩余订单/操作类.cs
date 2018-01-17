using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace 生成剩余订单
{
    class 操作类
    {
        
        SqlCommand cmd;
        SqlDataReader Reader;
        Dictionary<string, Excel.Workbook> listwb;
        Excel.Workbook wb;
        Excel.Application ExcelApp = new Excel.Application();
        

        public 操作类(SqlCommand sqlCommand )
        {
            this.cmd = sqlCommand;
            listwb = new Dictionary<string, Excel.Workbook>();
        }
        

        

        public void 开始生成订单()
        {
            生成表();
            cmd.CommandText = "SELECT ISNULL(C.NAME_ENG,B.PRD_NAME) as 品号," +
                "(CASE C.IDX1 WHEN '101' THEN 'C&G-Series' WHEN '102' THEN 'F-Series'  WHEN '103' THEN 'HM-Series' ELSE 'PARTS' END)AS 中类," +
                "'#'+A.CUS_OS_NO AS 客户订单号,(CASE A.CUS_NO WHEN 'A001' THEN '温哥华' WHEN 'A002' THEN '夏洛特'  WHEN 'A003' THEN 'BKT'  WHEN 'A004' THEN 'KCA' END) AS 客户," +
                "B.EST_DD 预交日,(ISNULL(B.QTY,0)-ISNULL(B.QTY_PS,0)) AS 数量, (CAST (SPC as varchar(8))) AS 排序" +
                " FROM MF_POS AS A, TF_POS AS B, PRDT AS C" +
                " WHERE B.OS_NO IN(SELECT OS_NO FROM MF_POS WHERE OS_ID LIKE 'SO' AND CLS_ID != 'T') " +
                "AND A.OS_NO = B.OS_NO AND ISNULL(B.QTY,0)!= ISNULL(B.QTY_PS, 0) AND B.PRD_NO = C.PRD_NO" +
                " ORDER BY  排序,品号";
            Reader = cmd.ExecuteReader();
            写入数据();




        }

        public void 保存表(string path)
        {
            foreach(var item in listwb)
            {
                item.Value.SaveAs(path + "\\" + item.Key.ToString()+".xlsx");
            }
            ExcelApp.Workbooks.Close();
            ExcelApp.Quit();
        }

        private void 生成表()
        {
            cmd.CommandText = "SELECT  DISTINCT  (CASE A.CUS_NO WHEN 'A001' THEN '温哥华' WHEN 'A002' THEN '夏洛特'  WHEN 'A003' THEN 'BKT'  WHEN 'A004' THEN 'KCA' END) AS 客户," +
                "(CASE C.IDX1 WHEN '101' THEN 'C&G-Series' WHEN '102' THEN 'F-Series'  WHEN '103' THEN 'HM-Series' ELSE 'PARTS' END)AS 中类" +
                " FROM MF_POS AS A, TF_POS AS B, PRDT AS C" +
                " WHERE B.OS_NO IN(SELECT OS_NO FROM MF_POS WHERE OS_ID LIKE 'SO' AND CLS_ID != 'T') AND A.OS_NO = B.OS_NO AND ISNULL(B.QTY,0)!= ISNULL(B.QTY_PS, 0) " +
                " AND B.PRD_NO = C.PRD_NO AND A.CUS_NO IN('A001','A002','A003','A004') "+
                " ORDER BY 客户 DESC ,中类 DESC";
            Reader = cmd.ExecuteReader();
            while(Reader.Read())
            {
                var 客户 = Reader["客户"];
                var 中类 = Reader["中类"];
                if(listwb.ContainsKey(客户.ToString()))
                {
                    wb = listwb[客户.ToString()];
                    Excel.Worksheet ws = wb.Worksheets.Add();
                    ws.Name = 中类.ToString();
                    写入表头数据(ws);
                }
                else
                {
                    Excel.Workbook wb;
                    wb = ExcelApp.Workbooks.Add();
                    wb.Worksheets[1].name = 中类.ToString();
                    Excel.Worksheet ws = wb.Worksheets[1];
                    写入表头数据(ws);
                    listwb.Add(客户.ToString(), wb);
                }
            }
            Reader.Close();
        }

        private void 写入数据()
        {
            Excel.Workbook wb;
            Excel.Worksheet ws;
            while (Reader.Read())
            {
                var 品号 = Reader["品号"];
                var 中类 = Reader["中类"];
                var 客户订单号 = Reader["客户订单号"];
                var 客户 = Reader["客户"];
                var 预交日 = Reader["预交日"];
                var 数量 = Reader["数量"];
                var 排序 = Reader["排序"];
                string 尺寸 = Get尺寸(排序.ToString());
                if (客户.ToString()!="")
                {
                    wb = listwb[客户.ToString()];
                    ws = wb.Worksheets[中类.ToString()];
                    int 列 = 1;
                    int 行 = 3;
                    string 当前表品名 = "";
                    string 当前表尺寸 = "";
                    string 当前表客户订单 = "";
                    do
                    {
                        当前表品名 = ws.Cells[行, 1];
                        if (品号.ToString() == 当前表品名)
                        {
                            do
                            {
                                当前表尺寸 = ws.Cells[行, 2];
                                if(尺寸==当前表尺寸)
                                {

                                }
                            }while()
                            
                        }
                    } while (当前表品名 == "" && 当前表尺寸 == "");
                }
                    
                


            }
        }

        private void 写入表头数据(Excel.Worksheet ws )
        {
            ws.Cells.Font.Name = "Arial";
            ws.Cells[1, 1] = "JY Valve & Mfg. Co., Ltd.";
            ws.Cells[2, 1] = "Updated Delivery Schedule on outstanding orders - " + ws.Name;
            ws.Cells[4, 1] = "ITEM";
            ws.Cells[4, 2] = "SIZE";
        }

        private string Get尺寸(string s)
        {
            string 比对字符;
            string 尺寸 = "";
            string[] 字符数组 = s.Split('.');
            
            if(字符数组.Count() > 1)
            {
                比对字符 = 字符数组[1];
                switch (比对字符)
                {
                    case "00":
                        尺寸 = "";
                        break;
                    case "02":
                        尺寸 = "1/2\"";
                        break;
                    case "03":
                        尺寸 = "3/8\"";
                        break;
                    case "04":
                    case "05":
                        尺寸 = "1/2\"";
                        break;
                    case "06":
                    case "07":                       
                        尺寸 = "3/4\"";
                        break;
                    case "10":
                        尺寸 = "1\"";
                        break;
                    case "12":
                        尺寸 = "11/4\"";
                        break;
                    case "15":
                        尺寸 = "11/2\"";
                        break;
                    case "20":
                        尺寸 = "2\"";
                        break;                   
                    case "25":
                        尺寸 = "21/2\"";
                        break;
                    case "30":
                        尺寸 = "3\"";
                        break;
                    case "40":
                        尺寸 = "4\"";
                        break;
                    case "60":
                        尺寸 = "6\"";
                        break;
                }
            }
                
            return 尺寸;
        }
        

        

    }
}
