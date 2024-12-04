using ex1;

namespace ex2;

public class Video: Article, IRentable
{
 private int duree;

 public Video(string nom, float prix, int quantite, ArticleType type, int duree) : base(nom, prix, quantite, type)
 {
  this.duree = duree;
 }

 public void afficher()
 {
  Console.WriteLine("Afficher duree");
 }

 public float calculateRent()
 {
  float rent = (duree / prix) * 2;
  return rent;
 }
 
 public void DiscountStrategy(float amount)
 {
    Console.WriteLine($"le prix après remise est de {Delegate.Remise(prix,amount)}");
 }
 
 public override void PublishDetails()
 {
  Console.WriteLine($"{base.ToString()}, durée : {duree} minutes");
 }
 
 public override string ToString()
 {
  return $"{base.ToString()}, durée : {duree} minutes";
 }

}
