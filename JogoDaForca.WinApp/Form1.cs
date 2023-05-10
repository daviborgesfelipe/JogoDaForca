namespace JogoDaForca.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGerarFrutaAleatoria.Click += GerarFrutaAleatoria;
        }

        private void GerarFrutaAleatoria(object? sender, EventArgs e)
        {
            string[] frutas =
            {
                    "ABACATE",
                    "ABACAXI",
                    "ACEROLA",
                    "ACAI",
                    "ARACA",
                    "ABACATE",
                    "BACABA",
                    "BACURI",
                    "BANANA",
                    "CAJA",
                    "CAJU",
                    "CARAMBOLA",
                    "CAPUAÇU",
                    "GRAVIOLA",
                    "GOIABA",
                    "JABUTICABA",
                    "JENIPAPO",
                    "MACA",
                    "MANGABA",
                    "MANGA",
                    "MARACUJA",
                    "MURICI",
                    "PEQUI",
                    "PITANGA",
                    "PITAYA",
                    "SAPOTI",
                    "TANGERINA",
                    "UMBU",
                    "UVA",
                    "UVAIA"
                };
            Random random = new Random();
            string frutaAleatoria = frutas[random.Next(0, frutas.Length)];
            char[] frutaAdivinhada = new char[frutaAleatoria.Length];

            #region transformarPalavraEmTracinho
            for (int i = 0; i < frutaAdivinhada.Length; i++)
            {
                frutaAdivinhada[i] = '_';
            }

            string frutaAdivinhadaString = new string(frutaAdivinhada);
            TextBox textBox = new TextBox();
            textBox.Text = frutaAdivinhadaString;
            txtFrutaAleatoria.Text = textBox.Text;
            #endregion
        }
    }
}