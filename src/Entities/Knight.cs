namespace abstraindo_um_jogo_RPG_Usando_orientacao_a_objetos.src.Entities
{
    public class Knight : Characters
    {
        public Knight(string name, int level, string classHero) : base(name, level, classHero)
        {
            this.Name = name;
            this.Level = level;
            this.ClassHero = classHero;
        }

        public override string Attack()
        {
            return this.Name + " atacou com a espada";
        }
    }
}