namespace EstudosMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];/*A "," indica a inicialização de um arranja bidimensional com coluna e linha
                                             e na instancia podemos dizer quantos linhas queremos no caso 2 e quantas colunas no caso 3*/

            Console.WriteLine(mat.Length); //quantidade de "slots"

            Console.WriteLine(mat.Rank); //quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); //a dimensão 0 da matriz, ela tem dimensão 2 que é a quantidade de linhas 

            Console.WriteLine(mat.GetLength(1)); //a dimensão 1 da matriz, ela tem 3 dimensões que é a quantidade de colunas
        }
    }
}
