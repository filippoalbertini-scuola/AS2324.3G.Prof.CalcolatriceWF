namespace AS2324._3G.Prof.CalcolatriceWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            double operando1 = Convert.ToDouble(txtOperando1.Text);
            double operando2 = Convert.ToDouble(txtOperando2.Text);

            double risultato = 0;

            switch (cmbOperatore.Text)
            {
                case "+":
                    risultato = operando1 + operando2;
                    break;
                case "-":
                    risultato = operando1 - operando2;
                    break;
                case "*":
                    risultato = operando1 * operando2;
                    break;
                case "/":
                    // TODO: gestire denominatore uguale a 0
                    risultato = operando1 / operando2;
                    break;
            }

            // comunichiamo a video il risultato

            lblRisultato.Text = $"Risultato {risultato}";
        }
    }
}
