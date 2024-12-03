// See https://aka.ms/new-console-template for more information

using ex1;
using ex2;
using Delegate = ex2.Delegate;

Console.WriteLine("Hello, World!");

List<Article> articles = new List<Article>();

articles.Add(new Poche("Eragon",21.99f,14,ArticleType.LOISIR,"2342232",478,"Poche"));
articles.Add(new Disque("Naheulbeuk",18.20f,25,ArticleType.LOISIR,"Johnson Records"));
articles.Add(new Video("Le c# pour les nuls : le guide", 24,99,ArticleType.LOISIR,25));

foreach (var article in articles)
{
    article.PublishDetails();
    if (article is IRentable rent)
    {
        Console.WriteLine(rent.calculateRent());
    }

    switch (article)
    {
        case Poche poche:
            poche.DiscountStrategy(0.25f);
            break;
        case Disque disque:
            disque.DiscountStrategy(0.50f);
            break;
        case Video video:
            video.DiscountStrategy(0.75f);
            break;
    }
}