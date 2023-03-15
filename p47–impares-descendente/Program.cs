
// Imprime números impares descendente
int n,c,suma;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números impares descendente\n");
    Console.Write("Desde donde: ");
    n = int.Parse(Console.ReadLine());
    suma=0;
    c = ( n%2==0 ? --n : n);
    while( c>=1 ) {
        Console.Write($"{c} ");
        suma = suma + c;
        c = c-2;
    }
    Console.WriteLine($"\nLa suma es {suma}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp!='N' );
Console.WriteLine("\nGracias por utilizar este programa !");