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
    public partial class formProductos : Form
    {
        DataSet dsGrupo = new DataSet();
        DataTable dtGrupo = new DataTable();
        private string estadoUsuario = "";
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        public formProductos()
        {
            InitializeComponent();
        }

        private void formGrupo_Load(object sender, EventArgs e)
        {


        }


        private void btnGrupo_Insertar_Click(object sender, EventArgs e)
        {


        }

        private void LimpiarTxts()
        {
            txtCod.ResetText();
            validarCampo();

        }

        private void CargarGridGrupo()
        {
           
        }

        private void CargarComboGrupo()
        {
         
        }
        private void BuscarGrupo()
        {

        }

        private void CargarDatosGrupo()
        {


        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
        }

        private void dgvGrupoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteGrupoes_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvGrupos.ClearSelection();
        }

        private void txtGrupo_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void validarCampo() // valida campos de texto para activar o desactivar ciertos botones y mas
        {
            var vr = !string.IsNullOrEmpty(txtCod.Text);

            btnModificar.Enabled = vr;
            btnInsertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnInsertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnInsertar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
            }
            // boton btnActivarEliminado manejo mas especifico
            if (vr && chkbxMostrarEliminados.Checked)
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.Gray;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }


        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
