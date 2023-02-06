using Typesense;

namespace Api.Movies.ListAll
{
    public class Response
    {
        public SearchResult<MoviesDto> MyProperty { get; set; }
    }
}
