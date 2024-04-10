using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrogen
{
    internal class Carriage
    {
        string comfort;
        double ticketPrice;
        int passengers;

        public string Comfort
        {
            get => comfort;
            set
            {
                if (comfort == value || string.IsNullOrWhiteSpace(value))
                    return;
                comfort = value;
            }
        }

        public double TicketPrice
        {
            get => ticketPrice;
            set
            {
                if (ticketPrice == value || ticketPrice < 0)
                    return;
                ticketPrice = value;
            }
        }

        public int Passangers
        {
            get => passengers;
            set
            {
                if (passengers == value || passengers < 0)
                    return;
                passengers = value;
            }
        }

        public double Money
        {
            get => Passangers * TicketPrice;
        }

        public Carriage()
        {
            Comfort = "Noname";
            TicketPrice = 0;
            Passangers = 0;
        }

        public Carriage(string comfort, double ticketPrice, int passengers)
            : this()
        {
            Comfort = comfort;
            TicketPrice = ticketPrice;
            Passangers = passengers;
        }

        public Carriage(Carriage c)
            : this(c.Comfort, c.TicketPrice, c.Passangers) { }

        public override string ToString() =>
            $"Carriage[Klasa: {Comfort}, Cena biletu: {TicketPrice} PLN, Pasażerowie: {Passangers}, Zarobiona kaska: {Money} PLN]";
    }
}
