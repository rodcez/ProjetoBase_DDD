using ProjetoBase.Domain.Entities.Base;
using ProjetoBase.Domain.Enum;
using ProjetoBase.Domain.ValueObjects;
using ProjetoBase.Domain.Utils.Validators;
using System;

namespace ProjetoBase.Domain.Entities.Usuario
{
    public class Usuario : EntityBase
    {
        public Usuario(Nome nome, string email, UsuarioTipo tipo)
        {
            Nome = nome;
            Email = email;
            Tipo = tipo;

            Validate(this, new UsuarioValidator());
        }

        public Nome Nome { get; private set; }

        public string Email { get; private set; }

        public UsuarioTipo Tipo { get; private set; }
    }
}
