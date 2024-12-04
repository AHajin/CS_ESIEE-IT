// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using ex1;
using ex2;
using TP_LINQ;

List<Article> articles = new List<Article>()
{
    new Article("Pomme",1.25f,240,ArticleType.ALIMENTAIRE),
    new Article("Banane",1.72f,240,ArticleType.ALIMENTAIRE),
    new Article("Poire",1.34f,240,ArticleType.ALIMENTAIRE),
    new Article("Cerises",1.98f,240,ArticleType.ALIMENTAIRE),
    new Article("Savon", 3.2f, 30, ArticleType.DROGUERIE),
    new Article("T-shirt", 15.0f, 20, ArticleType.HABILLEMENT)
};

int totalStock = 0;

var articlesAlimentairesByDesc = articles.OrderByDescending(article => article.prix);


foreach (var article in articlesAlimentairesByDesc)
{
    Console.WriteLine(article.ToString());
    totalStock += article.quantite;
}

Console.WriteLine($"\nLe total est de : {totalStock}");

Console.WriteLine("\n\nEtape2.2");

List<Object> articlesNonType = new List<Object>()
{
    new Article("Pomme",1.25f,240,ArticleType.ALIMENTAIRE),
    new Article("Banane",1.72f,240,ArticleType.ALIMENTAIRE),
    new Article("Poire",1.34f,240,ArticleType.ALIMENTAIRE),
    new Article("Cerises",1.98f,240,ArticleType.ALIMENTAIRE),
    new Article("Savon", 3.2f, 30, ArticleType.DROGUERIE),
    new Article("T-shirt", 15.0f, 20, ArticleType.HABILLEMENT),
    ("aaa","eeaaeee","eaeiaooioiao","sgfjhubnfgjobnsgropbnbdjfovgbnkjn",25),
    ("gfskjghbn", 3222456,"kenf","wowhc",22.26f),
    ("bipboup","etremechant","cpasouf",2234,662.2622f),
};


var articlesByType = articles.OfType<Article>();

foreach (var article in articlesByType)
{
    Console.WriteLine(article);
}

Console.WriteLine("\n\nEtape2.3");

List<Article> articlesNonSimplifie = new List<Article>()
{
    new Article("Pomme",1.25f,240,ArticleType.ALIMENTAIRE),
    new Article("Banane",1.72f,240,ArticleType.ALIMENTAIRE),
    new Article("Poire",1.34f,240,ArticleType.ALIMENTAIRE),
    new Article("Cerises",1.98f,240,ArticleType.ALIMENTAIRE),
    new Article("Savon", 3.2f, 30, ArticleType.DROGUERIE),
    new Article("T-shirt", 15.0f, 20, ArticleType.HABILLEMENT)
};

var articlesSimplifies = articlesNonSimplifie.Select(article => new { article.nom, article.prix }).ToList();

foreach (var article in articlesSimplifies)
{
    Console.WriteLine($"{article}");
}

Console.WriteLine("\n\nEtape2.4");

Extension.AfficherTous(articlesNonSimplifie);

Func<Article, float> calculStock = article => article.prix * article.quantite;
float stockValue = articles.Sum(calculStock);

Console.WriteLine($"{stockValue}");

Console.WriteLine("\n\nEtape2.5");

const string fichier = "articles.json";
string cheminFichier = Path.GetFullPath(fichier);

string json = JsonSerializer.Serialize(articlesSimplifies);
File.WriteAllText(cheminFichier, json);
Console.WriteLine("JSON créé");
