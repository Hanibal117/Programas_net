// Calcular tiempo 

double Ds, Hrs, Mins, Segs;
Ds = Hrs = Mins = Segs = 0;

Console.WriteLine("Calcular el tiempo:\n");
Console.Write("Ingresa las horas: \n"); Hrs = double.Parse(Console.ReadLine());

Ds = Hrs / 24;
Mins = Hrs * 60;
Segs = Hrs * 60 * 60;

Console.WriteLine($"El tiempo es:\n{Ds} Dias\n{Hrs} Horas\n{Mins} Minutos\n{Segs} Segundos\n");