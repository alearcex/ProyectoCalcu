using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCalculadora1.Calculadora_Proyecto.Menu
{
    public partial class menu_proyecto : Page
    {
        private static float num1 = 0;
        private static string operacion = "";

        //Este método hace el ingreso de números en el txt por medio de los botones
        protected void NumerosClick(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            string num = boton.Text;
            Tvalor1.Text += num;
        }

        //Cambia el número del txt de negativo a positivo
        protected void MasMenosClick(object sender, EventArgs e)
        {
            if (Tvalor1.Text.StartsWith("-"))
            {
                Tvalor1.Text = Tvalor1.Text.Substring(1);
            }
            else
            {
                Tvalor1.Text = "-" + Tvalor1.Text;
            }
        }

        //Agrega el "." al txt
        protected void PuntoClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tvalor1.Text))
            {
                Tvalor1.Text = "0.";
            }
            else
            {
                Tvalor1.Text += ",";
            }
        }

        //Borra solo el elemento final de la cadena que haya en el txt
        protected void BorrarClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Tvalor1.Text))
            {
                //Substring devuelve todos los valores de la cadena menos el último
                Tvalor1.Text = Tvalor1.Text.Substring(0, Tvalor1.Text.Length - 1);
            }
        }

        //Vacía el txt
        protected void LimpiarClick(object sender, EventArgs e)
        {
            Tvalor1.Text = string.Empty;
            operacion = string.Empty;
        }

        //Cacula la raíz del botón que hay en pantalla
        protected void RaizClick(object sender, EventArgs e)
        {
            float valor;
            if (float.TryParse(Tvalor1.Text, out valor))
            {
                float resultado = (float)Math.Sqrt(valor);
                Tvalor1.Text = resultado.ToString();
            }
            else
            {
                Tvalor1.Text = "Error";
            }
        }

        //Hace el cálculo del número al cuadrado
        protected void CuadradoClick(object sender, EventArgs e)
        {
            float valor;
            if (float.TryParse(Tvalor1.Text, out valor))
            {
                float resultado = (float)Math.Pow(valor, 2);
                Tvalor1.Text = resultado.ToString();
            }
            else
            {
                Tvalor1.Text = "Error";
            }
        }

        //Hace el cálculo del número al cuadrado
        protected void FactClick(object sender, EventArgs e)
        {
            float valor;
            float respuesta = 1;
            if (float.TryParse(Tvalor1.Text, out valor))
            {
                if (valor != 0 || valor != 1)
                {
                    for (int i = 1; i <= valor; i++)
                    {
                        respuesta *= i;
                    }
                }

                Tvalor1.Text = respuesta.ToString();
            }
            else
            {
                Tvalor1.Text = "Error";
            }
        }

        //Guarda el valor de num1 y la operación que se quiere realizar
        protected void OperacionClick(object sender, EventArgs e)
        {
            if (float.TryParse(Tvalor1.Text, out float valorActual))
            {
                var boton = (Button)sender;

                num1 = valorActual;
                Tvalor1.Text = string.Empty;
                operacion = boton.Text;
            }
            else
            {
                Tvalor1.Text = "Error";
            }
        }

        protected void IgualClick(object sender, EventArgs e)
        {
            if (float.TryParse(Tvalor1.Text, out float num2))
            {
                float resultado;
                switch (operacion)
                {
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "×":
                        resultado = num1 * num2;
                        break;
                    case "÷":
                        resultado = num1 / num2;
                        break;
                    case "xⁿ":
                        resultado = (float)Math.Pow(num1, num2);
                        break;
                    default:
                        resultado = num2;
                        break;
                }

                Tvalor1.Text = resultado.ToString();
            }
            else
            {
                Tvalor1.Text = "Error";
            }
        }

        protected void LogClick(object sender, EventArgs e)
        {
            float valor;
            if (float.TryParse(Tvalor1.Text, out valor))
            {
                float resultado = (float)Math.Log10(valor);
                Tvalor1.Text = resultado.ToString();
            }
            else
            {
                Tvalor1.Text = "Error";
            }

        }

        protected void B10xClick(object sender, EventArgs e)
        {
            float valor;
            if (float.TryParse(Tvalor1.Text, out valor))
            {
                float resultado = (float)Math.Pow(10, valor);
                Tvalor1.Text = resultado.ToString();
            }
            else
            {
                Tvalor1.Text = "Error";
            }
        }
    }
}
