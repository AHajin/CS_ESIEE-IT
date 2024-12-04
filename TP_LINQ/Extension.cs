using ex2;

namespace TP_LINQ;

public static class Extension
{
    public static void AfficherTous(List<Article> articles)
    {
        foreach (var article in articles)
        {
            Console.WriteLine(article);
        }
    }
}