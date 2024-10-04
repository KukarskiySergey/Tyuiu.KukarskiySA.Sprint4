using Tyuiu.KukarskiySA.Sprint4.Task6.V19.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            // Arrange
            string[] array = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            DataService dataService = new DataService();
            int expectedCount = 4; // ќжидаемое количество строк с длиной больше 5

            // Act
            int actualCount = dataService.Calculate(array);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}