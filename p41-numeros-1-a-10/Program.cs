
// Imprmir los numeros del 1 al 100
int c,n,p;
c=1;
Console.Clear();
Console.Write("Hasta donde: "); n= int.Parse(Console.ReadLine());
Console.Write("Paso: "); p= int.Parse(Console.ReadLine());
while( c <= n ) {
Console.Write($"{c} ");
c+=p;
}