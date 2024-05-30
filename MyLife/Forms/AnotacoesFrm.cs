using MyLife.API;
using MyLifeModel.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLife
{
    public partial class AnotacoesFrm : Form
    {
        public AnotacoesFrm()
        {
            InitializeComponent();
            BtnNovo.Text = "Novo";
            lblAnotacoes.Text = "Anotações";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "Nova anotação";
            rtbTexto.Text = "<Digite uma anotação>";
            lbAnotacoes.Items.Add(txtDescricao.Text);
            Anotacao anotacao = new Anotacao();
            anotacao.Descricao = txtDescricao.Text;
            anotacao.Texto = rtbTexto.Text;


            Api api = new Api();
            api.Add(anotacao);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
