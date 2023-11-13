namespace Practica3._1.GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegramaODGM;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegramaODGM = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
            if (rbOrdinario.Checked)
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            //numPalabras = textoTelegrama.Length;  cuenta letras, no palabras
            char[] delimitadores = new char[] { ' ', '\r', '\n' };
            numPalabras = textoTelegramaODGM.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * (numPalabras - 10);
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}