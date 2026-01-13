using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;



//hacer 3 finales
/*
 final1 la cagoneta gana con 80% de probabilidades o mas yo se qque no hay suerte pero tampoc asi
final2 cheposo ganar con 60% de probabilidades o menos
final3 cheposo supremo ganar con 50% de probabilidades
finalsecreto ????
 */
//final la cagoneta si uas la carta para ganar y si llegas al 100% de probabilida cagas con la cagoneta
//final cheposo ganar con meons de 70% de probabilidades
//final cheposo supremo ganar con el 50 % de probabilidad
//final secreto hacer un articulo carisimo con ????
//odviamente mejoror la interface

//TODO ESTO ES UN COMENTAROIO DE VARIAS LINEAS

class program
{
    static void Main()
    {
        DateTime inicio = DateTime.Now;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        thecoin thecoin = new thecoin();
        thecoin.f11();
        thecoin.introduccion();
        thecoin.juego();

    }
}

class utilidades
{
    public static void mensajecontinue()
    {
        Console.WriteLine("\npreciona enter para continuar.........");
        Console.ReadKey();
        Console.Clear();
    }
    public static void EscribirCentrado(string texto)
    {
        int ancho = Console.WindowWidth;
        int espacios = (ancho - texto.Length) / 2;

        if (espacios < 0) espacios = 0;

        Console.WriteLine(new string(' ', espacios) + texto);
    }
    public static void Escribirfinal(string texto)
    {
        int ancho = Console.WindowWidth;
        int espacios = (ancho - texto.Length);

        if (espacios < 0) espacios = 0;

        Console.WriteLine(new string(' ', espacios) + texto);
    }

    static Random rng = new Random();
    public static void mensajealeatorio()
    {
        if(rng.Next(2) == 0)
        {
        string[] mensajes =
        {
        "Y si esto es un virus",
        "esto dique era un proyectico rapido para practicar en c#",
        "Definitivamente es un GOTY",
        "hay un 1% de que salga un jumpscare",
        @"███▀▀▀▀███████████████
██░░░░░▄██████████████
█▌░░░░████░░██░░██░░██
██░░░░░▀██████████████
███▄▄▄▄███████████████",
        "esto puede ser un virus en verdad",
        "你真的翻譯了這個嗎.exe",
        "--.- ..- . / - ..- / .--. . -. ... .- ... - .",
        "talvez fue demasiado para una simple aplicacion de consola",
        "the best gameplay",
        "la consola esta pensando…",
        "silencio incomodo",
        "mensaje completamente inutil",
        "todo esto por un Console.WriteLine",
        "si estas leyendo esto ya perdiste tiempo",
        "esto se suponia que era simple",
        "esto no es un bug (mentira)",
        "esto no deberia aparecer",
        "observando…",
        "el juego recuerda",
        "esto ya paso antes",
        "ignora este mensaje",
        "ya optuve los datos que queria",
        "esto tampoco ayuda",
        "esto fue una mala idea",
        "la consola te esta mirando",
        "el codigo parpadeo",
        "algo se ejecuto mal pero siguio",
        "esto no estaba en el plan",
        "el juego hizo un ruido raro",
        "esto se imprimio solo",
        "nada",
        "seguimos",
        "jumpscare.png slkdjfslkdjfslkfjsdfkls",
        "este mensaje no se repetira (mentira)",
    "esto no deberia ser posible",
    "la consola no esta de acuerdo",
"la consola esta observando",
"la consola no entiende tu decision",
    };

        Console.WriteLine(mensajes[rng.Next(mensajes.Length)]);
        }
        else
        {
                       
        }

    }

    public static void mensaesdeerror()
    {
        string[] errores =
        {
        "\nmas respeto con el juego",
        "\npa mi que no leiste la introduccion (yo tampoco lo hubiera hecho)",
        "\naja",
        "\npue mi juego e un relajo",
        "\nestamos en una consola por favor",
        "\nenserio tu pensaste que iba a explotar",
        "\n你真的翻譯了這個嗎",
        "\n--.- ..- . / - ..- / .--. . -. ... .- ... - . / --.- ..- . / -.. .. .-. .. .-",
        "\nestas jugando o testeando",
        "\nerror 404 no se encontro el respeto por el juego",
        "\nno se encontro la habilidad para jugar",
        "\nparece que el juego es muy dificil",
        "\nel teclado no tiene la culpa",
        "\nsabia que esto iba a pasar",
        "\naquí normalmente habría un error serio",
        "\n¿esto cuenta como fallo?",
        "\n01000101 01110010 01110010 01101111 01110010",
        "\nsi sigues rompiendo el juego se te reiniciara la racha",
        "\ngracias por testear sin cobrar",
        "\nnadie se esta riendo... o tal vez si"
        };

        Console.WriteLine(errores[rng.Next(errores.Length)]);
    }

