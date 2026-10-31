using ProtoTask.Entity;
using ProtoTask.GUI;
using ProtoTask.Persistence;
using System.ComponentModel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProtoTask
{
	public partial class FormPrincipal : Form
	{
		//Criando variaveis
		private static FormPrincipal? _instance;
		private UInt32 _ultimoUsuarioId;

		private FormLogin _login;
		private AutoCompleteStringCollection listaSugestoes = new AutoCompleteStringCollection();

		private FormPrincipal(FormLogin formLogin, UInt32 ultimoLogin)
		{
			//Iniciando
			InitializeComponent();
			radTodas.Checked = true;

			//Atribundo valor nas variaveis
			_ultimoUsuarioId = ultimoLogin;
			_login = formLogin;
			tlsUsuario.Text = $"Login: {new UsuarioRepository().FindbyId(_ultimoUsuarioId).UsuarioName} || Data: {DateTime.Now}";
			Recarregar();

			//Configurando o Auto Completar
			txtPesquisa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtPesquisa.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txtPesquisa.AutoCompleteCustomSource = listaSugestoes;

		}

		//Metodo que Inicia uma instancia do Singleton
		public static FormPrincipal Instance(FormLogin login, UInt32 ultimoLogin)
		{
			if (_instance == null || _instance.IsDisposed)
			{
				_instance = new FormPrincipal(login, ultimoLogin);
			}

			return _instance;
		}

		//Metodo que recarrega Check List Box
		public void Recarregar()
		{
			clbTarefas.Items.Clear();
			//Altualiza AutoCompleta
			listaSugestoes.AddRange(new TarefaRepository().FindByAuthor(_ultimoUsuarioId));

			if (radTodas.Checked)
			{
				foreach (Tarefa tarefa in new TarefaRepository().FindAll())
				{
					if (tarefa.UsuarioAutorId == _ultimoUsuarioId)
					{
						int index = clbTarefas.Items.Add(tarefa.ToString());

						if (tarefa.Concluida)
						{
							clbTarefas.SetItemChecked(index, true);
						}
					}
				}
			}
			if (radNaoConcluidas.Checked)
			{

				foreach (Tarefa tarefa in new TarefaRepository().FindByChecked(false))
				{
					if (tarefa.UsuarioAutorId == _ultimoUsuarioId)
					{
						int index = clbTarefas.Items.Add(tarefa.ToString());
						clbTarefas.SetItemChecked(index, false);
					}
				}

			}

		}

		//Programando elementos e Butõens
		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			if (txtPesquisa.Text.Length > 3 && txtPesquisa.Text.Length < 100 && dtpLimite.Value > DateTime.Today)
			{
				Tarefa u = new Tarefa
				{
					Concluida = false,
					Descricao = txtPesquisa.Text,
					Limite = dtpLimite.Value,
					UsuarioAutorId = _ultimoUsuarioId
				};


				new TarefaRepository().Save(u);
				Recarregar();
				txtPesquisa.Clear();
				dtpLimite.Value = DateTime.Today;
			}
			else
			{
				lblError.Visible = true;
				Recarregar();
				txtPesquisa.Clear();
				dtpLimite.Value = DateTime.Today;
			}
		}



		private void clbTarefas_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int selected = e.Index;
			if (selected > -1)
			{
				bool estaMarcado = e.NewValue == CheckState.Checked;
				var descricao = clbTarefas.Items[selected].ToString();

				TarefaRepository tarefaRepository = new TarefaRepository();

				foreach (Tarefa tarefa in tarefaRepository.FindAll())
				{
					if (descricao == tarefa.ToString())
					{
						tarefa.Concluida = estaMarcado;
						tarefaRepository.Save(tarefa);
						break;
					}
				}
			}
		}



		private void radNaoConcluidas_CheckedChanged(object sender, EventArgs e)
		{
			Recarregar();
		}
		private void radTodas_CheckedChanged(object sender, EventArgs e)
		{
			Recarregar();
		}

		private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || string.IsNullOrWhiteSpace(txtPesquisa.Text))
			{
				clbTarefas.Items.Clear();
				if (radTodas.Checked)
				{
					foreach (Tarefa tarefa in new TarefaRepository().FindAll())
					{
						if (tarefa.UsuarioAutorId == _ultimoUsuarioId && tarefa.Descricao.ToLower().Contains(txtPesquisa.Text.ToLower()))
						{
							int index = clbTarefas.Items.Add(tarefa.ToString());

							if (tarefa.Concluida)
							{
								clbTarefas.SetItemChecked(index, true);
							}
						}
					}
				}
				if (radNaoConcluidas.Checked)
				{
					foreach (Tarefa tarefa in new TarefaRepository().FindByChecked(false))
					{
						if (tarefa.UsuarioAutorId == _ultimoUsuarioId && tarefa.Descricao.ToLower().Contains(txtPesquisa.Text.ToLower()))
						{
							int index = clbTarefas.Items.Add(tarefa.ToString());

							if (tarefa.Concluida)
							{
								clbTarefas.SetItemChecked(index, true);
							}
						}
					}

				}
			}
		}


		private void sairDaContaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			_login.Show();
		}

		private void sairParaOWindowsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			_login.Close();
		}

		private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			_login.Close();
		}
	}
}
