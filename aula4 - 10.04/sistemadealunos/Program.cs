using System;
using System.Globalization;

namespace SISTEMADEALUNOS{
    class Program{
        static void Main(string[] args){
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(
                Console.ReadLine(), CultureInfo.InvariantCulture
            );

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(
                Console.ReadLine(), CultureInfo.InvariantCulture
            );

            Aluno aluno = new Aluno(nome, nota1, nota2);
            aluno.ExibirResultado();

        }

    }
}