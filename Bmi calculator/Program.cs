using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace SillyPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Jesse = new Person("Jesse", 180, 87, "male", 19);
            Person Vanessa = new Person("Vanessa", 175, 75, "female", 48);
            Person Rael = new Person("Rael", 190, 71, "male", 19);
            Person Ilan = new Person("Ilan", 160, 115, "male", 55);
            Ilan.Bmi(Ilan.Height,Ilan.Weight);
           


        }
    }
}
