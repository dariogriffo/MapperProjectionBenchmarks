# Mapper Projection Benchmarks
The code for https://youtu.be/nCuKV4n5_28

This repository contains the code for the benchmarks for projections to PostgreSql with
- Automapper
- Mapster
- Manual

The results

![Results](https://github.com/dariogriffo/MapperProjectionBenchmarks/blob/main/results.png "Results")


## How to run:

```bash
docker run --name automapper-postgres -p 5432:5432 -e POSTGRES_PASSWORD=postgres -d postgres

pg_restore -d automapper dump.tar

dotnet run -c Release MapperProjectionBenchmarks/MapperProjectionBenchmarks.csproj`csharp
```
