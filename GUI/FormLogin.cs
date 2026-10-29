using ProtoTask.Entity;
using ProtoTask.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProtoTask.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                UsuarioName = txtUsuario.Text,
                Password = txtSenha.Text,
            };

            UsuarioRepository usuarioRepository = new UsuarioRepository();

            if (usuarioRepository.FindByUsuarioNameAndPassword(usuario) == null)
            {
                DialogResult resultado = MessageBox.Show(
                    "Usuario nâo registrado registrar?",
                    "Confirmação",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
                if (resultado == DialogResult.OK)
                {
                    usuarioRepository.Save(usuario);
                    this.Hide();
                    Form1.Instance().Show();
                }
                else
                {
                    usuario = null;
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
            else
            {
                usuarioRepository.Save(usuario);
                this.Hide();
                Form1.Instance().Show();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
