using ProjetoBase.Domain.Arguments.Base;
using ProjetoBase.Domain.Resourses;
using System;

namespace ProjetoBase.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse : ResponseBase
    {
        public Guid Id { get; set; }

        public string Mensagem { get; set; }

        public static explicit operator AdicionarUsuarioResponse(Entities.Usuario.Usuario v)
        {
            return new AdicionarUsuarioResponse()
            {
                Id = v.Id,
                Mensagem = MensagemGenerica.OPERACAO_SUCESSO
            };
        }
    }
}
