using System;
namespace AlgebraUMOIdentitySupercloneRank3
{
    public abstract class Multioperation
    {
        private int _decimalRepresentation;
        protected int _arity;
        protected int _rank;

        public int Arity => _arity;
        public int Rank => _rank;
        public int DecimalRepresentation => _decimalRepresentation;

        protected int[] vectorForm;

        public Multioperation()
        {
            _arity = int.MaxValue;
            _rank = int.MaxValue;
        }

        public Multioperation(int[] vectorForm)
        {
            this.vectorForm = (int[])vectorForm.Clone();
        }

        public override string ToString()
        {
            string info = "Multioperation: (";
            foreach(int i in vectorForm)
            {
                info += i.ToString() + ",";
            }
            info.Remove(info.Length - 1);
            info += ")";
            return info;
        }
    }
}
