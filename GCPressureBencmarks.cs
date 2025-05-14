using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Buffers;

namespace GCPressureDemo;

[MemoryDiagnoser]
public class GCPressureBenchmarks
{
    private const int BufferSize = 1024;

    [Benchmark]
    public void AllocateNewArray()
    {
        var buffer = new byte[BufferSize];
        buffer[0] = 1;
    }

    [Benchmark]
    public void UseArrayPool()
    {
        var pool = ArrayPool<byte>.Shared;
        var buffer = pool.Rent(BufferSize);

        buffer[0] = 1;

        pool.Return(buffer);
    }
}
