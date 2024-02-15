using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Febrero06
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void eliminarPeliToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmBuscar frmBuscarMovie = new FrmBuscar();
      frmBuscarMovie.MdiParent = this;
      frmBuscarMovie.Show();
    }

    private void altaDePeliculaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmAltaMovie frmAlta = new FrmAltaMovie();
      frmAlta.MdiParent = this;
      frmAlta.Show();
    }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mostrarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeliculas frmPeliculas = new FrmPeliculas();
            frmPeliculas.MdiParent = this;
            frmPeliculas.Show();
        }

        private void buscarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDelete frmBorrar = new FrmDelete();
            frmBorrar.MdiParent = this;
            frmBorrar.Show();
        }

        private void editarPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpDatePelicula update =new FrmUpDatePelicula();
            update.MdiParent = this;
            update.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
