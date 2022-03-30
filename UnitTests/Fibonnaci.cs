using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class Fibonnaci
    {
        private IMath _math;

        private int _firstTerm = 0;
        private int _secondTerm = 1;

        public Fibonnaci(IMath math)
        {
            _math = math;
        }      

        public int GetNthTerm(int n)
        {
            if (n < 0)
                throw new Exception("Opps, that number is negative");

            if (n.Equals(0))
                return _firstTerm;

            if (n.Equals(1))
                return _secondTerm;

            int nMinusOneTerm = _secondTerm;
            int nMinusTwoTerm = _firstTerm;

            for(int i = 2; i <= n; i++)
            {
                int newTerm = _math.Add(nMinusOneTerm, nMinusTwoTerm);

                nMinusTwoTerm = nMinusOneTerm;
                nMinusOneTerm = newTerm;
            }

            return nMinusOneTerm;
        }
    }
}
