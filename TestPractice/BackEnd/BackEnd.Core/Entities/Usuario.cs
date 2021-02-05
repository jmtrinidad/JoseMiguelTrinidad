namespace BackEnd.Core.Entities
{
    using System;

    public class Usuario:BaseEntity
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }
          
        public string Cedula { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }

        public DateTime Fecha_Nac { get; set; }

        public int DepartamentoId { get; set; }

        public Departamento Departamento { get; set; } 

        public string Supervisor_Inmediato { get; set; }

        public int CargoId { get; set; }

        public Cargo Cargo { get; set; }


    }
}
