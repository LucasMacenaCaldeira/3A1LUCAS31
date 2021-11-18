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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Login objlogin = new Login();

        private void btnEntrar_Click(object sender, EventArgs e)

        {
            
            if (objlogin.ValidarUsuario(txtUsuario.Text, txtSenha.Text))
            {

                this.Visible = false;
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
                this.Visible = true;

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos...","Falha no Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
