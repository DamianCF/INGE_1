using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formLogin());//new frmProfesor()

            formPrincipal login = new formPrincipal();  // apertura del form login
            login.FormClosed += MainForm_Closed; 
            login.Show();
            Application.Run(); 
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        { // metodo que permite pasar entre forms sin que se cierre la aplicacion al cerrar el principal
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }

            // Link de metodo: https://es.stackoverflow.com/questions/38427/c%C3%B3mo-cerrar-un-form-en-c-y-que-se-habra-otro
        }
    }
}