    public static int intervencion_racha()
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Random rng = new Random();
        int numero = rng.Next(1, 161);
        Console.WriteLine(@"░██████              ░██                                                                    ░██                      
  ░██                ░██                                                                                             
  ░██  ░████████  ░████████  ░███████  ░██░████ ░██    ░██  ░███████  ░████████   ░███████  ░██ ░███████  ░████████  
  ░██  ░██    ░██    ░██    ░██    ░██ ░███     ░██    ░██ ░██    ░██ ░██    ░██ ░██    ░██ ░██░██    ░██ ░██    ░██ 
  ░██  ░██    ░██    ░██    ░█████████ ░██       ░██  ░██  ░█████████ ░██    ░██ ░██        ░██░██    ░██ ░██    ░██ 
  ░██  ░██    ░██    ░██    ░██        ░██        ░██░██   ░██        ░██    ░██ ░██    ░██ ░██░██    ░██ ░██    ░██ 
░██████░██    ░██     ░████  ░███████  ░██         ░███     ░███████  ░██    ░██  ░███████  ░██ ░███████  ░██    ░██ 
                                                                                                                     
                                                                                                                     
                                                                                                                     ");
        string respuesta;
        //numero = 65; //quitar despues de probar
        switch (numero)
        {
            case <= 10:
                Console.WriteLine("si aciertas tu racha subira +2 y si no bajaras -2 \npregunta:cual es la capital de brazil");
                 respuesta = Console.ReadLine();
                if (respuesta.ToLower().Trim().Contains("brasilia")) 
                {
                    Console.WriteLine("correcto +2 de racha");
                    utilidades.mensajecontinue();
                    return 2;
                }
                else
                {
                    Console.WriteLine("incorrecto -2 de racha");
                    utilidades.mensajecontinue();
                    return -2;
                }

            case <= 20:
                Console.WriteLine("\nresponda verdadero o falso\nEl Real Madrid es el mejor equipo del mundo:");
                respuesta = Console.ReadLine();
                if(respuesta.ToLower().Trim().Contains("verdadero"))
                {
                    Console.WriteLine("correcto racha +2");
                    utilidades.mensajecontinue();
                    return 2;
                }
                else
                {
                    Console.WriteLine("incorrecto racha-2");
                    utilidades.mensajecontinue();
                    return -2;
                }

                break;
            case <= 30:
                Console.WriteLine("aca en esta intervencion no pasa nada solo que hay un 5% de porbabilidad de que tu racha se reinicie xd\n");
                numero = rng.Next(1, 101);
                if(numero <= 5)
                {
                    Console.WriteLine("tu racha se reinicia");
                    utilidades.mensajecontinue();
                    return -9999;
                } else
                {
                    Console.WriteLine("no paso nada");
                    utilidades.mensajecontinue();
                    return 0;
                }
                break;
            case <= 40:
                        Console.WriteLine("piedra papel o tijeros si gano tu racha baja a -2 si gano tu racha sube +2 y si es empate pues nt no pasa nada \n aceptas? (si o no)");
                    respuesta = Console.ReadLine();
                    if(respuesta.ToLower().Trim().Contains("si"))
                    {
                        string[] opciones = { "piedra", "papel", "tijeras" };
                        Console.WriteLine("elige piedra papel o tijeras");
                        string eleccion_usuario = Console.ReadLine();
                        Random rng2 = new Random();
                        int eleccion_ia_index = rng2.Next(0, 3);
                        string eleccion_ia = opciones[eleccion_ia_index];
                        Console.WriteLine($"elegi {eleccion_ia}");
                        if (eleccion_usuario.ToLower().Trim() == eleccion_ia)
                        {
                            Console.WriteLine("empate tu racha no cambia");
                        utilidades.mensajecontinue();
                        return 0;
                        }
                        else if ((eleccion_usuario.ToLower().Trim() == "piedra" && eleccion_ia == "tijeras") ||
                                 (eleccion_usuario.ToLower().Trim() == "papel" && eleccion_ia == "piedra") ||
                                 (eleccion_usuario.ToLower().Trim() == "tijeras" && eleccion_ia == "papel"))
                        {
                            Console.WriteLine("ganaste tu racha sube en 2");
                        utilidades.mensajecontinue();
                        return 2;
                        }
                        else
                        {
                            Console.WriteLine("perdiste tu racha baja en 2");
                        utilidades.mensajecontinue();
                        return -2;
                        }
                    } else if (respuesta.ToLower().Trim().Contains("no"))
                    {
                        Console.WriteLine("por cagon tu racha baja en 1");
                    utilidades.mensajecontinue();
                    return -1;
                    }
                    else
                    {
                        Console.WriteLine("por chistoso te vas con -3");
                    utilidades.mensajecontinue();
                    return -3;
                    }
            case <= 50:
                Console.WriteLine(@"en las instrucciones habia un numero que nuemero era ese");
                respuesta = Console.ReadLine();
                if(respuesta.Trim() == "7")
                {
                    Console.WriteLine("correcto tu racha sube en 3");
                    utilidades.mensajecontinue();
                    return 3;
                } else
                {
                    Console.WriteLine("incorrecto tu racha baja en 3");
                    utilidades.mensajecontinue();
                    return -3;
                }
                break;
            case <= 60:
                Console.WriteLine("salado y pico de todas las intervenciones que hay  esta lo unico que hace es bajarte -2 en la racha de gratis increible ");
                utilidades.mensajecontinue();
                return -2;
                break;
            case <= 70:
                Console.WriteLine("esta es buena adivina el numero del dado si la pegas la  cantidad se te sumara a la racha y si la fallas esa cantidad se te va a restar a la racha :)");
                int numero_dado = rng.Next(1, 7);
                while (true)
                {
                    try
                    {

                        Console.WriteLine("\ncual numero saldra del dado (1-6)");
                        int esta_respuesta = Convert.ToInt32(Console.ReadLine());
                        if (esta_respuesta == 0)
                        {
                            Console.WriteLine("que pensaste que no pense en eso laskjdflksdfjslkfjdsf\nno seas cagon y juega \npude haber puesto aqui que se te reinicie la racha lskdjfskldfjsfkj");
                            Thread.Sleep(10000);
                            Console.Clear();
                            continue;
                        } else if (esta_respuesta < 1 || esta_respuesta > 6)
                        {
                            Console.WriteLine("del 1 al 6 abusador");
                            Thread.Sleep(2200);
                            continue;
                        }
                        if (esta_respuesta == numero_dado)
                        {
                            Console.WriteLine($"correcto racha+{esta_respuesta}");
                            utilidades.mensajecontinue();
                            return esta_respuesta;
                        } else
                        {
                            Console.WriteLine($"incorrecto el numero era {numero_dado} racha-{esta_respuesta}");
                            utilidades.mensajecontinue();
                            return -esta_respuesta;
                        }
                    }
                    catch
                    {
                        mensaesdeerror();
                        Thread.Sleep(2200);
                        Console.Clear();
                        continue;
                    }
                    break;
                }
            case <= 80:
                Console.WriteLine(". ... -.-. .-. .. -... . / .... .- .-.. .- / -- .- -.. .-. .. -.. / .--. .- .-. .- / --.- ..- . / -. --- / .--. .- ... . / -. .- -.. .- / ... .. / .--. --- -. . ... / -.-. ..- .- .-.. --.- ..- .. . .-. / --- - .-. .- / -.-. --- ... .- / -....- ..--- / .--. --- .-. / -. --- / - .-. .- -.. ..- ... .. .-.");
                respuesta = Console.ReadLine();
                if(respuesta.ToLower().Trim() == "hala madrid")
                {
                    Console.WriteLine("bien hacho");
                    utilidades.mensajecontinue();
                    return 0;
                }
                else
                {
                    Console.WriteLine("-2 de racha");
                    utilidades.mensajecontinue();
                    return -2;
                }
                break;
            case <= 90:
                Console.WriteLine("si escribes hala madrid en el teclado del juego te da +5 de racha");
                utilidades.mensajecontinue();
                return 0;
                break;
            case <= 100:
                Console.WriteLine("en el video de youtube Hala Madrid...y nada más (feat. RedOne) del canal oficial del real madrid \ncual es la segunda red social que aparece en la descripcion si no responde la racha se reinicia \nle bien la pregunta");
                respuesta = Console.ReadLine();
                if(respuesta.ToLower().Trim() == "twitter"|| respuesta.ToLower().Trim() == "x")
                {
                    Console.WriteLine("correcto racha +3");
                    Console.WriteLine("en verdad tanto twiter como x son correctos xd");
                    utilidades.mensajecontinue();
                    return 3;
                } else
                {
                    Console.WriteLine("incorrecto tu racha se reinicia");
                    utilidades.mensajecontinue();
                    return -9999;
                }
                break;
            case <= 110:
                Console.WriteLine("no hagas nada…");

                DateTime inicio = DateTime.Now;

                while ((DateTime.Now - inicio).TotalMilliseconds < 3000)
                {
                    if (Console.KeyAvailable)
                    {
                        Console.ReadKey(true); 
                        Console.WriteLine("te dije que no hicieras nada -2 de racha");
                        utilidades.mensajecontinue();
                        return -2;             
                    }

                    Thread.Sleep(50); 
                }

                Console.WriteLine("bien. Racha +2");
                utilidades.mensajecontinue();
                return 2; 
            case <= 120:
                Console.WriteLine("tu racha se reiniciara");
                utilidades.mensajecontinue();
                Console.WriteLine("era mentira xd");
                utilidades.mensajecontinue();
                return 0;
            case <= 130:
                string[,] preguntas =
                             {
                                { "¿Cuál es el planeta más grande del sistema solar?", "jupiter" },
                                { "¿En qué continente está Egipto?", "africa" },
                                { "¿Cuántos lados tiene un triángulo?", "3" },
                                { "¿Quién pintó la Mona Lisa?", "da vinci" },
                                { "¿Cuál es el océano más grande del mundo?", "pacifico" },
                                { "¿En qué país está la Torre Eiffel?", "francia" },
                                { "¿Cuántos minutos tiene una hora?", "60" },
                                { "¿Cuál es el metal cuyo símbolo es Fe?", "hierro" }
                            };

                int index = rng.Next(preguntas.GetLength(0));

                Console.WriteLine("PREGUNTA DE CULTURA GENERAL:");
                Console.WriteLine(preguntas[index, 0]);

                respuesta = Console.ReadLine().ToLower().Trim();

                if (respuesta.Contains(preguntas[index, 1]))
                {
                    Console.WriteLine("correcto +2 de racha");
                    utilidades.mensajecontinue();
                    return 2;
                }
                else
                {
                    Console.WriteLine($"incorrecto -2 de racha\nla respuesta era: {preguntas[index, 1]}");
                    utilidades.mensajecontinue();
                    return -2;
                }
            case <= 140:
                Console.WriteLine("buenos dias");
                utilidades.mensajecontinue();
                break;
            case <= 150:
                Console.WriteLine("tu racha sube en 1");
                utilidades.mensajecontinue();
                return 1;
            case <= 160:
                Console.WriteLine("tu racha baja en 1");
                utilidades.mensajecontinue();
                return -1;
        }
        return 0;
    }
    public static int intervencion_dinero()
    {

        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Random rng = new Random();
            int numero = rng.Next(1, 141);
            Console.WriteLine(@"░██████              ░██                                                                    ░██                      
  ░██                ░██                                                                                             
  ░██  ░████████  ░████████  ░███████  ░██░████ ░██    ░██  ░███████  ░████████   ░███████  ░██ ░███████  ░████████  
  ░██  ░██    ░██    ░██    ░██    ░██ ░███     ░██    ░██ ░██    ░██ ░██    ░██ ░██    ░██ ░██░██    ░██ ░██    ░██ 
  ░██  ░██    ░██    ░██    ░█████████ ░██       ░██  ░██  ░█████████ ░██    ░██ ░██        ░██░██    ░██ ░██    ░██ 
  ░██  ░██    ░██    ░██    ░██        ░██        ░██░██   ░██        ░██    ░██ ░██    ░██ ░██░██    ░██ ░██    ░██ 
░██████░██    ░██     ░████  ░███████  ░██         ░███     ░███████  ░██    ░██  ░███████  ░██ ░███████  ░██    ░██ 
                                                                                                                     
                                                                                                                     
                                                                                                                     ");
            string respuesta;
            //numero = 65; //quitar despues de probar
            switch (numero)
            {
                case <= 10:
                    Console.WriteLine("si aciertas te dare 300 dolares y si no me daras 200 pregunta:\ncual es la capital de peru");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToLower().Trim().Contains("lima"))
                    {
                        Console.WriteLine("correcto ten 300");
                        utilidades.mensajecontinue();
                        return 300;
                    }
                    else
                    {
                        Console.WriteLine("incorrecto mis 200 sin intereses");
                        utilidades.mensajecontinue();
                        return -200;
                    }
                case <= 20:
                    Console.WriteLine("\nresponda verdadero o falso\nEl tercer idioma mas hablado del mundo(solo contando nativos) es el ingles");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToLower().Trim().Contains("verdadero"))
                    {
                        Console.WriteLine("correcto racha +500");
                        utilidades.mensajecontinue();
                        return 500;
                    }
                    else
                    {
                        Console.WriteLine("incorrecto racha -500");
                        utilidades.mensajecontinue();
                        return -500;
                    }

                    break;
                case <= 30:
                    Console.WriteLine("an esta intervencion no pasa nada lo unico es que hay 5 porciento de probabilidad de que te quite todo el dinero xd\n");
                    numero = rng.Next(1, 101);
                    if (numero <= 5)
                    {
                        Console.WriteLine("te lleve todo");
                        utilidades.mensajecontinue();
                        return -999999;
                    }
                    else
                    {
                        Console.WriteLine("no paso nada");
                        utilidades.mensajecontinue();
                        return 0;
                    }
                    break;
                case <= 40:
                    Console.WriteLine("piedra papel o tijeros si ganas +500 dolares y si gano -500 y si es empate pues nt no pasa nada \n aceptas? (si o no)");
                    respuesta = Console.ReadLine();
                    if (respuesta.ToLower().Trim().Contains("si"))
                    {
                        string[] opciones = { "piedra", "papel", "tijeras" };
                        Console.WriteLine("elige piedra papel o tijeras");
                        string eleccion_usuario = Console.ReadLine();
                        Random rng2 = new Random();
                        int eleccion_ia_index = rng2.Next(0, 3);
                        string eleccion_ia = opciones[eleccion_ia_index];
                        Console.WriteLine($"elegi {eleccion_ia}");
                        if (eleccion_usuario.ToLower().Trim() == eleccion_ia)
                        {
                            Console.WriteLine("nt");
                            utilidades.mensajecontinue();
                            return 0;
                        }
                        else if ((eleccion_usuario.ToLower().Trim() == "piedra" && eleccion_ia == "tijeras") ||
                                 (eleccion_usuario.ToLower().Trim() == "papel" && eleccion_ia == "piedra") ||
                                 (eleccion_usuario.ToLower().Trim() == "tijeras" && eleccion_ia == "papel"))
                        {
                            Console.WriteLine("ganaste +500");
                            utilidades.mensajecontinue();
                            return 500;
                        }
                        else
                        {
                            Console.WriteLine("perdiste te toca pagar");
                            utilidades.mensajecontinue();
                            return -500;
                        }
                    }
                    else if (respuesta.ToLower().Trim().Contains("no"))
                    {
                        Console.WriteLine("por cagon te quito -200");
                        utilidades.mensajecontinue();
                        return -1;
                    }
                    else
                    {
                        Console.WriteLine("por chistoso te vas con -300");
                        utilidades.mensajecontinue();
                        return -300;
                    }
                case <= 50:
                    Console.WriteLine(@"en las instrucciones habia un numero que nuemero era ese");
                    respuesta = Console.ReadLine();
                    if (respuesta.Trim() == "7")
                    {
                        Console.WriteLine("correcto +300");
                        utilidades.mensajecontinue();
                        return 300;
                    }
                    else
                    {
                        Console.WriteLine("incorrecto -200");
                        utilidades.mensajecontinue();
                        return -200;
                    }
                    break;
                case <= 60:
                    Console.WriteLine("impuestos -200 (esto no aumenta con el tiempo tranquilo)");
                    utilidades.mensajecontinue();
                    return -200;
                    break;
                case <= 70:
                    Console.WriteLine("esta es buena adivina el numero del dado si la pegas la  cantidad se te sumara y si la fallas esa cantidad se te va a restar :) ( 1 = 100)");
                    int numero_dado = rng.Next(1, 7);
                    while (true)
                    {
                        try
                        {

                            Console.WriteLine("\ncual numero saldra del dado (1-6)");
                            int esta_respuesta = Convert.ToInt32(Console.ReadLine());
                            if (esta_respuesta == 0)
                            {
                                Console.WriteLine("que pensaste que no pense en eso laskjdflksdfjslkfjdsf\nno seas cagon y juega \npude haber puesto aqui que te quedes en 0 lskdjfskldfjsfkj");
                                Thread.Sleep(10000);
                                Console.Clear();
                                continue;
                            }
                            else if (esta_respuesta < 1 || esta_respuesta > 6)
                            {
                                Console.WriteLine("del 1 al 6 abusador");
                                Thread.Sleep(2200);
                                continue;
                            }
                            if (esta_respuesta == numero_dado)
                            {
                                Console.WriteLine($"correcto doalres +{esta_respuesta*100}");
                                utilidades.mensajecontinue();
                                return esta_respuesta * 100;
                            }
                            else
                            {
                                Console.WriteLine($"incorrecto el numero era {numero_dado} dolares-{esta_respuesta * 100}");
                                utilidades.mensajecontinue();
                                return -(esta_respuesta * 100);
                            }
                        }
                        catch
                        {
                            mensaesdeerror();
                            Thread.Sleep(2200);
                            Console.Clear();
                            continue;
                        }
                        break;
                    }
                case <= 80:
                    Console.WriteLine("de las tantas que hay es la unica en la que no pasa nada xd");
                    utilidades.mensajecontinue();
                    return 0;
                case <= 90:
                    Console.WriteLine("recuerda esta palabra \"sldkjfklsjd\" ");
                    utilidades.mensajecontinue();
                    return 0;
                    break;
                case <= 100:
                    Console.WriteLine("+200 de gratis");
                    utilidades.mensajecontinue();
                    return 200;
                case <= 110:
                    Console.WriteLine("no hagas nada…");

                    DateTime inicio = DateTime.Now;

                    while ((DateTime.Now - inicio).TotalMilliseconds < 3000)
                    {
                        if (Console.KeyAvailable)
                        {
                            Console.ReadKey(true);
                            Console.WriteLine("te dije que no hicieras nada -200 dolares");
                            utilidades.mensajecontinue();
                            return -200;
                        }

                        Thread.Sleep(50);
                    }

                    Console.WriteLine("bien. +200 dolares");
                    utilidades.mensajecontinue();
                    return 200;
                case <= 120:
                    Console.WriteLine("te quedas en 0 (de dinero)");
                    utilidades.mensajecontinue();
                    Console.WriteLine("era mentira xd");
                    utilidades.mensajecontinue();
                    return 0;
                case <= 130:
                    string[,] preguntas =
                                 {
                                { "¿Cuál es el planeta más grande del sistema solar?", "jupiter" },
                                { "¿En qué continente está Egipto?", "africa" },
                                { "¿Cuántos lados tiene un triángulo?", "3" },
                                { "¿Quién pintó la Mona Lisa?", "da vinci" },
                                { "¿Cuál es el océano más grande del mundo?", "pacifico" },
                                { "¿En qué país está la Torre Eiffel?", "francia" },
                                { "¿Cuántos minutos tiene una hora?", "60" },
                                { "¿Cuál es el metal cuyo símbolo es Fe?", "hierro" }
                            };

                    int index = rng.Next(preguntas.GetLength(0));

                    Console.WriteLine("PREGUNTA DE CULTURA GENERAL:");
                    Console.WriteLine(preguntas[index, 0]);

                    respuesta = Console.ReadLine().ToLower().Trim();

                    if (respuesta.Contains(preguntas[index, 1]))
                    {
                        Console.WriteLine("correcto +200");
                        utilidades.mensajecontinue();
                        return 200;
                    }
                    else
                    {
                        Console.WriteLine($"incorrecto -200\nla respuesta era: {preguntas[index, 1]}");
                        utilidades.mensajecontinue();
                        return -200;
                    }
                case <= 140:
                    Console.WriteLine("buenos dias");
                    utilidades.mensajecontinue();
                    return 0;
                    break;


            }
            return 0;
        }
    }
}
class thecoin
{
    int probabidad = 50;
    bool exit = false;
    public int racha = 0;
    //false = crus  true = cara
    bool moneda = true;
    bool carta = false;
    public int dinero = 666660;
    public int cuanto_dinero_dube = 5;
    Tienda tienda;
    int dinero_total =0;
    int pegar = 0;
    DateTime inicio = DateTime.Now;
    int intentos = 0;
    Random rng = new Random();
    


