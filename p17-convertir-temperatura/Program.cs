// Convertir temperatura 
float temp, res;
Console.Clear();
Console.WriteLine("Convertir de grados farenheit a celcius\n");
Console.Write("Dame los grados Farenheit ? "); temp=float.Parse(Console.ReadLine());
res = ( temp - 32 ) * 5 / 9;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");

Console.WriteLine("\nGracias por utilizar este programa");