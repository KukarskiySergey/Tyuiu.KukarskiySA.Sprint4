using Tyuiu.KukarskiySA.Sprint4.Task3.V28.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            // Arrange
            int[,] array = {
                {5, 4, 9, 8, 5},
                {4, 6, 6, 9, 9},
                {9, 8, 4, 8, 8},
                {6, 8, 6, 8, 9},
                {9, 4, 6, 6, 7}
            };
            DataService dataService = new DataService();
            int expectedMin = 6; // Минимальный элемент в 4-м столбце

            // Act
            int actualMin = dataService.Calculate(array);

            // Assert
            Assert.AreEqual(expectedMin, actualMin);
        }
    }
}