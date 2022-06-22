using System;
using System.Data;
using SistemaMatricula.CapaIntegracion;
using System.Windows.Forms;
using SistemaMatricula.CapaPresentacion.Validar_TextBox;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class formCurso : Form
    {

        DataSet dsCurso = new DataSet();
        DataTable dtCurso = new DataTable();
        private string estadoUsuario = "";


        public formCurso()
        {
            InitializeComponent();
        }

        private void formCurso_Load(object sender, EventArgs e)
        {
            if (estadoUsuario != "A") // desactivacion de ciertas funciones si el usuario es administrador
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteCursos.Enabled = false;
                btnReporteCursos.Visible = false;
                btnReporteEstCurso.Enabled = false;
                btnReporteEstCurso.Visible = false;
            }
            validarCampo();
            CargarGridCurso();
            CargarComboCurso();

        }

        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        private void btnCurso_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.insertarCurso(txtCurso_nombre.Text, txtCurso_creditos.Text,
                    txtCurso_cupo.Text, "A");
            }

            LimpiarTxts();

            CargarGridCurso();
            CargarComboCurso();

        }

        private void LimpiarTxts()
        {
            txtCurso_nombre.ResetText();
            txtCurso_creditos.ResetText();
            txtCurso_cupo.ResetText();
            validarCampo();

        }

        private void CargarGridCurso() // metododo que carga el grid con cursos con activas o inactivas
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    dgvCursos.DataSource = elCurso.ListarCursosInactivos();
                }
                else
                {
                    dgvCursos.DataSource = elCurso.ListarCurso();
                }


                dgvCursos.Columns["Curso_id"].Visible = false;
                dgvCursos.Columns["Curso_nombre"].HeaderText = "Nombre";
                dgvCursos.Columns["Curso_creditos"].HeaderText = "Creditos";
                dgvCursos.Columns["Curso_cupo"].HeaderText = "Cupo";
                dgvCursos.Columns["Curso_estado"].Visible = false;

            }
        }

        private void CargarComboCurso() // metododo que carga el comboboxAula con cursos activas o inactivas
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    cbxCurso.DataSource = elCurso.ListarCursosInactivos();
                }
                else
                {
                    cbxCurso.DataSource = elCurso.ListarCurso();
                }

                cbxCurso.ValueMember = "Curso_id";
                cbxCurso.DisplayMember = "Curso_nombre";// despliega  pero selecciona id
            }
        }
        private void BuscarCurso()
        {
            int Curso_id = int.Parse(cbxCurso.SelectedValue.ToString());


            using (GestorCurso Curso = new GestorCurso())
            {
                this.dsCurso = Curso.ConsultarCurso(Curso_id);
                this.dtCurso = this.dsCurso.Tables[0];
            }
            CargarDatosCurso();
        }

        private void CargarDatosCurso()
        {
            txtCurso_nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            txtCurso_creditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            txtCurso_cupo.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarCurso();
        }

        private void dgvCursoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvCursos.CurrentCell.RowIndex;
                int Curso_id = int.Parse(this.dgvCursos[0, numFila].Value.ToString());


                using (GestorCurso Curso = new GestorCurso())
                {
                    this.dsCurso = Curso.ConsultarCurso(Curso_id);
                    this.dtCurso = this.dsCurso.Tables[0];
                }
                CargarDatosCurso();
                cbxCurso.SelectedIndex = numFila;
                validarCampo();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta", // mensage 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.FormatException) // fila vacia
            {
                MessageBox.Show("Elemento de tabla no seleccionado", "Error Eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {                               //si cambia la variable a global Curso_id y le manda esa funciona si se seleciona desde el grid
                elCurso.ModificarCurso(int.Parse(cbxCurso.SelectedValue.ToString()), txtCurso_nombre.Text, txtCurso_creditos.Text,
                                            txtCurso_cupo.Text, "A");
            }
            CargarGridCurso();
            CargarComboCurso();
        }

        private void btnReporteCursoes_Click(object sender, EventArgs e) // apertura reporte cursos
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'C';
            reporte.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCursos.ClearSelection();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void txtCurso_creditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();

        }

        private void txtCurso_cupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();

        }

        private void txtCurso_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();

        }

        private void validarCampo()// valida campos de texto para activar o desactivar ciertos botones y mas
        {
            var vr = !string.IsNullOrEmpty(txtCurso_nombre.Text) &&
                !string.IsNullOrEmpty(txtCurso_creditos.Text) &&
                !string.IsNullOrEmpty(txtCurso_cupo.Text);

            btnModificar.Enabled = vr;
            btnCurso_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            btnReporteEstCurso.Enabled = vr;

            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnCurso_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
                btnReporteEstCurso.BackColor = Color.CornflowerBlue;

            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnCurso_Insertar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
                btnReporteEstCurso.BackColor = Color.Gray;

            }
            // boton btnActivarEliminado manejo mas especifico
            if (vr && chkbxMostrarEliminados.Checked)
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.BackColor = Color.Gray;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //busca que el curso no este en  matriculas
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de curso en matriculas de estudiante
                {
                    DataTable repetidos = elMatricula.ListarMatriculasCurso(int.Parse(cbxCurso.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error eliminar curso  en matriculas");
                        MessageBox.Show(" curso con estudiantes matriculados", "Error eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (GestorCurso elCurso = new GestorCurso())
                        {
                            elCurso.InactivarCurso(int.Parse(cbxCurso.SelectedValue.ToString()));
                        }
                        LimpiarTxts();

                        CargarGridCurso();
                        CargarComboCurso();

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error eliminar curso  en matriculas catch");
            }


        }

        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();
            CargarGridCurso();
            CargarComboCurso();
        }

        private void btnReporteEstCurso_Click(object sender, EventArgs e)
        {
            if (chkbxMostrarEliminados.Checked == false)
            {
                frmReporte reporte = new frmReporte();
                reporte.Eleccion = '1';/// lista de estudiantes del curso reporte
                reporte.IDParametro1 = int.Parse(cbxCurso.SelectedValue.ToString());
                reporte.Show();
            }
        }
    }
}
