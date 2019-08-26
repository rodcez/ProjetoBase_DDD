using Moq;
using ProjetoBase.Domain.Arguments.Usuario;
using ProjetoBase.Domain.Entities.Usuario;
using ProjetoBase.Domain.Enum;
using ProjetoBase.Domain.Interfaces.Repositories;
using ProjetoBase.Domain.Services;
using ProjetoBase.Domain.ValueObjects;
using System;
using Xunit;

namespace ProjetoBase.UnitTest.UsuarioTest
{
    public class UsuarioTest
    {
        [Fact]
        public void Test1()
        {
            var request = GetAdicionarUsuarioRequest();
            var usuario = GetUsuario(request);

            var repositoryUsuario = new Mock<IRepositoryUsuario>();
            repositoryUsuario.Setup(x => x.Adicionar(usuario));
            var serviceUsuario = new ServiceUsuario(repositoryUsuario.Object);

            AdicionarUsuarioResponse response = serviceUsuario.Adicionar(request);
            Assert.True(response.Status, response.Mensagem);
        }

        private Usuario GetUsuario(AdicionarUsuarioRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var tipo = (UsuarioTipo)System.Enum.Parse(typeof(UsuarioTipo), request.Tipo);

            var usuario = new Usuario(nome, request.Email, tipo);

            return usuario;
        }

        private AdicionarUsuarioRequest GetAdicionarUsuarioRequest()
        {





            var age = 33;










            var x = age;
            age = 1;



            return new AdicionarUsuarioRequest()
            {
                PrimeiroNome = "Primeiro Nome",

                UltimoNome = "Último Nome",
                Email = "email@dominio.com",
                Tipo = "Tipo1"
            };
        }
    }
}
