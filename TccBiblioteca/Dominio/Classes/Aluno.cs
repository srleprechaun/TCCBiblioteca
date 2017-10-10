using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TccBiblioteca.Dados;
using System.Windows.Forms;
using TccBiblioteca.Classes;


namespace TccBiblioteca
{
    public class Aluno : Pessoa
    {
        #region Propriedades
        public string rm { get; set; }
        public string periodo { get; set; }
        public string modulo { get; set; }
        public int idCurso { get; set; }
        public Curso curso { get; set; }
        #endregion

    }
}
