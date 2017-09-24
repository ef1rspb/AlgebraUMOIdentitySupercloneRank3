using System;
using System.Collections.Generic;

namespace AlgebraUMOIdentitySupercloneRank3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AlgebraOfUnaryMultioperations umo = new AlgebraOfUnaryMultioperations(
                new List<Multioperation> {
                new MultioperationUnary(10)
            });
            Console.WriteLine(umo);
        }
    }
}
