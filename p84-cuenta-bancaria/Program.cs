// Control bancario
Console.WriteLine("\nProbando la clase CuentaBancaria:\n");
CuentaBancaria cuenta1 = new CuentaBancaria(5000);
cuenta1.Deposita(10000);
Console.WriteLine($"El saldo es {cuenta1.Saldo}");

bool retiro = cuenta1.Retira(56);
if(retiro) Console.WriteLine($"Retiro efectuado, nuevo saldo {cuenta1.Saldo}");
    else Console.WriteLine($"Ni para los cigarros");

Console.WriteLine("\nProbando clase Cliente: ");
Cliente cliente1 = new Cliente("David", "Monreal");
cliente1.Cuenta = cuenta1;

 Console.WriteLine($"Cliente: {cuenta1.ToString()}");
Console.WriteLine($"El saldo es: {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente("Carlos", "Castaneda");
cliente2.Cuenta = new CuentaBancaria(100000000);
cliente2.Cuenta.Retira(50000);
Console.WriteLine($"cliente: {cliente2.ToString()}");
Console.WriteLine($"El saldo es: {cliente2.Cuenta.Saldo}");


Console.WriteLine("\nProbando clase Banco");
Banco mibanco = new Banco("Banco Patito SA de CV","Arboleada 45");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);
Cliente cliente3 = new Cliente("Solo Vino","Solo se fue");
cliente3.Cuenta = new CuentaBancaria(1001);
mibanco.AgregarCliente(cliente3);

mibanco.Clientes[0].Cuenta.Deposita(10000);
mibanco.Clientes[1].Cuenta.Retira(1000);
mibanco.Clientes[2].Cuenta.Deposita(10000001);

Console.WriteLine("/nResumen del banco\n");
Console.WriteLine($"Banco: {mibanco.ToString()}");

foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente {cl.ToString()}");
    Console.WriteLine($"Saldo {cl.Cuenta.Saldo}");
    
}




/*
Console.WriteLine($"Saldo inicial : {cuenta.Saldo}");
cuenta.Deposita(200);
Console.WriteLine($"Saldo deposito: {cuenta.Saldo}");
bool retiro = cuenta.Retira(40);
if(retiro)
Console.WriteLine($"Saldo retiro : {cuenta.Saldo}");
else
Console.WriteLine("No se pudo retirar, saldo insuficiente");
*/