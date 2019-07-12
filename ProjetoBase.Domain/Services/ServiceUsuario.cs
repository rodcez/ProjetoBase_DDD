using ProjetoBase.Domain.Arguments.Usuario;
using ProjetoBase.Domain.Entities.Usuario;
using ProjetoBase.Domain.Enum;
using ProjetoBase.Domain.Interfaces.Repositories;
using ProjetoBase.Domain.Interfaces.Services;
using ProjetoBase.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var nome = new Nome()
            {
                PrimeiroNome = request.PrimeiroNome,
                UltimoNome = request.UltimoNome
            };

            var tipo = (UsuarioTipo)System.Enum.Parse(typeof(UsuarioTipo), request.Tipo);

            var usuario = new Usuario(nome, request.Email, tipo);

            usuario = _repositoryUsuario.Adicionar(usuario);

            //Retornar com o Mapper

            throw new NotImplementedException();
        }
    }
}
