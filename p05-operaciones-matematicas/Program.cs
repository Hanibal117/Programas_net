//Efectua operaciones matematicas con 2 numeros
double suma, resta, multi, div, resi, pote;
Console.Clear();
Console.WriteLine("Efectua operaciones matematicas con 2 numeros.\n");

double x = 10.5, y = 2.5;

suma = x + y;
resta = x - y;
multi = x * y;

div = x / y ;
resi = x % y ;
pote = Math.Pow(x, y) ;
Console.WriteLine($"Los numeros son: {x}, {y}\n");
Console.WriteLine("El resultado de las operaciones es el siguiente:\n");
Console.WriteLine($"Suma: {suma}\nResta: {resta}");
Console.WriteLine($"Multiplicacion: {multi}\nDivision: {div}");
Console.WriteLine($"Residuo: {resi}\nPotencia: {pote}");
