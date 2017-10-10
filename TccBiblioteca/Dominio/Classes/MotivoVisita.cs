namespace TccBiblioteca.Classes
{
    public class MotivoVisita
    {
        #region Propriedades
        public string descricao { get; set; }
        public int idMotivoVisita { get; set; }
        #endregion

        public override string ToString()
        {
            return descricao;
        }
    }
}
