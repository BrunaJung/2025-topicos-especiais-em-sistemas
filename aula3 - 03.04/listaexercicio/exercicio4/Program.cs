//leia um numero inteiro e mostre na tela a tabuada desse numero de 1 a 10 . utilize uma estrutura de repetição para calcular e exibir os resultados.

Console.Write("Digite um numero inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

int next_num;

for(int i = 1; i <= 10; i++){
    next_num = num * i;
    Console.Write("\n" + num + "x" + i + "=" + next_num);
}
