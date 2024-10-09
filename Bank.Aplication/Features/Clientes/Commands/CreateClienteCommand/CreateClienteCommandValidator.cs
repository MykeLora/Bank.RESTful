using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Aplication.Features.Clientes.Commands.CreateClienteCommand
{
    public class CreateClienteCommandValidator : AbstractValidator<CreateClienteCommand>
    {
        public CreateClienteCommandValidator()
        {
            RuleFor(n => n.Nombre)
                    .NotEmpty().WithMessage("{PropertyName} the property Name required")
                    .MaximumLength(80).WithMessage("{PropertyName} should not exceed of {MaxLength} ");

            RuleFor(n => n.Apellido)
                    .NotEmpty().WithMessage("{PropertyName} the property Name required")
                    .MaximumLength(80).WithMessage("{PropertyName} should not exceed of {MaxLength} ");

            RuleFor(n => n.FechaNacimiento)
                    .NotEmpty().WithMessage("{PropertyName} the property cannot empty");

            RuleFor(n => n.Telefono)
                    .NotEmpty().WithMessage("{PropertyName} the property Name required")
                    .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} should be in format 0000-0000")
                    .MaximumLength(9).WithMessage("{PropertyName} should not exceed of {MaxLength} ");

            RuleFor(n => n.Email)
                    .NotEmpty().WithMessage("{PropertyName} the property Name required")
                    .EmailAddress().WithMessage("{PropertyName} should be an adreesse valid ")
                    .MaximumLength(100).WithMessage("{PropertyName} should not exceed of {MaxLength} ");

            RuleFor(n => n.Direccion)
                    .NotEmpty().WithMessage("{PropertyName} the property Name required")
                    .MaximumLength(120).WithMessage("{PropertyName} should not exceed of {MaxLength} ");

        }
    }
}
