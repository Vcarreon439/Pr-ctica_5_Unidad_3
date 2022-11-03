using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5_Unidad_3
{
    public class Fibonacci
    {
        static public int CalcularRercursivo(int iteraciones) 
        {
            if (iteraciones < 2)
                return iteraciones;

            return CalcularRercursivo(iteraciones-1)+ CalcularRercursivo(iteraciones-2);
        }

        static public int CalcularCicloFor(int posicion, ref Stack<int> resultados)
        {
            int siguiente = 1, actual = 0, temporal = 0;

            resultados.Push(actual);
            resultados.Push(siguiente);

            for (int i = 1; i < posicion; i++)
            {
                temporal = actual;
                actual = siguiente;
                siguiente += temporal;
                resultados.Push(siguiente);
            }

            return actual;
        }


        static public int CalculaCicloWhile(int posicion)
        {
            int siguiente = 1, temporal = 0, actual = 0, i = 0;
            while (i < posicion)
                temporal = actual;
                actual = siguiente;
                siguiente += temporal;
            return actual;
        }

    }
}
