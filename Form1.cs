using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String operacion, borrado;
        double num1, num2, resultado;
       
        /// Inicio de botones numericos
        bool secuencia = true;
        private void b_0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0") {
                return;
            
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }
            
        }

        private void b_uno_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }
        }

        private void b_dos_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }

        private void b_tres_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }

        private void b_cuatro_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }

        private void b_punto_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = ".";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + ".";
            }
        }

        private void b_siete_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }

        private void b_ocho_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }

        private void b_nueve_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }

        private void b_cinco_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }

        

        private void b_seis_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                secuencia = false;

            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }

       

        //Fin de botones numericos

        //inicio de botones operacionales
         private void b_resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void b_multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "X";
            num1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

        private void b_divicion_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }
        private void b_mas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(Pantalla.Text);
            secuencia = true;
        }

       

        private void raiz_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Pantalla.Text);
            resultado = Math.Sqrt(num1);
            Pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        private void b_c_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = Pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0,x);
            Pantalla.Text = borrado;
            

            if (Pantalla.Text == "")
            {
                Pantalla.Text = "0";
                secuencia = true;
               
            }
            if (Pantalla.Text == "-")
            {
                Pantalla.Text = "0";
                secuencia = true;

            }

        }

        private void b_igual_Click(object sender, EventArgs e)
        {
          //  if (Pantalla.Text == "666") { Pantalla.Text = Pantalla.Text + "AMEN"; }
            num2 = double.Parse(Pantalla.Text);
            switch (operacion) {
                case "+": {
                        resultado = num1 + num2;
                        Pantalla.Text = resultado.ToString();
                        secuencia = true;
                        break; }
                case "X":
                    {
                        resultado = num1 * num2;
                        Pantalla.Text = resultado.ToString();
                        secuencia = true;
                        break;
                    }
                case "-":
                    {
                        resultado = num1 - num2;
                        Pantalla.Text = resultado.ToString();
                        secuencia = true;
                        break;
                    }
                case "/":
                    {
                        resultado = num1 / num2;
                        Pantalla.Text = resultado.ToString();
                        secuencia = true;
                        break;
                    }
            }
               

        }

        private void b_ce_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            resultado = 0;
            secuencia = true;
        }
    }
}
