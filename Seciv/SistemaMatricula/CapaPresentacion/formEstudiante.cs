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

    public partial class formEstudiante : Form
    {
        DataSet dsEstudiante = new DataSet();
        DataTable dtEstudiante = new DataTable();
        private string estadoUsuario = "";

        public formEstudiante()
        {
            InitializeComponent();
        }

        private void formEstudiante_Load(object sender, EventArgs e)
        {
            if (estadoUsuario != "A") // desactivacion de ciertas funciones si el usuario es administrador
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteEstudiantes.Enabled = false;
                btnReporteEstudiantes.Visible = false;
            }
            validarCampo();
            CargarGridEstudiante();
            CargarComboEstudiante();
            CargarComboGrupo();

        }

        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        private void btnEstudiante_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.insertarEstudiante(int.Parse(cbxGrupo.SelectedValue.ToString()), txtEstudiante_cedula.Text, txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text,
                    txtEstudiante_segundoApellido.Text, txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text,
                    txtEstudiante_direccion.Text, "A");
            }

            LimpiarTxts();

            CargarGridEstudiante();
            CargarComboEstudiante();
            CargarComboGrupo();

        }

        private void LimpiarTxts()
        {
            txtEstudiante_cedula.ResetText();
            txtEstudiante_nombre.ResetText();
            txtEstudiante_primerApellido.ResetText();
            txtEstudiante_segundoApellido.ResetText();
            txtEstudiante_telefono.ResetText();
            txtEstudiante_correoElectronico.ResetText();
            txtEstudiante_direccion.ResetText();

            CargarComboGrupo();
            validarCampo();

        }

        private void CargarGridEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {// metododo que carga el grid con estudiantes con activas o inactivas
                if (chkbxMostrarEliminados.Checked)
                {
                    dgvEstudiantes.DataSource = elEstudiante.ListarEstudiantesInactivos();
                }
                else
                {
                    dgvEstudiantes.DataSource = elEstudiante.ListarEstudiante();
                }


                dgvEstudiantes.Columns["Estudiante_id"].Visible = false;
                dgvEstudiantes.Columns["Estudiante_cedula"].HeaderText = "Cedula";
                dgvEstudiantes.Columns["Grupo_id"].HeaderText = "ID Grupo";
                dgvEstudiantes.Columns["Estudiante_nombre"].HeaderText = "Nombre";
                dgvEstudiantes.Columns["Estudiante_primerApellido"].HeaderText = "Apellido";
                dgvEstudiantes.Columns["Estudiante_segundoApellido"].HeaderText = "Apellido";
                dgvEstudiantes.Columns["Estudiante_telefono"].HeaderText = "Telefono";
                dgvEstudiantes.Columns["Estudiante_correoElectronico"].HeaderText = "eMail";
                dgvEstudiantes.Columns["Estudiante_direccion"].HeaderText = "Direccion";
                dgvEstudiantes.Columns["Estudiante_estado"].Visible = false;

            }
        }

        private void CargarComboEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {// metododo que carga el comboboxAula con aulas activas o inactivas
                if (chkbxMostrarEliminados.Checked)
                {
                    cbxEstudiante.DataSource = elEstudiante.ListarEstudiantesInactivos();
                }
                else
                {
                    cbxEstudiante.DataSource = elEstudiante.ListarEstudiante();
                }


                cbxEstudiante.ValueMember = "Estudiante_id";
                cbxEstudiante.DisplayMember = "Estudiante_cedula";// despliega cedula pero selecciona id
            }
        }

        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxGrupo.DataSource = elGrupo.ListarGrupo();
                cbxGrupo.ValueMember = "Grupo_id";
                cbxGrupo.DisplayMember = "Grupo_descripcion";
            }
        }

        private void BuscarEstudiante()
        {
            int Estudiante_id = int.Parse(cbxEstudiante.SelectedValue.ToString());


            using (GestorEstudiante Estudiante = new GestorEstudiante())
            {
                this.dsEstudiante = Estudiante.ConsultarEstudiante(Estudiante_id);
                this.dtEstudiante = this.dsEstudiante.Tables[0];
            }
            CargarDatosEstudiante();
        }

        private void CargarDatosEstudiante()
        {
            txtEstudiante_cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
            txtEstudiante_nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
            txtEstudiante_primerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
            txtEstudiante_segundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
            txtEstudiante_telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_telefono"].ToString();
            txtEstudiante_correoElectronico.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
            txtEstudiante_direccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();

            cbxGrupo.SelectedValue = this.dtEstudiante.Rows[0]["Grupo_id"].ToString();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarEstudiante();
        }

        private void dgvEstudiantees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvEstudiantes.CurrentCell.RowIndex;
                int Estudiante_id = int.Parse(this.dgvEstudiantes[0, numFila].Value.ToString());


                using (GestorEstudiante Estudiante = new GestorEstudiante())
                {
                    this.dsEstudiante = Estudiante.ConsultarEstudiante(Estudiante_id);
                    this.dtEstudiante = this.dsEstudiante.Tables[0];
                }
                CargarDatosEstudiante();
                cbxEstudiante.SelectedIndex = numFila;
                validarCampo();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta", // mensage 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Elemento de tabla no seleccionado", "Error Eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {                               //si cambia la variable a global Estudiante_id y le manda esa funciona si se seleciona desde el grid
                elEstudiante.ModificarEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()), txtEstudiante_cedula.Text, txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text,
                    txtEstudiante_segundoApellido.Text, txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text,
                    txtEstudiante_direccion.Text, "A");
            }
            CargarGridEstudiante();
            CargarComboEstudiante();
            CargarComboGrupo();
        }

        private void btnReporteEstudiantees_Click(object sender, EventArgs e)
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'E';
            reporte.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LimpiarTxts();
            dgvEstudiantes.ClearSelection();
        }

        private void txtEstudiante_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();

        }

        private void txtEstudiante_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();

        }

        private void txtEstudiante_primerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();

        }

        private void txtEstudiante_segundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();

        }

        private void txtEstudiante_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();

        }

        private void validarCampo()// valida campos de texto para activar o desactivar ciertos botones y mas
        {
            var vr = !string.IsNullOrEmpty(txtEstudiante_cedula.Text) &&
                !string.IsNullOrEmpty(txtEstudiante_nombre.Text) &&
                !string.IsNullOrEmpty(txtEstudiante_primerApellido.Text) &&
                !string.IsNullOrEmpty(txtEstudiante_segundoApellido.Text) &&
                !string.IsNullOrEmpty(txtEstudiante_telefono.Text) &&
                !string.IsNullOrEmpty(txtEstudiante_correoElectronico.Text) &&
                !string.IsNullOrEmpty(txtEstudiante_direccion.Text) &&
                cbxGrupo.SelectedItem != null;

            btnModificar.Enabled = vr;
            btnEstudiante_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnEstudiante_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnEstudiante_Insertar.BackColor = Color.Gray;
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

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //busca que el estudiante no este en  matriculas
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de estudiante en matriculas 
                {
                    DataTable repetidos = elMatricula.ListarMatriculasEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error eliminar estudiante ");
                        MessageBox.Show(" estudiante con matriculas", "Error eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        using (GestorEstudiante elEstudiante = new GestorEstudiante())
                        {
                            elEstudiante.InactivarEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()));
                        }
                        LimpiarTxts();

                        CargarGridEstudiante();
                        CargarComboEstudiante();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error eliminar estudiante catch");
            }
        }

        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();

            CargarGridEstudiante();
            CargarComboEstudiante();
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
