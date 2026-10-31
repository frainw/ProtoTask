using ProtoTask.Entity;
using ProtoTask.GUI;
using ProtoTask.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProtoTask
{
	public partial class FormCadastro : Form
	{
		private static FormCadastro? _instance;
		private FormLogin _login;
		private Boolean visivel = false;
		private FormCadastro(FormLogin formlogin)
		{
			_login = formlogin;
			InitializeComponent();
		}
		public static FormCadastro GetCadastroInstance(FormLogin formlogin)
		{
			if (_instance == null || _instance.IsDisposed)
			{
				_instance = new FormCadastro(formlogin);
			}
			return _instance;
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtSenha.Text)) {
					btnConfirmar.Enabled = false;
					Usuario usuario = new Usuario
					{
						UsuarioName = txtUsuario.Text,
						Password = txtSenha.Text,
					};

					if (new UsuarioRepository().UsuarioExiste(usuario) == true)
					{
						lblError.Visible = true;
						txtUsuario.Focus();
						txtUsuario.SelectAll();
					}
					else
					{

						new UsuarioRepository().Save(usuario);
						this.Close();
						txtSenha.Clear();
						txtUsuario.Clear();
						_login.ResultadoCadastro = DialogResult.OK;
						lblError.Visible = false;
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
				btnConfirmar.Enabled = true;
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			txtSenha.Clear();
			txtUsuario.Clear();
			txtUsuario.Focus();
			lblError.Visible = false;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
			txtSenha.Clear();
			txtUsuario.Clear();
			_login.ResultadoCadastro = DialogResult.OK;
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
				btnConfirmar.Focus();
			}
		}

		private void btnRevelar_Click(object sender, EventArgs e)
		{
			

			if (visivel == false)
			{
				txtSenha.UseSystemPasswordChar = false;
				txtSenha.PasswordChar = '\0';
				visivel = true;
			}
			else
			{
				txtSenha.UseSystemPasswordChar = true;
				txtSenha.PasswordChar = '•';
				visivel = false;
			}
		}
	}
}
