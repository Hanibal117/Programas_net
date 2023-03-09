// Imprmir los numeros del 100 al 1
int n,p;

Console.Clear();
Console.Write("Desde donde: "); n= int.Parse(Console.ReadLine());
Console.Write("Paso: "); p= int.Parse(Console.ReadLine());
while( 1 <= n ) {
Console.Write($"{n} ");
n-=p;
}
