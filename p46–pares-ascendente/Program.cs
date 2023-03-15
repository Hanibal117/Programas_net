// Imprime números pares  de forma ascendente
int num,c,suma;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números pares ascendente\n");
    Console.WriteLine("Hasta donde: ");
    num = int.Parse(Console.ReadLine());
    suma=0;
    c=2;
    while( c<=num ) {
        Console.Write($"{c} ");
        suma = suma + c;
        c = c+2;
    }
    Console.WriteLine($"La suma es: {suma}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp!='N' );
Console.WriteLine("\nGracias por utilizar este programa !");