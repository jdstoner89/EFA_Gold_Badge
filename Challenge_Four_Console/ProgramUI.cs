using System;
using ChallengeFour_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Four_Console
{
    class ProgramUI
    {
        private OutingsRepository _outingRepo = new OutingsRepository();
        public void Run()
        {
            SeedOutingsList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu item:\n" +
                    "1. View All Outings\n" +
                    "2. Create New Outing\n" +
                    "3. View Outing Cost By Event Type\n" +
                    "4. Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        ViewAllOutings();
                        break;
                    case "2":
                        CreateNewOuting();
                        break;
                    case "3":
                        ViewOutingCostByEventType();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewOuting()
        {
            Console.Clear();
            Outings newOuting = new Outings();
            Console.WriteLine("Enter the name of event type:");
            newOuting.EventType = Console.ReadLine();
            Console.WriteLine("Enter the number of people in attendance:");
            string attendanceAsString = Console.ReadLine();
            newOuting.Attendance = int.Parse(attendanceAsString);
            Console.WriteLine("Enter the date of the outing(enter as text):");
            Console.WriteLine("Enter the cost per person in attendance:");
            string personconstAsString = Console.ReadLine();
            newOuting.PersonCost = double.Parse(personconstAsString);
            Console.WriteLine("Enter the cost of the outing:");
            string eventcostAsString = Console.ReadLine();
            newOuting.EventCost = double.Parse(eventcostAsString);

            _outingRepo.AddOutingToList(newOuting);
        }
        private void ViewAllOutings()
        {
            List<Outings> listOfOutings = _outingRepo.GetOutingsList();
            foreach(Outings outing in listOfOutings)
            {
                Console.WriteLine($"EventType: {outing.EventType}\n" +
                    $"Attendance: {outing.Attendance}\n" +
                    $"EventCost: {outing.EventCost}");
            }
        }
        private void ViewOutingCostByEventType()
        {
            Console.Clear();
            Console.WriteLine("Enter the the event type.");
            string eventType = Console.ReadLine();
            Outings outing = _outingRepo.GetOutingByEventType(eventType);
            if(outing != null)
            {
                Console.WriteLine($"EventType: {outing.EventType}\n" +
                    $"EventCost: {outing.EventCost}");
            }
            else
            {
                Console.WriteLine("No outing by that name.");
            }
        }
        private void SeedOutingsList()
        {
            Outings golf = new Outings("Golf", 20, "July First", 100.00, 2000.00);
            Outings bowling = new Outings("Bowling", 50, "June First", 20.00, 1000.00);
            Outings amusementPark = new Outings("Amusement Park", 75, "August First", 100.00, 7500.00);
            Outings concert = new Outings("Concert", 10, "May Fifteenth", 100.00, 1000.00);

            _outingRepo.AddOutingToList(golf);
            _outingRepo.AddOutingToList(bowling);
            _outingRepo.AddOutingToList(amusementPark);
            _outingRepo.AddOutingToList(concert);
        }
        
    }
}
