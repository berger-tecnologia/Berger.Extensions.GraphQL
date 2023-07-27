namespace Berger.Extensions.GraphQL
{
    public class GraphQLHandler : DelegatingHandler
    {
        public GraphQLHandler(HttpMessageHandler inner = null) : base(inner ?? new HttpClientHandler()) { }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelation)
        {
            var token = "";

            request.Headers.Add("Authorization", "Bearer " + token);
            //client.HttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            return await base.SendAsync(request, cancelation);
        }
    }
}