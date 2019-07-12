using ProjetoBase.Domain.Resourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBase.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Mensagem = MensagemGenerica.OPERACAO_SUCESSO;
        }
        public string Mensagem { get; set; }
    }
}
