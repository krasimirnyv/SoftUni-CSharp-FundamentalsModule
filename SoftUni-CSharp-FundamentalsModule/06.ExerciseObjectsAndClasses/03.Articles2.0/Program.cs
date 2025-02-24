namespace _03.Articles2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                articles.Add(new Article(input[0], input[1], input[2]));
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}".ToString();
        }
    }
}
