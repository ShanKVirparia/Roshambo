using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public abstract class Player
    {
        //Fields
        public enum Roshambo
        {
            Rock,
            Paper,
            Scissors

        }

        //Properties
        public string Name { get; set; }
        public Roshambo value { get; set; }
        
        //Constructor

        //Methods

        public abstract Roshambo GenerateRoshambo();
        
    }
}
