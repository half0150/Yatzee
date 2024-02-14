using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public class YatzeeScoreCard
    {

        private static int UPPER_BONUS = 35;
        private static int UPPER_SCORE_MIN_TO_GET_BONUS = 63;

        public int? OnesScore { get; private set; }
        public int? TwosScore { get; private set; }
        public int? ThreesScore { get; private set; }
        public int? FoursScore { get; private set; }
        public int? FivesScore { get; private set; }
        public int? SixesScore { get; private set; }
        
        public int UpperSum => 
            (OnesScore ?? 0) +
            (TwosScore ?? 0) +
            (ThreesScore ?? 0) +
            (FoursScore ?? 0) +
            (FivesScore ?? 0) +
            (SixesScore ?? 0);
        
        public int UpperBous => 
            UpperSum >= UPPER_SCORE_MIN_TO_GET_BONUS ? UPPER_BONUS : 0;

        public int? ThreeOfAKind { get; private set; }
        public int? FourOfAKind { get; private set; }
        public int? FullHouse { get; private set; }
        public int? SmallStraight { get; private set; }
        public int? LargeStraight { get; private set; }
        public int? Chance { get; private set; }
        public int? Yatzee { get; private set; }
        public int Total => UpperSum + UPPER_BONUS +
            (ThreeOfAKind ?? 0) +
            (FourOfAKind ?? 0) +
            (FullHouse ?? 0) +
            (SmallStraight ?? 0) +
            (LargeStraight ?? 0) +
            (Chance ?? 0) +
            (Yatzee ?? 0);

        public YatzeeScoreCard()
        {
            OnesScore = null;
            TwosScore = null;
            ThreesScore = null;
            FoursScore = null;
            FivesScore = null;
            SixesScore = null;
            ThreeOfAKind = null;
            FourOfAKind = null;
            FullHouse = null;
            SmallStraight = null;
            LargeStraight = null;
            Chance = null;
            Yatzee = null;
        }
    }
}
