// Conversion de temperaturas usando funciones

float Farenheit(float t) {
return (t*9/5)+32;
}
float Celcius(float t) {
return (t-32)*5/9;
}
int op;
float temp, res;
char respuesta;
Console.Clear();
Console.Write("[1] farenheit\n[2] celcius\nElige:  ");

op = int.Parse(Console.ReadLine());
Console.Write("Dame la temperatura:  ");
temp = float.Parse(Console.ReadLine());

if(op==1) {
res = Farenheit(temp);
Console.WriteLine($"\n{temp} Grados Celcius equivale a {res} grandos Farenheit...");
}
else if(op==2) {
res = Celcius(temp);
Console.WriteLine($"\n{temp} Grados Farenheit equivale a {res} grandos Celcius...");
}
else Console.WriteLine("Opción inválida");
