namespace Prova2.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }
         public override string Attack()
        {
            return this.Name + " Lançou uma jutsu";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 5 )
            {
                return this.Name + " Lançou um SUPER JUTSU LENDÁRIO com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou um jutso simples com bônus de " + Bonus;
            } 
        }     
    }
}