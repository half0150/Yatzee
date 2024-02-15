﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzee
{
    public class YatzeeScoreCard
    {

        public static int UPPER_BONUS = 35;
        public static int UPPER_SCORE_MIN_TO_GET_BONUS = 63;

        public static int SMALL_STRAIGHT_SCORE = 30;
        public static int LARGE_STRAIGHT_SCORE = 40;
        public static int FULL_HOUSE_SCORE = 25;
        public static int YATZEE_SCORE = 50;

        public int? OnesScore { get; set; }
        public int? TwosScore { get; set; }
        public int? ThreesScore { get; set; }
        public int? FoursScore { get; set; }
        public int? FivesScore { get; set; }
        public int? SixesScore { get; set; }
        
        public int UpperSum => 
            (OnesScore ?? 0) +
            (TwosScore ?? 0) +
            (ThreesScore ?? 0) +
            (FoursScore ?? 0) +
            (FivesScore ?? 0) +
            (SixesScore ?? 0);
        
        public int UpperBous => 
            UpperSum >= UPPER_SCORE_MIN_TO_GET_BONUS ? UPPER_BONUS : 0;

        public int? ThreeOfAKind { get; set; }
        public int? FourOfAKind { get; set; }
        public int? FullHouse { get; set; }
        public int? SmallStraight { get; set; }
        public int? LargeStraight { get; set; }
        public int? Chance { get; set; }
        public int? Yatzee { get; set; }
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
