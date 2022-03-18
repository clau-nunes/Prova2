namespace Prova2.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia maléfica";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 7 )
            {
                return this.Name + " Lançou magia maléfica SUPER EFETIVA com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia maléfica com força fraca com bônus de " + Bonus;
            }           
        }
    }
}