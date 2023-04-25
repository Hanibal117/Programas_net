//p79-medidas-longitud
int op;


void pulgadas_cent(){
    Console.WriteLine("Ingresa la medida en pulgadas: ");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine($"Equivale a: {a*2.54} centimetros.");
}

void metros_pie(){
    Console.WriteLine("Ingresa la medida en metros: ");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine($"Equivale a: {a*3.281} pies.");
}

int menu(){
    Console.WriteLine("Convertir pulgadas a centimetros...   [1]");
    Console.WriteLine("Convertir metros a pies...            [2]");
    Console.WriteLine("Salir...                              [3]");
    Console.Write("Elige una opcion...");
    op = int.Parse(Console.ReadLine());
    return op;
}

do{
    Console.Clear();
    op = menu();
    switch(op){
        case 1 : pulgadas_cent();break;
        case 2 : metros_pie();break;
        default : break;
    }
    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadLine();
}while(op != 3);