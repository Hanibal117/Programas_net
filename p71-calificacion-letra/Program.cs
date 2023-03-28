 // Calificación con letra


char CalLetra(float cal) {
    char letra=' ';
    if(cal>=90&&cal<=100)
        letra='A';
    else if(cal>=80&&cal<90)
        letra='B';
    else if(cal>=70&&cal<80)
        letra='C';
    else if(cal>=60&&cal<70)
        letra='D';
    else if(cal>=0&&cal<60)
        letra='F';
    return letra;
}

float cal;
char letra;

do {
    Console.Write("Dame tu calificacion  es escala de [0-100]:  ");
    cal = float.Parse(Console.ReadLine());
    } while(cal<0 || cal>100);
letra = CalLetra(cal);
Console.WriteLine($"Tu calificación de {cal} corresponde a la letra: {letra}");
