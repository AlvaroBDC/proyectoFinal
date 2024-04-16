using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class frmNuevoEstudiantes : Form
    {
        public frmNuevoEstudiantes()
        {
            InitializeComponent();
        }

        private void frmNuevoEstudiantes_Load(object sender, EventArgs e)
        {



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bgvData.Rows.Add(new object[] { "", txtID.Text, txtNombres.Text, txtApellidos.Text, txtGrado.Text, txtCelular.Text });
        }
    }
}
