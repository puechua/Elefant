﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elefant
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI() {
            Console.WriteLine("Na imię mi " + Name + ".");
            Console.WriteLine("Długość moich uszu to " + EarSize + " cm.");
        }


        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " usłyszał(a) wiadomość.");
            Console.WriteLine(whoSaidIt.Name + " powiedział(a): " + message);
        }


        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
