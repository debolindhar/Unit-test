using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class FibonnaciTests
    {
        [TestMethod]
        //Check the first value we calculate
        public void Fibonnaci_GetNthTerm_Input2_AssertResult1()
        {
            //Arrange
            int n = 2;

            //setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);

            UnitTests.Fibonnaci fibonnaci = new UnitTests.Fibonnaci(mockMath.Object);


            //Act
            int result = fibonnaci.GetNthTerm(n);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        //Check the Fifth Term To Make the Test More Robust
        public void Fibonnaci_GetNthTerm_Input4_AssertResult3()
        {
            //Arrange
            int n = 4;

            //setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);

            UnitTests.Fibonnaci fibonnaci = new UnitTests.Fibonnaci(mockMath.Object);


            //Act
            int result = fibonnaci.GetNthTerm(n);

            //Assert
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        //Test To Make Sure Add is Only Called Once on the Third Term
        public void Fibonnaci_GetNthTerm_Input2_AssertAddCalledOnce()
        {
            //Arrange
            int n = 2;

            //setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);

            UnitTests.Fibonnaci fibonnaci = new UnitTests.Fibonnaci(mockMath.Object);


            //Act
            int result = fibonnaci.GetNthTerm(n);

            //Assert
            mockMath.Verify(r => r.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        [TestMethod]
        //Test To Verify Add Called Three times on the fifth Term
        public void Fibonnaci_GetNthTerm_Input4_AssertAddCalledThreeTimes()
        {
            //Arrange
            int n = 4;

            //setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);

            UnitTests.Fibonnaci fibonnaci = new UnitTests.Fibonnaci(mockMath.Object);

            //Act
            int result = fibonnaci.GetNthTerm(n);

            //Assert
            mockMath.Verify(r => r.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(3));
        }

        [TestMethod]
        //Test To Verify Add Never Called on the First Term
        public void Fibonnaci_GetNthTerm_Input0_AssertAddNeverCalled()
        {
            //Arrange
            int n = 0;

            //setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);

            UnitTests.Fibonnaci fibonnaci = new UnitTests.Fibonnaci(mockMath.Object);

            //Act
            int result = fibonnaci.GetNthTerm(n);

            //Assert
            mockMath.Verify(r => r.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        //Test To Verify Add Never Called on the First Term
        public void Fibonnaci_GetNthTerm_InputNegative_AssertExceptionThrown()
        {
            //Arrange
            int n = -2;

            //setup
            Mock<UnitTests.IMath> mockMath = new Mock<UnitTests.IMath>();
            mockMath
                .Setup(r => r.Add(It.IsAny<int>(), It.IsAny<int>()))
                .Returns((int x, int y) => x + y);

            UnitTests.Fibonnaci fibonnaci = new UnitTests.Fibonnaci(mockMath.Object);

            //Act and Assert
            Assert.ThrowsException<System.Exception>(() => fibonnaci.GetNthTerm(n));
        }
    }
}