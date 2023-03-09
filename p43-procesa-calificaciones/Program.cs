// Procesa n calificaciones:  calcula la suma y el promedio
int n,c;
float calificacion,suma, prom;
calificacion=suma=prom=0;
Console.Clear();
Console.WriteLine("Procesa n calificaciones, calcular su suma y el promedio\n");
Console.Write("Cuantas calificaciones procesaras: "); n=int.Parse(Console.ReadLine());
c=1;
while( c <= n ) {
Console.Write($"Calificacion {c} : ",c++);
calificacion = float.Parse(Console.ReadLine());
suma = suma + calificacion;
}
prom = suma / n;
Console.WriteLine($"La suma es : {suma:f2}");
Console.WriteLine($"El promedio es : {prom:f2}");
Console.WriteLine($"Listo");