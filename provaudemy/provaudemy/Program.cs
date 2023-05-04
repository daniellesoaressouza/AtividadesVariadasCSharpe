// See https://aka.ms/new-console-template for more information

Console.WriteLine("a");
double a = float.Parse(Console.ReadLine());
Console.WriteLine("b");
double b = float.Parse(Console.ReadLine());
Console.WriteLine("c");
double c = float.Parse(Console.ReadLine());

double delta = ((b * b) - (4 * a * c));

if(a==0||delta<0)
{
    Console.WriteLine("Impossivel Calcular.");
}
else
{
    double raiz = Math.Sqrt(delta);
    double r1 = ((-(b))+raiz)/(2*a);
    double r2 = ((-(b)) -raiz) / (2 * a);
    Console.WriteLine(r1);
    Console.WriteLine(r2);
}
