/*Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e 
ordenar do menor para o maior.
b) Utilizar uma função em C# para ordenação.*/

int[] vetor = new int[10];

Random r = new Random();

for(int i = 0; i < vetor.Length; i++){
    vetor[i] = r.Next(100);
}

for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.WriteLine("\n\nVetor ordenado:");

for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}