namespace StrategyPattern
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
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_total = new System.Windows.Forms.Label();
            this.com_zk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_show = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(84, 29);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 21);
            this.txt_price.TabIndex = 0;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(84, 65);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 21);
            this.txt_qty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "单价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "数量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "总计：";
            // 
            // lab_total
            // 
            this.lab_total.AutoSize = true;
            this.lab_total.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_total.ForeColor = System.Drawing.Color.Red;
            this.lab_total.Location = new System.Drawing.Point(61, 435);
            this.lab_total.Name = "lab_total";
            this.lab_total.Size = new System.Drawing.Size(19, 19);
            this.lab_total.TabIndex = 8;
            this.lab_total.Text = "0";
            // 
            // com_zk
            // 
            this.com_zk.FormattingEnabled = true;
            this.com_zk.Items.AddRange(new object[] {
            "8折",
            "7折",
            "5折",
            "满100减25"});
            this.com_zk.Location = new System.Drawing.Point(84, 104);
            this.com_zk.Name = "com_zk";
            this.com_zk.Size = new System.Drawing.Size(100, 20);
            this.com_zk.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "折扣";
            // 
            // txt_show
            // 
            this.txt_show.FormattingEnabled = true;
            this.txt_show.ItemHeight = 12;
            this.txt_show.Location = new System.Drawing.Point(15, 164);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(306, 244);
            this.txt_show.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 493);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.com_zk);
            this.Controls.Add(this.lab_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_price);
            this.Name = "Form1";
            this.Text = "超市收银系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_total;
        private System.Windows.Forms.ComboBox com_zk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox txt_show;
    }
}

