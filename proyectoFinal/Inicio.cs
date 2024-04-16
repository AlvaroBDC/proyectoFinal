using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using FontAwesome.Sharp;

namespace proyectoFinal
{
    public partial class Inicio : Form
    {
        
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuNuevoUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmNuevoEstudiantes());
        }

        private void MenuPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmPagos());
        }

        private void MenuCuentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCuentas());
        }

        private void menuReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReporte());
        }
    }
}
