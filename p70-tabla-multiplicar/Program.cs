 // Tabla de multiplicar


void Tabla(int c, int n) {
Console.WriteLine($"\nTabla del {c}\n");
for(int i=1; i <= n; i++)
Console.WriteLine($"{c} x {i} = {c*i}");
}


Console.Write("Ingresa tabla que deseas: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Hasta donde: ");
int n = int.Parse(Console.ReadLine());
Tabla(c,n);