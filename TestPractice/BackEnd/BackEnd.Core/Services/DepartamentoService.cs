namespace BackEnd.Core.Services
{
    using BackEnd.Core.DTOs;
    using BackEnd.Core.Entities;
    using BackEnd.Core.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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

        public Task<DepartamentoDto> GetDepartamentoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartamentoDto> GetDepartamentos()
        {
            var departamentos = _departamentoRepository.GetAll();
            var departamentoDtos = ConvertToDepartamentoDto(departamentos);
            return departamentoDtos;
        }
        public async Task InsertPostAsync(DepartamentoDto departamentoDto)
        {
            var departamento = new Departamento { Nombre = departamentoDto.Nombre };
           await _departamentoRepository.CreateAsync(departamento);
        }

        public Task<bool> UpdateDepartamentoAsync(DepartamentoDto departamentoDto)
        {
            throw new NotImplementedException();
        }
        private IEnumerable<DepartamentoDto> ConvertToDepartamentoDto(IEnumerable<Departamento> departamentos)
        {
            if (!departamentos.Any())
            {
                return new List<DepartamentoDto>();
            }
            else
            {
                return departamentos.Select(d => new DepartamentoDto { Id = d.Id, Nombre = d.Nombre });
            }


        }

       
    }
}
