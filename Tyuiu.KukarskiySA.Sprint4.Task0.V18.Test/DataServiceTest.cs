using Tyuiu.KukarskiySA.Sprint4.Task0.V18.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrEl_Test()
        {
            // Arrange
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            DataService dataService = new DataService();
            int expectedSum = 41;

            // Act
            int actualSum = dataService.GetSumOddArrEl(array);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}