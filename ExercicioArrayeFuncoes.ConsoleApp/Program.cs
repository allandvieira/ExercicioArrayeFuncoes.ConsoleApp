namespace ExercicioArrayeFuncoes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosArray = new int[10] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };

            Console.WriteLine($"O maior número da Sequência utilizando o método MAX() é: {numerosArray.Max()}");
            Console.WriteLine($"O maior número da Sequência utilizando o método manual é: {RetornaMaiorNumeroArray(numerosArray)}");
            Console.WriteLine();
            Console.WriteLine($"O maior número da Sequência utilizando o método MIN() é: {numerosArray.Min()}");
            Console.WriteLine($"O maior número da Sequência utilizando o método manual é: {RetornaMenorNumeroArray(numerosArray)}");
            Console.WriteLine();
            Console.WriteLine($"A media dos número da Sequência utilizando o método MIN() é: {numerosArray.Average()}");
            Console.WriteLine($"A media dos número da Sequência utilizando o método manual é: {RetornaMediaArray(numerosArray)}");

            Console.ReadLine();

        }

        public static int RetornaMaiorNumeroArray(int[] numeros)
        {
            int maiorNumero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }

            return maiorNumero;
        }

        public static int RetornaMenorNumeroArray(int[] numeros)
        {
            int menorNumero = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }

            return menorNumero;
        }

        public static float RetornaMediaArray(int[] numeros)
        {
            int count = 0;
            float media = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                count += numeros[i];
            }

            media = (float) count / numeros.Length;
            return media;
        }

        static void TresMaiores(int[] numeros, int tamanhodovetor)
        {
            int maiornum = numeros[0];
            for (int i = 0; i < tamanhodovetor; i++)
            {

                if (numeros[i] > maiornum)
                {
                    maiornum = numeros[i];
                }
            }

            int aux = maiornum;
            int count = 0;
            Console.Write($"\nOs tres maiores numeros são: ");
            while (true)
            {
                for (int i = 0; i < tamanhodovetor; i++)
                {
                    if (numeros[i] == aux)
                    {
                        //maiornum = num[i];
                        Console.Write($"{numeros[i]}  ");
                        aux--;
                        count++;
                    }
                }
                if (count == 3)
                {
                    break;
                }
            }
            Console.ReadLine();
        }

        static void NumerosNegativos(int[] numeros, int tamanhodovetor)
        {
            Console.Write($"\nOs numeros negativos são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.Write($"{numeros[i]}  ");
                }
            }
            Console.ReadLine();
        }

        static void Sequencia(int[] numeros, int tamanhodovetor)
        {
            Console.Write($"\nOs numeros desta sequencia são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{numeros[i]}  ");
            }
            Console.ReadLine();
        }

        static int Apagar(int tamanhodovetor, int[] numeros)
        {
            //Imprimindo os numeros da sequencia novamente
            Console.Write($"\nOs numeros desta sequencia são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{numeros[i]}  ");
            }

            Console.Write($"\n\nQual numero deseja apagar? ");
            int aux2 = Convert.ToInt32(Console.ReadLine());
            int aux3;
            for (int i = 0; i < tamanhodovetor; i++)
            {
                if (numeros[i] == aux2)
                {
                    aux3 = i;
                    int aux4 = i + 1;
                    for (int j = aux4; j < tamanhodovetor; j++)
                    {
                        numeros[aux3] = numeros[j];
                        aux3++;
                    }
                    i--;
                }
            }
            tamanhodovetor--;

            //Imprimindo os numeros da sequencia novamente
            Console.Write($"\nOs numeros desta sequencia agora são: ");
            for (int i = 0; i < tamanhodovetor; i++)
            {
                Console.Write($"{numeros[i]}  ");
            }
            Console.ReadLine();
            return tamanhodovetor;
        }
    }
}