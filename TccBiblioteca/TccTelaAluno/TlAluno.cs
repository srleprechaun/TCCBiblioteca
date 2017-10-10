using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModuloBiometria;
using TccBiblioteca.Dados;
using TccBiblioteca;
using TccBiblioteca.Classes;


namespace TccTelaAluno
{
    public partial class TlAluno : Form
    {
        MotivoVisitaDados ObjMotivoVisitaDados = new MotivoVisitaDados();

        MotivoVisita ObjMotivoVisita = new MotivoVisita();

        Visita objVisita = new Visita();

        VisitaDados objVisitaDados = new VisitaDados();

        public TlAluno()
        {
            InitializeComponent();
            ListarMotivos();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ListarMotivos()
        {
            List<MotivoVisita> motivos = ObjMotivoVisitaDados.consultarMotivoVisita();
            
            foreach (MotivoVisita motivo in motivos)
                cboMotivoVisita.Items.Add(motivo);

            cboMotivoVisita.Items.Insert(0, "--- Selecionar ---");
            cboMotivoVisita.SelectedIndex = 0;
        }

        private void cboMotivoVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMotivoVisita.SelectedIndex > 0)
            {
                Biometria biometria = new Biometria();
                string digitalCapturada = biometria.CapturarDigitalParaVerificacao();

                AlunoDados dados = new AlunoDados();

                List<Aluno> alunos = dados.listarAlunosParaValidacaoDeDigital();

                Aluno alunoEncontrado = null;

                foreach (Aluno aluno in alunos)
                {
                    try
                    {
                        if (biometria.VerificarDigitais(digitalCapturada, aluno.Digitais))
                        {
                            alunoEncontrado = aluno;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                try
                {
                    if (alunoEncontrado != null)
                    {
                        MotivoVisita motivo = (MotivoVisita)cboMotivoVisita.SelectedItem;
                        objVisita.MotivoVisitaId = motivo.idMotivoVisita;
                        objVisita.AlunoRM = int.Parse(alunoEncontrado.rm);
                        objVisitaDados.InsertVisita(objVisita);


                        MessageBox.Show(alunoEncontrado.Nome);
                    }
                    else
                    {
                        MessageBoxButtons botao = MessageBoxButtons.OK;
                        DialogResult resultado = MessageBox.Show(" Cadastro não encontrado! ", "Registrar Visita", botao, MessageBoxIcon.Error);
                    }

                    cboMotivoVisita.SelectedIndex = 0;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.StackTrace);

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToLongTimeString();
        }


    }
}
