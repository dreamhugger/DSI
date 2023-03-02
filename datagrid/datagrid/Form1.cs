using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double vUnit, vTotal, total = 0;
            int qtd;
            string nome;

            nome = textProduto.Text;
            qtd = Convert.ToInt32(textQtd.Text);
            vUnit = Convert.ToDouble(textValor.Text);
            vTotal = qtd * vUnit;

            dataGridView1.Rows.Add(nome, vUnit, qtd, vTotal);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["ColumnTotal"].Value);
            }

            textTotal.Text = Convert.ToDouble(total).ToString("C");

        }
    }
}
