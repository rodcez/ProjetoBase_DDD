using FluentValidation;
using ProjetoBase.Domain.Entities.Usuario;
using ProjetoBase.Domain.Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Domain.Utils.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(a => a.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage(string.Format(MensagemUsuario.Invalido, MensagemUsuario.Email));

            RuleFor(a => a.Nome.PrimeiroNome)
                .NotEmpty()
                .Length(3, 50)
                .WithMessage(string.Format(MensagemUsuario.Invalido, MensagemUsuario.PrimeiroNome));

            RuleFor(a => a.Nome.UltimoNome)
                .NotEmpty()
                .Length(3, 50)
                .WithMessage(string.Format(MensagemUsuario.Invalido, MensagemUsuario.UltimoNome));

            RuleFor(a => a.Tipo)
                .NotEmpty()
                .WithMessage(string.Format(MensagemUsuario.Invalido, MensagemUsuario.Tipo));
        }
    }
}
