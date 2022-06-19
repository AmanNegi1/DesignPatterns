using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP
{
    class LEDTV
    {
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }
        public LEDTV(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
        }
        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
        }
    }
    class Memento
    {
        public LEDTV ledTV { get; set; }
        public Memento(LEDTV ledTV)
        {
            this.ledTV = ledTV;
        }
        public string GetDetails()
        {
            return "Memento [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
    class Originator
    {
        public LEDTV ledTV;

        public Memento CreateMemento()
        {
            return new Memento(ledTV);
        }
        public void SetMemento(Memento memento)
        {
            ledTV = memento.ledTV;
        }
        public string GetDetails()
        {
            return "Originator [ledTV=" + ledTV.GetDetails() + "]";
        }
    }

    class Caretaker
    {
        private List<Memento> ledTvList = new List<Memento>();
        public void AddMemento(Memento m)
        {
            ledTvList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        public Memento GetMemento(int index)
        {
            return ledTvList[index];
        }
    }

    internal class MementoDP
    {
        public static void test()
        {
            Originator originator = new Originator();
            originator.ledTV = new LEDTV("42 inch", "60000Rs", false);

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());
            originator.ledTV = new LEDTV("46 inch", "80000Rs", true);
            caretaker.AddMemento(originator.CreateMemento());
            originator.ledTV = new LEDTV("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");
            originator.ledTV = caretaker.GetMemento(0).ledTV;
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
