using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Clase encargada de validacion de campos de texto
/// su funcion radica en captar el evento keypress de los campo de texto y determinar si 
/// lo digitado es numero o letras 
/// Asi pues si cumple con esto se acepta el digito sino no se inserta y se muestra un mensaje
/// 
/// La creacion de esta clase es atribuida a :  https://www.youtube.com/watch?v=V5cbzZAfDiE&list=WL&index=177&ab_channel=IsraelSistemas
/// Link descarga documento: http://www.mediafire.com/file/k99l7hrp7dp9gak/Validar_TextBox.rar/file
/// 
/// </summary>

namespace SistemaMatricula.CapaPresentacion.Validar_TextBox
{
    public class Validar
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {// deteccion de lectras en campo de texto y rechazo o aceptacion de estas
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Letras", "Error Digitacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {// deteccion de numeros en campo de texto y rechazo o aceptacion de estas
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }            
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros","Error Digitacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static void NumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo numeros o numeros con punto decimal");
            }
        }
    }
}
