using Microsoft.EntityFrameworkCore;
using ProtoTask.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTask.Persistence
{
    public class TarefaRepository
    {
        public void Save(Tarefa tarefa)
        {
            try
            {
                using (Repository repository = new Repository())
                {
                   if (tarefa.Id == 0)
                    {
                        repository.Tarefas.Add(tarefa);
                    }
                    else
                    {
                        repository.Tarefas.Entry(tarefa).State = 
                            EntityState.Modified;
                    }
                   repository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Tarefa> FindAll()
        {
            try
            {
                using (Repository repository = new())
                {
                    return repository.Tarefas.ToList();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<Tarefa> FindByChecked(bool marcado)
        {

            try
            {
                using (Repository repository = new())
                {
                    return repository.Tarefas.Where(t => t.Concluida == marcado).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String[] FindByAuthor(UInt32 Id)
        {
            using(Repository repository = new Repository())
            {
                return repository.Tarefas.Where(t => t.UsuarioAutorId == Id).Select(t => t.Descricao.ToString()).ToArray();
            }
        }

    }
}
