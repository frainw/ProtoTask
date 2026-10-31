using Microsoft.EntityFrameworkCore;
using ProtoTask.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProtoTask.Persistence
{
    internal class UsuarioRepository
    {
        public void Save(Usuario usuario)
        {
            try
            {
                using (Repository repository = new Repository())
                {
                    if (usuario.Id == 0)
                    {
                        
						repository.Usuarios.Add(usuario);
                    }
                    else
                    {
                        repository.Usuarios.Entry(usuario).State = EntityState.Modified;
                    }

                    repository.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        public bool UsuarioExiste(Usuario usuario) {
            using (Repository repository = new Repository())
            {
                return repository.Usuarios.Any(u => usuario.UsuarioName == u.UsuarioName);
            }
        }

        public bool SenhaCorreta(Usuario usuario)
        {
            using(Repository repository = new Repository())
            {
                Usuario? usuario2 = repository.Usuarios.FirstOrDefault(u => u.UsuarioName == usuario.UsuarioName);

                if(usuario2 == null)
                {
                    return false;
                }

				return usuario.Password == usuario2.Password;
			}
        }

		public Usuario? GetUsuario(Usuario usuario)
        {
			using (Repository repository = new Repository())
			{
                return repository.Usuarios.Where(u => u.UsuarioName == usuario.UsuarioName).FirstOrDefault();
			}
		}

		public Usuario? FindbyId(UInt32 Id )
        {
            using(Repository repository = new Repository())
            {
                return repository.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
            }
        }
	}
}
