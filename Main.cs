using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    enum Menu
    {
        choice_LoadFromFile = 1, choice_SaveToFile, choice_Input, choice_Valiade, choice_Check, choice_Buy, choice_Print, choice_Quit
    };

    static void Main()
    {
        Bus bus = new Bus();
        bus.composterList.Add(new Composter());
        bus.composterList.Add(new Composter());
        bus.composterList[0].tickets.Add(new BusTicket(1));
        bus.composterList[0].tickets.Add(new BusTicket(2));

        bus.composterList[1].tickets.Add(new BusTicket(1));
        bus.composterList[1].tickets.Add(new BusTicket(2));
        bus.composterList[1].tickets.Add(new BusTicket(1));

        Composter composter = new Composter();

        int choice;

        string temp;
        bool programIsOpen = true;
        while (programIsOpen)
        {

            Console.WriteLine("\n\nMENU\n\n1.Load from file\n2.Save to file\n3.Console input\n4.Validate\n5.Check ticket\n6.Buy ticket\n7.Print info\n8.Quit\n\nYour choice: \n");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);

            //Console.WriteLine("Invalid input. Please enter a valid integer.");

            Menu menu = (Menu)choice;

            switch (menu)
            {
                case Menu.choice_LoadFromFile:
                    Console.WriteLine("Input filename: ");
                    temp = Console.ReadLine();
                    bus.composterList[0].LoadFromFile(temp);
                    break;

                case Menu.choice_SaveToFile:
                    Console.WriteLine("Input filename: ");
                    temp = Console.ReadLine();
                    bus.composterList[0].SaveToFile(temp);
                    break;
                case Menu.choice_Input:
                    bus.composterList[0].Input();
                    break;
                case Menu.choice_Valiade:
                    Console.WriteLine("Input number of ticket: ");
                    int t = int.Parse(Console.ReadLine());
                    composter.Validate(bus.composterList[0].tickets[t-1]);
                    break;
                case Menu.choice_Check:
                    composter.Check(bus.composterList[1].tickets[0]);
                    break;
                case Menu.choice_Buy:
                    composter.BuyTicket();
                    break;
                case Menu.choice_Print:
                    bus.Print();
                    break;
                case Menu.choice_Quit:
                    programIsOpen = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, input integer in menu range");
                    break;
            }

        }
    }
}