    public thecoin()
    {
        tienda = new Tienda(this);
    }

    public void modificar_racha(int menos)
    {
        if ((racha + menos) < 0)
        {
            racha = 0;
            return;
        }
        racha += menos;
    }

    public void modificar_dinero(int menos)
    {
        if (menos > 0)
        {
            dinero_total += menos;
        }

        if ((dinero + menos) < 0)
        {
            dinero = 0;
            return;
        }
        dinero += menos;
    }
    public void stats()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine(@"              ░██                  ░██               
              ░██                  ░██               
 ░███████  ░████████  ░██████   ░████████  ░███████  
░██           ░██          ░██     ░██    ░██        
 ░███████     ░██     ░███████     ░██     ░███████  
       ░██    ░██    ░██   ░██     ░██           ░██ 
 ░███████      ░████  ░█████░██     ░████  ░███████  
                                                     
                                                     
                                                     ");
        TimeSpan tiempotranscurrido = DateTime.Now - inicio;
        Console.WriteLine($"Tiempo imvetido: \nHoras {tiempotranscurrido.TotalHours:F2} \nMinutos {tiempotranscurrido.TotalMinutes:F2} \nSegundos{tiempotranscurrido.TotalSeconds:F2}") ;
        Console.WriteLine($"cuanto dinero en total conseguiste:{dinero_total}");
        Console.WriteLine($"Cuantas veces la pegaste:{pegar}");
        Console.WriteLine($"Cuantas veces fallaste xd:{intentos - pegar }");
        if(intentos > 0)
        {
            double efectividad = (double)pegar / intentos * 100;
            Console.WriteLine($"Efectividad: {efectividad:F2}%");
        }
        Console.WriteLine($"Cuantas veces lo intentaste(cuantas veces escribiste cara o cruz): {intentos}");

        utilidades.mensajecontinue();
    }

