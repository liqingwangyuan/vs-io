namespace EC_TEST
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.skuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wslXsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wslThToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wslXsESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单据状态查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSkuPluEx = new System.Windows.Forms.Button();
            this.buttonSkuPlu = new System.Windows.Forms.Button();
            this.buttonEtp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(713, 171);
            this.textBox2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skuToolStripMenuItem,
            this.dgssToolStripMenuItem,
            this.wslXsToolStripMenuItem1,
            this.wslThToolStripMenuItem,
            this.wslXsESCToolStripMenuItem,
            this.单据状态查询ToolStripMenuItem,
            this.清空ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // skuToolStripMenuItem
            // 
            this.skuToolStripMenuItem.Name = "skuToolStripMenuItem";
            this.skuToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // dgssToolStripMenuItem
            // 
            this.dgssToolStripMenuItem.Name = "dgssToolStripMenuItem";
            this.dgssToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // wslXsToolStripMenuItem1
            // 
            this.wslXsToolStripMenuItem1.Name = "wslXsToolStripMenuItem1";
            this.wslXsToolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // wslThToolStripMenuItem
            // 
            this.wslThToolStripMenuItem.Name = "wslThToolStripMenuItem";
            this.wslThToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // wslXsESCToolStripMenuItem
            // 
            this.wslXsESCToolStripMenuItem.Name = "wslXsESCToolStripMenuItem";
            this.wslXsESCToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // 单据状态查询ToolStripMenuItem
            // 
            this.单据状态查询ToolStripMenuItem.Name = "单据状态查询ToolStripMenuItem";
            this.单据状态查询ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "返回信息展示：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(713, 58);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "{\"BgnDate\":\"2014-02-24 15:00:13\",\"EndDate\":\"2020-02-25 15:00:13\",\"PageNum\":1,\"Max" +
    "Counts\":100}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "输入参数：(请以接口文档中格式为标准)";
            // 
            // buttonSkuPluEx
            // 
            this.buttonSkuPluEx.Location = new System.Drawing.Point(398, 12);
            this.buttonSkuPluEx.Name = "buttonSkuPluEx";
            this.buttonSkuPluEx.Size = new System.Drawing.Size(111, 44);
            this.buttonSkuPluEx.TabIndex = 20;
            this.buttonSkuPluEx.Text = "辅助属性";
            this.buttonSkuPluEx.UseVisualStyleBackColor = true;
            this.buttonSkuPluEx.Click += new System.EventHandler(this.buttonEtp_Click);
            // 
            // buttonSkuPlu
            // 
            this.buttonSkuPlu.Location = new System.Drawing.Point(242, 12);
            this.buttonSkuPlu.Name = "buttonSkuPlu";
            this.buttonSkuPlu.Size = new System.Drawing.Size(102, 44);
            this.buttonSkuPlu.TabIndex = 21;
            this.buttonSkuPlu.Text = "商品档案";
            this.buttonSkuPlu.UseVisualStyleBackColor = true;
            this.buttonSkuPlu.Click += new System.EventHandler(this.buttonSkuPlu_Click);
            // 
            // buttonEtp
            // 
            this.buttonEtp.Location = new System.Drawing.Point(26, 12);
            this.buttonEtp.Name = "buttonEtp";
            this.buttonEtp.Size = new System.Drawing.Size(111, 44);
            this.buttonEtp.TabIndex = 22;
            this.buttonEtp.Text = "企业信息";
            this.buttonEtp.UseVisualStyleBackColor = true;
            this.buttonEtp.Click += new System.EventHandler(this.buttonSkuPluEx_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "说明:企业信息接口不校验输入参数（即全量查询并返回），商品档案和辅助属性需要按参数标准格式查询（即条件查询）。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(24, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "运行本程序前请先配置本程序根目录下的[EC-TEST.exe.config]文件中的接口地址[address]值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEtp);
            this.Controls.Add(this.buttonSkuPlu);
            this.Controls.Add(this.buttonSkuPluEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "电商接口调用示例程序";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem skuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wslXsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wslThToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wslXsESCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dgssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单据状态查询ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSkuPluEx;
        private System.Windows.Forms.Button buttonSkuPlu;
        private System.Windows.Forms.Button buttonEtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

