using GraphQL;

namespace Berger.Extensions.GraphQL
{
    public class BaseGraphQLError
    {
        public List<GraphQLError> Errors { get; set; }
    }
}