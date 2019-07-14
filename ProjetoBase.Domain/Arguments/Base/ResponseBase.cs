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
        public bool Status
        {
            get { return ErrorMessage.Count <= 0; }
        }

        public List<string> ErrorMessage { get; set; }
    }
}
