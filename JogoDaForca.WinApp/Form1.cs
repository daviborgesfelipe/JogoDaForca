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

        private void ComparaLetraChuteComLetraFruta(object? sender, EventArgs e)
        {
            Button btnClicado = (Button)sender;
            bool letraFoiEncontrada = false;
            for (int i = 0; i < jogoDaForca.frutaAdivinhada.Length; i++)
            {
                char palpite = Convert.ToChar(btnClicado.Text);
                if (palpite == jogoDaForca.frutaAleatoria[i])
                {
                    jogoDaForca.frutaAdivinhada[i] = palpite;
                    letraFoiEncontrada = true;
                }
            }
            if (letraFoiEncontrada == false)
            {
                jogoDaForca.tentativas++;
                DesenhaBonecoConformeTentativaErro();
            }
            txtFrutaAleatoria.Text = new string(jogoDaForca.frutaAdivinhada);
            if (txtFrutaAleatoria.Text == jogoDaForca.frutaAleatoria)
            {
                txtFrutaAleatoria.Text = $"ACERTOU";
            }
            else if (jogoDaForca.enforcou)
            {
                txtFrutaAleatoria.Text = "ENFORCOU";
            }
        }


        private void DesenhaBonecoConformeTentativaErro()
        {
            if (txtFrutaAleatoria.Text == jogoDaForca.frutaAleatoria)
            {
                jogoDaForca.acertou = true;
            }
            else if (jogoDaForca.tentativas == 1)
            {
                labCabeca.Visible = true;
            }
            else if (jogoDaForca.tentativas == 2)
            {
                labBrancoEsq.Visible = true;
            }
            else if (jogoDaForca.tentativas == 3)
            {
                labBracoDir.Visible = true;
            }
            else if (jogoDaForca.tentativas == 4)
            {
                labTronco1.Visible = true;
            }
            else if (jogoDaForca.tentativas == 5)
            {
                labTronco2.Visible = true;
            }
            else if (jogoDaForca.tentativas == 6)
            {
                labPernaEsq.Visible = true;
            }
            else if (jogoDaForca.tentativas == 7)
            {
                labPernaDir.Visible = true;
                jogoDaForca.enforcou = true;
            }
        }
        private void DesativaVisibilidadeBoneco()
        {
            labCabeca.Visible = false;
            labBrancoEsq.Visible = false;
            labBracoDir.Visible = false;
            labTronco1.Visible = false;
            labTronco2.Visible = false;
            labPernaEsq.Visible = false;
            labPernaDir.Visible = false;
            jogoDaForca.tentativas = 0;
            jogoDaForca.enforcou = false;
        }
        private void GerarFrutaAleatoria(object? sender, EventArgs e)
        {
            GeraFrutaUmaAleatoria();
            TransformarPalavraEmTracinho();
            txtFrutaAleatoria.Text = new string(jogoDaForca.frutaAdivinhada);
            DesativaVisibilidadeBoneco();
            this.jogoDaForca.tentativas = 0;
        }
        private void ConfiguraClickBotao()
        {
            foreach (Button botao in tableLayoutPanel1.Controls)
            {
                botao.Click += ComparaLetraChuteComLetraFruta;
            }
            btnGerarFrutaAleatoria.Click += GerarFrutaAleatoria;
            /*
            btnA.Click += ComparaLetraChuteComLetraFruta;
            btnB.Click += ComparaLetraChuteComLetraFruta;
            btnC.Click += ComparaLetraChuteComLetraFruta;
            btnD.Click += ComparaLetraChuteComLetraFruta;
            btnE.Click += ComparaLetraChuteComLetraFruta;
            btnF.Click += ComparaLetraChuteComLetraFruta;
            btnG.Click += ComparaLetraChuteComLetraFruta;
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
             */
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