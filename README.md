# GCPressure

A simple .NET benchmark comparing regular array allocation with `ArrayPool<T>` to demonstrate how to reduce garbage collector (GC) pressure.

## 🧪 Benchmarks

Using [BenchmarkDotNet](https://benchmarkdotnet.org/), this project shows how pooled memory can reduce allocations and improve performance in high-throughput scenarios.

## 🔧 Run it

```bash
dotnet run -c Release
