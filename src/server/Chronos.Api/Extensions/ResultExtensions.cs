using Chronos.Core.Results;

namespace Chronos.Web.Extensions;

public static class ResultExtensions
{
    public static IResult ToErrorResult(this Error error)
    {
        return error switch
        {
            NotFoundError => Results.NotFound(),
            _ => Results.BadRequest(error.Message)
        };
    }
}