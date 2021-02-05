using BackEnd.Core.Entities;
using BackEnd.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Core.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        
        public DepartamentoService(IDepartamentoRepository departamentoRepository)
        {
            this._departamentoRepository = departamentoRepository;
        }
        public Task<bool> DeleteDepartamentoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Departamento> GetDepartamentoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> GetDepartamentos()
        {
            return _departamentoRepository.GetAll();
        }

        public Task InsertPostAsync(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDepartamentoAsync(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}
