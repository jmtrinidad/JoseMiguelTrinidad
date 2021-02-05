namespace BackEnd.Core.Helpers
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    public class ConvertHelper : IConvertHelper
    {
        public DepartamentoDto ToDepartamentoDto(Departamento departamento)
        {
            return new DepartamentoDto
            {
                Id = departamento.Id,
                Nombre = departamento.Nombre,
            };
        }

        public UsuarioDto ToUsuarioDto(Usuario usuario)
        {
            return new UsuarioDto
            {
                Apellidos = usuario.Apellidos,
                Cargo = usuario.Cargo,
                Cedula = usuario.Cedula,
                DepartamentoId = usuario.DepartamentoId,
                Fecha_Nacimiento = usuario.Fecha_Nacimiento,
                Genero = usuario.Genero,
                Id = usuario.Id,
                Nombres = usuario.Nombres,
                Supervisor_Inmediato = usuario.Supervisor_Inmediato,
            };
        }
    }
}
