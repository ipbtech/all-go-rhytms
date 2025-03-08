# all-go-rhytms
Analysis of the popular algorithms, test them by xUnit and provide benchmarks by BenchmarkDotNet
## Impements algorithms:
### Searching
  - Linear
  - Binary
  - Jumping
  - BFS/DFS (todo)
### Sorting
  - Bubble
  - Selection
  - Insertion
  - Counting
  - Radix
  - Quick
  - Merge
### Other
  - Shuffling

## A little bit of benchmarks
### Searching
| Method                 | Mean     | Error   | StdDev   | Gen0   | Allocated |
|----------------------- |---------:|--------:|---------:|-------:|----------:|
| LinearSearchFirstIndex | 159.1 ns | 3.25 ns |  9.47 ns | 0.0305 |     256 B |
| JumpSearchFirstIndex   | 146.1 ns | 3.76 ns | 11.09 ns | 0.0305 |     256 B |
| BinarySearchFirstIndex | 140.9 ns | 2.98 ns |  8.79 ns | 0.0305 |     256 B |

### Shuffling
| Method                       | Mean        | Error     | StdDev     | Gen0    | Gen1    | Gen2    | Allocated |
|----------------------------- |------------:|----------:|-----------:|--------:|--------:|--------:|----------:|
| ShuffleByInboxImplementation |    76.57 us |  3.143 us |   9.119 us |  9.5215 |  1.8311 |       - |  78.28 KB |
| ShuffleByFisherYates         |    61.00 us |  2.230 us |   6.505 us |  9.5215 |  1.8311 |       - |  78.28 KB |
| ShuffleByOrderedRandom       | 1,250.07 us | 24.638 us |  35.334 us | 27.3438 |  7.8125 |       - | 234.88 KB |
| ShuffleByOrderedGuid         | 2,684.33 us | 53.283 us | 103.925 us | 46.8750 | 46.8750 | 46.8750 | 351.93 KB |

### Sorting
| Method        | Mean       | Error    | StdDev   | Gen0   | Gen1   | Allocated |
|-------------- |-----------:|---------:|---------:|-------:|-------:|----------:|
| BubbleSort    |   164.1 ns |  2.29 ns |  2.15 ns | 0.0668 |      - |     560 B |
| SelectionSort |   238.6 ns |  3.11 ns |  2.91 ns | 0.0668 |      - |     560 B |
| InsertionSort |   161.9 ns |  1.95 ns |  1.73 ns | 0.0668 |      - |     560 B |
| CountingSort  | 4,685.4 ns | 35.79 ns | 31.73 ns | 3.9825 | 0.4959 |   33488 B |
| RadixSort     | 1,114.1 ns | 16.89 ns | 15.80 ns | 0.3433 |      - |    2880 B |
| QuickSort     |   320.5 ns |  3.28 ns |  3.06 ns | 0.0668 |      - |     560 B |
| MergeSort     |   421.9 ns |  2.78 ns |  2.60 ns | 0.2122 |      - |    1776 B |
