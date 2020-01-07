
namespace homeWorkLesson11_6
{
    class Store
    {
        private Article[] articles;

        public Article this[int articleIndex]
        {
            get
            {
                if (articles != null && articleIndex < articles.Length)
                {
                    return articles[articleIndex];
                }

                return null;
            }
        }

        public Article this[string articleName]
        {
            get
            {
                if (articles != null)
                {
                    foreach (var article in articles)
                    {
                        if (article.Name == articleName)
                        {
                            return article;
                        }
                    }
                }

                return null;
            }
        }

        public Store(params Article[] articles)
        {
            this.articles = articles;
        }
    }
}
