using System;
using System.Collections.Generic;

namespace AlgebraUMOIdentitySupercloneRank3
{
    public abstract class AlgebraOfMultioperations : Superclone
    {
        public static Multioperation Empty;
        public static Multioperation Full;
        public static List<Multioperation> Projections = new List<Multioperation>();

        protected bool[] contain;
        protected int _multioperationArity;

        public int Arity => _multioperationArity;

        public AlgebraOfMultioperations() : base()
        {
            
        }

        public AlgebraOfMultioperations(List<Multioperation> generators)
        {
            
        }
    }
}
