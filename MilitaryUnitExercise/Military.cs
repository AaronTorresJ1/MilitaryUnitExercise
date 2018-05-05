using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnitExercise
{
    public class Military
    {
        public string Name { get; set; }

        public Military(string name)
        {
            this.Name = name;
        }

        public void Mission()
        {
            Console.WriteLine("We are going to war");
        }

        public virtual string StateMission()
        {
            return "Defend our country";
        }
    }

    public class Marines : Military
    {
        public Marines(string name) : base(name)
        {
            this.Name = name;
        }

        public new void Mission()
        {
            Console.WriteLine("Marines are first to fight!");
        }

        public override string StateMission()
        {
            return "Marines are first to fight and love to eat crayons...YUT";
        }
    }

    public class Army : Military
    {
        public Army(string name) : base(name)
        {
            this.Name = name;
        }

        public override string StateMission()
        {
            return "The army waits for the Marines.";
        }

      
    }

    public class Navy : Military
    {
        public Navy(string name) : base(name)
        {
            this.Name = name;
        }
        public override string StateMission()
        {
            return "The Navy takes Marines wherever the mission is";
        }
   
    }
    public class AirForce : Military
    {
        public AirForce(string name) : base(name)
        {
            this.Name = name;
        }
        public override string StateMission()
        {
            return "The Air Force has it made.";
        }
      
    }
}
