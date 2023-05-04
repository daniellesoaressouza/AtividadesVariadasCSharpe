// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Quant de itenes em uma lista");
int tam = int.Parse(Console.ReadLine());
float[] array = new float[tam];

for (int i = 0; i < tam; i++)
{
    array[i] = float.Parse(Console.ReadLine());
  
}
for (int j = 0; j < tam; j++)
{
    if (array[j] > 9 && array[j] < 21)
    {
        Console.WriteLine("in" + " " + array[j]);
    }
    else
    {
        Console.WriteLine("out" + " " + array[j]);
    }
}