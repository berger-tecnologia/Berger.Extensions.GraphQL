using Berger.Extensions.Abstractions;

namespace Berger.Extensions.GraphQL
{
    public class GraphQLHandler : DelegatingHandler
    {
        public GraphQLHandler(HttpMessageHandler inner = null) : base(inner ?? new HttpClientHandler()) { }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelation)
        {
            var token = "";

            request.Headers.Add(Standards.Authorization, Standards.Bearer + token);

            return await base.SendAsync(request, cancelation);
        }
    }
}