    public void f11()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Presiona F11 para pantalla completa (recomendado)");
        Console.WriteLine(@"
NO DEJE EL ENTER PRECIONADO PARA NO SALTARSE NADA POR ERROR Y NO ENTIENDAS LO QUE ESTA PASANDO

EN CASO DE HACERLO ESCRIBA TUTORIAL EN EL JUEGO

NUNCA DEJES EL ENTER PISADO PORQUE ESTAMOS EN UNA CONSOLA TAMPOCO ABUSES
");
        utilidades.mensajecontinue();

    }

    public void ver_otrofinal()
    {
        int final = 0;
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();
        Console.WriteLine("\nDesea ver otro final o ya se quiere ir :( (hay mucho que ver en verdad no todo sale en la primera vuelta)\n(si o no)");
        string respuesta = Console.ReadLine();
        if (respuesta.ToLower().Trim().Contains("si"))
        {
            while (true)
            {
                try
                {
                Console.WriteLine("Que numero de final quiere ver como se hace?");
                final = Convert.ToInt32(Console.ReadLine());
                if (final == 0 || final > 4 || final < 0)
                {
                
                    Console.WriteLine("te inventaste un final");
                    Thread.Sleep(2200);
                    continue;
                }
                }
                catch
                {
                    utilidades.mensaesdeerror();
                    Thread.Sleep(2200);
                    Console.Clear();
                    continue;
                }
                break;
            }
        } else if (respuesta.ToLower().Trim().Contains("no"))
        {
            Console.WriteLine(":(");
            Console.WriteLine("\n proximamente mas cosas y mas intervenciones diferentes");
            Thread.Sleep(2200);
            Environment.Exit(0);
        }
        else
        {
            ver_otrofinal();
        }


        switch (final)
        {
            case 1:
                {
                    Console.WriteLine("Final 1/4: la cagoneta gana con 70% de probabilidad o mas");
                    utilidades.mensajecontinue();
                    racha = 0;
                    dinero = 0;
                    probabidad = 50;
                    carta = false;
                    juego();
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Final 2/4: Cheposo principiante Gana con 60% de probabilidad");
                    utilidades.mensajecontinue();
                    racha = 0;
                    dinero = 0;
                    probabidad = 50;
                    carta = false;
                    juego();
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Final 3/4:Cheposo Supremo Gana con 50% de probabilidad (mensaje oculto solo para cuando haces este final)");
                    utilidades.mensajecontinue();
                    racha = 0;
                    dinero = 0;
                    probabidad = 50;
                    carta = false;
                    juego();
                    break;
                }
            case 4:
                {
                    Console.WriteLine("很明顯，這件東西就在部長的儲藏室裡；這不需要是工程師也能明白。");
                    utilidades.mensajecontinue();
                    racha = 0;
                    dinero = 0;
                    probabidad = 50;
                    carta = false;
                    juego();
                    break;
                }


        }
    }
    public void introduccion()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine(@"                                                        
                        ▄                    ▄          
  ▄▄▄    ▄▄▄   ▄ ▄▄   ▄▄█▄▄   ▄▄▄   ▄   ▄  ▄▄█▄▄   ▄▄▄  
 █▀  ▀  █▀ ▀█  █▀  █    █    █▀  █   █▄█     █    █▀ ▀█ 
 █      █   █  █   █    █    █▀▀▀▀   ▄█▄     █    █   █ 
 ▀█▄▄▀  ▀█▄█▀  █   █    ▀▄▄  ▀█▄▄▀  ▄▀ ▀▄    ▀▄▄  ▀█▄█▀ 
 ");
        Console.WriteLine("\nestaba en youtube y vi a x creador (no nos esta pagando) juando esta juego y dije pero eso yo lo puedo hacer en c# en par de minutos (no fue asi)\nbueno la idea original es que cada vez que haces click giras una moneda y si sale cara 10 veces ganas pero por temas de que estamos en una consola pues se modifico la idea origianal\npensaras que es un diparate grande pero creeme que no lo es (o tal vez si) \ny aqui estamos la idea es simple en la siguiente pestaña se te va a explicar todo pero si ese es el contexto de esto");
        utilidades.mensajecontinue();    
        Console.WriteLine(@"░██████████              ░██                        ░██           ░██ 
    ░██                  ░██                                      ░██ 
    ░██    ░██    ░██ ░████████  ░███████  ░██░████ ░██ ░██████   ░██ 
    ░██    ░██    ░██    ░██    ░██    ░██ ░███     ░██      ░██  ░██ 
    ░██    ░██    ░██    ░██    ░██    ░██ ░██      ░██ ░███████  ░██ 
    ░██    ░██   ░███    ░██    ░██    ░██ ░██      ░██░██   ░██  ░██ 
    ░██     ░█████░██     ░████  ░███████  ░██      ░██ ░█████░██ ░██ 
 ");
        Console.WriteLine(@"                                                        
   ▄▄▄                              ▀▀█                 
 ▄▀   ▀  ▄▄▄   ▄▄▄▄▄   ▄▄▄   ▄▄▄▄     █     ▄▄▄   ▄   ▄ 
 █   ▄▄ ▀   █  █ █ █  █▀  █  █▀ ▀█    █    ▀   █  ▀▄ ▄▀ 
 █    █ ▄▀▀▀█  █ █ █  █▀▀▀▀  █   █    █    ▄▀▀▀█   █▄█  
  ▀▄▄▄▀ ▀▄▄▀█  █ █ █  ▀█▄▄▀  ██▄█▀    ▀▄▄  ▀▄▄▀█   ▀█   
                             █                     ▄▀   
                             ▀                    ▀▀ ");
        Console.WriteLine(@"la idea es simple tienes que adiviar si saldra cara o cruz 10 veces seguidas para ganar 
hay un 33% de porbabilidad de que ocurra una intervencion, las intervenciones son eventos que pueden perjudicarte o ayudarte a ganar mas rapido
En la tienda puedes comprar objetos que te ayudaran en tu


el juego cuenta con 4 finales cuando consigas un final se te dara la opcion de saber como se hace un final diferente
");
        Console.WriteLine(@"                                                               
   ▄▄▄                  ▄                  ▀▀█                 
 ▄▀   ▀  ▄▄▄   ▄ ▄▄   ▄▄█▄▄   ▄ ▄▄   ▄▄▄     █     ▄▄▄    ▄▄▄  
 █      █▀ ▀█  █▀  █    █     █▀  ▀ █▀ ▀█    █    █▀  █  █   ▀ 
 █      █   █  █   █    █     █     █   █    █    █▀▀▀▀   ▀▀▀▄ 
  ▀▄▄▄▀ ▀█▄█▀  █   █    ▀▄▄   █     ▀█▄█▀    ▀▄▄  ▀█▄▄▀  ▀▄▄▄▀ 
");
        Console.WriteLine(@"
1) Escribe cara o cruz para adivinar 
2) Escribe shop o tienda para ir a la tienda
3) Escribe stats para ver tus estadisticas
4) Puedes salir mas de una intervencion sguida es un 33%
5) NUNCA DEJES EL ENTER PISADO QUE ESTAMOS EN UNA CONSOLA
6) NUNCA SE DES DOS VECES SEGUIDAS el juego esta hecho para que siepre que le des a enter pase algo y vuelva no le des de nuevo si el juego no te lo puede
7) NUNCA CIERRE EL PROGRA USTED MISMO EL JUEGO ESTA HECHO PARA QUE SALGA SOLO
8) Si en algun momento pones algo que no debes en el teclado se ta a saltar un mensaje
9) SOLAMENTE USA LAS FLECHAS CUADNO ESTES EN UN TECLADO (DENTRO DEL JUEGO)
10) DISFRUTA EL JUEGO

