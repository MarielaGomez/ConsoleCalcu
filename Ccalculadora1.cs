using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalcu
{
    class Ccalculadora1
    {
        // esta clase es definida por nosotros

        // declaramos los atributos(siempre privado, por ahora publico)
        public double a;
        public double b;
        public double r;

        // declaramos los metodos
        public void Suma()
        {
            // se lleva acabo una accion
            r = a + b;

        }
        public void Muestra()
        {
            Console.WriteLine("a={0}, b= {2)}, r={2}", a, b, r);
        }
    }
    }
