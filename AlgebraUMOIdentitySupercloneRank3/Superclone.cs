using System;
using System.Collections.Generic;

namespace AlgebraUMOIdentitySupercloneRank3
{
    public abstract class Superclone
    {
        protected int _multioperationRank;

        protected Multioperation[] generators;
        protected Multioperation[] set;

        public int Rank => _multioperationRank;

        public abstract void AddNullaryMultioperations();

        public abstract void Generate();

        public abstract Multioperation Superposition(Multioperation f, Multioperation g);

        public override string ToString()
        {
            string result = "Superclone: ";
            foreach (Multioperation m in set)
            {
                result += m.ToString() + ' ';
            }
            return result;
        }
    }
}
