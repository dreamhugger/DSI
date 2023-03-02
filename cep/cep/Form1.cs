using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            CEP_CorreioService(txtCep.Text);
        }

        private void CEP_CorreioService(String CEP)
        {
            try
            {
                CorreiosRef.AtendeClienteClient correios = new CorreiosRef.AtendeClienteClient();
                CorreiosRef.enderecoERP consulta = correios.consultaCEP(CEP);

                if (consulta != null) {
                    txtRua.Text = consulta.end;
                    txtBairro.Text = consulta.bairro;
                    txtCidade.Text = consulta.cidade;
                    txtEstado.Text = consulta.uf;

                    txtNumero.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Cep não encontrado!");
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
