namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Entities;
    interface IConvertHelper
    {
        UsuarioDto ToUsuarioDto(Usuario usuario);

        DepartamentoDto ToDepartamentoDto(Departamento departamento);
    }
}
