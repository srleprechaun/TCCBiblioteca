using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccBiblioteca.Classes
{
    public class Visita
    {
        #region Atributos
        private DateTime dataentrada;
        private int alunoRM;
        private int motivoVisitaId;


        public int AlunoRM
        {
            get { return alunoRM; }
            set { alunoRM = value; }
        }
       
        public int MotivoVisitaId
        {
            get { return motivoVisitaId; }
            set { motivoVisitaId = value; }
        }

        #endregion

        #region Propriedades
        
        public DateTime Dataentrada
        {
            get { return dataentrada; }
            set { dataentrada = value; }
        }
         #endregion
    }
}
