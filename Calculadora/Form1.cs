namespace Calculadora
{
    public partial class Form1 : Form
    {

        double res = 0;
        double input;
        string strRes, strInput;
        int op = 1;
        bool jaCalc = false;

        private void showNumberInput()
        {
            txbInput.Text += $"{strInput}";
            input = Double.Parse(txbInput.Text);
        }

        private void showNumberInputDecim()
        {
            input = Double.Parse(strInput);
            txbInput.Text = $"{input}";
        }

        private void showNumberRes()
        {
            txbRes.Text = $"{strRes}";
            res = Double.Parse(txbRes.Text);
        }

        private void passaResult()
        {
            txbRes.Text = txbInput.Text;
            txbInput.Text = "";
            op = 1;
            jaCalc = true;
        }

        private void executaCalc()
        {
            switch (op){
                case 0:
                    res -= input;
                    break;
                case 1:
                    res += input;
                    break;
                case 2:
                    res /= input;
                    break;
                case 3:
                    res *= input;
                    break;
                case 4:
                    res *=res;
                    break;
                default:
                    break;
            }
            jaCalc = true;
            txbRes.Text = $"{res}";
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            strInput = $"{btn1.Text}";
            showNumberInput();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            strInput = $"{btn2.Text}";
            showNumberInput();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            strInput = $"{btn3.Text}";
            showNumberInput();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            strInput = $"{btn4.Text}";
            showNumberInput();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            strInput = $"{btn5.Text}";
            showNumberInput();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            strInput = $"{btn6.Text}";
            showNumberInput();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            strInput = $"{btn7.Text}";
            showNumberInput();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            strInput = $"{btn8.Text}";
            showNumberInput();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            strInput = $"{btn9.Text}";
            showNumberInput();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            passaResult();
            executaCalc();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            strRes = $"{res}";
            showNumberRes();
            passaResult();
            op = 0;
            executaCalc();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            strRes = $"{res}";
            showNumberRes();
            passaResult();

            op = 1;
            executaCalc();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {


            strRes = $"{res}";
            showNumberRes();
            if (jaCalc)
            {
                op = 2;
                executaCalc();
            }
            else
            {
                passaResult();
                jaCalc = true;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {

            strRes = $"{res}";
            showNumberRes();
            if (jaCalc)
            {
                op = 3;
                executaCalc();
            }
            else
            {
                passaResult();
                jaCalc = true;
            }
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            strRes = $"{res}";
            showNumberRes();
            passaResult();
            op = 4;
            executaCalc();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            txbInput.Text = "";
            strInput = "";
            input = 0;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txbInput.Text = "";
            strInput = "";
            input = 0;
            txbRes.Text = "";
            strRes = "";
            res = 0;
            jaCalc = false;
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            res *= (-1);
            strRes = $"{res}";
            showNumberRes();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            strInput = $"{btnPonto.Text}";
            showNumberInputDecim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}