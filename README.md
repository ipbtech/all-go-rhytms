# all-go-rhytms
Analysis of the popular algorithms with tests (xUnit) and benchmarks (BenchmarkDotNet) for fun.
## Impements algorithms and a little bit of benchmarks:
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
  - Shuffling (todo)

## A little bit of benchmarks
### Searching
| Method                 | Mean     | Error   | StdDev   | Gen0   | Allocated |
|----------------------- |---------:|--------:|---------:|-------:|----------:|
| LinearSearchFirstIndex | 159.1 ns | 3.25 ns |  9.47 ns | 0.0305 |     256 B |
| JumpSearchFirstIndex   | 146.1 ns | 3.76 ns | 11.09 ns | 0.0305 |     256 B |
| BinarySearchFirstIndex | 140.9 ns | 2.98 ns |  8.79 ns | 0.0305 |     256 B |
