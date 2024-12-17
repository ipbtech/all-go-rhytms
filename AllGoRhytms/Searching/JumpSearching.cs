namespace AllGoRhytms.Searching
{
    public class JumpSearching
    {

        [Theory]
        [InlineData(21, 5, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(18, 2, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(50, 10, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(5, 0, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(80, 13, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(1, -1, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        public void JumpSearchFirstIndex(int searchValue, int expectedInd, params int[] inputArray)
        {
            // Arrange
            int actualInd = -1;
            int size = (int)Math.Sqrt(inputArray.Length);

            // Act
            int start = 0;
            int end = size - 1;
            while (end < inputArray.Length)
            {
                if (inputArray[end] >= searchValue)
                    break;

                start = start + size;
                end = end + size;
            }

            if (end != inputArray.Length - 1)
            {
                for (int i = start; i <= end; i++)
                {
                    if (inputArray[i] == searchValue)
                    {
                        actualInd = i;
                        break;
                    }
                }
            }

            //Assert
            Assert.Equal(expectedInd, actualInd);
        }


        [Theory]
        [InlineData(21, 8, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(18, 3, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(50, 11, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(5, 0, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(80, 13, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(1, -1, new int[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        [InlineData(5, 4, new int[] { 5, 5, 5, 5, 5, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
        public void JumpSearchLastIndex(int searchValue, int expectedInd, params int[] inputArray)
        {
            // Arrange
            int actualInd = -1;
            int size = (int)Math.Sqrt(inputArray.Length);

            // Act
            int start = 0;
            int end = size - 1;
            while (end < inputArray.Length -1 && inputArray[end + 1] <= searchValue)
            {
                start = start + size;
                end = (end + size) > inputArray.Length - 1 ? inputArray.Length - 1 : end + size;
            }


            for (int i = end; i >= start; i--)
            {
                if (inputArray[i] == searchValue)
                {
                    actualInd = i;
                    break;
                }
            }

            //Assert
            Assert.Equal(expectedInd, actualInd);
        }
    }
}
