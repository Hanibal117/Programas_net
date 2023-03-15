// Imprime una tabla de conversion de grados celsius a fahrenheit
int inicial, final;
float c;
char respuesta;
do {
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de grados celsius a fahrenheit\n");
    do {
        Console.Write("Temperatura Inicial: "); inicial = int.Parse(Console.ReadLine());
        Console.Write("Temperatura Final: "); final = int.Parse(Console.ReadLine());
    } while(final < inicial);
    c = inicial;
    Console.WriteLine(new string('-', 20));
    Console.WriteLine("Celsius\tFahreheit");
    Console.WriteLine(new string('-', 20));
    while( c <= final ) {
        Console.WriteLine($"{c}\t{(c * 9 / 5) + 32:f4}");
        c++;
    }
    Console.WriteLine(new string('-', 20));
    Console.Write("\nDeseas continuar (S/N) ? ");respuesta = char.ToUpper(Console.ReadLine()[0]);
} while( respuesta != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");