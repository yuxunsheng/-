using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 公有类库
{
    public class 数据库连接
    {
        private string 连接字符串;
        private SqlConnection conn;

        public 数据库连接()
        {
            this.连接字符串 = "server=192.168.31.188;uid=sa;pwd=Wdsjsme525;database=DB_FZJY";
        }

        public bool 打开数据库()
        {
            bool 连接成功与否 = true;
            try
            {
                this.conn = new SqlConnection(连接字符串);
                conn.Open();
            }
            catch (Exception)
            {
                连接成功与否 = false;
                conn.Close();
                conn.Dispose();
            }

            return 连接成功与否;

        }
        public void 关闭数据库()
        {
            conn.Close();
            conn.Dispose();
        }

        public SqlCommand getSqlCommand()
        {
            return conn.CreateCommand();
        }

    }
}
