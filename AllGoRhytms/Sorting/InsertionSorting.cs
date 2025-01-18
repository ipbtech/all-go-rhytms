namespace AllGoRhytms.Sorting
{
    public class InsertionSorting
    {
        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void InsertionSortEscending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderBy(x => x).ToArray();

            //Act
            for (int i = 1; i < array.Length; i++)
            {
                int bufferEl = array[i];
                int bufferInd = i;
                while (bufferInd > 0 && array[bufferInd - 1] > bufferEl)
                {
                    array[bufferInd] = array[bufferInd - 1];
                    bufferInd--;
                }
                array[bufferInd] = bufferEl;
            }

            //Assert
            Assert.Equal(expected, array);
        }


        [Theory]
        [InlineData(new int[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void InsertionSortDescending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderByDescending(x => x).ToArray();

            //Act
            for (int i = 1; i < array.Length; i++)
            {
                int bufferEl = array[i];
                int bufferInd = i;
                while (bufferInd > 0 && array[bufferInd - 1] < bufferEl)
                {
                    array[bufferInd] = array[bufferInd - 1];
                    bufferInd--;
                }
                array[bufferInd] = bufferEl;
            }

            //Assert
            Assert.Equal(expected, array);
        }
    }
}
