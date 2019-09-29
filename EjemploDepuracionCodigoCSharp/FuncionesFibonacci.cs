using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCSharp
{
    class FuncionesFibonacci : Funciones
    {

        public List<int> fibonacci()
        {
            int a = 0;
            int b = 1;
            int i = 0;
            int c = 0; 
           
            List<int> valores = new List<int>();
            while (i<= this.getNumero())
            {
                i++;
                c = a + b;
               valores.Add(a);
                a = b;
                b = c ;
                
            }
            return valores;
        }
    }
}    
            

    

