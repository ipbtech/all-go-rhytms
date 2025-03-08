namespace AllGoRhytms.Searching;

public class BinarySearching
{

    [Theory]
    [InlineData(3, 0, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    [InlineData(179, 16, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    [InlineData(21, 5, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    [InlineData(58, 11, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    [InlineData(101, 14, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    [InlineData(5, 2, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    [InlineData(26, 7, new[] { 3, 4, 5, 7, 10, 21, 23, 26, 29, 31, 54, 58, 75, 80, 101, 156, 179 })]
    public void BinarySearch(int searchValue, int expectedInd, params int[] inputArray)
    {
        //Arrange
        int actualInd = -1;

        //Act
        int start = 0;
        int end = inputArray.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (inputArray[mid] < searchValue)
                start = mid + 1;
            else if (inputArray[mid] > searchValue)
                end = mid - 1;
            else
            {
                actualInd = mid;
                break;
            }
        }

        //Assert
        Assert.Equal(expectedInd, actualInd);
    }


    [Theory]
    [InlineData(21, 5, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(18, 2, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(50, 10, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(5, 0, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(80, 13, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    [InlineData(1, -1, new[] { 5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80 })]
    public void BinarySearchFirstIndex(int searchValue, int expectedInd, params int[] inputArray)
    {
        //Arrange
        int actualInd = -1;

        //Act
        int start = -1;
        int end = inputArray.Length - 1;
        while (end >= 0)
        {
            int mid = (start + end) / 2;
            if (inputArray[mid] < searchValue)
                start = mid + 1;
            else if (inputArray[mid] > searchValue)
                end = mid - 1;
            else
            {
                while (mid > 0 && inputArray[mid - 1] == searchValue)
                {
                    mid--;
                }
                  
                actualInd = mid;
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
    public void BinarySearchLastIndex(int searchValue, int expectedInd, params int[] inputArray)
    {
        //Arrange
        int actualInd = -1;

        //Act
        int start = 0;
        int end = inputArray.Length;
        while (start <= inputArray.Length - 1 && end >= 0)
        {
            int mid = (start + end) / 2;
            if (inputArray[mid] < searchValue)
                start = mid + 1;
            else if (inputArray[mid] > searchValue)
                end = mid - 1;
            else
            {
                while (mid < inputArray.Length - 1 && inputArray[mid + 1] == searchValue)
                {
                    mid++;
                }

                actualInd = mid;
                break;
            }
        }

        //Assert
        Assert.Equal(expectedInd, actualInd);
    }
}