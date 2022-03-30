using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        //A simple test to assure ourselves 2 + 2 = 4
        public void Math_Add_Input2And2_AssertAnswer4()
        {
            //Arrange
            int x = 2;
            int y = 2;

            UnitTests.Math math = new UnitTests.Math();

            //Act
            int sum = math.Add(x, y);

            //Assert
            Assert.AreEqual(sum, 4);
        }

        [TestMethod]
        //Does our library properly add negative numbers to positive ones?
        public void Math_Add_InputNegative2And2_AssertAnswer0()
        {
            //Arrange
            int x = -2;
            int y = 2;

            UnitTests.Math math = new UnitTests.Math();

            //Act
            int sum = math.Add(x, y);

            //Assert
            Assert.AreEqual(sum, 0);
        }

        [TestMethod]
        //What about two negative numbers?
        public void Math_Add_InputNegative2AndNegative2_AssertAnswerNegative4()
        {
            //Arrange
            int x = -2;
            int y = -2;

            UnitTests.Math math = new UnitTests.Math();

            //Act
            int sum = math.Add(x, y);

            //Assert
            Assert.AreEqual(sum, -4);
        }
    }
}
