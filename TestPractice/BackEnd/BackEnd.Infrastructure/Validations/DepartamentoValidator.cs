using BackEnd.Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Infrastructure.Validations
{
    class DepartamentoValidator : AbstractValidator<Departamento>
    {
        public DepartamentoValidator()
        {
            RuleFor(dept => dept.Nombre)
             .NotNull()
             .Length(3, 100);
        }
    }
}
