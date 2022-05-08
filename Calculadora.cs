namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double numero1;
        double numero2;
        string operacion;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.Suma suma = new Clases.Suma();
        Clases.Resta resta = new Clases.Resta();
        Clases.Multiplicacion multi = new Clases.Multiplicacion();
        Clases.Division div = new Clases.Division();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "8";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + ".";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "9";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(tbxResultado.Text);

            double S;
            double R;
            double M;
            double D;

            switch (operacion)
            {
                case "+":
                    S = suma.Sumar((numero1), (numero2));
                    tbxResultado.Text = S.ToString();
                    break;

                case "-":
                    R = resta.Restar((numero1), (numero2));
                    tbxResultado.Text = R.ToString();
                    break;

                case "*":
                    M = multi.Multiplicar((numero1), (numero2));
                    tbxResultado.Text = M.ToString();
                    break;

                case "/":
                    D = div.Dividir((numero1), (numero2));
                    tbxResultado.Text = D.ToString();
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbxResultado.Clear();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxResultado.ClearUndo();
        }
    }
}