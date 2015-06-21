using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Objects.DataClasses;

namespace ObjetoTransferencia
{
    public class ModeloLoginPessoa
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}
