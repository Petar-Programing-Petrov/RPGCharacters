using characters;
using characters.Inventory.Equipment;
using characters.Items.Armor;
using characters.Items.Weapons;
using Xunit;
using static characters.Items.Armor.Armor;
using static characters.Items.Item;
using static characters.Items.Weapons.Weapon;

namespace RPGCharacterEquipmentTest
{
    public class RPGEquipmentTest
    {
        //Using the same equipment for multiple tests
        MageClass mage = new MageClass("Brand");
        //Wand for mage
        Weapon testWand = new Weapon()
        {
            ItemName = "Common wand",
            ItemSlot = Slot.WEAPON,
            WeaponType = TypeOfWeapons.WAND
        };
        Weapon testBowLvl1 = new Weapon()
        {
            ItemName = "Common bow",
            ItemSlot = Slot.WEAPON,
            WeaponType = TypeOfWeapons.BOW
        };
        //Weapon with level 3
        Weapon testWandLvl3 = new Weapon()
        {
            ItemName = "Common wand",
            ItemSlot = Slot.WEAPON,
            WeaponType = TypeOfWeapons.WAND,
            ItemLevel = 3
        };
        //Weapon with wrong equipment slot
        Weapon testWandWrongSlot = new Weapon()
        {
            ItemName = "Common wand",
            ItemLevel = 1,
            ItemSlot = Slot.BODY,
            WeaponType = TypeOfWeapons.WAND,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1}
            
        };

