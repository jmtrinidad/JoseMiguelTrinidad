namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Entities;
   public interface IConvertHelper
    {
        UsuarioDto ToUsuarioDto(Usuario usuario);

        DepartamentoDto ToDepartamentoDto(Departamento departamento);

        Usuario ToUsuario(UsuarioDto usuario);
    }
}
