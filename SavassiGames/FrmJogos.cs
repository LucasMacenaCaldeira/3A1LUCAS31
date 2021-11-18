using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SavassiGames;

namespace SavassiGames
{
    public partial class FrmJogos : Form
    {
        public FrmJogos()
        {
            InitializeComponent();
        
        }

    

    
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtgjogos.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtjogo.Text = dtgjogos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtvendedor.Text = dtgjogos.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }


  
        Jogos objJogos = new Jogos();
     
        private void ExibirDados()
        {
            dtgjogos.DataSource = objJogos.ListarJogos();
        }

        private void limparcampos()
        {
            txtcodigo.Clear();
            txtjogo.Clear();
            txtvendedor.Clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            objJogos.codigo = int.Parse(txtcodigo.Text);
            objJogos.ExcluirJogo();
            MessageBox.Show("Jogo excluído com sucesso.");
            ExibirDados();
            limparcampos();
        }

     
     
        private void FrmJogos_Load(object sender, EventArgs e)
        {
            ExibirDados();
            
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            objJogos.codigo = int.Parse(txtcodigo.Text);

            objJogos.jogo = txtjogo.Text;
            objJogos.vendedor = txtvendedor.Text;

            objJogos.AlterarJogo();
            MessageBox.Show("Dados alterados com sucesso.");
            ExibirDados();
            limparcampos();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            objJogos.jogo = txtjogo.Text;
            objJogos.vendedor = txtvendedor.Text;


            objJogos.InserirJogo();

            MessageBox.Show("Dados enviados com sucesso.");
            dtgjogos.DataSource = objJogos.ListarJogos();
            limparcampos();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
