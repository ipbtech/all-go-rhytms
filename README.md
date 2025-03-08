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
  - Merge (todo)
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
| BubbleSort    |   162.5 ns |  3.19 ns |  3.42 ns | 0.0668 |      - |     560 B |
| SelectionSort |   230.3 ns |  2.54 ns |  2.38 ns | 0.0668 |      - |     560 B |
| InsertionSort |   160.9 ns |  1.70 ns |  1.59 ns | 0.0668 |      - |     560 B |
| CountingSort  | 3,779.7 ns | 38.21 ns | 33.88 ns | 3.9825 | 0.4959 |   33488 B |
| RadixSort     | 1,109.9 ns |  8.64 ns |  6.75 ns | 0.3433 |      - |    2880 B |
| QuickSort     |   308.1 ns |  4.08 ns |  3.82 ns | 0.0668 |      - |     560 B |
