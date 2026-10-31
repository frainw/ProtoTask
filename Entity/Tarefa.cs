using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTask.Entity
{
    public class Tarefa
    {
        public UInt32 Id {  get; set; }
        private string descricao;
        public string Descricao 
        { 
            get 
            { 
                return descricao; 
            } 
            set 
            {
                if (value.Length < 3 || value.Length > 100)
                {
                    throw new ArgumentException("Descrição deve ter entre 3 e 100 caracteres");
                }
                descricao = value;
            } 
        }
        public Boolean Concluida { get; set; }
        public DateTime Limite { get; set; }

        public UInt32 UsuarioAutorId { get; set; }

		public override string ToString() { 
        
            return $"{Descricao} [" + Limite.ToShortDateString() + "]";
        }
    }
}
