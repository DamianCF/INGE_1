using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Reportes;
using CrystalDecisions.CrystalReports.Engine;

namespace CapaPresentacion
{
    public partial class frmReporte : Form
    {

        private char eleccion; // atributo para elegir que reporte cargar 
        private int IDParametro; // atributo de parametro para reportes con parametros
        

        public frmReporte()
        {
            InitializeComponent();
        }
        public char Eleccion { get => eleccion; set => eleccion = value; }
        public int IDParametro1 { get => IDParametro; set => IDParametro = value; }

        private void frmReporte_Load(object sender, EventArgs e)
        {// metodo para elegir reporte a mostrar
            
            ReportDocument miReporte = new ReportDocument();

            if (eleccion == 'P')
            {
                miReporte.Load(@"Reportes\crProfesores.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if(eleccion == 'A'){
                miReporte.Load(@"Reportes\crAulas.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if (eleccion == 'C')
            {
                miReporte.Load(@"Reportes\crCursos.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if (eleccion == 'E')
            {
                miReporte.Load(@"Reportes\crEstudiantes.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if (eleccion == 'G')
            {
                miReporte.Load(@"Reportes\crGrupos.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if (eleccion == 'H')
            {
                miReporte.Load(@"Reportes\crHorarios.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if (eleccion == 'M')
            {
                miReporte.Load(@"Reportes\crMatriculas.rpt");
                crvReporte.ReportSource = miReporte;
            }
            else if (eleccion == '1') //  lista de estudiantes del curso
            {
                crEstudiantesCurso reporte = new crEstudiantesCurso();
                reporte.SetParameterValue("@Curso_id", IDParametro);
                crvReporte.ReportSource = reporte;
            }
            else if (eleccion == '2') //  lista de cursos segun profesor
            {
                crCursosProfesor reporte = new crCursosProfesor();
                reporte.SetParameterValue("@Profesor_id", IDParametro);
                crvReporte.ReportSource = reporte;
            }
            else if (eleccion == '3') //  lista de cursos segun horario
            {
                crCursosHorario reporte = new crCursosHorario();
                reporte.SetParameterValue("@Horario_id", IDParametro);
                crvReporte.ReportSource = reporte;
            }

        }

        private void crvReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
