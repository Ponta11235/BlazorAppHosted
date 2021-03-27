namespace BlazorAppHosted.Shared.Models
{
    public class Book
    {
        public long Id {get; set;}
        public string Name {get; set;}
        public string Author {get; set;}
        public int Price {get; set;}
        public bool? Available {get; set;}
    }
}