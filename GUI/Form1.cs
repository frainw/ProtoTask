using ProtoTask.Entity;
using ProtoTask.Persistence;
using System.ComponentModel;

namespace ProtoTask
{
    public partial class Form1 : Form
    {
        private static Form1 _instace;
        private Form1()
        {
            InitializeComponent();
            Recarregar();
        }
        public static Form1 Instance(){
            if (_instace == null) { 
                _instace = new Form1();    
            }
            return _instace;
        }
        private void Recarregar()
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
            Recarregar();
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
                Recarregar();
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
                Recarregar();

                txtPesquisa.Clear();
            }
        }
    }
}