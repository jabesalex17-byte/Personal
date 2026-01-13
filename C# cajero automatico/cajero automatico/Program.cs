//tienes que poder logearte 
//que no se puedea modificar publicamente el monto de alguien 


using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class CajeroAutomatioc
{
    double monto = 0;
    public CajeroAutomatioc(double setmonto = 0)
    {
        monto = setmonto;
    }
    public void cajero()
    {
        
        bool whileexit = true;
        while (whileexit)
        {
            try
            {
                Console.WriteLine(@"======================================================
CAJERO AUTOMATIOCO
======================================================");
                Console.WriteLine("Que le gustaria hacer :\n 1)Ver su Monto\n 2)Depositar\n 3)Retirar\n 4)salir");
                int respuesta = Convert.ToInt32(Console.ReadLine());

                switch (respuesta)
                {
                    case 1:
                        ver_monto();
                        break;
                    case 2:
                        deposito();
                        break;

                    case 3:
                        retiro();
                        break;
                    case 4:
                        Console.WriteLine("que tenga un buen dia\n precione enter para salir");
                        Console.ReadKey();
                        whileexit = false;
                        //Environment.Exit(0);
                        //esto cierrra la aplicacion de golpe Environment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("porfavor ingrese un numero valido");
                            continue;
                        }
                }
                /*
                                Console.WriteLine("Desea hacer algo mas? (Si o No)");
                                string respuesta2 = Console.ReadLine();
                                if(respuesta2.ToLower() == "si")
                                {
                                        Console.WriteLine("perfecto");
                                        continue;
                                } 
                                    else if(respuesta2.ToLower() == "no")
                                {
                                    Console.WriteLine("pase un buen dia");
                                    break;
                                }
                */


            }
            catch
            {
                Console.Clear();
                Console.WriteLine("exploto");
                continue;
            }

        }


    }
 


    public void ver_monto()
        {


            Console.WriteLine($"Su monto actual es de {monto}");
            Console.WriteLine("presicona enter para continuar");
            Console.ReadKey();
        Console.Clear();

    }

        public void deposito()
        {

            Console.WriteLine("ingrese el monto que desea depositar");
            double deposito = Convert.ToDouble(Console.ReadLine());
            if (deposito < 100)
            {
                Console.WriteLine("no se puede depositar menos de 100 sea serio");
                //lo que se deberia hacer aqui es preguntarle si va a retirar mas o si queire volver al menu pero por temas practivos vamos a devolverlo directamente al menu
            }
            else
            {
                monto += deposito;
                Console.WriteLine($"Su deposito se aplico corectamente su nuevo balance es de {monto}");
                Console.WriteLine("presicona enter para continuar");
                Console.ReadKey();
            Console.Clear();

            }
        }

        public void retiro()
        {


            Console.WriteLine("ingrese la cantidad que desea retirar");
            double retiro = Convert.ToDouble(Console.ReadLine());

            if (retiro > monto)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"bueno mi loco no te alcansa  tu monto es de {monto}\n y te quedarias en {monto - retiro} \n te estarias metiendo en un lio de los prestamos \n te guataria retirar esa cantidad como quiera ? (si o no)");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower().Trim() == "si")
                        {
                            monto -= retiro;
                            Console.WriteLine($"Su retiro se aplico correctamente su nuevo balance es de {monto}");
                            break;
                        }
                        else if (respuesta.ToLower().Trim() == "no")
                        {
                            Console.WriteLine("buena decision");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("si o no porfavor");
                            continue;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("cero cosa rara");
                        continue;
                    }
                }
            }
            else
            {
                monto -= retiro;
                Console.WriteLine($"Su retiro se aplico correctamente su nuevo balance es de {monto}");

            }
            Console.WriteLine("presicona enter para continuar");
            Console.ReadKey();
        Console.Clear();
    }

}

class program
{
   static void Main()
    {
        CajeroAutomatioc cajero = new CajeroAutomatioc(44);
        cajero.cajero();
    }
}

