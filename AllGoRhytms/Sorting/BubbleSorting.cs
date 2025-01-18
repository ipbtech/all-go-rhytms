namespace AllGoRhytms.Sorting
{
    public class BubbleSorting
    {
        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55 })]
        public void BubbleSortEscending(params int[] array)
        {
            // Arrange
            var expected = array.OrderBy(x => x).ToArray();

            // Act
            for (int i = array.Length - 1; i >= 0; i--)
            {
                bool alreadySorted = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        alreadySorted = false;
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

                if (alreadySorted)
                    break;
            }

            // Assert
            Assert.Equal(expected, array);
        }


        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55 })]
        public void BubbleSortDescending(params int[] array)
        {
            // Arrange
            var expected = array.OrderByDescending(x => x).ToArray();

            // Act
            for (int i = array.Length - 1; i >= 0; i--)
            {
                bool alreadySorted = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        alreadySorted = false;
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

                if (alreadySorted)
                    break;
            }

            // Assert
            Assert.Equal(expected, array);
        }
    }
}
