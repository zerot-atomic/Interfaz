namespace Febrero06
{
  partial class FrmAltaMovie
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.LbNombre = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPelicula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbRating = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPicture = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(103, 31);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(44, 13);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nombre";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Location = new System.Drawing.Point(103, 77);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(26, 13);
            this.lbAño.TabIndex = 1;
            this.lbAño.Text = "Año";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(103, 127);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(103, 163);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbPelicula
            // 
            this.lbPelicula.AutoSize = true;
            this.lbPelicula.Location = new System.Drawing.Point(103, 264);
            this.lbPelicula.Name = "lbPelicula";
            this.lbPelicula.Size = new System.Drawing.Size(44, 13);
            this.lbPelicula.TabIndex = 4;
            this.lbPelicula.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calificacion";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(217, 75);
            this.txtYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.txtYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(215, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Comedia",
            "Terror",
            "Suspenso",
            "Fantasia",
            "Acciòn",
            "Romance",
            "Ciencia ficciòn",
            "Drama",
            "Animaciòn"});
            this.cbCategory.Location = new System.Drawing.Point(217, 124);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(215, 21);
            this.cbCategory.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(217, 163);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 84);
            this.txtDescription.TabIndex = 9;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(226, 253);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(181, 144);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 10;
            this.pbPicture.TabStop = false;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(215, 422);
            this.tbRating.Maximum = 5;
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(206, 45);
            this.tbRating.TabIndex = 12;
            this.tbRating.Value = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de Imagen|* .jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(436, 254);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(35, 33);
            this.btnPicture.TabIndex = 13;
            this.btnPicture.Text = "...";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Alta de Pelicula";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAltaMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPelicula);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbAño);
            this.Controls.Add(this.LbNombre);
            this.Name = "FrmAltaMovie";
            this.Text = "FrmAltaMovie";
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LbNombre;
    private System.Windows.Forms.Label lbAño;
    private System.Windows.Forms.Label lbCategoria;
    private System.Windows.Forms.Label lbDescripcion;
    private System.Windows.Forms.Label lbPelicula;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.NumericUpDown txtYear;
    private System.Windows.Forms.ComboBox cbCategory;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.PictureBox pbPicture;
    private System.Windows.Forms.TrackBar tbRating;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button btnPicture;
    private System.Windows.Forms.Button button2;
  }
}