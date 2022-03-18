namespace Prova2.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6 )
            {
                return this.Name + " Lançou magia SUPER EFETIVA com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia com força fraca com bônus de " + Bonus;
            }           
        }
    }
}