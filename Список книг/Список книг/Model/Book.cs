namespace Список_книг.models
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _content;
        public string Title
        {
            get; set;
        }
        public string Author { get; set; }
        public string Content { get; set; }

        public Book()
        {
            Title = "Без названия";
            Author = "Народ";
            Content = "Живем бедно, но....";
        }
        public Book(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public override string ToString()
        {
            return $"Title: {Title}; Author: {Author};";
        }
    }
}