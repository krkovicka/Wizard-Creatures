using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wizards
{
   public class Program
    {      
        static void Main(string[] args)
        {
            Wizard[] wizardArray = new Wizard[5];
            Creature[] creatureArray = new Creature[5];

            int countWizards = -1;
            int countCreauters = -1;

            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

            bool MainMenu()
            {               
                Console.WriteLine("Choose option");
                Console.WriteLine("1) Make a new Wizard");
                Console.WriteLine("2) Make a new Creature");
                Console.WriteLine("3) Batle");
                Console.WriteLine("4) All out Batle");

                string x = Console.ReadLine();

                if (x == "1")
                {
                    countWizards++;
                    MakeWizard();
                    return true;
                }
                else if (x == "2")
                {
                    countCreauters++;
                    MakeCreature();
                    return true;
                }
                else if (x == "3")
                {
                    Duel();
                    return true;
                }
                else if (x == "4")
                {
                    AllOutBatle();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            object MakeWizard()
            {
                Console.Clear();
                Console.WriteLine("Whats your's wizard name");
                string name = Console.ReadLine();

                Console.WriteLine("How much power does he have");
                int power = Int32.Parse(Console.ReadLine());

                Console.WriteLine("What is the wizard's Age");
                int age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("When did the wizard started learning");
                Console.WriteLine("Input Date in dd/mm/yyyy  format");
                DateTime date = new DateTime();
                date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Has the wizard graduated?  Y/N");
                bool graduation = false;
                string y = Console.ReadLine();
                y = y.ToUpper();
                if (y == "Y")
                {
                    graduation = true;
                }
                else if (y == "N")
                {
                    graduation = false;
                }

                Wizard wizz = new Wizard(name, power, age, date, graduation);
                wizardArray[countWizards] = wizz;
                return wizardArray;
            }

            object MakeCreature()
            {
                Console.Clear();
                Console.WriteLine("What is your Creature Name");
                string name = Console.ReadLine();

                Console.WriteLine("How much power does he have?");
                int power = Int32.Parse(Console.ReadLine());

                Console.WriteLine("What is the creature's Age");
                int age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Has the creature been tamed?  Y/N");
                bool tamed = false;
                string y = Console.ReadLine();
                y = y.ToUpper();
                if (y == "Y")
                {
                    tamed = true;
                }
                else if (y == "N")
                {
                    tamed = false;
                }

                Creature creature = new Creature(name, power, age, tamed);
                creatureArray[countCreauters] = creature;
                return creatureArray;
            }

            void Duel()
            {
                Console.WriteLine("Chose a wizard");

                for (int i = 0; i < wizardArray.Length; i++)                   
                {
                    Wizard wi = wizardArray[i];
                    if (wi == null)
                    {
                        Console.WriteLine(i + ")No Wizard here");
                    }
                    else
                    {
                        Console.WriteLine(String.Format(" {0}) = {1}", i, wi.Name));
                    }
                }
                int w = Int32.Parse(Console.ReadLine());
                Wizard wiz = wizardArray[w];

                for (int i = 0; i < creatureArray.Length; i++)
                {
                    Creature cr = creatureArray[i];
                        if (cr == null)
                    {
                        Console.WriteLine(i + ") No Creature Here");
                    }
                    else
                    {
                        Console.WriteLine(String.Format(" {0}) = {1}", i, creatureArray[i].Name));
                    }
                }
                int c = Int32.Parse(Console.ReadLine());
                Creature creature = creatureArray[c];

                if (creature.Tamed == false)
                {
                    if (creature.PowerLevel < wiz.PowerLevel)
                    {
                        creature.Tamed = true;
                        Console.WriteLine("The wizard won");
                    }
                    else if (creature.PowerLevel >= wiz.PowerLevel)
                    {
                        Console.WriteLine("The creature won");
                    }
                }
                else
                {
                    Console.WriteLine("The creature is tamed");
                }

                Console.WriteLine(creature.Tamed);

            }

            void AllOutBatle()
            {
                
                for (int i = 0; i < creatureArray.Length; i++)
                {
                    Creature creature = creatureArray[i];

                    if (creature == null)
                    {
                    }
                    else
                    {
                        bool unbetable = true;
                        for (int j = 0; j < wizardArray.Length; j++)
                        {
                            Wizard wiz = wizardArray[j];
                            
                            if (wiz == null)
                            {
                            }
                            else
                            {
                                if (creature.PowerLevel > wiz.PowerLevel)
                                {
                                    unbetable = true;
                                    
                                }
                                else if (creature.PowerLevel < wiz.PowerLevel)
                                {
                                    unbetable = false;
                                }
                            }
                        }

                        if (unbetable)
                        {
                            Console.WriteLine("No wizard can beat creature " + creature.Name);
                        }

                    }
                }                
            }      
        }
    }
}
