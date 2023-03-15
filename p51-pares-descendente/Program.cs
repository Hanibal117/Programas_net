// Imprime números pares descendientes

int n, c, s, p, cont = 0;
char respuesta;
do {
    Console.Clear();
    Console.WriteLine("Imprime números impares descendientes\n");
    Console.Write("Hasta donde quieres? ");
    n = int.Parse(Console.ReadLine());
    s = 0;
    c = 100;
    while( c >= n ) {
        Console.Write($"{c} ");
        s = s + c;
        c = c - 2;
        cont++;
    }
    p = s/ cont;
    Console.WriteLine($"\nLa suma es {s}");
    Console.WriteLine($"El promedio es {p}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    respuesta = char.ToUpper( Console.ReadLine()[0] );
} while( respuesta != 'N' );
Console.WriteLine("\nGracias por utilizar este programa !");