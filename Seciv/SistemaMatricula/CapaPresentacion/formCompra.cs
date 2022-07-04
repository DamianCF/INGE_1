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
using SistemaMatricula.CapaPresentacion.Validar_TextBox;

namespace CapaPresentacion
{
    public partial class formCompra : Form
    {
        string idCompra = "";
        Conexion conexion = new Conexion();
        List<Compra> lst;

        public formCompra()
        {
            InitializeComponent();
        }

        private void formMatricula_Load(object sender, EventArgs e)
        {
            dgvCompras.Columns.Add("id", "ID");
            dgvCompras.Columns["id"].Visible = false;
            dgvCompras.Columns.Add("codCompra", "Codigo compra");
            this.dgvCompras.Columns["codCompra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns.Add("monto", "Monto");
            this.dgvCompras.Columns["monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns.Add("fecha", "Fecha de compra");
            this.dgvCompras.Columns["fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CargarGridMatricula();
        }

        private void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            var categoriasDB = conexion.getCompras();
            var compra = new Compra() { Cod_Compra = txtCodCompra.Text.ToString(), Monto_Compra = int.Parse(txtMonto.Text.ToString()), Fecha_Compra = txtFecha.Text.ToString() };
            categoriasDB.InsertOne(compra);
            CargarGridMatricula();
            LimpiarTxts();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var categoriasDB = conexion.getCompras();
            var compra = new Compra() { id= idCompra, Cod_Compra = txtCodCompra.Text.ToString(), Monto_Compra = int.Parse(txtMonto.Text.ToString()), Fecha_Compra = txtFecha.Text.ToString() };
            categoriasDB.ReplaceOne(d=>d.id == idCompra, compra);
            CargarGridMatricula();
            LimpiarTxts();
        }



        private void LimpiarTxts()
        {
            idCompra = "";
            txtCodCompra.Clear();
            txtFecha.Clear();
            txtMonto.Clear();
        }

        private void CargarGridMatricula()
        {
            dgvCompras.Rows.Clear();
            var comprasDB = conexion.getCompras();
            lst = comprasDB.Find(d => true).ToList();
            foreach (Compra compra in lst)
            {
                dgvCompras.Rows.Add(compra.id.ToString(),compra.Cod_Compra.ToString(), compra.Monto_Compra.ToString(), compra.Fecha_Compra.ToString());
            }  
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
            var categoriasDB = conexion.getCompras();
            categoriasDB.DeleteOne(d => d.id == idCompra);
            CargarGridMatricula();
            LimpiarTxts();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
