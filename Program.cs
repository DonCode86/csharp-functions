// See https://aka.ms/new-console-template for more information
int[] arrayInput = { 2, 6, 7, 5, 3, 9 };

void StampaArray(int[] array, char openP = '[', char closeP = ']')
{
    Console.Write(openP);

    int i;

    for (i = 0; i < array.Length -1; i++)
    {
        Console.Write(array[i]);
        Console.Write(",");
    }

    Console.Write(array[i]);

    Console.WriteLine(closeP);
}
Console.WriteLine("La lista dei numeri è: ");
StampaArray(arrayInput);

int Quadrato(int numero)
{
    Console.WriteLine(numero * numero);
    return numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = (int)Math.Pow(array[i], 2);
    }
    return result;
}
Console.WriteLine("I numeri elevati al quadrato sono: ");
StampaArray(ElevaArrayAlQuadrato(arrayInput));

int sommaElementiArray(int[] array)
{
    int somma = 0;

    foreach (int i in array)
    {
        somma += i;
    }

    return somma;
}
Console.WriteLine("La somma dei numeri dell'array è: ");
Console.WriteLine(sommaElementiArray(arrayInput));

Console.WriteLine("La somma dei numeri dell'array elevati al quadrato è: ");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrayInput)));