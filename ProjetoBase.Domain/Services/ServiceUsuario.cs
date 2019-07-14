using ProjetoBase.Domain.Arguments.Usuario;
using ProjetoBase.Domain.Entities.Usuario;
using ProjetoBase.Domain.Enum;
using ProjetoBase.Domain.Interfaces.Repositories;
using ProjetoBase.Domain.Interfaces.Services;
using ProjetoBase.Domain.ValueObjects;
using System.Linq;

namespace ProjetoBase.Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        public readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public AdicionarUsuarioResponse Adicionar(AdicionarUsuarioRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var tipo = (UsuarioTipo)System.Enum.Parse(typeof(UsuarioTipo), request.Tipo);

            var usuario = new Usuario(nome, request.Email, tipo);
            var usuarioResponse = new AdicionarUsuarioResponse();

            if (!usuario.ValidationResult.IsValid)
            {
                usuarioResponse.ErrorMessage.AddRange(usuario.ValidationResult.Errors.Select(s => s.ErrorMessage));
                return usuarioResponse;
            }

            var xusuario = _repositoryUsuario.Adicionar(usuario);

            return (AdicionarUsuarioResponse) xusuario;
        }
    }
}
