using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RandomPlayer : Player
    {
        //Fields

        //Properties

        //Constructor

        //Methods
        private static Random random = new Random();
        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)random.Next(Enum.GetNames(typeof(Roshambo)).Length);
        }
    }
}
