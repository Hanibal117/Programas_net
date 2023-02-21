// Calcular el angulo 
double angulo1, angulo2, CONST180 = 180.0, angulo3;

Console.Clear();
Console.WriteLine("Calcular el tercer angulo de un triangulo. \n");
Console.Write("Dame el angulo1: "); angulo1=double.Parse(Console.ReadLine());
Console.Write("Dame el angulo2: "); angulo2=double.Parse(Console.ReadLine());

angulo3 = CONST180-(angulo1 + angulo2);
Console.WriteLine($"\nEl angulo 3 es {angulo3}");