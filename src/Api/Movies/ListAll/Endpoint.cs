using System.Net;
using System.Net.Http;
using Typesense;

namespace Api.Movies.ListAll
{
    public class Endpoint :EndpointWithoutRequest<Response>
    {
        private readonly IHttpClientFactory httpClientFactory;

        public Endpoint(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public override void Configure()
        {
            Get("api/movies/all");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var client = this.httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("X-TYPESENSE-API-KEY", "Hu52dwsas2AdxdE");
            var responseMessage = await client.GetAsync("http://localhost:8108/collections/movies/documents/search?q=*");

            var searchResult = await responseMessage.Content.ReadFromJsonAsync<SearchResult<MoviesDto>>();
            await SendAsync(new Response
            {
                MyProperty = searchResult
            },200,ct);
        }
    }
}
