//using StrategyPattern.Factory;
using StrategyPattern.Strategy;
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
            //简单工厂实现
            //var payMoney = DiscountFactory.GetDiscountinstance(com_zk.SelectedItem.ToString()).GetPaidAmount(total);

            //策略模式实现，客户端选择具体的策略
            //CashStrategy super;
            //switch (com_zk.SelectedItem.ToString())
            //{
            //    case "8折":
            //        super = new Discount(0.8);
            //        break;
            //    case "7折":
            //        super = new Discount(0.7);
            //        break;
            //    case "5折":
            //        super = new Discount(0.5);
            //        break;
            //    case "满100减25":
            //        super = new Reflow(100, 25);
            //        break;
            //    default:
            //        super = new Discount(1);
            //        break;
            //}
            //CashStrategyContext context = new CashStrategyContext(super);

            //策略模式实现,策略上下文选择具体的策略
            CashStrategyContext context = new CashStrategyContext(com_zk.SelectedItem.ToString());
            var payMoney = context.GetPayAMount(total);

            txt_show.Items.Add($"单价：{txt_price.Text} 数量：{txt_qty.Text} {com_zk.SelectedItem} 合计：{payMoney}");
            var money = Convert.ToDouble(lab_total.Text) + payMoney;
            lab_total.Text = money.ToString(); 
        }
    }
}
