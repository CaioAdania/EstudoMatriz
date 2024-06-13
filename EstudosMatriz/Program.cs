namespace EstudosMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)// para cada uma das linhas **
            {
                string[] values = Console.ReadLine().Split(" "); //aqui estamos lendo a linha inteira e recortando por "ESPAÇO" e guardando dentro do vetor values

                for(int j =0; j < n; j++) //responsavel por percorrer as colunas *
                {
                    mat[i, j] = int.Parse(values[j]); //a coluna 0, guarda o values[0], pois ainda não houve incremento, guardando tudo na coluna 0
                    // é usado o int.Parse pois quando fazemos o vetor, ele é uma string e o int.Parse, converte para int para ser guardado na matriz
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i =0; i<n; i++) //for para mudar o numero da matriz e percorrer toda diagonal
            {
                Console.Write(mat[i, i] + " "); //a matriz recebe i,i, pois a diagonal sempre é 0,0 1,1 2,2
            }
            Console.WriteLine();

            int count = 0; //variavel iniciada em 0
            for(int i =0; i<n;i++) //percorrer as linhas
            {
                for (int j =0; j<n; j++) //percorrer as colunas
                {
                    if (mat[i,j] < 0) //verificação de numero <0
                    {
                        count++; //cada vez que ele encontrar um numero < 0, ele faz o incremento
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + count);
        }
    }
}
