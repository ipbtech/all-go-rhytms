using BenchmarkDotNet.Attributes;

namespace Benchmarks
{
    [MemoryDiagnoser]
    public class Shuffling
    {
        private AllGoRhytms.Shuffling _shuffling = new AllGoRhytms.Shuffling();

        [Benchmark]
        public void ShuffleByInboxImplementation() => _shuffling.ShuffleByInboxImplementation();

        [Benchmark]
        public void ShuffleByFisherYates() => _shuffling.ShuffleByFisherYates();

        [Benchmark]
        public void ShuffleByOrderedRandom() => _shuffling.ShuffleByOrderedRandom();

        [Benchmark]
        public void ShuffleByOrderedGuid() => _shuffling.ShuffleByOrderedGuid();
    }
}
