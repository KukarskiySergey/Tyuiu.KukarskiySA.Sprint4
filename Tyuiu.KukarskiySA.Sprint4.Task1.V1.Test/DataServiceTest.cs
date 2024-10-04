using Tyuiu.KukarskiySA.Sprint4.Task1.V1.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            // Arrange
            int[] array = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 }; // Массив чисел, введенных с клавиатуры
            DataService dataService = new DataService();
            int expectedSum = 14; // Сумма четных элементов 8 + 2 + 0 + 4 = 14

            // Act
            int actualSum = dataService.Calculate(array);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}