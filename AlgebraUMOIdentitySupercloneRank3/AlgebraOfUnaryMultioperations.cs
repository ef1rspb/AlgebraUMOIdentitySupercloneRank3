using System;
using System.Collections.Generic;

namespace AlgebraUMOIdentitySupercloneRank3
{
    public sealed class AlgebraOfUnaryMultioperations : AlgebraOfMultioperations
    {
        public AlgebraOfUnaryMultioperations()
        {
            generators = new MultioperationUnary[3];
            AddNullaryMultioperations();
        }

		public AlgebraOfUnaryMultioperations(List<Multioperation> generators)
        {
            
            this.generators = new MultioperationUnary[3 + generators.Count];
			AddNullaryMultioperations();
			Generate();
		}

        public override Multioperation Superposition(Multioperation f, Multioperation g)
        {
            return null;
        }

        public override void AddNullaryMultioperations()
		{
            this._multioperationArity = 1;
            Projections.Add(new MultioperationUnary(84));
            Empty = new MultioperationUnary(0);
            Full = new MultioperationUnary(511);

			generators[0] = Empty;
            generators[1] = Full;
            generators[2] = Projections[0];

            set[0] = generators[0];
            set[1] = generators[1];
            set[2] = generators[2];

            contain = new bool[1 << (Arity * Arity)];
            contain[0] = true;
            contain[1] = true;
            contain[2] = true;
		}

        public override void Generate()
		{
            for (int i = 1; i < set.Length; i++)
			{
                Multioperation f = set[i];
				for (int j = 1; j < set.Length; j++)
				{
					Multioperation g = set[j];

					if (f == Empty ||
						g == Empty)
						continue;

					Multioperation k = Superposition(f, g);
                    if (!contain[k.DecimalRepresentation])
					{
						//set.Add(k);
					}
				}
			}
		}

	}
}
