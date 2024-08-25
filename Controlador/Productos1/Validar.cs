using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroServicios.Vista.Productos1;

namespace AgroServicios.Controlador.Productos1
{
    class Validar
    {
        public static void SoloLetras(KeyPressEventArgs V) 
        {
            if (Char.IsLetter(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else 
            {
                V.Handled = true;
                MessageBox.Show("Solo se pude agregar letras en esta casilla", "Solo letras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void SoloNumeros(KeyPressEventArgs V) 
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else 
            {
                V.Handled = true;
                MessageBox.Show("Solo se pude agregar numeros enteros en esta casilla", "Solo numeros enteros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void SoloDecimales(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (V.KeyChar.ToString().Equals("."))
            {
                V.Handled = true;
                MessageBox.Show("Solo se pude agregar numeros con punto decimal en esta casilla", "Solo numeros decimales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}