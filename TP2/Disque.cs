using System.Transactions;
using ex1;

namespace ex2;

public class Disque : Article, IRentable
{
    private string label;

    public Disque(string nom, float prix, int quantite, ArticleType type, string label) : base(nom, prix, quantite, type)
    {
        this.label = label;
    }

    public void ecouter()
    {
        Console.WriteLine("Entre com o valor do label:");
    }
    public void DiscountStrategy(float amount)
    {
        Console.WriteLine(Delegate.Remise(prix,amount));
    }

    
    public override void PublishDetails()
    {
        Console.WriteLine($"{base.ToString()}, label : {label}");
    }
    public override string ToString()
    {
        return $"{base.ToString()}, label : {label}";
    }


    public float calculateRent()
    {
        return (prix / quantite) * 10;
    }
}