namespace AllGoRhytms.Sorting
{
    public class QuickSorting
    {

        [Theory]
        [InlineData(new[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void QuickSortAscending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderBy(x => x).ToArray();

            //Act
            QuickSort(array, 0, array.Length - 1);

            //Assert
            Assert.Equal(expected, array);
        }


        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        // Partition function
        private int Partition(int[] arr, int low, int high)
        {
            // Choose the pivot
            int pivot = arr[high];

            // Index of smaller element and indicates 
            // the right position of pivot found so far
            int i = low - 1;

            // Traverse arr[low..high] and move all smaller
            // elements to the left side. Elements from low to 
            // i are smaller after every iteration
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            // Move pivot after smaller elements and
            // return its position
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] arr, int i, int j) => (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}
