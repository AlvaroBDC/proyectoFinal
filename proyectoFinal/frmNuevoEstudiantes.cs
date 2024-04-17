using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using proyectoFinal.Utilidades;
using CapaEntidad;
using CapaOperacion;

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
            foreach(DataGridViewColumn columna in bgvData.Columns)
            {
                if (columna.Visible == true )
                {
                    cboBusqueda.Items.Add(new OpcionCombo()
                    {
                        Valor=columna.Name, Texto=columna.HeaderText
                    });
                }
                cboBusqueda.DisplayMember = "Texto";
                cboBusqueda.ValueMember = "Valor";
                cboBusqueda.SelectedIndex = 0;
            }

            //Mostrar todos los usuarios
            List<Estudiantes> listarEstudiantes = new CO_Estudiantes().listar();

            foreach (Estudiantes item in listarEstudiantes)
            {
                bgvData.Rows.Add(new object[] {
                    "",
                    item.ID,
                    item.ID,
                    item.Nombres,
                    item.Apellidos,
                    item.Grado,
                    item.Celular
                    
                });
            }


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bgvData.Rows.Add(new object[] { 
                "", 
                txtID.Text,
                txtIDEstudiante.Text,
                txtNombres.Text,
                txtApellidos.Text,
                txtGrado.Text,
                txtCelular.Text 
            });

            Limpiar();
        }
        private void Limpiar()
        {
            txtID.Text = "0";
            txtIDEstudiante.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtGrado.Text = "";
            txtCelular.Text = "";

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
