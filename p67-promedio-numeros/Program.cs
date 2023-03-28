// Calcula el promedio de tres números usando una func

float promedio(float numero1, float numero2, float numero3) {
float suma;
suma = numero1 + numero2 + numero3;
return suma/3;
}

string[] nums;
float numero1, numero2, numero3, prom;

Console.Clear();
Console.Write("Dame tres números separados por espacio: ");
nums = Console.ReadLine().Split();
numero1 = float.Parse(nums[0]); numero2 = float.Parse(nums[1]); numero3 = float.Parse(nums[2]);
prom = promedio(numero1, numero2, numero3);
Console.WriteLine($"\nEl promedio es {prom:f2}");