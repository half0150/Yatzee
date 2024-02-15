using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public class Player
    {
        YatzeeScoreCard YatzeeScoreCard { get; set; }


        public Player()
        {
            YatzeeScoreCard = new YatzeeScoreCard();
        }
    }
}
