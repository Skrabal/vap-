int[] cislo = [1, 2, 3, 4];
Console.WriteLine(cislo[0]);
int ii = 0;
while (ii < cislo.Length)
{
    Console.WriteLine(cislo[ii]);
    ii++;

}

int[] poleInt = [235, 51, 578, 35, 684];
int max = int.MinValue;
int min = int.MaxValue;
for (int i = 0; i < poleInt.Length; i++)
{
    if (max < poleInt[i])
    {
        max = poleInt[i];
    }
    if (min > poleInt[i])
    {
        min = poleInt[i];
    }



}
Console.WriteLine("max= " + max);

Console.WriteLine("min= " + min);



