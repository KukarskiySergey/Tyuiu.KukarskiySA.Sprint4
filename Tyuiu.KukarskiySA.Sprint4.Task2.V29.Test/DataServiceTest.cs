using Tyuiu.KukarskiySA.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3 }; // Пример массива
            DataService dataService = new DataService();
            int expectedProduct = 2 * 4 * 6 * 8 * 2; // Произведение четных чисел

            // Act
            int actualProduct = dataService.Calculate(array);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}