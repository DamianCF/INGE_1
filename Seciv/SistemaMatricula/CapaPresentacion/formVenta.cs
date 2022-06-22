using SistemaMatricula.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaPresentacion.Validar_TextBox;

namespace CapaPresentacion
{
    public partial class formVenta : Form
    {
        DataSet dsProfesor = new DataSet();
        DataTable dtProfesor = new DataTable();
        private string estadoUsuario = "";
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public formVenta()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//frmProfesor_Load
        {
            if (estadoUsuario != "A") // activacion de ciertas botones segun estado usuario 
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteProfesores.Enabled = false;
                btnReporteProfesores.Visible = false;
                btnReporteCursosProfesor.Enabled = false;
                btnReporteCursosProfesor.Visible = false;
            }


        }

        private void btnProfesor_Insertar_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarTxts()
        {
            txtProfesor_cedula.ResetText();
            txtProfesor_nombre.ResetText();
            txtProfesor_primerApellido.ResetText();
            txtProfesor_segundoApellido.ResetText();

            validarCampo();
        }

        private void CargarGridProfesor()
        {

        }

        private void CargarComboProfesor()
        {

        }
        private void BuscarProfesor()
        {

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {

        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteProfesores_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProfesores.ClearSelection();
        }

        private void txtProfesor_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();
        }

        private void txtProfesor_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtProfesor_primerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtProfesor_segundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtProfesor_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();
        }

        private void validarCampo() // validacion de campos completos
        {
            var vr = !string.IsNullOrEmpty(txtProfesor_cedula.Text) &&
                !string.IsNullOrEmpty(txtProfesor_nombre.Text) &&
                !string.IsNullOrEmpty(txtProfesor_primerApellido.Text) &&
                !string.IsNullOrEmpty(txtProfesor_segundoApellido.Text) ;

            btnModificar.Enabled = vr;
            btnProfesor_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
           
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnProfesor_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
                btnReporteCursosProfesor.Enabled = true;
                btnReporteCursosProfesor.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnProfesor_Insertar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
                btnReporteCursosProfesor.Enabled = true;
                btnReporteCursosProfesor.BackColor = Color.Gray;
            }
            // boton btnActivarEliminado manejo mas especifico
            if (vr && chkbxMostrarEliminados.Checked) {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.Gray;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) // realmente lo inactiva
        {
            //busca que el Profesor no este en  matriculas

        }

        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();

            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void btnReporteCursosProfesor_Click(object sender, EventArgs e)
        {

        }
    }
}
