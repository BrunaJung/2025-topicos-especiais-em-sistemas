//leia um numero inteiro digitado pelo usuario e informe se o numero e par ou impar. utilize o operador de modulo para realizar a verificação

Console.Write("Digite um numero inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0){
    Console.Write("\nO numero digitado e par!");
}
else{
    Console.Write("\nO numero digitado e impar!");
}
