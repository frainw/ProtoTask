using ProtoTask.Entity;
using ProtoTask.Persistence;

namespace ProtoTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // carga das tarefas do banc para o check list box
            //clbTarefas.DataSource = new TarefaRepository().FindAll();

            ReCarregar();
        }

        private void ReCarregar()
        {
            clbTarefas.Items.Clear();

            foreach (Tarefa t in new TarefaRepository().FindAll())
            {
                int index = clbTarefas.Items.Add(t.ToString());

                if (t.Concluida)
                {
                    clbTarefas.SetItemChecked(index, true);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Tarefa u = new Tarefa
            {
                Concluida = false,
                Descricao = txtPesquisa.Text,
                Limite = dtpLimite.Value
            };


            new TarefaRepository().Save(u);
            ReCarregar();
            txtPesquisa.Clear();

        }



        private void clbTarefas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selected = e.Index;
            if (selected > -1)
            {
                bool estaMarcado = e.NewValue == CheckState.Checked;
                string descricao = clbTarefas.Items[selected].ToString();

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

        private void radTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (radTodas.Checked && radNaoConcluidas.Checked == false)
            {
                radNaoConcluidas.Checked = false;
                ReCarregar();
            }
        }

        private void radNaoConcluidas_CheckedChanged(object sender, EventArgs e)
        {
            if (radNaoConcluidas.Checked && radTodas.Checked == false)
            {
                clbTarefas.Items.Clear();
                foreach (Tarefa tarefa in new TarefaRepository().FindByChecked(false))
                {
                    int index = clbTarefas.Items.Add(tarefa.ToString());

                    if (tarefa.Concluida)
                    {
                        clbTarefas.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Tarefa u = new Tarefa
                {
                    Concluida = false,
                    Descricao = txtPesquisa.Text,
                    Limite = dtpLimite.Value
                };


                new TarefaRepository().Save(u);
                ReCarregar();

                txtPesquisa.Clear();
            }
        }
    }
}