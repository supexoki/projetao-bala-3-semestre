using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetao_bala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlPeao.Left = 0;
            pnlPeao.Top = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = txtComida.Text;

            cboComidas.Items.Add(x);
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            string mensagem = "Você vai comer ";
            mensagem += cboComidas.SelectedItem.ToString();
            mensagem += " e vai beber " + lstBebidas.SelectedItem.ToString();
            bool praViagem = chkViagem.Checked;

            if(praViagem)
            {
                mensagem += ".\nPra viagem!";
            }
            MessageBox.Show(mensagem, "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            tmrMover2.Start();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            
        }

        private void tmrMover2_Tick(object sender, EventArgs e)
        {

            pnlPeao.Left += pnlPeao.Width;

        }
    }
}
