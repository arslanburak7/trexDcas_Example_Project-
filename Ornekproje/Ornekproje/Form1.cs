using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StockDao _stockDao = new StockDao();
        private void Form1_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = _stockDao.GetAll();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _stockDao.Add(new Stock
            {
                Name = txbAddName.Text,
                StockAmount = Convert.ToInt32(txbAddStockAmount.Text)

            });
            MessageBox.Show("Stock Added!");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbUpdateName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbUpdateStockAmount.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value),
                Name = txbUpdateName.Text,
                StockAmount = Convert.ToInt32(txbUpdateStockAmount.Text)
            };

            _stockDao.Update(stock);

            MessageBox.Show("Stock Updated!");

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


            _stockDao.Delete(id);

            MessageBox.Show("Deleted");
        }


    }
}

