int numeroDeNotas = 0;
double[] nota = new double[4];
int i = 0;

while (i < 4)
{
    nota[i] = Double.Parse(Console.ReadLine());

    if (nota[i] < 0 || nota[i] > 11)
    {
        numeroDeNotas++;
        Console.WriteLine("nota invalida");
    }

    if (numeroDeNotas == 2)
    {
        break;
    }

    i++;
}

double media = (nota[1] + nota[1] + nota[1] + nota[1]) / 4;

Console.WriteLine($"media = {media}");
