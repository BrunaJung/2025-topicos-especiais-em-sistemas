//Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.

Console.Write("Digite um numero inteiro: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite um numero inteiro: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int maior = 0;
int menor = 0; 

if(num1 > num2){
    maior = num1;
    menor = num2;
}
else{
    maior = num2;
    menor = num1;
}

Console.Write("\nO menor numero e: " + menor);
Console.Write("\nO maior numero e: " + maior);