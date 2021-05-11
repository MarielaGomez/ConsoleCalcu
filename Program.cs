using System;

namespace ConsoleCalcu
{
    class Program
    {
        static void Main(string[] args)
        {
            // creamos instancia
            Ccalculadora1 calcu1 = new Ccalculadora1();

            //accedemos a los atributos para colocar la informacion 
            calcu1.a = 5;
            calcu1.b = 3;

            // mostramos los datos
            calcu1.Muestra();

            //invocamos el metodo 
            calcu1.Suma();

            // mostramos nuevamente los datos
            calcu1.Muestra();

            //------
            Console.WriteLine("-------");

            // creamos otro objeto y asignamos valores
            Ccalculadora1 miCalcu = Ccalculadora1();
            miCalcu.a = 18;
            miCalcu.b = 53;
            miCalcu.Suma();

            // comprobamos que cada objeto tiene su propia informacion

            calcu1.Muestra();
            miCalcu.Muestra();




            
        }

        private static Ccalculadora1 Ccalculadora1()
        {
            throw new NotImplementedException();
        }
    }
}
