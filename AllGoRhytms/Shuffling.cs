namespace AllGoRhytms
{
    public class Shuffling
    {
        [Fact]
        public void ShuffleByFisherYates()
        {
            // Arrange
            var array = GenerateOrderedArray(10000);
            var orderedBuffer = (int[])array.Clone();
            var rand = new Random();

            // Act
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int randInd = rand.Next(i);

                int buffer = array[randInd];
                array[randInd] = array[i];
                array[i] = buffer;
            }

            // Assert
            Assert.NotEqual(array, orderedBuffer);
        }


        [Fact]
        public void ShuffleByOrderedRandom()
        {
            // Arrange
            var array = GenerateOrderedArray(10000);
            var orderedBuffer = (int[])array.Clone();
            var rand = new Random();

            // Act
            array = array.OrderBy(x => rand.Next()).ToArray();

            // Assert
            Assert.NotEqual(array, orderedBuffer);
        }


        [Fact]
        public void ShuffleByOrderedGuid()
        {
            // Arrange
            var array = GenerateOrderedArray(10000);
            var orderedBuffer = (int[])array.Clone();

            // Act
            array = array.OrderBy(x => Guid.NewGuid()).ToArray();

            // Assert
            Assert.NotEqual(array, orderedBuffer);
        }


        [Fact]
        public void ShuffleByInboxImplementation()
        {
            // Arrange
            var array = GenerateOrderedArray(10000);
            var orderedBuffer = (int[])array.Clone();
            var rand = new Random();

            // Act
            rand.Shuffle(array);

            // Assert
            Assert.NotEqual(array, orderedBuffer);
        }



        private int[] GenerateOrderedArray(int n) => Enumerable.Range(1, n).ToArray();
    }
}
