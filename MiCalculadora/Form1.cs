namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double resultado = 0;
        private string operador = string.Empty;

        private void btn0_Click(object sender, EventArgs e)
        {
            IngresaNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            IngresaNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            IngresaNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            IngresaNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            IngresaNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            IngresaNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            IngresaNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            IngresaNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            IngresaNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            IngresaNumero("9");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "0";
            resultado = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!lblPantalla.Text.Contains("."))
            {
                lblPantalla.Text += ".";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                resultado += double.Parse(lblPantalla.Text);
            }
            else if (operador == "-")
            {
                resultado -= double.Parse(lblPantalla.Text);
            }
            else if (operador == "*")
            {
                resultado *= double.Parse(lblPantalla.Text);
            }
            else if (operador == "/")
            {
                resultado /= double.Parse(lblPantalla.Text);
            }
            else
            {
                resultado = double.Parse(lblPantalla.Text);
            }
            operador = "+";
            lblPantalla.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                resultado += double.Parse(lblPantalla.Text);
                lblPantalla.Text = resultado.ToString();
                resultado = 0;
            }
            if (operador == "-")
            {
                resultado -= double.Parse(lblPantalla.Text);
                lblPantalla.Text = resultado.ToString();
                resultado = 0;
            }
            if (operador == "*")
            {
                resultado *= double.Parse(lblPantalla.Text);
                lblPantalla.Text = resultado.ToString();
                resultado = 0;

            }
            if (operador == "/")
            {
                resultado /= double.Parse(lblPantalla.Text);
                lblPantalla.Text = resultado.ToString();
                resultado = 0;
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                resultado += double.Parse(lblPantalla.Text);
            }
            else if (operador == "-")
            {
                resultado -= double.Parse(lblPantalla.Text);
            }
            else if (operador == "*")
            {
                resultado *= double.Parse(lblPantalla.Text);
            }
            else if (operador == "/")
            {
                resultado /= double.Parse(lblPantalla.Text);

            }
            else
            {
                resultado = double.Parse(lblPantalla.Text);
            }
            operador = "-";
            lblPantalla.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            RealizaOperacion("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            
            RealizaOperacion("/");
        }

        private void RealizaOperacion(string opera)
        {
            if (opera == "+")
            {
                resultado += double.Parse(lblPantalla.Text);


            }
            else if (opera == "-")
            {
                resultado -= double.Parse(lblPantalla.Text);


            }
            else if (opera == "*")
            {
                resultado *= double.Parse(lblPantalla.Text);


            }
            else if (opera == "/")
            {
                resultado /= double.Parse(lblPantalla.Text);

            }
            else
            {
                resultado = double.Parse(lblPantalla.Text);
            }
            operador = opera;
            lblPantalla.Text = "0";// This method is currently not used.
        }

        private void IngresaNumero(string numero)
        {
            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = numero;
            }
            else
            {
                lblPantalla.Text += numero;
            }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            btn0.Enabled = false;
        }
    }
}
