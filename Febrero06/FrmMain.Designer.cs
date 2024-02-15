namespace Febrero06
{
  partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDePeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPeliculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDePeliculaToolStripMenuItem,
            this.editarPeliculaToolStripMenuItem,
            this.eliminarPeliToolStripMenuItem,
            this.buscarPeliculaToolStripMenuItem,
            this.mostrarPeliculaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // altaDePeliculaToolStripMenuItem
            // 
            this.altaDePeliculaToolStripMenuItem.Name = "altaDePeliculaToolStripMenuItem";
            this.altaDePeliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDePeliculaToolStripMenuItem.Text = "Alta de Pelicula";
            this.altaDePeliculaToolStripMenuItem.Click += new System.EventHandler(this.altaDePeliculaToolStripMenuItem_Click);
            // 
            // editarPeliculaToolStripMenuItem
            // 
            this.editarPeliculaToolStripMenuItem.Name = "editarPeliculaToolStripMenuItem";
            this.editarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarPeliculaToolStripMenuItem.Text = "Actualizar pelicula";
            this.editarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.editarPeliculaToolStripMenuItem_Click);
            // 
            // eliminarPeliToolStripMenuItem
            // 
            this.eliminarPeliToolStripMenuItem.Name = "eliminarPeliToolStripMenuItem";
            this.eliminarPeliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarPeliToolStripMenuItem.Text = "Eliminar Pelicula";
            this.eliminarPeliToolStripMenuItem.Click += new System.EventHandler(this.eliminarPeliToolStripMenuItem_Click);
            // 
            // buscarPeliculaToolStripMenuItem
            // 
            this.buscarPeliculaToolStripMenuItem.Name = "buscarPeliculaToolStripMenuItem";
            this.buscarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarPeliculaToolStripMenuItem.Text = "Buscar Pelicula";
            this.buscarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.buscarPeliculaToolStripMenuItem_Click);
            // 
            // mostrarPeliculaToolStripMenuItem
            // 
            this.mostrarPeliculaToolStripMenuItem.Name = "mostrarPeliculaToolStripMenuItem";
            this.mostrarPeliculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarPeliculaToolStripMenuItem.Text = "Mostrar Pelicula";
            this.mostrarPeliculaToolStripMenuItem.Click += new System.EventHandler(this.mostrarPeliculaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem altaDePeliculaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editarPeliculaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eliminarPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPeliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPeliculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}