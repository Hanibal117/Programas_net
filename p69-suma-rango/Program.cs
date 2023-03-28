// suma de un rango de numeros

float SumaR(float inicio, float fin) {

float suma =0;

for(float i = inicio; i <= fin ;i++)
    suma+=i;
    return suma;
}
float i, f, res;
Console.Clear();
do {
Console.Write("Dame inicio : "); i = float.Parse(Console.ReadLine());
Console.Write("Dame fin : "); f = float.Parse(Console.ReadLine());
} while( i > f);
res = SumaR(i, f);
Console.WriteLine($"\nLa suma del rango es de {res:n3}");