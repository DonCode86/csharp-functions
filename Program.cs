// See https://aka.ms/new-console-template for more information

Console.WriteLine("Da quanti numeri vuoi che sia composto il tuo array?");
int userArryLength = Convert.ToInt32(Console.ReadLine());
int[] arrayInput = new int[userArryLength];
for (int i = 0; i < arrayInput.Length; i++)
{
    arrayInput[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < arrayInput.Length; i++)
{
    Console.WriteLine(arrayInput[i] + " ");
}

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