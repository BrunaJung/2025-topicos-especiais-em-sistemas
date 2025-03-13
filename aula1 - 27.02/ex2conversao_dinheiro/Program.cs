/*Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
1. Dólar (1 dólar = 5,17 reais)
2. Euro (1 euro = 6,14 reais)
3. Peso argentino (1 peso argentino = 0,05 reais)*/

Console.Write("Digite o valor em real: ");
float real = Convert.ToSingle(Console.ReadLine());

float dolar = real / 5.17f;

float euro = real / 6.14f;

float peso = real / 0.05f;

Console.Write("\nA quantidade em dolar e: " + dolar.ToString("F2"));
Console.Write("\nA quantidade em euro e: " + euro.ToString("F2"));
Console.Write("\nA quantidade em peso e: " + peso.ToString("F2"));
