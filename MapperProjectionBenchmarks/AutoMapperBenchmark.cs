
using automapper_01;
using AutoMapper.QueryableExtensions;
using BenchmarkDotNet.Attributes;
using Mapster;
using Microsoft.EntityFrameworkCore;

[MemoryDiagnoser]
public class AutoMapperBenchmark
{
    static AutoMapperBenchmark()
    {
        MapsterConfigurator.Boostrap();
    }
    
    private readonly Database _db = new();

    private readonly AutoMapper.IConfigurationProvider _configurationProvider =
        new AutoMapper.MapperConfiguration(x => x.AddProfile(new MapperProfile())).CreateMapper().ConfigurationProvider;

    [Benchmark]
    public void AutoMapper()
    {
        _ = _db
            .Users
            .ProjectTo<UserDto>(_configurationProvider)
            .Take(200)
            .ToList();
    }
    
    [Benchmark]
    public void Mapster()
    {
        _ = _db
            .Users
            .ProjectToType<UserDto>()
            .Take(200)
            .ToList();
    }

    [Benchmark]
    public void ManualMapping()
    {
        var users = _db
            .Users
            .Include(x => x.PostsSummary)
            .Include(x => x.Address)
            .Take(200)
            .ToList();

        _ = users.Select(MapUser).ToList();
    }

    private static UserDto MapUser(User user) =>
        new()
        {
            Id = user.Id,
            Address = new AddressDto()
            {
                AddressWithPostCode = $"{user.Address.FirstLine} | {user.Address.PostCode}"
            },
            PostsSummary = new PostsSummaryDto()
            {
                TotalLikes = user.PostsSummary.TotalLikes,
                TotalCommentsReceived = user.PostsSummary.TotalCommentsReceived,
                TotalMinutesWatched = user.PostsSummary.TotalMinutesWatched,
                TotalViews = user.PostsSummary.TotalViews,
            }
        };


}
