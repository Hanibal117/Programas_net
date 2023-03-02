// Dado el nombre del estudiante, sexo (h/m), su edad y tres calificaciones, decidir si el estudiante es aceptado. La
//Universidad Kitty Kat SA es solo para mujeres mayores de 21 años con un promedio de entre 8 y 9.5.

   Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        //h = hembra
        //m = macho
        Console.Write("Ingrese el sexo del estudiante (h/m): ");
        char sexo = char.ToLower(Console.ReadKey().KeyChar);

        Console.Write("\nIngrese la edad del estudiante: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la primera calificación: ");
        double calif1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la segunda calificación: ");
        double calif2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la tercera calificación: ");
        double calif3 = double.Parse(Console.ReadLine());

        bool esAceptado = false;
        if (sexo == 'm') {
            Console.WriteLine("\nLo siento, la Universidad Kitty Kat SA es solo para mujeres.");
        } else if (edad < 21) {
            Console.WriteLine("\nLo siento, la Universidad Kitty Kat SA es solo para mujeres mayores de 21 años.");
        } else if (calif1 < 0 || calif2 < 0 || calif3 < 0) {
            Console.WriteLine("\nLas calificaciones no pueden ser negativas.");
        } else {
            double promedio = (calif1 + calif2 + calif3) / 3.0;
            if (promedio >= 8.0 && promedio <= 9.5) {
                esAceptado = true;
            }
        }

        if (esAceptado) {
            Console.WriteLine("\n¡Felicidades, " + nombre + ", has sido aceptada en la Universidad Kitty Kat SA!");
        } else {
            Console.WriteLine("\nLo siento, " + nombre + ", no cumples con los requisitos para ser aceptada en la Universidad Kitty Kat SA.");
        }