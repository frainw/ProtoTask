using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTask.Entity
{
    public class Tarefa
    {
        public UInt32 Id {  get; set; }
        public string _descricao;
        public string Descricao 
        { 
            get 
            { 
                return _descricao; 
            } 
            set 
            {
                if (value.Length < 3 || value.Length > 100)
                {
                    throw new ArgumentException("Descrição deve ter entre 3 e 100 caracteres");
                }
                _descricao = value;
            } 
        }
        public bool Concluida { get; set; }
        public DateTime Limite { get; set; }

        public override string ToString()
        {
            return $"{Descricao} [" + Limite.ToShortDateString() + "]";
        }
    }
}
