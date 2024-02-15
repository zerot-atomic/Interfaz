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
  public partial class FrmLogin : Form
  {
    public FrmLogin()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string user, password;
      user = txtUser.Text;
      password = txtPassword.Text;
      if (user == "Familia" && password == "admin")
      {

        FrmMain principal = new FrmMain();
        principal.Show();
        this.Hide();
      }
      else
        MessageBox.Show("Usuario o contraseña incorrecta",
          "Castores", MessageBoxButtons.OK,
          MessageBoxIcon.Warning);

    }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
