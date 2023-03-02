void Menu() {
    Console.Clear();
    Console.WriteLine("Elige como deseas armar tu pedido de pizza:");
    Console.WriteLine("Tamano: [C]hica   - $5 ");
    Console.WriteLine("Tamano: [M]ediana - $10 ");
    Console.WriteLine("Tamano: [G]rande  - $15 ");
    Console.WriteLine("Ingredientes: [E]xtra queso/n [C]hampinones/n [P]ina/n, unidos un + - $5 por ingrediente");

}

char tam;
string tamano="", ingredientes="";
string[] ings;
float subtotal=0;

if(args.Length<1){
    Menu();
    return 1;
}
//Procesar tamano
tam=char.Parse(args[0].ToUpper());
if(tam=='C') {tamano="Chica";subtotal=+5;}
else if(tam=='M') {tamano="Mediana";subtotal=+10;}
    else {tamano="Grande";subtotal=+15;}
//Procesar Ingredienteres

ings = args[1].Split("+");
foreach(string ing in ings) {
    switch(char.Parse(ing.ToUpper())){

        case 'E' : ingredientes+="Extraqueso";break;
        case 'C' : ingredientes+="Champinones";break;
        case 'P' : ingredientes+="Pina";break;
    }
    subtotal+=5;
}
(args[2].ToUpper());
cubierta = (ContextBoundObject=='D' ? "Delgada" : "Gruesa" );
//Procesar donde
DateOnly char.Parse(args[3]ToUpper());
DllNotFoundException =



Console.WriteLine($"Tamano: {tamano}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Subtotal: {subtotal}");


return 0;