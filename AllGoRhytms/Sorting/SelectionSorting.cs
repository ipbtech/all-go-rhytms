namespace AllGoRhytms.Sorting
{
    public class SelectionSorting
    {
        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55 })]
        public void SelectionSortEscending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderBy(x => x).ToArray();

            //Act
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int maxInd = i;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[maxInd])
                        maxInd = j;
                }

                if (maxInd != i)
                {
                    int buffer = array[maxInd];
                    array[maxInd] = array[i];
                    array[i] = buffer;
                }
            }

            //Assert
            Assert.Equal(expected, array);
        }


        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55 })]
        public void SelectionSortDescending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderByDescending(x => x).ToArray();

            //Act
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int minInd = i;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[minInd])
                        minInd = j;
                }

                if (minInd != i)
                {
                    int buffer = array[minInd];
                    array[minInd] = array[i];
                    array[i] = buffer;
                }
            }

            //Assert
            Assert.Equal(expected, array);
        }
    }
}
