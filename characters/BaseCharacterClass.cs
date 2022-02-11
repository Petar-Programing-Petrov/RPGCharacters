using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class BaseCharacterClass
    {
        private string characterName;
        private string characterClass;
        private string equipment;
        private string armor;

        //Stats primary atributes
        private int strength;
        private int dexterity;
        private int intelligence;

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }

        }
        public string CharacterClass
        {
            get { return characterClass; }
            set { characterClass = value; }

        }
        public string Equipment
        {
            get { return equipment; }
            set { equipment = value; }

        }
        public string Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
    }
}
