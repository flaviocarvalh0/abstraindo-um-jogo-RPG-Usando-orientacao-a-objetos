namespace abstraindo_um_jogo_RPG_Usando_orientacao_a_objetos.src.Entities
{
    public class Wizard : Characters
    {
        public Wizard(string name, int level, string classHero) : base(name, level, classHero)
        {
            this.Name = name;
            this.Level = level;
            this.ClassHero = classHero;
        }

        public override string Attack()
        {
            return this.Name + "Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia Super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}