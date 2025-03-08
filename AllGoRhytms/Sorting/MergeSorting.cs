namespace AllGoRhytms.Sorting
{
    public class MergeSorting
    {
        [Theory]
        [InlineData(new[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void MergeSortAscending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderBy(x => x).ToArray();

            //Act
            Sort(array, 0, array.Length - 1);

            //Assert
            Assert.Equal(expected, array);
        }

        private void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(array, left, middle);
                Sort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private void Merge(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }

            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
    }
}
