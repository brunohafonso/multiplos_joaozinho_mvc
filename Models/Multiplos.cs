using System;
using System.Collections.Generic;
using System.Linq;

namespace multiplos_mvc.Models
{
    public class Multiplos
    {   
        public List<string> Numeros { get; set; }
        public static string verificarMultiplos(int num) 
        {
            if(num % 3 == 0 && num % 5 == 0)
            {
                return "FIZZBUZZ";
            } 
            else if(num % 3 == 0) 
            {
                return "FIZZ";
            } 
            else if(num % 5 == 0) 
            {
                return "BUZZ";
            }
            else 
            {
                return Convert.ToString(num);
            }
        }
        public List<string> listarMultiplos()
        {
            Numeros = Enumerable.Range(1, 100).Select(x => verificarMultiplos(x)).ToList();

            return Numeros;
        }
    }
}