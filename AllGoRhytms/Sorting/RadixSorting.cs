namespace AllGoRhytms.Sorting
{
    public class RadixSorting
    {
        [Theory]
        [InlineData(new[] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void RadixSortAscending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderBy(x => x).ToArray();

            int maxNumLenght = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxNumLenght = array[i].ToString().Length;
                }
            }


            //Act
            int[] negatives = array.Where(x => x < 0).Select(x => Math.Abs(x)).ToArray();
            _ = Sort(negatives, maxNumLenght);

            int[] positives = array.Where(x => x >= 0).ToArray();
            int[] positivesSorted = Sort(positives, maxNumLenght);

            var reversed = negatives.Reverse().Select(x => 0 - x);
            var actual = reversed.Concat(positivesSorted).ToArray();

            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(new [] { 16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88 })]
        public void RadixSortDescending(params int[] array)
        {
            //Arrange
            int[] expected = array.OrderByDescending(x => x).ToArray();

            int maxNumLenght = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxNumLenght = array[i].ToString().Length;
                }
            }


            //Act
            int[] negatives = array.Where(x => x < 0).Select(x => Math.Abs(x)).ToArray();
            _ = Sort(negatives, maxNumLenght, false);
            var negativesReversed = negatives.Reverse().Select(x => 0 - x);

            int[] positives = array.Where(x => x >= 0).ToArray();
            int[] positivesSorted = Sort(positives, maxNumLenght, false);

            var actual = positivesSorted.Concat(negativesReversed).ToArray();

            //Assert
            Assert.Equal(expected, actual);
        }


        private int[] Sort(int[] array, int maxNumLenght, bool esc = true)
        {
            int pow = 1;
            int digitCounts = 10;
            List<int>[] pocket = new List<int>[digitCounts];
            for (int i = 0; i < pocket.Length; i++)
                pocket[i] = new List<int>();

            for (int i = 0; i < maxNumLenght; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int value = array[j] / pow % 10;
                    pocket[value].Add(array[j]);
                }

                int arrayPointer = 0;
                if (esc)
                {
                    for (int j = 0; j < pocket.Length; j++)
                    {
                        for (int k = 0; k < pocket[j].Count; k++)
                        {
                            array[arrayPointer] = pocket[j][k];
                            arrayPointer++;
                        }
                        pocket[j].Clear();
                    }
                }
                else
                {
                    for (int j = pocket.Length - 1; j >= 0; j--)
                    {
                        for (int k = 0; k < pocket[j].Count; k++)
                        {
                            array[arrayPointer] = pocket[j][k];
                            arrayPointer++;
                        }
                        pocket[j].Clear();
                    }
                }
                pow *= 10;
            }
            return array;
        }
    }
}
