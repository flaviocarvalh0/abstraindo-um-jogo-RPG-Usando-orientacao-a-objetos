namespace abstraindo_um_jogo_RPG_Usando_orientacao_a_objetos.src.Entities
{
    public abstract class Characters
    {
        public Characters(string name, int level, string classHero)
        {
            this.Name = name;
            this.Level = level;
            this.ClassHero = classHero;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string ClassHero { get; set; }

        public override string ToString()
        {
            return this.Name + " - " + this.Level  + " - " + this.ClassHero;
        }

        public virtual string Attack ()
        {
            return this.Name;
        }
    }

}