        //Creating armor for tests
        Armor testClothBody = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = Slot.BODY,
            ArmorType = TypeOfArmor.CLOTH,
            PrimaryAttributes = new PrimaryAttributes() { Strength = 1}
            
        };
        Armor testClothWeaponSlot = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = Slot.WEAPON,
            ArmorType = TypeOfArmor.CLOTH,
            PrimaryAttributes = new PrimaryAttributes() { Strength = 1 }
            //Atributes go here
        };
        Armor testClothBodyHigherLevel = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 8,
            ItemSlot = Slot.WEAPON,
            ArmorType = TypeOfArmor.CLOTH,
            PrimaryAttributes = new PrimaryAttributes() { Strength = 1 }
            //Atributes go here
        };

        //Tests from assignment with warrior
        WarriorClass warriorForTests = new WarriorClass("Grooth");
        Weapon testAxe = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 1,
            ItemSlot = Slot.WEAPON,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };
        Armor testPlateBodyarmor = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = Slot.BODY,
            ArmorType = TypeOfArmor.PLATE,
            PrimaryAttributes = new PrimaryAttributes() { Strength = 1 }
        };
        Weapon testBow = new Weapon()
        {
            ItemName = "Common bow",
            ItemLevel = 1,
            ItemSlot = Slot.WEAPON,
            WeaponType = TypeOfWeapons.BOW,
            WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
        };
        Armor testClothHead = new Armor()
        {
            ItemName = "Common cloth head armor",
            ItemLevel = 1,
            ItemSlot = Slot.HEAD,
            ArmorType = TypeOfArmor.CLOTH,
            PrimaryAttributes = new PrimaryAttributes() { Intelligence = 5 }
        };


        //Testing equipment with warrior equipped with: axe and plateBody armor 

        //If  warrior tries correct  weapon
        [Fact]
        public void EquipWeaponWarriorTest_EquippingTheCorrectWeaponWarrior_ShouldReturnTrue()
        {
            //Arange
           
            bool expected = true;
            //Act
            bool actual = warriorForTests.EquipWeapon(testAxe);
            //Assert
            Assert.Equal(expected, actual);
        }

        //If  character tries to equip a high level weapon
        [Fact]
        public void EquipWeaponWarriorTest_EquippingHigherLevelWeaponWarrior_ShouldReturnFalse()
        {
            //Arange
            Weapon testAxeLevel2 = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 2,
                ItemSlot = Slot.WEAPON,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            bool expected = false;
            //Act
            bool actual = warriorForTests.EquipWeapon(testAxeLevel2);
            //Assert
            Assert.Equal(expected, actual);
        }
        //If  character tries to equip a wrong weapon type
        [Fact]
        public void EquipWrongWeaponWarriorTest_EquippingWrongLevelWeaponWarrior_ShouldReturnFalse()
        {
            //Arange
            Weapon testBow = new Weapon()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                ItemSlot = Slot.WEAPON,
                WeaponType = TypeOfWeapons.BOW,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            };
            bool expected = false;
            //Act
            bool actual = warriorForTests.EquipWeapon(testBow);
            //Assert
            Assert.Equal(expected, actual);
        }
        //If  warrior tries to equip a wrong armor type
        [Fact]
        public void EquipArmorWrongWarriorTest_EquippingWrongArmorWarrior_ShouldReturnFalse()
        {
            //Arange
            Armor testClothHead = new Armor()
            {
                ItemName = "Common cloth head armor",
                ItemLevel = 1,
                ItemSlot = Slot.HEAD,
                ArmorType = TypeOfArmor.CLOTH,
                PrimaryAttributes = new PrimaryAttributes() { Intelligence = 5 }
            };
            bool expected = false;
            //Act
            bool actual = warriorForTests.EquipArmor(testClothHead);
            //Assert
            Assert.Equal(expected, actual);
        }

        //If  warrior tries to equip a valid weapon type
        [Fact]
        public void EquipWeaponValidWarriorTest_EquippingValidWeaponWarrior_ShouldReturnTrue()
        {
            //Arange
            
            bool expected = true;
            //Act
            bool actual = warriorForTests.EquipWeapon(testAxe);
            //Assert
            Assert.Equal(expected, actual);
        }

        //If  warrior tries to equip a valid armor type
        [Fact]
        public void EquipArmorValidWarriorTest_EquippingValidArmorWarrior_ShouldReturnTrue()
        {
            //Arange

            bool expected = true;
            //Act
            bool actual = warriorForTests.EquipArmor(testPlateBodyarmor);
            //Assert
            Assert.Equal(expected, actual);
        }

        //Calculate warrior damage without weapon 
        [Fact]
        public void CalculatingDamageWarriorTest_CalculatingDamageWithoutWeaponWarrior_ShouldReturnDamage()
        {
            //Arange
            
            double expected = warriorForTests.CharacterDamage();
            //Act
            double actual = 1.0 * (1.0 + (5.0 / 100));
            //Assert
            Assert.Equal(expected, actual);
        }
        //Calculate warrior damage with valid weapon 
        [Fact]
        public void CalculatingDamageWithWeaponWarriorTest_CalculatingDamageWithWeaponWarrior_ShouldReturnDamage()
        {
            //Arange
            warriorForTests.EquipWeapon(testAxe);
            double expected = warriorForTests.CharacterDamage();
            //Act
            double actual = (7 * 1.1) * (1.0 + (5.0 / 100));
            //Assert
            Assert.Equal(expected, actual);
        }
        //Calculate warrior damage with valid weapon and armor
        [Fact]
        public void CalculatingDamageWithWeaponAndArmorWarriorTest_CalculatingDamageWithWeaponAndArmorWarrior_ShouldReturnDamage()
        {
            //Arange
            warriorForTests.EquipWeapon(testAxe);
            warriorForTests.EquipArmor(testPlateBodyarmor);
            double expected = warriorForTests.CharacterDamage();
            //Act
            double actual = (7 * 1.1) * (1.0 + ((5.0 + 1.0) / 100));
            //Assert
            Assert.Equal(expected, actual);
        }

        //Equipping the correct weapon with correct level on the correct slot

        [Fact]
        public void EquipWeapon_TryingToEquipCorrectWeaponForMage_ShouldReturnTrue()
        {
            //Arange
            bool expected = true;
            //Act
            bool actual = mage.EquipWeapon(testWand);
            //Assert
            Assert.Equal(expected, actual);
        }
        //Equipping wrong weapon for Mage
        [Fact]
        public void EquipWeapon_TryingToEquipWrongWeaponForMage_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act
            bool actual = mage.EquipWeapon(testBowLvl1);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        //Higher level for correct weapon
        public void EquipWeapon_TryingToEquipCorrectButHigherLevelWeaponForMage_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act
            bool actual = mage.EquipWeapon(testWandLvl3);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        //Equipping weapon two times on the same weapon slot
        public void EquipWeapon_TryingToEquipCorrectWeaponTwoTimes_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act
            mage.EquipWeapon(testWand);
            bool actual = mage.EquipWeapon(testWand);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        //Equipping weapon to armor slot
        public void EquipWeapon_TryingToEquipCorrectWeaponToArmorSlot_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act            
            bool actual = mage.EquipWeapon(testWandWrongSlot);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        //Equipping armor to armor slot
        public void EquipArmor_TryingToEquipCorrectArmorToArmorSlotForMage_ShouldReturnTrue()
        {
            //Arange
            bool expected = true;
            //Act            
            bool actual = mage.EquipArmor(testClothBody);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        //Equipping armor to weapon slot
        public void EquipArmor_TryingToEquipCorrectArmorToWeaponSlotForMage_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act            
            bool actual = mage.EquipArmor(testClothWeaponSlot);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        //Equipping armor with higher level to correct slot
        public void EquipArmor_TryingToEquipCorrectArmorWithHigherLevelToCorrectSlotForMage_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act            
            bool actual = mage.EquipArmor(testClothBodyHigherLevel);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        //Equipping armor on same slot
        public void EquipArmor_TryingToEquipCorrectArmorTwoTimesOnSameSlotForMage_ShouldReturnFalse()
        {
            //Arange
            bool expected = false;
            //Act            
            mage.EquipArmor(testClothBodyHigherLevel);
            bool actual = mage.EquipArmor(testClothBodyHigherLevel);

            //Assert
            Assert.Equal(expected, actual);
        }
        //Equipping the correct weapon with correct level on the correct slot and a Mage level 1
        [Fact]
        public void EquipCorrectArmorForHeadArmorSlot_TestingDamageWithArmorForMageLevelOne_ShouldReturnTotalCharacterDamage()
        {
            //Arange
            Armor testClothHead = new Armor()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = Slot.HEAD,
                ArmorType = TypeOfArmor.CLOTH,
                PrimaryAttributes = new PrimaryAttributes() { Intelligence = 15 }
            };

            mage.EquipArmor(testClothHead);
            double expected = 1.0 * (1.0 + 23.0 / 100);

            //Act
            double actual = mage.CharacterDamage();

            //Assert
            Assert.Equal(expected, actual);
        }
        //Testing warrior class with axe and plate body armor
        [Fact]
        public void EquipCorrectArmorForAllArmorSlot_TestingDamageWithArmorForWarrirorLevelOne_ShouldReturnTotalCharacterDamage()
        {
            //Arange
            WarriorClass warrior = new WarriorClass("Brus");
            Armor tesPlateHead = new Armor()
            {
                ItemName = "Common plate head armor",
                ItemLevel = 1,
                ItemSlot = Slot.HEAD,
                ArmorType = TypeOfArmor.PLATE,
                PrimaryAttributes = new PrimaryAttributes() { Strength = 1 }
            };


            warrior.EquipArmor(tesPlateHead);
            double expected = 1.0 * (1.0 + 6.0 / 100);

            //Act
            double actual = warrior.CharacterDamage();

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
