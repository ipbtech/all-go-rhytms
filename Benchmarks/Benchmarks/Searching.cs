using AllGoRhytms.Searching;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class Searching
    {
        private readonly JumpSearching _jumpSearching = new();
        private readonly BinarySearching _binarySearching = new();
        private readonly LinearSearching _linearSearching = new();

        private readonly int[] _inputArray = 
            [5, 16, 18, 18, 20, 21, 21, 21, 21, 45, 50, 50, 75, 80];

        [Benchmark]
        public void LinearSearchFirstIndex() => _linearSearching.LinearSearchFirstIndex(21, 5, _inputArray);

        [Benchmark]
        public void JumpSearchFirstIndex() => _jumpSearching.JumpSearchFirstIndex(21, 5, _inputArray);

        [Benchmark]
        public void BinarySearchFirstIndex() => _binarySearching.BinarySearchFirstIndex(21, 5, _inputArray);
    }
}
