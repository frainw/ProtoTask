using ProtoTask.Entity;
using ProtoTask.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProtoTask.GUI
{
    public partial class FormLogin : Form
    {
        public DialogResult ResultadoCadastro;
		
		public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                btnEntrar.Enabled = false;
                UsuarioRepository usuarioRepository = new UsuarioRepository();

                if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    Usuario usuario = new Usuario
                    {
                        UsuarioName = txtUsuario.Text,
                        Password = txtSenha.Text,
                    };



                    if (usuarioRepository.UsuarioExiste(usuario) == false)
                    {
                        DialogResult resultado = MessageBox.Show(
                            "Usuario nâo registrado registrar?",
                            "Confirmação",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question
                        );
                        if (resultado == DialogResult.OK)
                        {
                            ResultadoCadastro = DialogResult.None;
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            while (ResultadoCadastro != DialogResult.OK)
                            {
                                FormCadastro.GetCadastroInstance(this).ShowDialog();
                            }
                        }
                        else
                        {
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            txtUsuario.Focus();
                        }
                    }
                    else
                    {
						if (usuarioRepository.SenhaCorreta(usuario) == true)
						{
							this.Hide();
							FormPrincipal.Instance(this,usuarioRepository.GetUsuario(usuario).Id).Show();
							lblError.Visible = false;
							txtSenha.Clear();
							txtUsuario.Clear();
						}
						else
						{
							txtUsuario.SelectAll();
							txtUsuario.Focus();
							txtSenha.Clear();
							lblError.Visible = true;

						}
					}
                }
                else
                {
					lblError.Text = "Preencha todos os campos";
					lblError.Visible = true;                   
                }
            }
            finally
            {
                btnEntrar.Enabled = true;
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
