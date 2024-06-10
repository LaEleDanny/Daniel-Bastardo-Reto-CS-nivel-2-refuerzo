Console.WriteLine("Ingresa dos números entre 1 y 49:");

Random random = new Random();
HashSet<int> numerosAleatorios = new HashSet<int>();

while (numerosAleatorios.Count < 2)
{
    int numeroAleatorio = random.Next(1, 49);
    numerosAleatorios.Add(numeroAleatorio);
}

HashSet<int> numerosUsuario = new HashSet<int>();

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Introduce un número:");
    int numero = int.Parse(Console.ReadLine());

    if (numerosAleatorios.Contains(numero))
    {
        numerosUsuario.Add(numero);
    }
}

int aciertos = numerosUsuario.Count;

Console.WriteLine("Número de aciertos: " + aciertos);

Console.WriteLine("Los números ganadores son:");
foreach (int numeroGanador in numerosAleatorios)
{
    Console.WriteLine(numeroGanador);
}



