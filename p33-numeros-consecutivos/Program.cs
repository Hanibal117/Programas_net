//Dados tres números enteros, verificar si son consecutivos
int numero1,numero2,numero3;
string salida;
Console.Clear();
Console.WriteLine("Ingresa tres numeros para verificar si son consecutivos o no. \n");
Console.Write("Dame el primer numero: "); numero1 = int.Parse(Console.ReadLine());
Console.Write("Dame el segundo numero: "); numero2 = int.Parse(Console.ReadLine());
Console.Write("Dame el tercer numero: "); numero3 = int.Parse(Console.ReadLine());
if (numero2-numero1==1 && numero3-numero2==1){
     salida = string.Format($"Los numeros ({numero1}" + $",{numero2}," + $"{numero3}) son consecutivos ...");
}else{
    salida = string.Format($"Los numeros ({numero1}" + $",{numero2}," + $"{numero3}) no son consecutivos ...");
}
Console.WriteLine(salida);