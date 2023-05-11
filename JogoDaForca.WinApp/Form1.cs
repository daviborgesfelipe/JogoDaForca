using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace JogoDaForca.WinApp
{
    public partial class Form1 : Form
    {
        JogoDaForca jogoDaForca = new JogoDaForca();
        public Form1()
        {
            InitializeComponent();
            ConfiguraClickBotao();
        }

        private void ConfiguraClickBotao()
        {
            btnGerarFrutaAleatoria.Click += GerarFrutaAleatoria;
            btnA.Click += ComparaLetraChuteComLetraFruta;
            btnB.Click += ComparaLetraChuteComLetraFruta;
            btnC.Click += ComparaLetraChuteComLetraFruta;
            btnD.Click += ComparaLetraChuteComLetraFruta;
            btnE.Click += ComparaLetraChuteComLetraFruta;
            btnF.Click += ComparaLetraChuteComLetraFruta;
            btnH.Click += ComparaLetraChuteComLetraFruta;
            btnI.Click += ComparaLetraChuteComLetraFruta;
            btnJ.Click += ComparaLetraChuteComLetraFruta;
            btnK.Click += ComparaLetraChuteComLetraFruta;
            btnL.Click += ComparaLetraChuteComLetraFruta;
            btnM.Click += ComparaLetraChuteComLetraFruta;
            btnN.Click += ComparaLetraChuteComLetraFruta;
            btnO.Click += ComparaLetraChuteComLetraFruta;
            btnP.Click += ComparaLetraChuteComLetraFruta;
            btnQ.Click += ComparaLetraChuteComLetraFruta;
            btnR.Click += ComparaLetraChuteComLetraFruta;
            btnS.Click += ComparaLetraChuteComLetraFruta;
            btnT.Click += ComparaLetraChuteComLetraFruta;
            btnU.Click += ComparaLetraChuteComLetraFruta;
            btnV.Click += ComparaLetraChuteComLetraFruta;
            btnX.Click += ComparaLetraChuteComLetraFruta;
            btnZ.Click += ComparaLetraChuteComLetraFruta;
            btnW.Click += ComparaLetraChuteComLetraFruta;
        }

        private void ComparaLetraChuteComLetraFruta(object? sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            bool frutaFoiEncontrada = false;
            for (int i = 0; i < jogoDaForca.frutaAdivinhada.Length; i++)
            {
                char btn = Convert.ToChar(btnClicado.Text);
                if (btn == jogoDaForca.frutaAleatoria[i])
                {
                    jogoDaForca.frutaAdivinhada[i] = btn;
                    frutaFoiEncontrada = true;
                }
            }
            if (frutaFoiEncontrada == false)
            {
                jogoDaForca.tentativas++;
            }
            TextBox frutaEmTextBox = new TextBox(); 
            string frutaEmString = new string(jogoDaForca.frutaAdivinhada);
            frutaEmTextBox.Text = frutaEmString;

            jogoDaForca.acertou = frutaEmTextBox.Text == jogoDaForca.frutaAleatoria;
            txtFrutaAleatoria.Text = frutaEmTextBox.Text;
            if(jogoDaForca.acertou)
            {
                txtFrutaAleatoria.Text = $"ACERTOU" ;
            }
            else if(jogoDaForca.tentativas == 5)
            {
                jogoDaForca.enforcou = true;
                txtFrutaAleatoria.Text = "ENFORCOU";
            }
        }

        private void GerarFrutaAleatoria(object? sender, EventArgs e)
        {
            GeraFrutaUmaAleatoria();
            TransformarPalavraEmTracinho();
            AdicionaFrutaAleatoriaNoTextBox();
            this.jogoDaForca.tentativas = 0;
        }

        private void AdicionaFrutaAleatoriaNoTextBox()
        {
            string fruntaConvertitaEmTrancosString = new string(jogoDaForca.frutaAdivinhada);
            TextBox frutaConvertidaEmTextBox = new TextBox();
            frutaConvertidaEmTextBox.Text = fruntaConvertitaEmTrancosString;
            txtFrutaAleatoria.Text = frutaConvertidaEmTextBox.Text;
        }

        private void GeraFrutaUmaAleatoria()
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
            jogoDaForca.frutaAleatoria = frutas[random.Next(0, frutas.Length)];
        }

        private void TransformarPalavraEmTracinho()
        {
            jogoDaForca.frutaAdivinhada = new char[jogoDaForca.frutaAleatoria.Length];
            for (int i = 0; i < jogoDaForca.frutaAdivinhada.Length; i++)
            {
                jogoDaForca.frutaAdivinhada[i] = '_';
            }
        }
    }
}