using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MilitaryUnitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The military has 4 branches with very specific tasks, press ENTER to find out");
            Console.ReadLine();
            Marines marines = new Marines("");
            Army army = new Army("");
            Navy navy = new Navy("");
            AirForce airForce = new AirForce("");

            SayMission(marines);
            Console.WriteLine(marines.StateMission());
            SayMission(army);
            Console.WriteLine(army.StateMission());
            SayMission(navy);
            Console.WriteLine(navy.StateMission());
            SayMission(airForce);
            Console.WriteLine(airForce.StateMission());

        }

        public static void SayMission(Military branch)
        {
           
        }
    }
}
