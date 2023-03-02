//Diseñe un programa que permita procesar la solicitud e imprimir: tamaño de la compra, cantidad comprada, total compra, descuento, total de compra con descuento. 
int cantidad,precio;
double descuento,subtotal;
string tamanio="hola";
descuento=0.0f;
precio=0;
Console.WriteLine("--Bienvenido a la Pizzeria las ranas hermanas--\n");
Console.WriteLine("[C]hica (costo $5) ");
Console.WriteLine("[M]ediana (costo $10) ");
Console.WriteLine("[G]rande (costo $20) ");
Console.Write("Elije una opcion:  "); 

char tam = char.ToUpper(Console.ReadLine()[0]);
Console.Write("Cuantas pizzas quieres: "); cantidad = int.Parse(Console.ReadLine());
switch(tam) {
 case 'C': 
    precio=5;
    tamanio="Chica";
    break;
 case 'M': precio=10;
 tamanio="Mediana";
 break;
 default: precio=20;
 tamanio="Grande";
 break;
}
subtotal=precio*cantidad;
if(subtotal<=2000){
    descuento=0.0f;
}else{
    descuento= 0.15f;
}
Console.WriteLine("\nSu pedido:\n");
Console.WriteLine($"El tamaño que ordeno es: {tamanio} con costo de ${precio} por pizza");
Console.WriteLine($"La cantidad que usted ordeno es: {cantidad} ");
Console.WriteLine($"El total sin descuento es: ${subtotal} ");
Console.WriteLine($"Su descuento es de :{double.Round(descuento, 2) *100}% ");
Console.WriteLine($"El total con descuento es: ${double.Round(subtotal -descuento*subtotal, 2)} ");