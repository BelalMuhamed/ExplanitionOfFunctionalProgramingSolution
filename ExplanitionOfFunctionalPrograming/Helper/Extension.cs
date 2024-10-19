using ExplanitionOfFunctionalPrograming.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExplanitionOfFunctionalPrograming.Helper
{
    public static class Extension
    {
        #region FilterationMethod
        public static IEnumerable<T> Filter<T>( this IEnumerable<T> Source, Func<T, bool> FilterDelegate)
        {
            foreach (var item in Source)
            {
                if(FilterDelegate(item))
                {
                    yield return item;

                }
            }
        }
        #endregion

        #region PrintMethod
        public  static void  Print<T>(this IEnumerable<T> Source,string title)
        {
            if (Source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in Source)
                Console.WriteLine(item);
        }
        #endregion
    }
}
