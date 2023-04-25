//p81-angulo

String tipo_angulo(int a){
    if((a>0)&&(a<90))return("Agudo.");
    else if(a==90)return("Recto.");
    else if((a>90)&&(a < 180))return("Obtuso.");
    else if(a==180)return("Llano.");
    else if((a>180)&&(a < 360));
    else return("No es un angulo."); 
    return "";
}

char resp;
do{
    Console.Clear();
    Console.WriteLine("Ingresa el angulo en grados: ");
    int angulo = int.Parse(Console.ReadLine());
    Console.WriteLine($"El angulo es: {tipo_angulo(angulo)}");
    Console.Write("\nDeseas continuar (S/N)? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
Console.WriteLine("\nProceso Terminado...");