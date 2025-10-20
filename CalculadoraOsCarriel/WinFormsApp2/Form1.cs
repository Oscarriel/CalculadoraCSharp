namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// APAGAR PANTALLA ///
        private void btnonoff_Click(object sender, EventArgs e)
        {
            lblPantalla.Enabled = !lblPantalla.Enabled;

            if (lblPantalla.Enabled)
            {
                lblPantalla.BackColor = SystemColors.Window;
                lblPantalla.ForeColor = SystemColors.WindowText;

                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                btnSuma.Enabled = true;
                btnResta.Enabled = true;
                btnMultiplicar.Enabled = true;
                btnDivision.Enabled = true;
                btnC.Enabled = true;
                btnResultado.Enabled = true;

            }
            else
            {
                lblPantalla.BackColor = SystemColors.ControlDark;
                lblPantalla.ForeColor = SystemColors.GrayText;

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn0.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                btnSuma.Enabled = false;
                btnResta.Enabled = false;
                btnMultiplicar.Enabled = false;
                btnDivision.Enabled = false;
                btnC.Enabled = false;
                btnResultado.Enabled = false;
                lblPantalla.Text = "";
                btnC_Click(sender, e);
            }
        }
        private void lblPantalla_Click(object sender, EventArgs e)
        {

        }
        /// Codigo de Numeros ///
        private void btn7_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "8";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += "9";
        }
        /// CODIGO DE CLEAR///
        private void btnC_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "";
            val1 = 0;
            val2 = 0;
            operacion = 0;
        }
        /// OPERACIONES ///
        double val1 = 0;
        double val2 = 0;
        int operacion = 0; // 1= Suma, 2= Resta, 3= Multiplicacion, 4= Division 0= Ninguna
        private void GuardarVal1()
        {
            double.TryParse(lblPantalla.Text, out val1);
            lblPantalla.Text = "";
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            GuardarVal1();
            operacion = 4;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            GuardarVal1();
            operacion = 2;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            GuardarVal1();
            operacion = 1;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            GuardarVal1();
            operacion = 3;
        }
        /// RESULTADO ///
        private void btnResultado_Click(object sender, EventArgs e)
        {
            double.TryParse(lblPantalla.Text, out val2);

            switch (operacion)
            {
                case 1:
                    {
                        lblPantalla.Text = (val1 + val2).ToString();
                        break;
                    }
                case 2:
                    {
                        lblPantalla.Text = (val1 - val2).ToString();
                        break;
                    }
                case 3:
                    {
                        lblPantalla.Text = (val1 * val2).ToString();
                        break;
                    }
                case 4:
                    {
                        if (val2 != 0)
                        {
                            lblPantalla.Text = (val1 / val2).ToString();
                        }
                        else
                        {
                            lblPantalla.Text = "Sintax Error";
                        }
                        break;

                    }
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += ",";
        }
    }
}
