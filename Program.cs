using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_6
{
    class Character
    {

        public string Name;
        public int Level;
        public int MaxHealth;
        public int Mana;


        public virtual void getCharacter()
        {
            Console.WriteLine("Новый персонаж!");
        }

        public virtual void attackCharacter()
        {
            Console.WriteLine("Персонаж атакует!");
        }

        public void retreatCharacters()
        {
            Console.WriteLine("Персонаж отступает");
        }
        public void healCharacters()
        {
            Console.WriteLine("Персонаж восстанавливает здоровье");
        }

        public void LowHealth()
        {
            Console.WriteLine("Мало здоровья!");
        }

        public void LevelUp()
        {
            Console.WriteLine("Уровень персонажа повышен!");
        }
    }

    class Knight : Character
    {
        public int MaxSpeed;
        public int JumpHeight;
        public override void getCharacter()
        {
            Console.WriteLine("Новый персонаж - Рыцарь!");
        }

        public override void attackCharacter()
        {
            Console.WriteLine("Рыцарь атакует!");
        }

        public new void retreatCharacters()
        {
            Console.WriteLine("Рыцарь отступает назад!");
        }

        public new void healCharacters()
        {
            Console.WriteLine("Рыцарь восстанавливает здоровье");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Character ch = new Knight();
            ch.getCharacter();
            ch.attackCharacter();

            Knight kn = new Knight();
            kn.retreatCharacters();
            kn.healCharacters();
        }
    }
}