namespace abstraindo_um_jogo_RPG_Usando_orientacao_a_objetos.src.Entities
{
    public class Necromancer : Characters
    {
        public Necromancer(string name, int level, string classHero) : base(name, level, classHero)
        {
            this.Name = name;
            this.Level = level;
            this.ClassHero = classHero;
        }

        public override string Attack()
        {
            return this.Name + " Lançou shurikens";
        }

        public string Attack(int Bonus)
        {
            if (Bonus >= 3)
            {
                return this.Name + $" Lançou Magia com poder fraco de {Bonus}";
            }
            else if (Bonus >= 6)
            {
                return this.Name + $" Lançou Magia efetiva de {Bonus} e enimigo agora é um zumbi aliado";
            }
            else
            {
                return this.Name + " Errou a habilidade";
            }
        }
    }
}