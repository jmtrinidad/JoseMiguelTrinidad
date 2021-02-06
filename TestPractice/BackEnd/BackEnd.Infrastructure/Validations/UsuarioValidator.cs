

namespace BackEnd.Infrastructure.Validations
{
    using BackEnd.Core.Entities;
    using FluentValidation;
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(user => user.Apellidos)
              .NotNull()
              .Length(3, 50);
            RuleFor(user => user.Nombres)
              .NotNull()
              .Length(3, 50);
            RuleFor(user => user.Cedula)
              .NotNull()
              .Length(3, 15);
            RuleFor(user => user.Genero)
             .NotNull()
             .Length(3, 20);
            
            RuleFor(user => user.Fecha_Nacimiento)
                  .NotNull();
            RuleFor(user => user.DepartamentoId)
             .NotNull();
            RuleFor(user => user.Cargo)
            .NotNull()
            .Length(3, 50);
            RuleFor(user => user.Supervisor_Inmediato)
            .NotNull()
            .Length(3, 50);

        }
    }
}
