using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MTR
{
    public partial class Form1 : Form
    {
        private string path;//选择框里面的文件路径
        public Form1()
        {
            InitializeComponent();
        }

        private void button_选择_Click(object sender, EventArgs e)
        {
            
            //选择文件
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "03Excel 文件|*.xls|07Excel 文件|*.xlsx";
                of.Title = "选择文件";
                of.ShowDialog();
                if(of.FileName!=null)
                {
                    this.路径.Text = of.SafeFileName;
                    this.path = of.FileName;
                }
            }

        }

        private void button_出货炉号_Click(object sender, EventArgs e)
        {


        }
    }
}
