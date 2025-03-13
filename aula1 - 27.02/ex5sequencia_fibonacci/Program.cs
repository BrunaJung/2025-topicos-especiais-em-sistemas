/*Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência 
Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número 15, o 
programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.*/

Console.Write("Digite um numero inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] vetor = {0,1};
int proximo = 0;

Console.Write(vetor[0] + " " + vetor[1] + " ");

while(proximo <= num){

    proximo = vetor[0] + vetor[1];

    vetor[0] = vetor[1];
    vetor[1] = proximo;

    if(proximo <= num){
        Console.Write(proximo + " ");
    }
}
