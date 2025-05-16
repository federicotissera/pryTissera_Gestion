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
    public partial class frmPrincipal : Form
    {
        clsUsuario Conexion;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Conexion = new clsUsuario();
            lblstConexion.Text = Conexion.estadoConexion;
        }
    }
}
