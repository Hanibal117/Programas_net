//p77-numero-menor
int menor(int[] a) {
    int aux = a[0];
    for(int i=0; i<4; i++)
        if(a[i] < aux)
            aux = a[i];
    return aux;
}

int[] nums = {0, 0, 0, 0};
int resultado;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Ingrese 4 numeros enteros\n");
    for(int i=0; i < 4; i++ ) {
        nums[i] = int.Parse(Console.ReadLine());
    }
    resultado = menor(nums);
    Console.WriteLine($"\nEl numero menor es: {resultado}");
    Console.Write("\nDeseas continuar(S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");