Todas estas advertencias y forams de jugar es por su propio bien devido a que estamos en una consola y no en una app 
y devido a eso estamos medio limitados gracias por entender ");

        utilidades.mensajecontinue();

    }
    public void saludo_final()
    {
        Console.Clear();
        Console.WriteLine(@"                                                                                                                                                      
    ▄▄▄▄     ▄▄▄▄    ▄▄▄   ▄▄     ▄▄▄▄   ▄▄▄▄▄▄       ▄▄     ▄▄▄▄▄▄▄▄  ▄▄    ▄▄  ▄▄           ▄▄     ▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄     ▄▄▄▄    ▄▄▄   ▄▄    ▄▄▄▄   
  ██▀▀▀▀█   ██▀▀██   ███   ██   ██▀▀▀▀█  ██▀▀▀▀██    ████    ▀▀▀██▀▀▀  ██    ██  ██          ████    ▀▀▀██▀▀▀   ▀▀██▀▀    ██▀▀██   ███   ██  ▄█▀▀▀▀█  
 ██▀       ██    ██  ██▀█  ██  ██        ██    ██    ████       ██     ██    ██  ██          ████       ██        ██     ██    ██  ██▀█  ██  ██▄      
 ██        ██    ██  ██ ██ ██  ██  ▄▄▄▄  ███████    ██  ██      ██     ██    ██  ██         ██  ██      ██        ██     ██    ██  ██ ██ ██   ▀████▄  
 ██▄       ██    ██  ██  █▄██  ██  ▀▀██  ██  ▀██▄   ██████      ██     ██    ██  ██         ██████      ██        ██     ██    ██  ██  █▄██       ▀██ 
  ██▄▄▄▄█   ██▄▄██   ██   ███   ██▄▄▄██  ██    ██  ▄██  ██▄     ██     ▀██▄▄██▀  ██▄▄▄▄▄▄  ▄██  ██▄     ██      ▄▄██▄▄    ██▄▄██   ██   ███  █▄▄▄▄▄█▀ 
    ▀▀▀▀     ▀▀▀▀    ▀▀   ▀▀▀     ▀▀▀▀   ▀▀    ▀▀▀ ▀▀    ▀▀     ▀▀       ▀▀▀▀    ▀▀▀▀▀▀▀▀  ▀▀    ▀▀     ▀▀      ▀▀▀▀▀▀     ▀▀▀▀    ▀▀   ▀▀▀   ▀▀▀▀▀   ");
        Console.WriteLine("\n \nCongratulation has completado el juego\nMuchas gracias por jugar y llegar hasta aqui");
        //Console.WriteLine("Muchas gracias por tu tienpo\n");


    }
    public void final1()
    {

        saludo_final();
        Console.WriteLine("\nFINAL 1/4 FINAL 1 LA CAGONETA: \ngana con 70% de probabilidades o mas\n");
        Console.WriteLine("enter para ver continuar.....");
        Console.ReadKey();
        stats();
        ver_otrofinal();
    }
    public void final2()
    {
        saludo_final();
        Console.WriteLine("\nFINAL 2/4 FINAL CHEPOSO PRINCIPIANTE\n gana con 60% de probabilidades o menos\n");
        Console.WriteLine("enter para ver continuar.....");
        Console.ReadKey();
        stats();
        ver_otrofinal();
    } 
    public void final3()
    {
        saludo_final();
        Console.WriteLine("\nFINAL 3/4 FINAL CHEPOSO SUPREMO \n gana con 50% de probabilidades (si no hubiera intervenciones ni usaras la carta este final fuera imposible literalmente) \n");
        Console.WriteLine("enter para ver continuar.....");
        Console.ReadKey();
        stats();
        ver_otrofinal();
    }
    public void finalsecreto()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        for(int x =0; x < 10; x++)
        {
            Console.Beep(1000, 200);
                    Console.WriteLine(@"███████▀▀▀░░░░░░░▀▀▀███████
██████▀░░░░░░░░░░░░░░░▀████
█████│░░░░░░░░░░░░░░░░│████
████└┐░░░░░░░░░░░░░░░┌┘░███
███░░└┐░░░░░░░░░░░░░░┌┘░░██
███░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
██▌░▄██████▄░░░▄██████▄░▐██
███─┘░░▓▓▓▓░░░░░▓▓▓▓░░└─███
██▀▓▓▓░▓▓▓▓░░░░░▓▓▓▓░▓▓░▀██
██▄▓▓▓░▓▓▓▓▄▄▄▄▄▓▓▓▓░▓▓▄███
████▄─┘█████████████└─▄████
█████░░▐███████████▌░░█████
██████░░▀█████████▀░░▐█████
███████░░░░▓▓▓▓▓░░░░▄██████
████████▄░░░░░░░░░▄████████
███████████▓▓▓▓▓███████████
███████████▓▓▓▓▓███████████
═══════════════════════════════════════╗
████╗████████╗██╗███████╗███╗═══███╗████████╗
═██╔╝═══██╔══╝╚█║██╔════╝████╗═████║██╔═════╝
═██║════██║════╚╝███████╗██╔████╔██║█████╗
═██║════██║══════╚════██║██║╚██╔╝██║██╔══╝
████╗═══██║══════███████║██║═╚═╝═██║███████╗
═══════════════════════════════════════════╝");
            Thread.Sleep(100);
        }
        Thread.Sleep(3000);

        Environment.Exit(0);
    }
    public void juego()
    {
         
        while (!exit)
        {
            if (racha >= 10 && probabidad >= 70)
            {
                final1();
                continue;
            } else if (racha >= 10 && probabidad == 50)
            {
                final3();
                continue;
            } else if (racha >= 10 && probabidad <= 60)
            {
                final2();
                continue;
            }

            int numero = rng.Next(1, 7);
            if (numero == 2)
            {  
            int racha_baja = utilidades.intervencion_racha();
            modificar_racha(racha_baja);
                continue;
            } else if (numero == 1)
            {
                int probabilidad_baja = utilidades.intervencion_dinero();
                modificar_dinero(probabilidad_baja);
            }
            ;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            try
            {
            Console.Clear();
            Console.WriteLine(@"   ░██    ░██                                            ░██           
   ░██    ░██                                                          
░████████ ░████████   ░███████      ░███████   ░███████  ░██░████████  
   ░██    ░██    ░██ ░██    ░██    ░██    ░██ ░██    ░██ ░██░██    ░██ 
   ░██    ░██    ░██ ░█████████    ░██        ░██    ░██ ░██░██    ░██ 
   ░██    ░██    ░██ ░██           ░██    ░██ ░██    ░██ ░██░██    ░██ 
    ░████ ░██    ░██  ░███████      ░███████   ░███████  ░██░██    ░██ 
");
            Console.WriteLine($"DINERO: {dinero}\n");
            Console.WriteLine($"STREAK (RACHA):{racha}\n");
            Console.WriteLine($"Probabilidad de que salga cara:{probabidad}%\n");
            if(carta == true)
            {
                Console.WriteLine("Carta +2 disponible (escribe carta para usar)\n");
            }
            Console.WriteLine("\n");
                utilidades.mensajealeatorio();
            Console.WriteLine("\n \n\n");
                Console.WriteLine("(Escribe tutorial para volver al tutorial)");
                Console.Write("Teclado:");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower().Trim() == "carta" && carta == false)
                {
                    Console.WriteLine("\nprimero comprala");
                    Thread.Sleep(1500);
                    continue;
                }
            string[] palabras = { "cara", "cruz", "carta", "shop", "tienda", "stats","hala madrid","tutorial"};

            bool contiene = palabras.Any(p =>
                respuesta.Contains(p, StringComparison.OrdinalIgnoreCase)
            );

            if (!contiene)
            {
                    utilidades.mensaesdeerror();
                    Thread.Sleep(1500);
                continue;
            }
            
            Console.WriteLine("");
            if (respuesta.ToLower().Trim().Contains("tienda") || respuesta.ToLower().Trim().Contains("shop"))
            {
                tienda.setdinero(dinero);
                tienda.menu();
                continue;
            }
            
                if (respuesta.ToLower().Trim().Contains("tutorial"))
                {
                    introduccion();
                    continue;
                }
    
                if (respuesta.ToLower().Trim().Contains("stats"))
                {
                   
                    stats();
                    continue;
                }
                if (respuesta.ToLower().Trim().Contains("hala madrid"))
                {
                    Console.WriteLine("de verdad pensaste que te dario +5 de racha de gratis lskjlskdfjslkdfjsdlfkj");
                    Console.WriteLine("tu racha se reiniciara");
                    modificar_racha(-10);
                    Thread.Sleep(5800);
                    continue;
                }

                if (respuesta.ToLower().Trim().Contains("carta") && carta == true)
            {
                carta_mas_2();
                continue;
            } 

            girarmoneda();

            if (moneda == true)
            {
                Console.Write($"Moneda: salio  cara \n");
            } else if (moneda == false)
            {
                Console.Write("Moneda: Salio cruz  \n");
            }

            if((respuesta.ToLower().Trim().Contains("cara")&& moneda == true) ||(respuesta.ToLower().Trim().Contains("cruz") && moneda == false))
            {
                    intentos++;
                racha ++;
                    pegar++;
                    dinero_total += cuanto_dinero_dube;
                dinero += cuanto_dinero_dube;
            } else if((respuesta.ToLower().Trim().Contains("cara") && moneda == false) || (respuesta.ToLower().Trim().Contains("cruz") && moneda == true) )
            {
                    intentos++;
                    racha = 0;
            }

            


                Thread.Sleep(2200);
            

            }
            catch
            {
                utilidades.mensaesdeerror();
                
            }

        }
    }

    public void setdinero(int dinero)
    {
        this.dinero = dinero;
    }
    public void activar_carta()
    {
        carta = true;
    }

    void carta_mas_2()
    {
        if (carta == true)
        {
            racha += 2;
            carta = false;
        }
        else
        {
            Console.WriteLine("digo yo que primero hay que comprarla");
        }
    }

    public void probabilitor()
    {
        probabidad += 10;
    }

    public void teclado_oro()
    {
        cuanto_dinero_dube *= 2;
    }


    void girarmoneda()
    {
        Random rng = new Random();

        int numero = rng.Next(1, 101);

        if (probabidad <= numero)
        {
            moneda = false;
        }
        else
        {
            moneda = true;
        }
    }


}
class Tienda
{
    string respuesta;
    int teclado_price = 10;
    int carta_price = 50;
    int porbabilitor_price = 100;
    int dinero_del_jugador;
    int secreto_pice = 9999;
    thecoin juego;
    int stock = 5;