//forma original de como lo habia hecho
// el error fue del video yo habia hacio que la apliacion sea el cajero pero resulta que lo que el quieria era crear una class para crear cajeros bruh
/*
//tienes que poder logearte 
//que no se puedea modificar publicamente el monto de alguien 


using System.Transactions;

class program
{
    static void Main()
    {
        Console.WriteLine("ingrese su nombre completo");
        string nombre = Console.ReadLine();
        Console.WriteLine("ingrese una contrasena");
        string constrasena = Console.ReadLine();
        usuario usuarioActual = new usuario(nombre, constrasena);

        Console.Clear(); // limpia la consola
        Console.WriteLine("Perfecto su nombre de usuario y contrasena se han guardado corectamente");
        Console.WriteLine("presicona enter para continuar");
        Console.ReadKey();
        bool whileexit = true;
        while (whileexit)
        {
//            Console.Clear()

            try
            {
                Console.WriteLine("Que le gustaria hacer ahora:\n 1)Ver su Monto\n 2)Depositar\n 3)Retirar\n 4)salir");
             int respuesta = Convert.ToInt32(Console.ReadLine());

                switch(respuesta)
                {
                    case 1:
                        usuarioActual.ver_monto();
                        break;
                    case 2:
                        usuarioActual.deposito();
                        break;

                    case 3:
                        usuarioActual.retiro();
                        break;
                    case 4:
                        Console.WriteLine("que tenga un buen dia");
                        whileexit = false;
                        //esto cierrra la aplicacion de gfolpeEnvironment.Exit(0);
                        break;
                    default:
                        {
                            Console.WriteLine("porfavor ingrese un numero valido");
                            continue;
                        }
                }

                Console.WriteLine("Desea hacer algo mas? (Si o No)");
                string respuesta2 = Console.ReadLine();
                if(respuesta2.ToLower() == "si")
                {
                        Console.WriteLine("perfecto");
                        continue;
                } 
                    else if(respuesta2.ToLower() == "no")
                {
                    Console.WriteLine("pase un buen dia");
                    break;
                }

        

            }
            catch
            {
    Console.WriteLine("exploto");
    continue;
}
        
        }
        
    }
}

public class usuario
{
    string nombre;
    string contrasena;
    double monto;

    public usuario(string setnombre, string setcontrasena, double setmonto = 0)
    {
        nombre = setnombre;
        contrasena = setcontrasena;
        monto = setmonto;
    }

    public void ver_monto()
    {
        Console.Clear();

        Console.WriteLine($"Su monto actual es de {monto}");
        Console.WriteLine("presicona enter para continuar");
        Console.ReadKey();

    }

    public void deposito()
    {
        Console.Clear();
        Console.WriteLine("ingrese el monto que desea depositar");
        double deposito = Convert.ToDouble(Console.ReadLine());
        if (deposito < 100)
        {
            Console.WriteLine("no se puede depositar menos de 100 sea serio");
            //lo que se deberia hacer aqui es preguntarle si va a retirar mas o si queire volver al menu pero por temas practivos vamos a devolverlo directamente al menu
        }
        else
        {
            monto += deposito;
            Console.WriteLine($"Su deposito se aplico corectamente su nuevo balance es de {monto}");
            Console.WriteLine("presicona enter para continuar");
            Console.ReadKey();

        }
    }

    public void retiro()
    {
        Console.Clear();

        Console.WriteLine("ingrese la cantidad que desea retirar");
        double retiro = Convert.ToDouble(Console.ReadLine());

        if (retiro > monto)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"bueno mi loco no te alcansa  tu monto es de {monto}\n y te quedarias en {monto - retiro}te guataria retirar esa cantidad como quiera ? (si o no)");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower().Trim() == "si")
                    {
                        monto -= retiro;
                        Console.WriteLine($"Su retiro se aplico correctamente su nuevo balance es de {monto}");
                        break;
                    }
                    else if (respuesta.ToLower().Trim() == "no")
                    {
                        Console.WriteLine("buena decision");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("si o no porfavor");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("cero cosa rara");
                    continue;
                }
            }
        }
        else
        {
            monto -= retiro;
            Console.WriteLine($"Su retiro se aplico correctamente su nuevo balance es de {monto}");

        }
        Console.WriteLine("presicona enter para continuar");
        Console.ReadKey();
    }
}

*/