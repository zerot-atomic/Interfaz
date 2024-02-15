using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Febrero06
{
  public partial class FrmAltaMovie : Form
  {
        string picture;
    public FrmAltaMovie()
    {
      InitializeComponent();
    }
    private void btnPicture_Click(object sender, EventArgs e)
    {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = new Bitmap(openFileDialog1.FileName);
                picture = openFileDialog1.FileName;
            }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string name, description, category;
      int year, rating;
            //Leer info del usuario
      name = txtName.Text;
      description= txtDescription.Text;   
      year = int.Parse(txtYear.Value.ToString());
      rating = int.Parse(tbRating.Value.ToString());
      category = cbCategory.Text;
            //crear la pelicula
      Movie nuevaPelicula = new Movie (name, description, year, picture, rating, category);
      Data.Add_Movie(nuevaPelicula);
      MessageBox.Show("Pelicula agregada al catalogo", 
          "Cine Fantasi", MessageBoxButtons.OK,MessageBoxIcon.Information);   
    

    }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
