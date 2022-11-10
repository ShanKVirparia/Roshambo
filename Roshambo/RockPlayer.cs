using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    public class RockPlayer : Player
    {
        //Fields

        //Properties

        //Constructor

        //Methods
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;

        }
    }
}