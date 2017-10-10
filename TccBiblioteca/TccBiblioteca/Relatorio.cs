using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TccBiblioteca
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdbibliotecaDataSet.VisitasPorMotivo' table. You can move, or remove it, as needed.

            this.VisitasPorMotivo.Fill(this.bdbibliotecaDataSet.VisitasPorMotivo);

            this.reportViewer1.RefreshReport();
        }

        private void Relatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
