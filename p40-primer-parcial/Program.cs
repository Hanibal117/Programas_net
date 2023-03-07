//Se desea llevar el control de la inscripción a un evento académico de la Universidad Patito. Se especifica: Tipo
//de usuario, paquete y cantidad.
Console.Clear();
void Menu() {
    Console.Clear();
    Console.WriteLine("**********************************************************************************************************");
    Console.WriteLine("Universidad patitos ");
    Console.WriteLine("Tipo de usuario: [1] Alumno $100, [2] Trabajador $200, [3] Docente $500");
    Console.WriteLine("Tipo de paquete: [1] Solo conferencias $600, [2] Con eventos sociales $800, [3] Con kit de acceso $900");
    Console.WriteLine("\n");
    Console.WriteLine("Ingresa el tipo de usuario y los paquetes a elegir, asi como la cantidad");
}

int usuar, paq, cantidades;
string usuario = "", paquete = "";
float subtot = 0, desc = 0, total = 0;

if(args.Length < 3) {
    Menu();
    return 1;
}

usuar = int.Parse(args[0]);
if(usuar == 1){usuario = "Alumno"; subtot += 100;}
else if(usuar == 2){usuario = "Trabajador"; subtot += 200;}
else {usuario = "Docente"; subtot += 500;}

paq = int.Parse(args[1]);
if(paq == 1){paquete = "Solo conferencias"; subtot += 600;}
else if(paq == 2){paquete = "Con eventos sociales"; subtot += 800;}
else {paquete = "Con kit de acceso"; subtot += 900;}

cantidades = int.Parse(args[2]);
subtot = subtot * cantidades;

if(subtot >= 5000) {
    if(usuar == 1)desc = 0.20f;
    else if(usuar == 2)desc = 0.10f;
    else desc = 0.05f;
}
total = subtot - (subtot * desc);
Console.WriteLine($"Universidad Patito ------------------------------------------------------------");
Console.WriteLine($"Tu pedido fue: {cantidades} / Tipo de Usuario : {usuario} / Tipo de Paquete: {paquete}");
Console.WriteLine($"Precio normal: {subtot:c} con descuento: {(desc * subtot):c} ({desc*100}%) y un total de: {total:c}");
Console.WriteLine($"--------------------------------------------------------------------------------------------------------");

return 0;