using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaIntegracion;
using SistemaMatricula.CapaPresentacion.Validar_TextBox;
// ctrl +k+d acomodo codigo

namespace CapaPresentacion
{
    public partial class formAula : Form
    {

        DataSet dsAula = new DataSet();
        DataTable dtAula = new DataTable();
        private string estadoUsuario = "";


        public formAula()
        {
            InitializeComponent();
        }

        private void formAula_Load(object sender, EventArgs e)
        {
            if (estadoUsuario != "A")  // desactivacion de ciertas funciones si el usuario es administrador
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteAulas.Enabled = false;
                btnReporteAulas.Visible = false;
            }
            validarCampo();
            CargarGridAula();
            CargarComboAula();
        }

        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        private void btnAula_Insertar_Click_1(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.insertarAula(txtAula_descripcion.Text, txtAula_capacidad.Text, "A");
            }
            LimpiarTxts();
            CargarGridAula();
            CargarComboAula();
        }


        private void LimpiarTxts()
        {
            txtAula_descripcion.ResetText();
            txtAula_capacidad.Text = "0";
            validarCampo();
        }

        private void CargarGridAula() // metododo que carga el grid con aulas con activas o inactivas
        {
            using (GestorAula elAula = new GestorAula())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    dgvAulas.DataSource = elAula.ListarAulasInactivas();
                }
                else
                {
                    dgvAulas.DataSource = elAula.ListarAula();
                }


                dgvAulas.Columns["Aula_id"].Visible = false;
                dgvAulas.Columns["Aula_descripcion"].HeaderText = " Descripcion";
                dgvAulas.Columns["Aula_capacidad"].HeaderText = "Capacidad";
                dgvAulas.Columns["Aula_estado"].Visible = false;

            }
        }


        private void CargarComboAula() // metododo que carga el comboboxAula con aulas activas o inactivas
        {
            using (GestorAula elAula = new GestorAula())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    cbxAula.DataSource = elAula.ListarAulasInactivas();
                }
                else
                {
                    cbxAula.DataSource = elAula.ListarAula();
                }

                cbxAula.ValueMember = "Aula_id";
                cbxAula.DisplayMember = "Aula_descripcion";
            }
        }
        private void BuscarAula()
        {
            int Aula_id = int.Parse(cbxAula.SelectedValue.ToString());


            using (GestorAula Aula = new GestorAula())
            {
                this.dsAula = Aula.ConsultarAula(Aula_id);
                this.dtAula = this.dsAula.Tables[0];
            }
            CargarDatosAula();
        }

        private void CargarDatosAula()
        {
            txtAula_descripcion.Text = this.dtAula.Rows[0]["Aula_descripcion"].ToString();
            txtAula_capacidad.Text = this.dtAula.Rows[0]["Aula_capacidad"].ToString();
        }

        private void btnCargarDatos_Click_1(object sender, EventArgs e)
        {
            BuscarAula();
        }

        private void dgvAulaes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvAulas.CurrentCell.RowIndex;
                int Aula_id = int.Parse(this.dgvAulas[0, numFila].Value.ToString());


                using (GestorAula Aula = new GestorAula())
                {
                    this.dsAula = Aula.ConsultarAula(Aula_id);
                    this.dtAula = this.dsAula.Tables[0];
                }
                CargarDatosAula();
                cbxAula.SelectedIndex = numFila;
                validarCampo();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta", // mensage 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.FormatException) /// por si se selecciona una fila vacia
            {
                MessageBox.Show("Elemento de tabla no seleccionado", "Error Eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {                               //si cambia la variable a global Aula_id y le manda esa funciona si se seleciona desde el grid
                elAula.ModificarAula(int.Parse(cbxAula.SelectedValue.ToString()), txtAula_descripcion.Text,
                                            txtAula_capacidad.Text, "A");
            }
            CargarGridAula();
            CargarComboAula();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarTxts();

        }

        private void cbxAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAulas.ClearSelection();
        }

        private void btnReporteAulas_Click(object sender, EventArgs e) // mostrar reporte aulas
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'A';
            reporte.Show();

        }

        private void txtAula_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void txtAula_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);  // validaciones de campo de texto
            validarCampo();
        }

        private void validarCampo() // valida campos de texto para activar o desactivar ciertos botones y mas
        {                           // ademas se cambia de color a ciertas cosas
            var vr = !string.IsNullOrEmpty(txtAula_descripcion.Text) &&
                !string.IsNullOrEmpty(txtAula_capacidad.Text);

            btnModificar.Enabled = vr;
            btnAula_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnAula_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnAula_Insertar.BackColor = Color.Gray;
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

            //busca que el aula no este en  matriculas
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de aula en matriculas de estudiante
                {
                    DataTable repetidos = elMatricula.ListarMatriculasAula(int.Parse(cbxAula.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error eliminar aula ");
                        MessageBox.Show(" aula con estudiantes matriculados", "Error eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        using (GestorAula elAula = new GestorAula())
                        {
                            elAula.InactivarAula(int.Parse(cbxAula.SelectedValue.ToString()));
                        }
                        LimpiarTxts();

                        CargarGridAula();
                        CargarComboAula();

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error eliminar aula   catch");
            }


        }

        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            // el chkbxMostrarEliminados funcionara como activador para activar la funcionalida de recuperacion
            LimpiarTxts();
            CargarGridAula();
            CargarComboAula();
        }
    }
}
