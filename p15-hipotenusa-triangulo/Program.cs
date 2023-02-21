// Calcular la hipotenusa de un triangulo
double longitudLado1, logitudLado2, raizcuadrada, hipotenusa;
Console.Clear();
Console.WriteLine("Calculando la hipotenusa de un triangulo \n");
Console.Write("Dame la longitudLado1: "); longitudLado1=double.Parse(Console.ReadLine());
Console.Write("Dame la longitudLado2: "); logitudLado2=double.Parse(Console.ReadLine());

raizcuadrada = Math.Sqrt(longitudLado1 * longitudLado1 + logitudLado2 * logitudLado2);
hipotenusa = raizcuadrada;

Console.WriteLine($"\nLa hipotenusa es: {hipotenusa}");