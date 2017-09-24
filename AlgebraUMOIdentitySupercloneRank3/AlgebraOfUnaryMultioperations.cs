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
            moSet = new MultioperationUnary[512];
			AddNullaryMultioperations();
			Generate();
		}

        public override Multioperation Superposition(Multioperation f, Multioperation g)
        {
            return null;
        }

        public override void AddNullaryMultioperations()
		{
            _multioperationArity = 1;
            _multioperationRank = 3;
            Projections.Add(new MultioperationUnary(84));
            Empty = new MultioperationUnary(0);
            Full = new MultioperationUnary(511);

			generators[0] = Empty;
            generators[1] = Full;
            generators[2] = Projections[0];

            moSet[0] = generators[0];
            moSet[1] = generators[1];
            moSet[2] = generators[2];

            contain = new bool[1 << ((int)Math.Pow(Rank, Arity + 1))];
            contain[0] = true;
            contain[1] = true;
            contain[2] = true;
		}

        public override void Generate()
		{
            for (int i = 1; i < moSet.Length; i++)
			{
                Multioperation f = moSet[i];
				for (int j = 1; j < moSet.Length; j++)
				{
					Multioperation g = moSet[j];

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
