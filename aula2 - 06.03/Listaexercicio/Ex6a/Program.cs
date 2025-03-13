/*Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e 
ordenar do menor para o maior.
a) Desenvolver o algoritmo de ordenação (Bubble Sort).*/

//criando o vetor:
int[] vetor = new int[10];

//gerando valores aleatorios:
Random r = new Random();

//preenchendo o vetor: 
for(int i = 0; i < vetor.Length; i++){
    vetor[i] = r.Next(100);
}

//imprimindo os valores aleatorios:
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}

//ordenando o vetor:

// for(int j = vetor.Length - 1; j > 0; j++){
//     for(int i = 0; i < vetor.Length - 1; i++){
//         if(vetor[i] > vetor[i+1]){
//             int aux = vetor[i];
//             vetor[i] = vetor[i+1];
//             vetor[i+1] = aux;
//         }
//     }
// }

bool troca = false;

do{
    troca = false;
    for(int i = 0; i < vetor.Length - 1; i++){
        if(vetor[i] > vetor[i+1]){
            int aux = vetor[i];
            vetor[i] = vetor[i+1];
            vetor[i+1] = aux;

            troca = true;
        }
    }
}while(troca ==true);

Console.WriteLine("\n");

//imprimindo valores ordenados
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}
