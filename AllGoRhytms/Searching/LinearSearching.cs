namespace AllGoRhytms.Searching;

public class LinearSearching
{
    [Theory]
    [InlineData(21, 5, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(18, 2, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(50, 10, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(5, 0, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(80, 13, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(1, -1, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    public void LinearSearchFirstIndex(int searchValue, int expectedInd, params int[] inputArray)
    {
        // Arrange
        int actualInd = -1;

        // Arrange
        for (int i = 0; i < inputArray.Length; i++)
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


    [Theory]
    [InlineData(21, 8, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(18, 3, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(50, 11, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(5, 0, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(80, 13, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(1, -1, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(5, 4, new[] { 5, 5, 5, 5, 5, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    public void LinearSearchLastIndex(int searchValue, int expectedInd, params int[] inputArray)
    {
        // Arrange
        int actualInd = -1;

        // Arrange
        for (int i = inputArray.Length - 1; i >= 0; i--)
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