using ProjetoBase.Domain.Arguments.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Domain.Interfaces.Services
{
    public interface IServiceUsuario
    {
        AdicionarUsuarioResponse Adicionar(AdicionarUsuarioRequest request);
    }
}
