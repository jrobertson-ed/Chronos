using Chronos.Core.Data.Queries;
using Chronos.Web.Extensions;
using MinimalApi.Endpoint;

namespace Chronos.Web.Endpoints.Client;

public class GetClientEndpoint(IClientQueries clientQueries) : IEndpoint<IResult, Guid>
{
    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapGet("api/client/{id}", HandleAsync);
    }
    
    public async Task<IResult> HandleAsync(Guid id)
    {
        return (await clientQueries.GetClientAsync(id))
            .Match(client => Results.Ok(GetClientResponse.FromClient(client)), 
                error => error.ToErrorResult());
    }
}

public class GetClientResponse
{
    public Guid Id { get; set; }

    public static GetClientResponse FromClient(Core.Entities.Client client)
    {
        return new GetClientResponse { Id = client.Id };
    }
}