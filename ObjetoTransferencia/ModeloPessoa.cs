using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Objects.DataClasses;

namespace ObjetoTransferencia
{
    #region Modelo Pessoa
    public class ModeloPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCad { get; set; }
        public DateTime DataAltCad { get; set; }
    }
    #endregion
}
