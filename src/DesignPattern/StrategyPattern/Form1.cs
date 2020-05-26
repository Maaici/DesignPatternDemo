using StrategyPattern.Factory;
using System;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txt_price.Text) * Convert.ToDouble(txt_qty.Text);
            var payMoney = DiscountFactory.GetDiscountinstance(com_zk.SelectedItem.ToString()).GetPaidAmount(total);
            txt_show.Items.Add($"单价：{txt_price.Text} 数量：{txt_qty.Text} {com_zk.SelectedItem.ToString()} 合计：{payMoney}");
            var money = Convert.ToDouble(lab_total.Text) + payMoney;
            lab_total.Text = money.ToString(); 
        }
    }
}
