using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccBiblioteca.Classes
{
    public class Funcionario : Pessoa
    {
        #region Propriedades

        public string Senha{ get; set;}

        public string Login { get;set;}

        public int id { get; set; }

        #endregion
    }
}
