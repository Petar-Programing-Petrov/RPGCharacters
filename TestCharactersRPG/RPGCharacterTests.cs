using characters;
using characters.Inventory.Equipment;
using characters.Items.Armor;
using characters.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static characters.Items.Armor.Armor;
using static characters.Items.Item;
using static characters.Items.Weapons.Weapon;

namespace TestCharactersRPG
{
    public class RPGCharacterTests
    {
        //Creating  mage for tests
        MageClass mage = new MageClass("Brand");
        //Creating a Wand for the Mage
        Weapon testWand = new Weapon()
        {
            ItemName = "Common wand",
            ItemLevel = 1,
            ItemSlot = Slot.WEAPON,
            WeaponType = TypeOfWeapons.WAND,
            WeaponAttributes = new WeaponAttributes() { Damage = 2, AttackSpeed = 1.1 }

        };
        //Creating all suiting armor types for mage
        Armor testClothBody = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = Slot.BODY,
            ArmorType = TypeOfArmor.CLOTH,
            PrimaryAttributes = new PrimaryAttributes() { Intelligence = 10 }
        };
        Armor testClothLegs = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = Slot.LEGS,
            ArmorType = TypeOfArmor.CLOTH,
            PrimaryAttributes = new PrimaryAttributes() { Intelligence = 5 }
        };



        //Character tests...............................

        //Testing if character is level one when created
        [Fact]
        public void CreateCharacter_CreatingWarriorToSeeLevel_ShouldReturnCharacterLevel()
        {
            //Arange
            WarriorClass warior = new WarriorClass("Bruno");
            int expected = 1;
            //Act
            int warriorLevel = warior.CharacterLevel;
            int actual = warriorLevel;
            //Assert
            Assert.Equal(expected, actual);
        }

        //Testing level level up when method LevelUp is called
        [Fact]
        public void LevelingCharacter_LevelingTheCharacterUP_ShouldReturnNewCharacterLevel()
        {
            //Arange
            WarriorClass warior = new WarriorClass("Bruno");
            int expected = 2;
            //Act
            warior.LevelUp();
            int warriorLevel = warior.CharacterLevel;
            int actual = warriorLevel;
            //Assert
            Assert.Equal(expected, actual);
        }





        //Testing if all characters are with proper default attributes

        //Testing rogue default / base attributes
        [Fact]
        public void CreateCharacter_CreatingRogueToCheckBaseAttributes_ShouldReturnCharacterLevel()
        {
            //Arange
            RogueClass rogue = new RogueClass("Barbi");
            string expected = $"Character Name: {rogue.CharacterName}" +
                $"\nCharacter Level: {rogue.CharacterLevel}" +
                $"\nStrength: {rogue.PrimaryAttributes.Strength}" +
                $"\nDexterity: { rogue.PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {rogue.PrimaryAttributes.Intelligence}"; 
            //Act
            
            string actual = rogue.BaseStats();
            //Assert
            Assert.Equal(expected, actual);
        }
        //Test for Mage default /base attributes
        [Fact]
        public void CreateCharacter_CreatingMageToCheckBaseAttributes_ShouldReturnCharacterLevel()
        {
            //Arange
            MageClass mage = new MageClass("Barbi");
            string expected = $"Character Name: {mage.CharacterName}" +
                $"\nCharacter Level: {mage.CharacterLevel}" +
                $"\nStrength: {mage.PrimaryAttributes.Strength}" +
                $"\nDexterity: { mage.PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {mage.PrimaryAttributes.Intelligence}";
            //Act

            string actual = mage.BaseStats();
            //Assert
            Assert.Equal(expected, actual);
        }
        //Testing ranger default /base attributes
        [Fact]
        public void CreateCharacter_CreatingRangerToCheckBaseAttributes_ShouldReturnCharacterLevel()
        {
            //Arange
            RangerClass ranger = new RangerClass("Lusti");
            
            string expected = $"Character Name: {ranger.CharacterName}" +
                $"\nCharacter Level: {ranger.CharacterLevel}" +
                $"\nStrength: {ranger.PrimaryAttributes.Strength}" +
                $"\nDexterity: { ranger.PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {ranger.PrimaryAttributes.Intelligence}";
            //Act

            string actual = ranger.BaseStats();
            //Assert
            Assert.Equal(expected, actual);
        }
        //Testing warrior default / base attributes
        [Fact]
        public void CreateCharacter_CreatingWarriorToCheckBaseAttributes_ShouldReturnCharacterLevel()
        {
            //Arange
            WarriorClass warrior = new WarriorClass("Roger");

            string expected = $"Character Name: {warrior.CharacterName}" +
                $"\nCharacter Level: {warrior.CharacterLevel}" +
                $"\nStrength: {warrior.PrimaryAttributes.Strength}" +
                $"\nDexterity: { warrior.PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {warrior.PrimaryAttributes.Intelligence}";
            //Act

            string actual = warrior.BaseStats();
            //Assert
            Assert.Equal(expected, actual);
        }
        //Each character has their attributes updated after level up
        [Fact]
        public void LevelUpWarrior_LevelingWarriorToCheckBaseAttributesAfterLevelingUp_ShouldReturnUpdatedAttributesValue()
        {
            //Arange
            WarriorClass warrior = new WarriorClass("Roger");

            double[] expected = { warrior.PrimaryAttributes.Strength + 3, warrior.PrimaryAttributes.Dexterity + 2, warrior.PrimaryAttributes.Intelligence + 1 };
            //Act
            warrior.LevelUp();
            double[] actual = { warrior.PrimaryAttributes.Strength, warrior.PrimaryAttributes.Dexterity, warrior.PrimaryAttributes.Intelligence };

            //Assert
            Assert.Equal(expected, actual);
        }
        //Testing Mage attributes after levelup
        [Fact]
        public void LevelUpMage_LevelingMageToCheckBaseAttributesAfterLevelingUp_ShouldReturnUpdatedAttributesValue()
        {
            //Arange
            MageClass mage = new MageClass("Roger");

            double[] expected = { mage.PrimaryAttributes.Strength + 1, mage.PrimaryAttributes.Dexterity + 1, mage.PrimaryAttributes.Intelligence + 5 };
            //Act
            mage.LevelUp();
            double[] actual = { mage.PrimaryAttributes.Strength, mage.PrimaryAttributes.Dexterity, mage.PrimaryAttributes.Intelligence};

            //Assert
            Assert.Equal(expected, actual);
        }
        //Testing Ranger after leveling up
        [Fact]
        public void LevelUpRanger_LevelingRangerToCheckBaseAttributesAfterLevelingUp_ShouldReturnUpdatedAttributesValue()
        {
            //Arange
            RangerClass ranger = new RangerClass("Rogerranger");

            double[] expected = { ranger.PrimaryAttributes.Strength + 1, ranger.PrimaryAttributes.Dexterity + 5, ranger.PrimaryAttributes.Intelligence + 1};
            //Act
            ranger.LevelUp();
            double[] actual = { ranger.PrimaryAttributes.Strength, ranger.PrimaryAttributes.Dexterity, ranger.PrimaryAttributes.Intelligence };

            //Assert
            Assert.Equal(expected, actual);
        }
        //Testing Rogue after leveling up
        [Fact]
        public void LevelUpRogue_LevelingRogueToCheckBaseAttributesAfterLevelingUp_ShouldReturnUpdatedAttributesValue()
        {
            //Arange
            RangerClass ranger = new RangerClass("Rogerranger");

            double[] expected = { ranger.PrimaryAttributes.Strength + 1, ranger.PrimaryAttributes.Dexterity + 5, ranger.PrimaryAttributes.Intelligence + 1 };
            //Act
            ranger.LevelUp();
            double[] actual = { ranger.PrimaryAttributes.Strength, ranger.PrimaryAttributes.Dexterity, ranger.PrimaryAttributes.Intelligence };

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
