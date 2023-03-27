//Se desea imprimir la secuencia de términos armónicos,  el número de renglones que el usuario desee y su suma
int i,j,n;
float f, r;
char resp;
do {
Console.Clear();
r=0;
Console.Write("Cuantos terminos: "); n = int.Parse(Console.ReadLine());
for(i=1; i<=n; i++) {
    f=1;
    for(j=1; j<=i; j++) {
        f = j;
    }

    if(f==n){
    Console.Write($" 1 / {f}");
    }else{
        Console.Write($" 1 / {f} +");
    }
    r += (1 / f);
}
Console.WriteLine($"\n suma {r}");
Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");
