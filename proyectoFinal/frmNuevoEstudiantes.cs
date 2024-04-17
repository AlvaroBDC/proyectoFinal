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
                if (columna.Visible == true)
                {
                    cboBusqueda.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name, Texto = columna.HeaderText
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
            txtIDEstudiante.Text = "0";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtGrado.Text = "";
            txtCelular.Text = "";

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void bgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void bgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    txtIDEstudiante.Text = bgvData.Rows[indice].Cells["IDEstudiante"].Value.ToString();
                    txtNombres.Text = bgvData.Rows[indice].Cells["Nombres"].Value.ToString();
                    txtApellidos.Text = bgvData.Rows[indice].Cells["Apellidos"].Value.ToString();
                    txtGrado.Text = bgvData.Rows[indice].Cells["Grado"].Value.ToString();
                    txtCelular.Text = bgvData.Rows[indice].Cells["Celular"].Value.ToString();
                }
            }
        }
    }
}
