// Calcular el volumen de un cilindro

double radio, altura, volumen;
Console.Clear();
Console.WriteLine("Calculando el volumen de un cilindro \n");
Console.Write("Dame el radio: "); radio=double.Parse(Console.ReadLine());
Console.Write("Dame la altura: "); altura=double.Parse(Console.ReadLine());

volumen = Math.PI* (radio * radio) * altura;

Console.WriteLine($"\nEl volumen es: {volumen}");