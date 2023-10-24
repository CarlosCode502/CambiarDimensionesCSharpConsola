using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambiarDimensionesCSharpConsola
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public static void Main()
        {
            // Clear the screen, then save the top and left coordinates.
            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            // Draw the left side of a 5x5 rectangle, from top to bottom.
            WriteAt("+", 0, 0);
            WriteAt("|", 0, 1);
            WriteAt("|", 0, 2);
            WriteAt("|", 0, 3);
            WriteAt("+", 0, 4);

            // Draw the bottom side, from left to right.
            WriteAt("-", 1, 4); // shortcut: WriteAt("---", 1, 4)
            WriteAt("-", 2, 4); // ...
            WriteAt("-", 3, 4); // ...
            WriteAt("+", 4, 4);

            // Draw the right side, from bottom to top.
            WriteAt("|", 4, 3);
            WriteAt("|", 4, 2);
            WriteAt("|", 4, 1);
            WriteAt("+", 4, 0);

            // Draw the top side, from right to left.
            WriteAt("-", 3, 0); // shortcut: WriteAt("---", 1, 0)
            WriteAt("-", 2, 0); // ...
            WriteAt("-", 1, 0); // ...
                                //
            WriteAt("All done!", 0, 6);
            Console.ReadKey();
        }

        /*
        This example produces the following results:

        +---+
        |   |
        |   |
        |   |
        +---+

        All done!

        */



        //#region Variables
        ///// <summary>
        ///// Contiene la altura original y la nueva
        ///// </summary>
        //private static int origWidth, width;
        ///// <summary>
        ///// Contiene el alto original y el nuevo
        ///// </summary>
        //private static int origHeight, height;

        ///// <summary>
        ///// Mensaje que se muestra con el ancho y alto original.
        ///// </summary>
        //private static string m1 = "El ancho de la ventana actual es {0} y el " + "la altura actual de la ventana es {1}.";
        ///// <summary>
        ///// Mensaje que se muestra con el ancho y alto nuevo
        ///// </summary>
        //private static string m2 = "El ancho de la nueva ventana es {0} y el nuevo " + "la altura de la ventana es {1}.";
        ///// <summary>
        ///// Presione alguna tecla para continuar con la siguiente instrucción
        ///// </summary>
        //private static string m4 = "  (Press any key to continue...)";
        //#endregion

        ///// <summary>
        ///// Contiene las dimensiones de la ventana.
        ///// </summary>
        ///// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    //Paso 1: obtenga las dimensiones de la ventana actual.
        //    origWidth = Console.WindowWidth; //Ancho
        //    origHeight = Console.WindowHeight; //Alto
        //    //Imprimir msj 1 y dimensiones.
        //    Console.WriteLine(m1, Console.WindowWidth,
        //                          Console.WindowHeight);
        //    Console.WriteLine(m4); //msj presione alguna tecla
        //    Console.ReadKey(true); //la ventana continua abierta con true

        //    //Paso 2: corta la ventana a 1/4 de su tamaño original.
        //    width = origWidth / 2;
        //    height = origHeight / 2;
        //    Console.SetWindowSize(width, height);
        //    Console.WriteLine(m2, Console.WindowWidth,
        //                          Console.WindowHeight);
        //    Console.WriteLine(m4);
        //    Console.ReadKey(true);

        //    //Paso 3: restaure la ventana a su tamaño original.
        //    Console.SetWindowSize(origWidth, origHeight);
        //    Console.WriteLine(m1, Console.WindowWidth,
        //                          Console.WindowHeight);


        //    //mostrar la ventana pequeña al iniciar
        //    //Paso 1: obtenga las dimensiones de la ventana actual.
        //    origWidth = Console.WindowWidth; //Ancho
        //    origHeight = Console.WindowHeight; //Alto

        //    //Paso 2: corta la ventana a 1/4 de su tamaño original.
        //    width = origWidth / 2;
        //    height = origHeight / 2;
        //    Console.SetWindowSize(width, height);
        //    Console.WriteLine(m2, Console.WindowWidth,
        //                          Console.WindowHeight);
        //    Console.WriteLine(m4);
        //    Console.ReadKey();
        //}
    }
}

