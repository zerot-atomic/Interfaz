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
  public partial class FrmPeliculas : Form
    {
        private DataGridView dgPeliculas;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Calificacion;
        private DataGridViewImageColumn Foto;

        public FrmPeliculas()
    {
      InitializeComponent();
    }

        private void InitializeComponent()
        {
            this.dgPeliculas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPeliculas
            // 
            this.dgPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Año,
            this.Categoria,
            this.Calificacion,
            this.Foto});
            this.dgPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeliculas.Location = new System.Drawing.Point(0, 0);
            this.dgPeliculas.Name = "dgPeliculas";
            this.dgPeliculas.Size = new System.Drawing.Size(806, 327);
            this.dgPeliculas.TabIndex = 0;
            this.dgPeliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            // 
            // FrmPeliculas
            // 
            this.ClientSize = new System.Drawing.Size(806, 327);
            this.Controls.Add(this.dgPeliculas);
            this.Name = "FrmPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Movie> peliculas = Data.Get_Movies();

        }
    }
}
