using System.Collections.Generic;

namespace BackEnd.Core.Entities
{
    public class Cargo:BaseEntity
    {
        public Cargo()
        {
            Usuarios = new List<Usuario>();
        }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
