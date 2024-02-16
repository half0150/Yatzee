using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yatzee
{
    public class YatzeeDice
    {
        private static int MAX_ROLLS = 3;

        public int Die1Value => diceValues[0];
        public int Die2Value => diceValues[1];
        public int Die3Value  => diceValues[2];
        public int Die4Value => diceValues[3];
        public int Die5Value => diceValues[4];

        
        // Hold the dice
        public bool HoldDie1
        {             get { return holdValues[0]; }
                   set { holdValues[0] = value; }
        }
        public bool HoldDie2
        {             get { return holdValues[1]; }
                   set { holdValues[1] = value; }
        }
        public bool HoldDie3
        {            get { return holdValues[2]; }
                          set { holdValues[2] = value; }
        }
        public bool HoldDie4
        {            get { return holdValues[3]; }
                                 set { holdValues[3] = value; }
        }
        public bool HoldDie5
        {            get { return holdValues[4]; }
                                        set { holdValues[4] = value; }
        }

        public int NumberOfTimesRolled { get; private set; }

        private List<int> diceValues;
        private List<bool> holdValues;
        private IRandom random;

        public YatzeeDice(IRandom random)
        {
            this.random = random;
            NumberOfTimesRolled = 0;
            diceValues = new List<int> { 0, 0, 0, 0, 0 };
            holdValues = new List<bool> { false, false, false, false, false };
        }

        public void Roll()
        {
            if (NumberOfTimesRolled < MAX_ROLLS)
            {
                for ( int index = 0; index < diceValues.Count; index++)
                {
                    if (!holdValues[index])
                    {
                        diceValues[index] = random.Next(1, 7);
                    }
                }
                NumberOfTimesRolled++;
            }
        }

        private int GetScoreForNumber(int number)
        {
            int sum = 0;
            foreach ( int die in diceValues)
            {
                if (die == number)
                {
                    sum += number;
                }
            }
            return sum;
        }

        private int SumOfAllDice => diceValues.Sum();
        

        private List<int> GetDieValueOccurences()
        {
            List<int> diceValueOccurences = new List<int> { 0, 0, 0, 0, 0, 0, 0 };

            foreach (int die in diceValues)
            {
                diceValueOccurences[die]++;
            }
            return diceValueOccurences;
        }


        private bool hasSmallStraight()
        {
            int[] sortedDiceValues = GetSortedDiceValues();

            bool hasSmallStraight = false;
            for (int i = 0; i < sortedDiceValues.Length - 3; i++)
            {
                if (sortedDiceValues[i] == (sortedDiceValues[i + 1] - 1)
                    && sortedDiceValues[i + 1] == (sortedDiceValues[i + 2] - 2)
                    && sortedDiceValues[i + 2] == (sortedDiceValues[i + 3] - 3))
                {
                    hasSmallStraight = true;
                    break;
                }
            }
            return hasSmallStraight;
        }

        private int[] GetSortedDiceValues()
        {
            int[] sortedDiceValues = { Die1Value, Die2Value, Die3Value, Die4Value, Die5Value };
            Array.Sort(sortedDiceValues);
            return sortedDiceValues;
        }

        private bool hasLargeStraight()
        {
            int[] sortedDiceValues = GetSortedDiceValues();

            return sortedDiceValues[0] == (sortedDiceValues[1] - 1)
                    && sortedDiceValues[0] == (sortedDiceValues[2] - 2)
                    && sortedDiceValues[0] == (sortedDiceValues[3] - 3)
                    && sortedDiceValues[0] == (sortedDiceValues[4] - 4);
        }


        public YatzeeScoreCard GetPossibleScores()
        {
            YatzeeScoreCard scores = new YatzeeScoreCard();

            scores.OnesScore = GetScoreForNumber(1);
            scores.TwosScore = GetScoreForNumber(2);
            scores.ThreesScore = GetScoreForNumber(3);
            scores.FoursScore = GetScoreForNumber(4);
            scores.FivesScore = GetScoreForNumber(5);
            scores.SixesScore = GetScoreForNumber(6);

            scores.ThreeOfAKind = GetDieValueOccurences().Contains(3) ? SumOfAllDice : 0;
            scores.FourOfAKind = GetDieValueOccurences().Contains(4) ? SumOfAllDice : 0;
            scores.FullHouse = GetDieValueOccurences().Contains(3) && GetDieValueOccurences().Contains(2) ? YatzeeScoreCard.FULL_HOUSE_SCORE : 0;
            scores.SmallStraight = GetDieValueOccurences().Contains(4) || GetDieValueOccurences().Contains(5) ? 30 : 0;
            scores.LargeStraight = GetDieValueOccurences().Contains(5) ? 40 : 0;
            scores.Chance = SumOfAllDice;
            scores.Yatzee = GetDieValueOccurences().Contains(5) ? 50 : 0;

            scores.SmallStraight = hasSmallStraight() ? YatzeeScoreCard.SMALL_STRAIGHT_SCORE : 0;
            scores.LargeStraight = hasLargeStraight() ? YatzeeScoreCard.LARGE_STRAIGHT_SCORE : 0;

            scores.Chance = SumOfAllDice;

            scores.Yatzee = GetDieValueOccurences().Contains(5) ? YatzeeScoreCard.YATZEE_SCORE : 0;
            
            return scores;
        }
    }
}