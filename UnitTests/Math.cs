using System;

namespace UnitTests
{
    public interface IMath
    {
        int Add(int x, int y);
    }

    public class Math : IMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
