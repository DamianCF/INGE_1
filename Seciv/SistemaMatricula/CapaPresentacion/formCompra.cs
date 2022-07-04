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
using MongoDB.Driver;
using CapaPresentacion.Models;

namespace CapaPresentacion
{
    public partial class formCompra : Form
    {
        DataSet dsMatricula = new DataSet();
        DataTable dtMatricula = new DataTable();
        private string estadoUsuario = "";
        private string avisos = ""; // string que recolecta errores en caso de existir al momento de insertar matricula
        int IDAulaAnterior = 0;

        string idCompra = "";


        public formCompra()
        {
            InitializeComponent();
        }

        private void formMatricula_Load(object sender, EventArgs e)
        {
            //if (estadoUsuario != "A") // desactivacion de ciertas funciones si el usuario es administrador
            //{
            //    chkbxMostrarEliminados.Enabled = false;
            //    chkbxMostrarEliminados.Visible = false;
            //    btnActivarEliminado.Enabled = false;
            //    btnActivarEliminado.Visible = false;
            //    btnReporteMatriculas.Enabled = false;
            //    btnReporteMatriculas.Visible = false;
            //}

            CargarGridMatricula();
        }


        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public string Avisos { get => avisos; set => avisos = value; }
        private void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            var categoriasDB = conexion.getCompras();
            var compra = new Compra() { Cod_Compra = txtCodCompra.Text.ToString(), Monto_Compra = int.Parse(txtMonto.Text.ToString()), Fecha_Compra = txtFecha.Text.ToString() };
            categoriasDB.InsertOne(compra);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            var categoriasDB = conexion.getCompras();
            var compra = new Compra() { id= idCompra, Cod_Compra = txtCodCompra.Text.ToString(), Monto_Compra = int.Parse(txtMonto.Text.ToString()), Fecha_Compra = txtFecha.Text.ToString() };
            categoriasDB.ReplaceOne(d=>d.id == idCompra, compra);
        }



        private void LimpiarTxts()
        {
        }

        private void CargarGridMatricula()
        {// cargado de matriculas activas o inactivas

            Conexion conexion = new Conexion();
            var categoriasDB = conexion.getCompras();
            //var compra = new Compra() { Cod_Compra = "23232", Monto_Compra = 150, Fecha_Compra = "vsffvv" };
            List<Compra> lst = categoriasDB.Find(d => true).ToList();
            dgvCompras.Columns.Add("id", "ID");
            dgvCompras.Columns["id"].Visible = false;
            dgvCompras.Columns.Add("codCompra", "Codigo compra");
            dgvCompras.Columns.Add("monto", "Monto");
            dgvCompras.Columns.Add("fecha", "Fecha de compra");
            foreach (Compra compra in lst)
            {
                dgvCompras.Rows.Add(compra.id.ToString(),compra.Cod_Compra.ToString(), compra.Monto_Compra.ToString(), compra.Fecha_Compra.ToString());
                Console.WriteLine(compra.Cod_Compra.ToString());
                //System.Diagnostics.Debug.WriteLine(compra.Cod_Compra.ToString());
                // MessageBox.Show(compra.Cod_Compra.ToString());
            }
            

        }

        private void CargarComboMatricula()
        {// cargado de matriculas activas o inactivas

        }

        private void CargarComboEstudiante()
        {

        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numFila = dgvCompras.CurrentCell.RowIndex;

            if(dgvCompras.CurrentCell.Value != null)
            {

                idCompra = this.dgvCompras[0, numFila].Value.ToString();

                string codCompra = this.dgvCompras[1, numFila].Value.ToString();
                txtCodCompra.Text = codCompra;

                string Monto = this.dgvCompras[2, numFila].Value.ToString();
                txtMonto.Text = Monto;

                string Fecha = this.dgvCompras[3, numFila].Value.ToString();
                txtFecha.Text = Fecha;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            var categoriasDB = conexion.getCompras();
            categoriasDB.DeleteOne(d => d.id == idCompra);
        }
    }
}
