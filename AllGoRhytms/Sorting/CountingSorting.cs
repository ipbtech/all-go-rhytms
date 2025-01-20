namespace AllGoRhytms.Sorting
{
    public class CountingSorting
    {
        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void CountingSortEscending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderBy(x => x).ToArray();

            //Act
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }

            bool flag = min <= 0;
            int[] countsBuffer = new int[max - min + 1];
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (flag)
                    countsBuffer[value + Math.Abs(min)] = countsBuffer[value + Math.Abs(min)] + 1;
                else
                    countsBuffer[value - Math.Abs(min)] = countsBuffer[value - Math.Abs(min)] + 1;
            }

            int[] actual = new int[array.Length];
            int counter = 0;
            for (int i = 0; i < countsBuffer.Length; i++)
            {
                for (int j = 0; j < countsBuffer[i]; j++)
                {
                    actual[counter] = i + min;
                    counter++;
                }
            }

            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void CountingSortDescending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderByDescending(x => x).ToArray();

            //Act
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }

            bool flag = min <= 0;
            int[] countsBuffer = new int[max - min + 1];
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (flag)
                    countsBuffer[value + Math.Abs(min)] = countsBuffer[value + Math.Abs(min)] + 1;
                else
                    countsBuffer[value - Math.Abs(min)] = countsBuffer[value - Math.Abs(min)] + 1;
            }

            int[] actual = new int[array.Length];
            int counter = 0;
            for (int i = countsBuffer.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < countsBuffer[i]; j++)
                {
                    actual[counter] = i + min;
                    counter++;
                }
            }

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
