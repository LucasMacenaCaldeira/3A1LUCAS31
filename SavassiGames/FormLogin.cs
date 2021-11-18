using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SavassiGames.DTO;
using SavassiGames.BLL;

namespace SavassiGames.UI
{
    public partial class FormLogin : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Esqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            loginDTO.Usuario = txtusuario.Text;
            loginDTO.Usuario = txtsenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
                
            {
                FrmPrincipal frmprincipal = new FrmPrincipal();
                frmprincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o usuário e a senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
