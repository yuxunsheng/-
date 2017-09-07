namespace 生成剩余订单
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
            this.label_连接反馈 = new System.Windows.Forms.Label();
            this.button_生成剩余订单 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_连接反馈
            // 
            this.label_连接反馈.AutoSize = true;
            this.label_连接反馈.Location = new System.Drawing.Point(13, 13);
            this.label_连接反馈.Name = "label_连接反馈";
            this.label_连接反馈.Size = new System.Drawing.Size(29, 12);
            this.label_连接反馈.TabIndex = 0;
            this.label_连接反馈.Text = "连接";
            // 
            // button_生成剩余订单
            // 
            this.button_生成剩余订单.AutoSize = true;
            this.button_生成剩余订单.Enabled = false;
            this.button_生成剩余订单.Location = new System.Drawing.Point(12, 50);
            this.button_生成剩余订单.Name = "button_生成剩余订单";
            this.button_生成剩余订单.Size = new System.Drawing.Size(222, 84);
            this.button_生成剩余订单.TabIndex = 1;
            this.button_生成剩余订单.Text = "生成剩余订单";
            this.button_生成剩余订单.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(246, 146);
            this.Controls.Add(this.button_生成剩余订单);
            this.Controls.Add(this.label_连接反馈);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成剩余订单";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_连接反馈;
        public System.Windows.Forms.Button button_生成剩余订单;
    }
}

