﻿// Imprime numeros de 1 a n con paso de p
Console.WriteLine("Numeros de 1 a n con paso de p \n");
Console.Write("Hasta donde deseas ? "); int n =int.Parse(Console.ReadLine());
Console.Write("Pasos de cuanto ? "); int p =int.Parse(Console.ReadLine());
for(int i=1; i<=n; i+=p) {
Console.Write($"{i} ");
}