namespace BackEnd.Core.Entities
{
    using System;

    public class Usuario:BaseEntity
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }
          
        public string Genero { get; set; }

        public string Cedula { get; set; } 


        public DateTime Fecha_Nacimiento { get; set; }

        public int DepartamentoId { get; set; }

        public Departamento Departamento { get; set; } 

        public string Cargo { get; set; }

        public string Supervisor_Inmediato { get; set; } 


    }
}
