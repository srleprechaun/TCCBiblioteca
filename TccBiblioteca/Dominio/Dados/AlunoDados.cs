using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TccBiblioteca.Dados
{
    public class AlunoDados
    {
        DadosMySQL dados = new DadosMySQL();

        #region INCLUIR
        public bool incluir(Aluno aluno)
        {
            try
            {
                dados.ConvertSqlToInt("INSERT INTO Aluno " +
                    "( Rm, dIGITAL, Nome, TELEFONE, EMAIL, PERIODO, MODULO) " +
                    " VALUES( @Rm, @Digital, @Nome, @telefone, @EMAIL, @PERIODO, @MODULO)",
                    new MySqlParameter("@Rm", aluno.rm),
                    new MySqlParameter("@Digital", aluno.Digitais),
                    new MySqlParameter("@Nome", aluno.Nome),
                    new MySqlParameter("@telefone", aluno.Telefone),
                    new MySqlParameter("@EMAIL", aluno.Email),
                    new MySqlParameter("@PERIODO", aluno.periodo),
                    new MySqlParameter("@MODULO", aluno.modulo));


                    dados.ConvertSqlToInt("INSERT INTO ALUNO_HAS_CURSO(Aluno_RM,Curso_idCurso)"+
                        "VALUES(@RM_A,@ID_C)",
                         new MySqlParameter("@RM_A", aluno.rm),
                         new MySqlParameter("@ID_C", aluno.idCurso));

                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Usuário cadastrado com sucesso! ", "Cadastro Aluno", botao, MessageBoxIcon.Information);
                return true;
            }

            catch (MySqlException)
            {
                if (aluno.Digitais == null)
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Clique no botão da digital! ", "Cadastro Aluno", botao, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show(" Usuário já cadastrado com esse RM! ", "Cadastro Aluno", botao, MessageBoxIcon.Error);
                }
                return false;
            }
        }
        #endregion

        #region ALTERAR

        public bool atualizar(Aluno aluno)
        {
            try
            {
                dados.ConvertSqlToInt("UPDATE Aluno SET " +
                    "dIGITAL = @Digital, Nome = @Nome, TELEFONE = @Telefone, EMAIL = @Email, PERIODO = @Periodo, MODULO =@Modulo " +
                    "Where Rm = @Rm;",
                    new MySqlParameter("@Rm", aluno.rm),
                    new MySqlParameter("@Digital", aluno.Digitais),
                    new MySqlParameter("@Nome", aluno.Nome),
                    new MySqlParameter("@telefone", aluno.Telefone),
                    new MySqlParameter("@EMAIL", aluno.Email),
                    new MySqlParameter("@PERIODO", aluno.periodo),
                    new MySqlParameter("@MODULO", aluno.modulo));


                dados.ConvertSqlToInt("Update ALUNO_HAS_CURSO SET Curso_idCurso = @ID_C " +
                    "Where Aluno_RM = @RM_A;",
                     new MySqlParameter("@RM_A", aluno.rm),
                     new MySqlParameter("@ID_C", aluno.idCurso));

                MessageBoxButtons botao = MessageBoxButtons.OK;
                DialogResult resultado = MessageBox.Show("Cadastro Atualizado com Sucesso!", "Alterar Cadastro", botao, MessageBoxIcon.Information);
                return true;
            }

            catch (MySqlException)
            {
                if (aluno.Digitais == null)
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show("Clique no Botão da Digital.", "Alterar Cadastro", botao, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxButtons botao = MessageBoxButtons.OK;
                    DialogResult resultado = MessageBox.Show("Não foi Possível Realizar a Alteração!", "Alterar Cadastro", botao, MessageBoxIcon.Information);
                }
                return false;
            }
        }

        #endregion

        #region Consultar Curso
        public DataTable consultaCurso(Aluno aluno)
        {
            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                "SELECT NOME,IDCURSO FROM CURSO");

            return tblRecuperada;
        }
        #endregion

        #region Listar Alunos
        public List<Aluno> listarAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                  "SELECT A.RM, A.NOME, A.MODULO, A.PERIODO, A.TELEFONE, A.EMAIL, AC.Curso_idCurso AS Curso" +
                   " FROM ALUNO A, ALUNO_HAS_CURSO AC " +
                   " WHERE A.RM = AC.Aluno_RM");

            foreach (DataRow linha in tblRecuperada.Rows)
            {
                Aluno aluno = new Aluno();

                aluno.rm = linha["RM"].ToString();
                aluno.Nome = linha["Nome"].ToString();
                aluno.curso = new CursosDados().BuscarPorCodigo(int.Parse(linha["Curso"].ToString()));
                aluno.modulo = linha["Modulo"].ToString();
                aluno.periodo = linha["Periodo"].ToString();
                aluno.Telefone = linha["Telefone"].ToString();
                aluno.Email = linha["Email"].ToString();
                //aluno.Digitais = (byte[])linha["DIGITAL"];

                alunos.Add(aluno);
            }

            return alunos;
        }
        #endregion

        #region listar Alunos Para Validacao De Digital
        public List<Aluno> listarAlunosParaValidacaoDeDigital()
        {
            List<Aluno> alunos = new List<Aluno>();

            DataTable tblRecuperada = dados.ConvertSqlToDataTable("SELECT A.RM, A.NOME, A.DIGITAL FROM ALUNO A");
                   
            foreach (DataRow linha in tblRecuperada.Rows)
            {
                Aluno aluno = new Aluno();

                aluno.Nome = linha["NOME"].ToString();
                aluno.rm = linha["RM"].ToString();
                aluno.Digitais = linha["DIGITAL"].ToString();

                alunos.Add(aluno);
            }

            return alunos;
        }
        #endregion

        #region Consultar Aluno
        public Aluno consultarAluno(string rm)
        {
            Aluno aluno = null;
            string sql = "SELECT A.RM, A.DIGITAL, A.NOME, A.MODULO, A.PERIODO, A.TELEFONE, A.EMAIL, C.idCurso, C.Nome As NomeCurso" +
                   " FROM ALUNO A, CURSO C , aluno_has_curso AC" +
                   " WHERE RM = @RM AND AC.Aluno_RM = A.Rm AND C.IdCurso = AC.Curso_IdCurso";

            DataTable consultaAluno = dados.ConvertSqlToDataTable(sql, new MySqlParameter("@RM", rm));

            if (consultaAluno.Rows.Count > 0)
            {
                aluno = new Aluno();
                aluno.rm = rm;
                aluno.Telefone = consultaAluno.Rows[0]["Telefone"].ToString();
                aluno.periodo = consultaAluno.Rows[0]["Periodo"].ToString();
                aluno.Nome = consultaAluno.Rows[0]["Nome"].ToString();
                aluno.Email = consultaAluno.Rows[0]["Email"].ToString();
                aluno.Digitais = consultaAluno.Rows[0]["Digital"].ToString();
                aluno.modulo = consultaAluno.Rows[0]["Modulo"].ToString();
                aluno.curso = new Classes.Curso();
                aluno.curso.idCurso = Convert.ToInt32(consultaAluno.Rows[0]["idCurso"]);
                aluno.curso.nomeCurso = consultaAluno.Rows[0]["NomeCurso"].ToString();
            }

            return aluno;
        }
        #endregion

        #region DeletarAluno
        public Aluno excluirAluno(string rm)
        {
            Aluno aluno = null;
            try
            {
                aluno = new Aluno();

                dados.ConvertSqlToInt("DELETE FROM ALUNO WHERE RM = @RM",
                     new MySqlParameter("@RM", aluno.rm));

                    MessageBox.Show("Registro Excluído!");
            }

            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a Exclusão!");
            }
            return aluno;
        }
        #endregion

        #region Consultar AlunoRM/
        public List<Aluno> consultarAlunoRm(string rm)
        {
            List<Aluno> alunos = new List<Aluno>();

            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                  "SELECT A.RM, A.NOME, A.MODULO, A.PERIODO, A.TELEFONE, A.EMAIL, C.idCurso, C.Nome As NomeCurso, A.DIGITAL " +
                  " FROM ALUNO A, CURSO C , aluno_has_curso AC " +
                  " WHERE a.rm like @rm " +
                  " AND  A.Rm  = AC.Aluno_RM " +
                  " AND C.IdCurso = AC.Curso_IdCurso ",
                  new MySqlParameter("rm", rm + "%"));

            foreach (DataRow linha in tblRecuperada.Rows)
            {
                Aluno aluno = new Aluno();

                aluno.rm = linha["RM"].ToString();
                aluno.Nome = linha["Nome"].ToString();
                aluno.curso = new CursosDados().BuscarPorCodigo(int.Parse(linha["idCurso"].ToString()));
                aluno.modulo = linha["Modulo"].ToString();
                aluno.periodo = linha["Periodo"].ToString();
                aluno.Telefone = linha["Telefone"].ToString();
                aluno.Email = linha["Email"].ToString();
                //aluno.Digitais = (byte[])linha["DIGITAL"];

                alunos.Add(aluno);
            }

            return alunos;
        }
        #endregion

        #region Consultar AlunoNome/
        public List<Aluno> consultarAlunoNome(string nome)
        {
            List<Aluno> alunos = new List<Aluno>();

            DataTable tblRecuperada = dados.ConvertSqlToDataTable(
                  "SELECT A.RM, A.NOME, A.MODULO, A.PERIODO, A.TELEFONE, A.EMAIL, C.idCurso, C.Nome As NomeCurso, A.DIGITAL " + 
                  " FROM ALUNO A, CURSO C , aluno_has_curso AC " +
                  " WHERE a.nome like @nome " + 
                  " AND  A.Rm  = AC.Aluno_RM " + 
                  " AND C.IdCurso = AC.Curso_IdCurso ",
                  new MySqlParameter("nome", nome + "%"));

            foreach (DataRow linha in tblRecuperada.Rows)
            {
                Aluno aluno = new Aluno();

                aluno.rm = linha["RM"].ToString();
                aluno.Nome = linha["Nome"].ToString();
                aluno.curso = new CursosDados().BuscarPorCodigo(int.Parse(linha["idCurso"].ToString()));
                aluno.modulo = linha["Modulo"].ToString();
                aluno.periodo = linha["Periodo"].ToString();
                aluno.Telefone = linha["Telefone"].ToString();
                aluno.Email = linha["Email"].ToString();
                //aluno.Digitais = (byte[])linha["DIGITAL"];

                alunos.Add(aluno);
            }

            return alunos;
        }
        #endregion

    }
}
