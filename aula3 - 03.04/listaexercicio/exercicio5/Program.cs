//receba um numero inteiro e calcule o seu fatorial.

Console.Write("Digite um numero inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num;

for(int i = num-1; i > 0; i--){
    result *= i;
}

Console.Write("\nO resultado do fatorial e: " + result);