using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ARK.SQL;
using ARK.MyInterface;

namespace ARK.Forms
{
    public partial class MainForm : Form
    {
        SQL_ADDITIONAL _count = new SQL_ADDITIONAL();
        MyButtonClick _button = new MyButtonClick();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label10.Text = _count.ProductCount();
            label9.Text = _count.ProducerCount();
            label7.Text = _count.BuyerCount();
            label8.Text = _count.SaleCount();
            label6.Text = _count.ReturnCount();
        }
    
        private void btt_addProduct_Click(object sender, EventArgs e)
        {
            _button.AddButton(sender, e, new addProduct().ShowDialog() == DialogResult.OK);
            label10.Text = _count.ProductCount();
        }

        private void btt_addSale_Click(object sender, EventArgs e)
        {
            _button.AddButton(sender, e, new addSale().ShowDialog() == DialogResult.OK);
            label8.Text = _count.SaleCount();
        }

        private void btt_addBuyer_Click(object sender, EventArgs e)
        {
            _button.AddButton(sender, e, new addBuyer().ShowDialog() == DialogResult.OK);
            label7.Text = _count.BuyerCount();
        }

        private void btt_addProducer_Click(object sender, EventArgs e)
        {
            _button.AddButton(sender, e, new addProducer().ShowDialog() == DialogResult.OK);
            label9.Text = _count.ProducerCount();
        }

        private void btt_addReturn_Click(object sender, EventArgs e)
        {
            _button.AddButton(sender, e, new addReturn().ShowDialog() == DialogResult.OK);
            label6.Text = _count.ReturnCount();
        }

        private void tsmi_product_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
        }

        private void tsmi_producer_Click(object sender, EventArgs e)
        {
            new ProducerForm().Show();
        }

        private void tsmi_buyer_Click(object sender, EventArgs e)
        {
            new BuyerForm().Show();
        }

        private void tsmi_Sale_Click(object sender, EventArgs e)
        {
            new SRForm().Show();
        }

        private void tsmi_setting_Click(object sender, EventArgs e)
        {
            new FormSetting().Show();
        }
    }
}