    public Tienda(thecoin juego)
    {
        this.juego = juego;
    }
    Dictionary<string, int> articulos = new Dictionary<string, int>()
    {
        {"Teclado de oro", 20 },
        {"+2 carta_de_mas_2_del_UNO.png",50 },
        {"probabilitor el improbable", 100 },
        {"???", 9999 }
    };

    public void setdinero(int dinero)
    {
        dinero_del_jugador = dinero;
    }
    public void menu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            if (stock == 0)
            {
                articulos.Remove("probabilitor el improbable");
            }
            Console.Clear();
            Console.WriteLine(@"           ░██                              
           ░██                              
 ░███████  ░████████   ░███████  ░████████  
░██        ░██    ░██ ░██    ░██ ░██    ░██ 
 ░███████  ░██    ░██ ░██    ░██ ░██    ░██ 
       ░██ ░██    ░██ ░██    ░██ ░███   ░██ 
 ░███████  ░██    ░██  ░███████  ░██░█████  
                                 ░██        
                                 ░██        
");
                Console.WriteLine($"DINERO: {dinero_del_jugador}\n");
            Console.WriteLine("ARTICULOS DISPONIBLES");
            Console.WriteLine("====================================================");
            foreach (var articulo in articulos)
            {
                Console.WriteLine($"ITEM: {articulo.Key}\nPRICE: {articulo.Value} \n");
            }
            Console.WriteLine("====================================================");
            Console.WriteLine(@"                            
   ▄▄▄  ▄    ▄ ▄▄▄▄▄    ▄▄  
 ▄▀   ▀ █    █   █      ██  
 █   ▄▄ █    █   █     █  █ 
 █    █ █    █   █     █▄▄█ 
  ▀▄▄▄▀ ▀▄▄▄▄▀ ▄▄█▄▄  █    █
");

            Console.WriteLine(@"Teclado de oro (escribe teclado para comprar):
hace que ganes mas dinero cada vez que la pegas 

carta +2: (escribe carta para compra):
te da mas 2 en la racha si estas en racha de 8 y estas a dos de ganar puedes usarlo para ganar es medio cagon esto

probabilitor el improbable (escribe probabilitor para compra):
aumenta tus probabilidades que que salga cara

???(???):
??????????????????????????????????
");

            Console.WriteLine("Teclado:(escribe exit para salir)");
            respuesta = Console.ReadLine();
            Console.Write("");
            string[] palabras = {"exit","teclado","carta","probabilitor","???"};

            bool contiene = palabras.Any(p =>
                respuesta.Contains(p, StringComparison.OrdinalIgnoreCase)
            );

            if (!contiene)
            {
                utilidades.mensaesdeerror();
                Thread.Sleep(1500);
                continue;
            }
            if (respuesta.ToLower().Trim().Contains("exit") || respuesta.ToLower().Trim().Contains("salir"))
            {
                juego.setdinero(dinero_del_jugador);
                exit = true;
                continue;
            }
            compra(respuesta);
        }

    }

    void compra(string larepuesta)
    {
        var encontrar_precio = articulos.Where(x => x.Value == 50).FirstOrDefault();
        Console.WriteLine(encontrar_precio.Key);
        utilidades.mensajecontinue();
        if (larepuesta.ToLower().Contains("teclado") && dinero_del_jugador >= teclado_price)
        {
            while (true)
            {

            Console.Clear();
            Console.WriteLine("\nEstas seguro que quiers comprar este articulo? (si o no)\n\n");
            Console.WriteLine($"ITEM: Teclado de oro \n\nDESCRICION: aumenta la cantidad de dinero optenido cada vez que giras la moneda \n\nPrice:{teclado_price}\n\nDinero:{dinero_del_jugador}\n");
            string x = Console.ReadLine();
            if (x.ToLower().Trim().Contains("si"))
            {
            dinero_del_jugador -= teclado_price;
                juego.teclado_oro();
            teclado_price *= 2;
            articulos["Teclado de oro"] = teclado_price;
                Console.Clear();
            Console.WriteLine("compreate un este articulo exitosamente");
                utilidades.mensajecontinue();
                    break;
            } 
                else if (x.ToLower().Trim().Contains("no"))
                {
                    break;
                }
                else
                {
                    utilidades.mensaesdeerror();
                    Thread.Sleep(3500);
                    continue;

                }
            }

        }
        else if((dinero_del_jugador < teclado_price && respuesta.ToLower().Trim().Contains("teclado")) || dinero_del_jugador < carta_price && (respuesta.ToLower().Trim().Contains("carta")) || (dinero_del_jugador < porbabilitor_price && (respuesta.ToLower().Trim().Contains("teclado"))))
        {
            Console.Write("no te alcansa pa");
                                Thread.Sleep(2500);
        }

        else if (larepuesta.ToLower().Contains("probabilitor") && dinero_del_jugador >= porbabilitor_price)
        {
            while (true)
            {

            Console.Clear();
            Console.WriteLine("\nEstas seguro que quiers comprar este articulo? (si o no)\n\n");
            Console.WriteLine($"ITEM: Probabilitor el improbable \n\nDESCRICION: Aumenta la probabilidad de que salga cara lo que hace que sea mas facil \n\nPrice:{porbabilitor_price}\n\nDinero:{dinero_del_jugador}\n");
            string x = Console.ReadLine();
            if (x.ToLower().Trim().Contains("si"))
            {
                juego.probabilitor();
                dinero_del_jugador -= porbabilitor_price;
                porbabilitor_price *= 2;
                stock--;
                articulos["probabilitro el improbable"] = porbabilitor_price;
                Console.Clear();
                Console.WriteLine("compreate un este articulo exitosamente");
                utilidades.mensajecontinue();
                    break;

                } else if (x.ToLower().Trim().Contains("no"))
                {
                    break;
                }
                else
                {
                    utilidades.mensaesdeerror();
                    Thread.Sleep(3500);
                    continue;
                }
            }
        }
        else if (larepuesta.ToLower().Contains("carta") && dinero_del_jugador >= carta_price && articulos.ContainsKey("+2 carta_de_mas_2_del_UNO.png"))
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("\nEstas seguro que quiers comprar este articulo? (si o no)\n\n");
                Console.WriteLine($"ITEM: +2 \nDESCRICION: hace que se le sume +2 a tu contador de racha para activar este objeto escribe la palabra racha en el teclado del juego \n\nPrice:{carta_price}\n\nDinero:{dinero_del_jugador}\n");
                string x = Console.ReadLine();
                if (x.ToLower().Trim().Contains("si"))
                {
                    dinero_del_jugador -= carta_price;
                    articulos.Remove("+2 carta_de_mas_2_del_UNO.png");
                    juego.activar_carta();
                    Console.WriteLine("compreate un este articulo exitosamente");
                    utilidades.mensajecontinue();
                    break;
                }
                else if (x.ToLower().Trim().Contains("no"))
                {
                    break;
                }
                else
                {
                    utilidades.mensaesdeerror();
                    Thread.Sleep(3500);
                    continue;
                }
            }
        }else if(larepuesta.ToLower().Contains("carta") && !articulos.ContainsKey("+2 carta_de_mas_2_del_UNO.png"))
        {
            Console.WriteLine("sino esta es por algo");
            Thread.Sleep(2500);
        }
        else if(larepuesta.Trim().Contains("???"))
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Estas seguro que quiers comprar este articulo?(si o no) \n\n");
                Console.WriteLine($"ITEM: ??? \nDESCRICION: no sabes lo que es ni lo que hace pero cuesta todo tu dinero \n\nPrice:{secreto_pice}\n\nDinero:{dinero_del_jugador}\n\n");
                string x = Console.ReadLine();
                if (x.ToLower().Trim().Contains("si"))
                {
                    juego.finalsecreto();
                    break;
                }
                else if (x.ToLower().Trim().Contains("no"))
                {
                    break;
                }
                else
                {
                    utilidades.mensaesdeerror();
                    Thread.Sleep(3500);
                    continue;
                }
            }
        }
        else
        {
            utilidades.mensaesdeerror();
        }


    }

}