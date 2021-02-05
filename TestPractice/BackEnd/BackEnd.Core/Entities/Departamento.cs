using System.Collections.Generic;

namespace BackEnd.Core.Entities
{
    public class Departamento : BaseEntity
    {
        public Departamento()
        {
            Usuarios = new List<Usuario>();
        }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
