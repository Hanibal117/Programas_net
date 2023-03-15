// Imprime los primeros n numero de la serie de fibonacci
int n, countador = 0, fib = 0, fiboant = 0 , tempo = 0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime los primeros n numero de la serie de fibonacci\n");
    do {
        Console.Write("Ingresa un numero: ");
        n = int.Parse(Console.ReadLine());
    } while( n <= 0);
    do {
        tempo = fiboant;
        fiboant = fib;
        fib = fiboant + tempo;
        Console.Write($"{fiboant} ");
        if(fib == 0)fib++;
        countador++;
    } while(countador < n);
    countador = fib = fiboant = tempo = 0;
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");
