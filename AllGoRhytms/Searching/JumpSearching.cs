namespace AllGoRhytms.Searching
{
    public class JumpSearching
    {

        [Theory]
        [InlineData(21, 5, new int[] { 5, 16, 18, 19, 20, 21, 22, 30, 40, 45, 50, 60, 75, 80 })]
        [InlineData(5, 0, new int[] { 5, 16, 18, 19, 20, 21, 22, 30, 40, 45, 50, 60, 75, 80 })]
        [InlineData(80, 13, new int[] { 5, 16, 18, 19, 20, 21, 22, 30, 40, 45, 50, 60, 75, 80 })]
        [InlineData(63, -1, new int[] { 5, 16, 18, 19, 20, 21, 22, 30, 40, 45, 50, 60, 75, 80 })]
        public void JumpsSearch(int searchValue, int expectedInd, params int[] inputArray)
        {
            // Arrange
            int actualInd = -1;
            int size = (int)Math.Sqrt(inputArray.Length);

            // Act
            int start = 0;
            int end = start + size;
            while (end < inputArray.Length)
            {
                if (inputArray[end] >= searchValue)
                    break;

                start = start + size;
                end = end + size;
            }

            if (end != inputArray.Length - 1)
            {
                for (int i = start; i < end; i++)
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
    }
}
