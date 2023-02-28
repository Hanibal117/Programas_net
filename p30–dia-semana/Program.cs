// Dame un numero entre el 1 y 7 e imprime el dia de la semana
int dia;

Console.Clear();
Console.WriteLine("Dame un numero entre 1 y 7 y saber el dia de la semana:\n");
Console.WriteLine("Dame un numero: \n"); dia = int.Parse(Console.ReadLine());
switch(dia) {

    case 1 : Console.WriteLine("Lunes"); break;
    case 2 : Console.WriteLine("Martes"); break;
    case 3 : Console.WriteLine("Miercoles"); break;
    case 4 : Console.WriteLine("Jueves"); break;
    case 5 : Console.WriteLine("Viernes"); break;
    case 6 : Console.WriteLine("Sabado"); break;
    case 7 : Console.WriteLine("Domingo"); break;
    default : Console.WriteLine("En que dia vives"); break;
}

Console.WriteLine("\n Proceso terminado...");
