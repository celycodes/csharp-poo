using System;
using System.Globalization;

namespace checksNotes {
    class Program {
        static void Main(string[] args) {
            Student s;
            s = new Student();

            Console.WriteLine("Verificando as Notas do Aluno(a): ");
            Console.Write("Nome do aluna(a): ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas trimestrais do aluno(a): ");
            s.T1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.T2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.T3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + s.FinalScore().ToString("f2", CultureInfo.InvariantCulture));


            if (s.Check()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + s.remainingNote().ToString("f2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
