namespace MTR
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_选择 = new System.Windows.Forms.Button();
            this.路径 = new System.Windows.Forms.TextBox();
            this.button_出货炉号 = new System.Windows.Forms.Button();
            this.button_生成MTR = new System.Windows.Forms.Button();
            this.button_数据库 = new System.Windows.Forms.Button();
            this.button_历史出货 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件";
            // 
            // button_选择
            // 
            this.button_选择.Location = new System.Drawing.Point(70, 26);
            this.button_选择.Name = "button_选择";
            this.button_选择.Size = new System.Drawing.Size(61, 23);
            this.button_选择.TabIndex = 1;
            this.button_选择.Text = "选择";
            this.button_选择.UseVisualStyleBackColor = true;
            this.button_选择.Click += new System.EventHandler(this.button_选择_Click);
            // 
            // 路径
            // 
            this.路径.Location = new System.Drawing.Point(137, 27);
            this.路径.Name = "路径";
            this.路径.Size = new System.Drawing.Size(170, 21);
            this.路径.TabIndex = 2;
            // 
            // button_出货炉号
            // 
            this.button_出货炉号.Location = new System.Drawing.Point(25, 70);
            this.button_出货炉号.Name = "button_出货炉号";
            this.button_出货炉号.Size = new System.Drawing.Size(90, 28);
            this.button_出货炉号.TabIndex = 3;
            this.button_出货炉号.Text = "生成出货炉号表";
            this.button_出货炉号.UseVisualStyleBackColor = true;
            this.button_出货炉号.Click += new System.EventHandler(this.button_出货炉号_Click);
            // 
            // button_生成MTR
            // 
            this.button_生成MTR.Location = new System.Drawing.Point(152, 70);
            this.button_生成MTR.Name = "button_生成MTR";
            this.button_生成MTR.Size = new System.Drawing.Size(90, 28);
            this.button_生成MTR.TabIndex = 4;
            this.button_生成MTR.Text = "生成MTR";
            this.button_生成MTR.UseVisualStyleBackColor = true;
            // 
            // button_数据库
            // 
            this.button_数据库.Location = new System.Drawing.Point(25, 116);
            this.button_数据库.Name = "button_数据库";
            this.button_数据库.Size = new System.Drawing.Size(90, 28);
            this.button_数据库.TabIndex = 5;
            this.button_数据库.Text = "打开数据库";
            this.button_数据库.UseVisualStyleBackColor = true;
            // 
            // button_历史出货
            // 
            this.button_历史出货.Location = new System.Drawing.Point(152, 116);
            this.button_历史出货.Name = "button_历史出货";
            this.button_历史出货.Size = new System.Drawing.Size(90, 28);
            this.button_历史出货.TabIndex = 6;
            this.button_历史出货.Text = "打开历史出货记录";
            this.button_历史出货.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 180);
            this.Controls.Add(this.button_历史出货);
            this.Controls.Add(this.button_数据库);
            this.Controls.Add(this.button_生成MTR);
            this.Controls.Add(this.button_出货炉号);
            this.Controls.Add(this.路径);
            this.Controls.Add(this.button_选择);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "生成MTR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_选择;
        private System.Windows.Forms.TextBox 路径;
        private System.Windows.Forms.Button button_出货炉号;
        private System.Windows.Forms.Button button_生成MTR;
        private System.Windows.Forms.Button button_数据库;
        private System.Windows.Forms.Button button_历史出货;
    }
}

