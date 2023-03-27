//Se desea imprimir la secuencia de términos, el número de renglones que el usuario desee y su suma:
int i,j,n;
float f, r;
char resp;
do {
Console.Clear();
r=0;
Console.Write("Cuantos terminos: "); 
n = int.Parse(Console.ReadLine());
f=0;
for ( i = 1; i <=n; i++) {
            f = f * 10 + 1;
    if(i==n){
    Console.Write($"{f}");
    }else{
    Console.Write($"{f}+");
    }
            r += f;
}
Console.WriteLine($"\n suma {r}");
Console.Write("\nDeseas continuar (S/N) ?");
resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");