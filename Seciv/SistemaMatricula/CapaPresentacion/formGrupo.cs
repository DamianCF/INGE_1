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
    public partial class formGrupo : Form
    {
        DataSet dsGrupo = new DataSet();
        DataTable dtGrupo = new DataTable();
        private string estadoUsuario = "";
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        public formGrupo()
        {
            InitializeComponent();
        }

        private void formGrupo_Load(object sender, EventArgs e)
        {
            if (estadoUsuario != "A") // desactivacion de ciertas funciones si el usuario es administrador
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteGrupos.Enabled = false;
                btnReporteGrupos.Visible = false;
            }
            validarCampo();
            CargarGridGrupo();
            CargarComboGrupo();

        }


        private void btnGrupo_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.insertarGrupo(txtGrupo_descripcion.Text, "A");
            }

            LimpiarTxts();

            CargarGridGrupo();
            CargarComboGrupo();

        }

        private void LimpiarTxts()
        {
            txtGrupo_descripcion.ResetText();
            validarCampo();

        }

        private void CargarGridGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {

                if (chkbxMostrarEliminados.Checked)
                {
                    dgvGrupos.DataSource = elGrupo.ListarGruposInactivos();
                }
                else
                {
                    dgvGrupos.DataSource = elGrupo.ListarGrupo();
                }


                dgvGrupos.Columns["Grupo_id"].Visible = false;
                dgvGrupos.Columns["Grupo_descripcion"].HeaderText = "Descripcion";
                dgvGrupos.Columns["Grupo_estado"].Visible = false;

            }
        }

        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    cbxGrupo.DataSource = elGrupo.ListarGruposInactivos();
                }
                else
                {
                    cbxGrupo.DataSource = elGrupo.ListarGrupo();
                }


                cbxGrupo.ValueMember = "Grupo_id";
                cbxGrupo.DisplayMember = "Grupo_descripcion";// despliega descripcion pero selecciona id
            }
        }
        private void BuscarGrupo()
        {
            int Grupo_id = int.Parse(cbxGrupo.SelectedValue.ToString());


            using (GestorGrupo Grupo = new GestorGrupo())
            {
                this.dsGrupo = Grupo.ConsultarGrupo(Grupo_id);
                this.dtGrupo = this.dsGrupo.Tables[0];
            }
            CargarDatosGrupo();
        }

        private void CargarDatosGrupo()
        {
            txtGrupo_descripcion.Text = this.dtGrupo.Rows[0]["Grupo_descripcion"].ToString();


        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarGrupo();
        }

        private void dgvGrupoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvGrupos.CurrentCell.RowIndex;
                int Grupo_id = int.Parse(this.dgvGrupos[0, numFila].Value.ToString());


                using (GestorGrupo Grupo = new GestorGrupo())
                {
                    this.dsGrupo = Grupo.ConsultarGrupo(Grupo_id);
                    this.dtGrupo = this.dsGrupo.Tables[0];
                }
                CargarDatosGrupo();
                cbxGrupo.SelectedIndex = numFila;
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
            using (GestorGrupo elGrupo = new GestorGrupo())
            {                               //si cambia la variable a global Grupo_id y le manda esa funciona si se seleciona desde el grid
                elGrupo.ModificarGrupo(int.Parse(cbxGrupo.SelectedValue.ToString()), txtGrupo_descripcion.Text, "A");
            }
            CargarGridGrupo();
            CargarComboGrupo();
        }

        private void btnReporteGrupoes_Click(object sender, EventArgs e)
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'G';
            reporte.Show();
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
            var vr = !string.IsNullOrEmpty(txtGrupo_descripcion.Text);

            btnModificar.Enabled = vr;
            btnGrupo_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnGrupo_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnGrupo_Insertar.BackColor = Color.Gray;
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
            //busca que el   grupo
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de grupo en matriculas de estudiante
                {
                    DataTable repetidos = elMatricula.ListarMatriculasGrupo(int.Parse(cbxGrupo.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error eliminar grupo");
                        MessageBox.Show(" grupo con estudiantes matriculados", "Error eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        using (GestorGrupo elGrupo = new GestorGrupo())
                        {
                            elGrupo.InactivarGrupo(int.Parse(cbxGrupo.SelectedValue.ToString()));
                        }
                        LimpiarTxts();

                        CargarGridGrupo();
                        CargarComboGrupo();

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error eliminar grupo catch");
            }


        }


        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();

            CargarGridGrupo();
            CargarComboGrupo();
        }
    }
}
