//receber dois numeros do usuario e retornar qual é maior ou se eles sao iguais

Console.Write("Digite o primeiro numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.Write("\nO numero " + num1 + " e maior que o numero " + num2);
}
else if(num2 > num1){
    Console.Write("\nO numero " + num2 + " e maior que o numero " + num1);
}
else{
    Console.Write("\nOs numeros digitados sao iguais!");
}
