using System.Text.Json.Serialization;

namespace Sharetrade.Models
{
    public class Article
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("expertComment")]
        public string ExpertComment { get; set; }

        public Article() { }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;

            if (ReferenceEquals(this, obj)) return true;

            if (obj.GetType() != this.GetType()) return false;

            var that = obj as Article;

            if (Title != that.Title) return false;

            if (Description != that.Description) return false;

            if (ImageUrl != that.ImageUrl) return false;

            return ExpertComment == that.ExpertComment;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Title != null ? Title.GetHashCode() : 0;
                hashCode = (hashCode * 375) ^ (Description != null ? Description.GetHashCode() : 0);
                hashCode = (hashCode * 375) ^ (ImageUrl != null ? ImageUrl.GetHashCode() : 0);
                hashCode = (hashCode * 375) ^ (ExpertComment != null ? ExpertComment.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
