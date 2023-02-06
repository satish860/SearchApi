using System.Text.Json.Serialization;

namespace Api
{
    public class MoviesDto
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("title_suggest")]
        public string[] TitleSuggest { get; set; }

        [JsonPropertyName("genre")]
        public string[] Genre { get; set; }

        [JsonPropertyName("director")]
        public string Director { get; set; }

        [JsonPropertyName("Actors")]
        public string[] Actors { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("year")]
        public int year { get; set; }

        [JsonPropertyName("runtime")]
        public string Runtime { get; set; }

        [JsonPropertyName("rating")]
        public float Rating { get; set; }

        [JsonPropertyName("votes")]
        public int Votes { get; set; }

        [JsonPropertyName("revenue")]
        public string Revenue { get; set; }

        [JsonPropertyName("metascore")]
        public int MetaScore { get; set; }

        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    }
}
