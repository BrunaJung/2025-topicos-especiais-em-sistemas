/*Escrever um algoritmo que receba a altura e a largura de um retangulo e calcule sua area.*/

Console.Write("Digite a altura do retangulo: ");

int altura = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a largura do retangulo: ");
int largura = Convert.ToInt32(Console.ReadLine());

int area = largura * altura;

Console.WriteLine("\nA area do retangulo e: " + area);