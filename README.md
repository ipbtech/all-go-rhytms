# all-go-rhytms
Analysis of the popular algorithms with tests (xUnit) and benchmarks (BenchmarkDotNet) for fun.
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
  - Quick (todo)
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
