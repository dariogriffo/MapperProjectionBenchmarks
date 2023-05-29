using Mapster;

namespace automapper_01;

public static class MapsterConfigurator
{
    public static void Boostrap()
    {
        TypeAdapterConfig<User, UserDto>.NewConfig().PreserveReference(false);
        TypeAdapterConfig<PostsSummary, PostsSummaryDto>.NewConfig().PreserveReference(false);
        TypeAdapterConfig<Address, AddressDto>.NewConfig()
            .Map(x => x.AddressWithPostCode, src => $"{src.FirstLine} | {src.PostCode}").PreserveReference(false);
    }
}