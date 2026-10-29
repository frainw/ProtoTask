using Microsoft.EntityFrameworkCore;
using ProtoTask.Entity;
using System;
using System.Collections.Generic;
using System.Text;

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
        public Usuario? FindByUsuarioNameAndPassword(Usuario usuario)
        {
            try
            {
                using (Repository repository = new Repository())
                {
                    return repository.Usuarios.Where(u => u.UsuarioName == usuario.UsuarioName && u.Password == usuario.Password).FirstOrDefault();
                }
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
