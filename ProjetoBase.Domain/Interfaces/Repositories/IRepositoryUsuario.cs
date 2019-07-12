using ProjetoBase.Domain.Entities.Usuario;
using ProjetoBase.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario : IRepositoryBase <Usuario, Guid>
    {

    }
}
