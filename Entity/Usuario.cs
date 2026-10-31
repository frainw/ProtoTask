using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoTask.Entity
{
    public class Usuario
    {
        public UInt32 Id {  get; set; }
        private String _usuarioName;
        private String _password;

        public String UsuarioName
        {
            get
            {
                return _usuarioName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value)) {
                    if (value.Length < 8 && value.Length > 20)
                    {
                        throw new ArgumentException("O usuarioName deve conter entre 8 e 20 caracteries");
                    }
                    else
                    {
                        _usuarioName = value;
                    }
                }
            }

        }
        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length < 8 && value.Length > 20)
                {
                    throw new ArgumentException("Senha deve conter entre 8 e 20 caracteries");
                }
                _password = value;
            }
        }

		public override String ToString()
		{
			return $"{Id} \n Usuario: {_usuarioName} \n senha{_password}";
		}
	}
}
