using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavassiGames
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJogos formJogos = new FrmJogos();
            formJogos.ShowDialog();
        }

    

     

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
