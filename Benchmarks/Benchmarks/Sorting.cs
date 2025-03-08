using AllGoRhytms.Sorting;
using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class Sorting
    {
        private readonly BubbleSorting _bubbleSorting = new();
        private readonly SelectionSorting _selectionSorting = new();
        private readonly InsertionSorting _insertionSorting = new();
        private readonly CountingSorting _countingSorting = new();
        private readonly RadixSorting _radixSorting = new();
        private readonly QuickSorting _quickSorting = new();
        private readonly MergeSorting _mergeSorting = new();


        private readonly int[] _inputArray =
            [16, 5, 20, 10, 36, 88, 91, -200, 8000, 0, -3, -100, 80, 55, 16, 31, -3, 88];

        [Benchmark]
        public void BubbleSort() => _bubbleSorting.BubbleSortAscending(_inputArray);

        [Benchmark]
        public void SelectionSort() => _selectionSorting.SelectionSortAscending(_inputArray);

        [Benchmark]
        public void InsertionSort() => _insertionSorting.InsertionSortAscending(_inputArray);

        [Benchmark]
        public void CountingSort() => _countingSorting.CountingSortAscending(_inputArray);

        [Benchmark]
        public void RadixSort() => _radixSorting.RadixSortAscending(_inputArray);

        [Benchmark]
        public void QuickSort() => _quickSorting.QuickSortAscending(_inputArray);

        [Benchmark]
        public void MergeSort() => _mergeSorting.MergeSortAscending(_inputArray);
    }
}
