// Administra el pago por estacionamiento de acierdo a la zona

int op;
float tasa, pago, impuesto, total;

Console.Clear();
Console.WriteLine("Administra el pago por estacionamiento de acierdo a la zona\n"); 
Console.WriteLine("1 - Estacionamiento Tacuba  3%");
Console.WriteLine("2 - Estacionamiento Portales  5%");
Console.WriteLine("3 - Estacionamiento Conqusitadores  10%");
Console.WriteLine("4 - Estacionamiento Pajaros Cidos  15%");
Console.WriteLine("Elige opcion: "); op = int.Parse(Console.ReadLine());
Console.WriteLine("Pago efectuado: "); pago = float.Parse(Console.ReadLine());
tasa = 0.0f;
switch(op) {
    case 1 : tasa = 0.03f;break;
    case 2 : tasa = 0.05f;break;
    case 3 : tasa = 0.10f;break;
    case 4 : tasa = 0.15f;break;   
} 

impuesto = pago * tasa;
total = pago + impuesto;
string salida = string.Format($"Elegiste el estacionamiento {op}\n" +
                $"Pagaste {pago} por el tiempo de uso\n" +
                $"Corresponde un impuesto de {impuesto:n2}n" +
                $"El pago total es de {total:n2}"); 
                
Console.WriteLine(salida);



