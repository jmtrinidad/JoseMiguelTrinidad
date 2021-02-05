namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.DTOs;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IDepartamentoService
    {
        Task<bool> DeleteDepartamentoAsync(int id);
        Task<DepartamentoDto> GetDepartamentoByIdAsync(int id);
        IEnumerable<DepartamentoDto> GetDepartamentos();
        Task InsertPostAsync(DepartamentoDto departamentoDto);
        Task<bool> UpdateDepartamentoAsync(DepartamentoDto departamentoDto);
    }
}
