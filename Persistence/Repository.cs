using Microsoft.EntityFrameworkCore;
using ProtoTask.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTask.Persistence
{
    public class Repository : DbContext
    {
        private string _connectionParams = @"server=127.0.0.1;port=3306;uid=root;pwd=aluno;database=gestaotarefas";

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public Repository() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
