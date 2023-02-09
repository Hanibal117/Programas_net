//Programa que envia un saludo 
string amigo="Juan";
string hermano="Pablo";
Console.WriteLine(amigo);
amigo="Miguel";
Console.WriteLine("Hola "+ amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nMi amigo es {amigo} mi hermano es {hermano}\n");
Console.WriteLine("Nombres con mayusculas: ");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");


