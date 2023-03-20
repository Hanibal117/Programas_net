// Suma y promedio de n calificaciones...
int n;
float calificacion, suma, promedio;
char resp;
do {
Console.Clear();
suma=promedio=0;
Console.WriteLine("Suma y promedio de n calificaciones: \n");
Console.Write("Cuantas calificaciones? ");
n=int.Parse(Console.ReadLine());
for(int i=1; i<=n; i++) {
Console.Write($"Calificacion {i} ? ");
calificacion=float.Parse(Console.ReadLine());
suma+=calificacion;
}
promedio=suma/n;
Console.WriteLine($"\nSuma {suma} y promedio {promedio}");
Console.Write("\nDeseas continuar (S/N) ? ");
resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado ...");