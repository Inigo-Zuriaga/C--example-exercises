

            //shortcuts
            //ctrl + K + C comentar
            //ctrl + K + U descomentar
            //ctrl + L borra la linea marcada
            //ctrl + D clona la linea
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("Hola, amigo, escribe tu nombre: ");

            //var name = Console.ReadLine();

            //Console.WriteLine("Hola " + name + " esta es la tabla del 7 con for:");

            ////con for
            //Console.WriteLine("//CON FOR");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("7 x " + i + " = " + 7 * i);
            //}

            ////sin for
            //Console.WriteLine("//SIN FOR");
            //Console.WriteLine("7 x 1 = " + 7 * 1);
            //Console.WriteLine("7 x 2 = " + 7 * 2);
            //Console.WriteLine("7 x 3 = " + 7 * 3);
            //Console.WriteLine("7 x 4 = " + 7 * 4);
            //Console.WriteLine("7 x 5 = " + 7 * 5);
            //Console.WriteLine("7 x 6 = " + 7 * 6);
            //Console.WriteLine("7 x 7 = " + 7 * 7);
            //Console.WriteLine("7 x 8 = " + 7 * 8);
            //Console.WriteLine("7 x 9 = " + 7 * 9);
            //Console.WriteLine("7 x 10 = " + 7 * 10);

            ////WHILE
            //Console.WriteLine("//CON WHILE");
            //var numSum = 1;
            //while (numSum <= 10)
            //{
            //    Console.WriteLine("7 x " + numSum + " = " + 7 * numSum);
            //    numSum++;
            //}


            //EJERCICIO atraccion

            Console.WriteLine("Bienvenido, di tu edad");
            int age = int.Parse(Console.ReadLine());
            var aa ="1";
            //int age1 = int.TryParse(Console.ReadLine(), out aa);
            
            if (age < 7)
            {
                Console.WriteLine("NO PUEDES ENTRAR. Solo tienes " + age + ", eres muy pequeño");

            }
            else if (age <= 7 || age < 65)
            {

                Console.WriteLine("ENTRA JOVEN (" + age + "), DISFRUTA");

            }
            else
            {
                Console.WriteLine("NO PUEDES ENTRAR, eres demasiado viejo. Tienes " + age);
            }
