using ex1;

namespace ex2;

public class Article: Publication
{
    public string nom;
    public float prix;
    public int quantite;
    public ArticleType type;
    
    
    /*
     * Constructor of Article
     */
    public Article(string nom, float prix, int quantite, ArticleType type)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
        this.type = type;
    }

    public void afficher()
    {
        Console.WriteLine(nom + ", " + prix + " euro , " + quantite + " exemplaires" + type.ToString());
    }

    public void afficher(string name)
    {
        Console.WriteLine(name + " : " + nom + ", " + prix + " euro, " + quantite +" exemplaires, " + type.ToString());
    }

    public void ajouter(int quantite)
    {
        this.quantite = this.quantite + quantite;
        Console.WriteLine("Ajout de " + quantite);
    }

    public void retirer(int quantite)
    {
        if (quantite > 0)
        {
            this.quantite = this.quantite - quantite;
            Console.WriteLine("Retirer " + quantite);
        }
    }

    public override void PublishDetails()
    {
    }

    public override string ToString()
    {
        return $"{nom}, {prix} euros, {quantite} exemplaires, Type : {type}";
    }
}