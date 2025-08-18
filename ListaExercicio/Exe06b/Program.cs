int tamanho = 100;
int[] vetor = new int[tamanho];

Random random = new Random();
for (int i = 0; i < tamanho; i++)
{
    vetor[i] = random.Next(1000);
}

for (int i = 0; i < tamanho; i++)
{
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

Console.WriteLine("\n");
for (int i = 0; i < tamanho; i++)
{
    Console.Write(vetor[i] + " ");
}
