namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                #region geraPalavraAleatoria
                string[] frutas =
                {
                    "ABACATE",
                    "ABACAXI",
                    "ACEROLA",
                    "AÇAI",
                    "ARAÇA",
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
                    "MAÇÃ",
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
                #endregion

                #region transformarPalavraEmTracinho
                for (int i = 0; i < frutaAdivinhada.Length; i++)
                {
                    frutaAdivinhada[i] = '_';
                }
                #endregion

                Console.WriteLine(frutaAdivinhada);
                Console.WriteLine(frutaAleatoria);
                #region desenhaLogo
                    Console.WriteLine("+----------------+");
                    Console.WriteLine("| Jogo de Forca  |");
                    Console.WriteLine("+----------------+");
                    int tentativas = 0;
                    bool acertou = false, enforcou = false;
                #endregion
                #region jogoDaForca
                while (acertou == false && enforcou == false) 
                    {
                        
                        Console.WriteLine(frutaAdivinhada);

                        //gera letra maiuscula do chute
                        Console.Write("Digite uma letra? ");
                        string letra = Console.ReadLine();
                        char chute = Convert.ToChar(letra.ToUpper());
                        bool frutaFoiEncontrada = false;

                        //laco do tamanho do array da fruta
                        for (int i = 0; i < frutaAdivinhada.Length; i++)
                        {
                            //compara o chute com um caractere do array na posicao do indice no for
                            if (chute == frutaAleatoria[i])
                            {
                                frutaAdivinhada[i] = chute;
                                frutaFoiEncontrada = true;
                            }
                        }
                        if (frutaFoiEncontrada == false)
                        {
                            tentativas++;
                        }

                        // imprime a resposta
                        string palavraEncontrada = new string(frutaAdivinhada);
                        acertou = palavraEncontrada == frutaAleatoria;
                        enforcou = tentativas == 5;
                        if (acertou)
                        {
                            Console.WriteLine($"Você acertou a fruta é {frutaAleatoria}, parabéns!");
                        }
                        else if (enforcou)
                        {
                            Console.WriteLine("Nao foi dessa vez! Tente novamente!");
                        }
                    }

                #endregion
                Console.ReadLine();
            }
        }
    }
}