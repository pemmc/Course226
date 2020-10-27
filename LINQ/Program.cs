using System;
using System.Collections.Generic;

using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Criar um data source(coleção, array, recurso de E/ S, etc.)
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //2. Definir a query / consulta ... expressão de consulta
            // O LINK É COMPOSTO POR VÁRIOS EXTENSION MÉTODOS
            // MEU PREDICADO
            // este result e IEnumerable, contempla todos, mais que a LIST ou simplesmente usar VAR
            IEnumerable<int> result = numbers
                            .Where( x => x%2 == 0 )
                            .Select( x => x * 10);

            //3. Executar a query(foreach ou alguma operação terminal)
            foreach(int x in result)
            {
                Console.WriteLine(x);

            }
        }
    }
}
