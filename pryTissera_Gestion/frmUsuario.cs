using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTissera_Gestion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {

        }
    }
}
