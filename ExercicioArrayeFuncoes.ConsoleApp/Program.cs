namespace ExercicioArrayeFuncoes.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando e atribuindo valores pro array
            int[] numerosArray = new int[10] {-5, 3, 4, 5, 9, 6, 10, -2, 11, 1};

            ExibirValores(numerosArray);
            RetornarMaiorNumeroArray(numerosArray);
            RetornarMenorNumeroArray(numerosArray);
            RetornarMediaArray(numerosArray);
            RetornarTresMaioresValoresArray(numerosArray);
            RetornarValoresNegativosDoArray(numerosArray);
            RemoverItemDoArray(numerosArray, 7);

            Console.ReadLine();
        }

        private static void ExibirValores(int[] numerosArray)
        {
            // Forma manual
            //for (int = 0; i < numerosArray.Length; i++)
            //{
            //    Console.Write(numerosArray[i] + " ");
            //}

            Console.WriteLine($"A sequência de números do Array é: [{string.Join(", ", numerosArray)}]");
        }

        private static void RetornarMaiorNumeroArray(int[] numerosArray)
        {
            int maiorNumero = int.MinValue;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                int valorAtual = numerosArray[i];

                if (valorAtual > maiorNumero)
                {
                    maiorNumero = valorAtual;
                }
            }

            Console.WriteLine("\nO maior valor do Array é: " + maiorNumero);
        }

        private static void RetornarMenorNumeroArray(int[] numerosArray)
        {
            int menorNumero = int.MaxValue;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                int valorAtual = numerosArray[i];

                if (valorAtual < menorNumero)
                {
                    menorNumero = valorAtual;
                }
            }

            Console.WriteLine("\nO menor valor do Array é: " + menorNumero);
        }

        private static void RetornarMediaArray(int[] numerosArray)
        {
            decimal soma = 0;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                int valorAtual = numerosArray[i];
                soma += valorAtual;
            }

            decimal media = soma / numerosArray.Length;

            Console.WriteLine("\nO valor médio do Array é: " +  media);
        }

        private static void RetornarTresMaioresValoresArray(int[] numerosArray)
        {
            int[] copia = new int[numerosArray.Length];

            Array.Copy(numerosArray, copia, numerosArray.Length);

            Array.Sort(copia);

            Array.Reverse(copia);

            Console.WriteLine($"\nOs 3 maiores valores do Array são: [{copia[0]}, {copia[1]}, {copia[2]}]");
        }

        private static void RetornarValoresNegativosDoArray(int[] numerosArray)
        {
            int countNumerosNegativos = 0;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                int valorAtual = numerosArray[i];

                if (valorAtual < 0)
                    countNumerosNegativos++;
            }

            int[] numerosNegativos = new int[countNumerosNegativos];

            int indiceNumerosNegativos = 0;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                int valorAtual = numerosArray[i];

                if (valorAtual < 0)
                {
                    numerosNegativos[indiceNumerosNegativos] = valorAtual;
                    indiceNumerosNegativos++;
                }

            }

            Console.WriteLine($"\nOs numeros negativos do Array são: [{string.Join(", ", numerosNegativos)}]");
        }

        private static void RemoverItemDoArray(int[] numerosArray, int posicaoParaRemover)
        {
            int[] novoArray = new int[numerosArray.Length - 1];

            int countItens = 0;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                int valorAtual = numerosArray[i];
                if (i != posicaoParaRemover)
                {
                    novoArray[countItens] = numerosArray[i];
                    countItens++;
                }
            }

            Console.WriteLine($"\nA sequência do Array após remover um número é: [{string.Join(", ", novoArray)}]");
        }
    }
}