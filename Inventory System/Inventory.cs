using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        int damage = 10;
        float gold = 0.00f;
        int Dagger = 5;
        int Sword = 10;
        int BattleAx = 15;
        int Spear = 15;
        int Claymore = 20;
        int Halberd = 20;
        
        
        public void Menu()
        {
            string choice = "";
            

            while (choice != "0")
            {
                //display menu
                Console.WriteLine("/nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Add Gold");
                Console.WriteLine("4: Subtract Gold");

                //get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //check input
                if (choice == "1")
                {
                    EquipWeapon();
                }

                else if (choice == "2")
                {
                    UnequipWeapon();
                }
                else if (choice == "3")
                {
                    Console.Write("How much gold? ");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "4")
                {
                    Console.Write("How much gold? ");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubGold(subtractedGold);
                }
            }
        }

        public void EquipWeapon()
        {
            Console.WriteLine("Select a weapon");
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("/nMenu");
                Console.WriteLine("0: Prev Menu");
                Console.WriteLine("1: Dagger");
                Console.WriteLine("2: Sword");
                Console.WriteLine("3: Battle Ax");
                Console.WriteLine("4: Spear");
                Console.WriteLine("5: Claymore");
                Console.WriteLine("6: Halberd");

                choice = Console.ReadLine();
                Console.WriteLine("");

                if (choice == "1")
                {
                    Dagger 
                }





            }
            
        }

        public void UnequipWeapon()
        {
            Console.WriteLine("Unequipped a weapon");
            damage = 10;
            Console.WriteLine("Damage: " + damage);
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }
        public void SubGold(float amount)
        {
            
            Console.WriteLine("Lost " + amount + " gold");
            gold -= amount;
            
            //cant go under 0
            if (gold <= 0)
            {
                gold = 0;
               
            }
            Console.WriteLine("Gold: " + gold);
            Console.WriteLine("your already poor chill");
        } 
        


    }
}
