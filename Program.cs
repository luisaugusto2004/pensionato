namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());


            Estudante[] vet = new Estudante[10];
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Aluguel #" + i + ": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Estudante { Nome = nome, Email = email };
                Console.WriteLine();
            }

            Console.WriteLine("Quartos Ocupados:");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}
