using ex1;

namespace ex2;

public class Poche : Livre
{
    private string categorie;

    public Poche(string nom, float prix, int quantite, ArticleType type, string isbn, int nbPages, string categorie) : base(nom, prix, quantite, type, isbn, nbPages)
    {
        this.categorie = categorie;
    }
}