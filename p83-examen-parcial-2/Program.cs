
        float[] calificaciones = null;
        int n = 0;
        while (true) {
            Console.WriteLine("MENU");
            Console.WriteLine("[1] Ingresar calificaciones.");
            Console.WriteLine("[2] Mostrar calificaciones.");
            Console.WriteLine("[3] Calcular promedio y mostrar las calificaciones mayores al promedio.");
            Console.WriteLine("[4] Mostrar complemento a 100 de las calificaciones.");
            Console.WriteLine("[5] Contar calificaciones.");
            Console.WriteLine("[6] Salir...");

            Console.WriteLine("Ingresa una opcion: "); int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcion) {
                case 1:
                    Console.Write("Cuantos elementos deseas guardar? ");
                    n = int.Parse(Console.ReadLine());

                    calificaciones = new float[n];
                    for (int i = 0; i < n; i++) {
                        bool valido = false;
                        while (!valido) {
                            Console.Write($"Elemento {i+1}: ");
                            float calif = float.Parse(Console.ReadLine());
                            if (calif >= 10 && calif <= 100) {
                                calificaciones[i] = calif;
                                valido = true;
                            } else {
                                Console.WriteLine("La calificación debe estar entre 10 y 100.");
                            }
                        }
                    }
                    break;

                case 2:
                    if (calificaciones == null) {
                        Console.WriteLine("Primero debes ingresar las calificaciones.");
                        break;
                    }

                    Console.WriteLine("Los elementos del arreglo son:");
                    foreach (float calif in calificaciones) {
                        Console.Write(calif + " ");
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    if (calificaciones == null) {
                        Console.WriteLine("Digita califciaciones primero.");
                        break;
                    }

                    float promedio = 0;
                    foreach (float calif in calificaciones) {
                        promedio += calif;
                    }
                    promedio /= n;
                    Console.WriteLine($"El promedio de las calificaciones es: \n{promedio}");

                    Console.WriteLine("Las calificaciones mayores al promedio son:");
                    foreach (float calif in calificaciones) {
                        if (calif > promedio) {
                            Console.Write(calif + " ");
                        }
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    if (calificaciones == null) {
                        Console.WriteLine("Primero debes ingresar las calificaciones.");
                        break;
                    }

                    Console.WriteLine("El complemento a 100 es:");
                    foreach (float calif in calificaciones) {
                        Console.Write((100 - calif) + " ");
                    }
                    Console.WriteLine();
                    break;

                case 5:
                    if (calificaciones == null) {
                        Console.WriteLine("Primero debes capturar las calificaciones.");
                        break;
                    }

                    Console.Write("Contar calificación: Cual calificación? ");
                    float califBuscada = float.Parse(Console.ReadLine());
                    int contador = 0;
                    foreach (float calif in calificaciones) {
                        if (calif == califBuscada) {
                            contador++;
                        }
                    }
                    Console.WriteLine($"El {califBuscada} aparece {contador} veces");
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
        }