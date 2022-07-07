using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankNew
{
    internal class CardHolder
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string cardNumber { get; set; }
        public int pin { get; set; }

        public CardHolder(string firstName, string lastName, string cardNumber, int pin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cardNumber = cardNumber;
            this.pin = pin;
        }
    }
}
