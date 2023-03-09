// Imprime la tabla de multiplicar que el usuario pida, desde 1 hasta n
int c,t,n;
Console.Clear();
Console.WriteLine("Imprimir la tabla deseada de 1 a donde quieras\n");
Console.Write("Ingresa la tabla que quieres: ");
t = int.Parse(Console.ReadLine());
Console.Write("Hasta donde? ");
n = int.Parse(Console.ReadLine());
c = 1;
while( c <= n ) {
Console.WriteLine($"{c} x {t} = {c*t}");
c++;
}
Console.WriteLine("\nProceso terminado...");