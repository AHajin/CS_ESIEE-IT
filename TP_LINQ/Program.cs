// See https://aka.ms/new-console-template for more information

using ex1;
using ex2;

List<Article> articles = new List<Article>()
{
    new Article("Pomme",1.25f,240,ArticleType.ALIMENTAIRE),
    new Article("Banane",1.72f,240,ArticleType.ALIMENTAIRE),
    new Article("Poire",1.34f,240,ArticleType.ALIMENTAIRE),
    new Article("Cerises",1.98f,240,ArticleType.ALIMENTAIRE),
    new Article("Savon", 3.2f, 30, ArticleType.DROGUERIE),
    new Article("T-shirt", 15.0f, 20, ArticleType.HABILLEMENT)
};

var totalArticles = 0f;

var articlesAlimentairesByDesc = articles.OrderByDescending(article => article.prix )
    .ToList();


foreach (var article in articlesAlimentairesByDesc)
{
    Console.WriteLine(article.ToString());
    totalArticles += article.quantite;
}

Console.WriteLine($"\n\nLe total est de : {totalArticles}");
