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

namespace CapaPresentacion
{
    public partial class formHorario : Form
    {

        DataSet dsHorario = new DataSet();
        DataTable dtHorario = new DataTable();
        private string estadoUsuario = "";
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public formHorario()
        {
            InitializeComponent();
        }

        private void formHorario_Load(object sender, EventArgs e)
        {
            if (estadoUsuario != "A")// desactivacion de ciertas funciones si el usuario es administrador
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteHorarios.Enabled = false;
                btnReporteHorarios.Visible = false;
                btnReporteCursosHorario.Enabled = false;
                btnReporteCursosHorario.Visible = false;
            }
            validarCampo();
            CargarGridHorario();
            CargarComboHorario();
        }

        private void btnHorario_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.insertarHorario(txtHorario_descripcion.Text, cbxDia.SelectedItem.ToString(), txtHorario_horaInicio.Text,
                    txtHorario_horaFin.Text, "A");
            }

            LimpiarTxts();

            CargarGridHorario();
            CargarComboHorario();

        }

        private void LimpiarTxts()
        {
            txtHorario_descripcion.ResetText();
            cbxDia.SelectedItem = "L";
            txtHorario_horaInicio.ResetText();
            txtHorario_horaFin.ResetText();
            validarCampo();

        }

        private void CargarGridHorario()// metododo que carga el grid con horarios con activas o inactivas
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    dgvHorarios.DataSource = elHorario.ListarHorariosInactivos();
                }
                else
                {
                    dgvHorarios.DataSource = elHorario.ListarHorario();

                }


                dgvHorarios.Columns["Horario_id"].Visible = false;
                dgvHorarios.Columns["Horario_descripcion"].HeaderText = "Descripcion";
                dgvHorarios.Columns["Horario_dia"].HeaderText = "Dia";
                dgvHorarios.Columns["Horario_horaInicio"].HeaderText = "Hora Inicio";
                dgvHorarios.Columns["Horario_horaFinal"].HeaderText = "Hora Fin";
                dgvHorarios.Columns["Horario_estado"].Visible = false;

            }
        }

        private void CargarComboHorario()// metododo que carga el comboboxhorario con aulas activas o inactivas
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    cbxHorario.DataSource = elHorario.ListarHorariosInactivos();
                }
                else
                {
                    cbxHorario.DataSource = elHorario.ListarHorario();
                }

                cbxHorario.ValueMember = "Horario_id";
                cbxHorario.DisplayMember = "Horario_descripcion";// despliega descripcion pero selecciona id
            }
        }


        private void BuscarHorario()
        {
            int Horario_id = int.Parse(cbxHorario.SelectedValue.ToString());


            using (GestorHorario Horario = new GestorHorario())
            {
                this.dsHorario = Horario.ConsultarHorario(Horario_id);
                this.dtHorario = this.dsHorario.Tables[0];
            }
            CargarDatosHorario();
        }

        private void CargarDatosHorario()
        {
            txtHorario_descripcion.Text = this.dtHorario.Rows[0]["Horario_descripcion"].ToString();
            cbxDia.SelectedItem = this.dtHorario.Rows[0]["Horario_dia"].ToString();
            txtHorario_horaInicio.Text = this.dtHorario.Rows[0]["Horario_horaInicio"].ToString();
            txtHorario_horaFin.Text = this.dtHorario.Rows[0]["Horario_horaFinal"].ToString();

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarHorario();
        }

        private void dgvHorarioes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvHorarios.CurrentCell.RowIndex;
                int Horario_id = int.Parse(this.dgvHorarios[0, numFila].Value.ToString());


                using (GestorHorario Horario = new GestorHorario())
                {
                    this.dsHorario = Horario.ConsultarHorario(Horario_id);
                    this.dtHorario = this.dsHorario.Tables[0];
                }
                CargarDatosHorario();
                cbxHorario.SelectedIndex = numFila;
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
            using (GestorHorario elHorario = new GestorHorario())
            {                               //si cambia la variable a global Horario_id y le manda esa funciona si se seleciona desde el grid
                elHorario.ModificarHorario(int.Parse(cbxHorario.SelectedValue.ToString()), txtHorario_descripcion.Text, cbxDia.SelectedItem.ToString(), txtHorario_horaInicio.Text,
                                            txtHorario_horaFin.Text, "A");
            }
            CargarGridHorario();
            CargarComboHorario();
        }

        private void btnReporteHorarioes_Click(object sender, EventArgs e)
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'H';
            reporte.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHorarios.ClearSelection();
        }

        private void txtHorario_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void txtHorario_dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void txtHorario_horaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();

        }

        private void txtHorario_horaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void validarCampo()// valida campos de texto para activar o desactivar ciertos botones y mas
        {
            var vr = !string.IsNullOrEmpty(txtHorario_descripcion.Text) &&
                cbxDia.SelectedItem != null &&
                !string.IsNullOrEmpty(txtHorario_horaInicio.Text) &&
                !string.IsNullOrEmpty(txtHorario_horaFin.Text);


            btnModificar.Enabled = vr;
            btnHorario_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            btnReporteCursosHorario.Enabled = vr;

            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnHorario_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
                btnReporteCursosHorario.BackColor = Color.CornflowerBlue;

            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnHorario_Insertar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
                btnReporteCursosHorario.BackColor = Color.Gray;

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

            //busca que el Horario no este en  matriculas
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de Horario en matriculas de estudiante
                {
                    DataTable repetidos = elMatricula.ListarMatriculasHorario(int.Parse(cbxHorario.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error eliminar Horario ");
                        MessageBox.Show(" Horario con cursos matriculados", "Error eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (GestorHorario elHorario = new GestorHorario())
                        {
                            elHorario.InactivarHorario(int.Parse(cbxHorario.SelectedValue.ToString()));
                        }
                        LimpiarTxts();

                        CargarGridHorario();
                        CargarComboHorario();

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error eliminar Horario  catch");
            }


        }
        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();

            CargarGridHorario();
            CargarComboHorario();
        }

        private void btnReporteCursosHorario_Click(object sender, EventArgs e)
        {
            if (chkbxMostrarEliminados.Checked == false)
            {
                frmReporte reporte = new frmReporte();
                reporte.Eleccion = '3';/// lista de cursos segun horario en reporte
                reporte.IDParametro1 = int.Parse(cbxHorario.SelectedValue.ToString());
                reporte.Show();
            }
        }

        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
