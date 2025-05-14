```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.4.1 (24E263) [Darwin 24.4.0]
Apple M3 Pro, 1 CPU, 12 logical and 12 physical cores
.NET SDK 8.0.201
  [Host]     : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.2 (8.0.224.6711), Arm64 RyuJIT AdvSIMD


```
| Method           | Mean      | Error     | StdDev    | Gen0   | Allocated |
|----------------- |----------:|----------:|----------:|-------:|----------:|
| AllocateNewArray | 22.542 ns | 0.4471 ns | 0.4592 ns | 0.1253 |    1048 B |
| UseArrayPool     |  7.262 ns | 0.0235 ns | 0.0220 ns |      - |         - |
