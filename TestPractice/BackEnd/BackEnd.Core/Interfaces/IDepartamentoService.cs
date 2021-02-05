namespace BackEnd.Core.Interfaces
{
    using BackEnd.Core.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IDepartamentoService
    {
        Task<bool> DeleteDepartamentoAsync(int id);
        Task<Departamento> GetDepartamentoByIdAsync(int id);
        IEnumerable<Departamento> GetDepartamentos();
        Task InsertPostAsync(Departamento departamento);
        Task<bool> UpdateDepartamentoAsync(Departamento departamento);
    }
}
