using Tyuiu.KukarskiySA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.KukarskiySA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void Calculate_ShouldReplaceNegativeNumbersWithZero()
        {
            // Arrange
            int[,] inputMatrix = new int[,]
            {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, 8, -9 }
            };
            int[,] expectedMatrix = new int[,]
            {
                { 1, 0, 3 },
                { 0, 5, 0 },
                { 7, 8, 0 }
            };

            // Act
            int[,] result = _dataService.Calculate(inputMatrix);

            // Assert
            CollectionAssert.AreEqual(expectedMatrix, result);
        }

        [TestMethod]
        public void Calculate_ShouldReturnSameMatrixIfNoNegativeNumbers()
        {
            // Arrange
            int[,] inputMatrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] expectedMatrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Act
            int[,] result = _dataService.Calculate(inputMatrix);

            // Assert
            CollectionAssert.AreEqual(expectedMatrix, result);
        }

        [TestMethod]
        public void Calculate_ShouldHandleEmptyMatrix()
        {
            // Arrange
            int[,] inputMatrix = new int[,] { };
            int[,] expectedMatrix = new int[,] { };

            // Act
            int[,] result = _dataService.Calculate(inputMatrix);

            // Assert
            CollectionAssert.AreEqual(expectedMatrix, result);
        }

        [TestMethod]
        public void Calculate_ShouldHandleSingleElementMatrix()
        {
            // Arrange
            int[,] inputMatrixNegative = new int[,] { { -1 } };
            int[,] expectedMatrixNegative = new int[,] { { 0 } };

            int[,] inputMatrixPositive = new int[,] { { 5 } };
            int[,] expectedMatrixPositive = new int[,] { { 5 } };

            // Act
            int[,] resultNegative = _dataService.Calculate(inputMatrixNegative);
            int[,] resultPositive = _dataService.Calculate(inputMatrixPositive);

            // Assert
            CollectionAssert.AreEqual(expectedMatrixNegative, resultNegative);
            CollectionAssert.AreEqual(expectedMatrixPositive, resultPositive);
        }
    }
}