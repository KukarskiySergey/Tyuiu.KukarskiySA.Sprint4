using Tyuiu.KukarskiySA.Sprint4.Task7.V4.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ShouldReturnSumOfOddNumbers()
        {
            // Arrange
            string input = "382976421897";
            int expectedSum = 36;
            int n = 3;
            int m = 4;
            DataService dataService = new DataService();

            // Act
            int actualSum = dataService.Calculate(n, m, input);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}