﻿using SistemaMatricula.CapaIntegracion;
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


        }


        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public string Avisos { get => avisos; set => avisos = value; }
        private void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            //var database = client.GetDatabase("SECIV");

            //var categoriasDB = database.GetCollection<Categoria>("Categorias");


            //var categoria = new Categoria() { cod_Categoria = "9876344245", nombre_Categoria = "avvvvvdfs23a", descripcion_Categoria = "vvvvvv" };

            //categoriasDB.InsertOne(categoria);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }



        private void LimpiarTxts()
        {
        }

        private void CargarGridMatricula()
        {// cargado de matriculas activas o inactivas

        }

        private void CargarComboMatricula()
        {// cargado de matriculas activas o inactivas

        }

        private void CargarComboEstudiante()
        {

        }

    
    }
}
