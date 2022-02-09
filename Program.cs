using System;
using abstraindo_um_jogo_RPG_Usando_orientacao_a_objetos.src.Entities;
using static System.Console;

namespace dotnet_poo

{
    class Program
    {
        static void Main()
        {
            Knight knight = new Knight("Arus", 47, "Knight");
            Wizard wizard = new Wizard("Jenica", 87, "Wizard");
            Ninja ninja = new Ninja("Uzui", 99, "Ninja");
            Necromancer necromancer = new Necromancer ("Muzan",65,"Necromancer");



            WriteLine(knight.Attack());
            WriteLine(wizard.Attack(5));
            WriteLine(wizard.Attack(7));
            WriteLine(ninja.Attack(3));
            WriteLine(ninja.Attack(7));
            WriteLine(ninja.Attack(2));
            WriteLine(necromancer.Attack(3));
            WriteLine(necromancer.Attack(7));
            WriteLine(necromancer.Attack(2));
        }
    }
}