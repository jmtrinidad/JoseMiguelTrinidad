using System.Collections.Generic;

namespace BackEnd.Core.Entities
{
    public class Genero:BaseEntity
    {
        public Genero()
        {
            Usuarios = new List<Usuario>();
        }
        public int Preferencia_Sexual { get; set; }

        public virtual List<Usuario> Usuarios { get; set; }
    }
}
