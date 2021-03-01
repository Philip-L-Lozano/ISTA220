//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace C_Sharp_Exercise_7
//{
//    enum Value
//    {
//        Zero, One, Two, Three, Four, Five, Six, Seven,
//        Eight, Nine, Ten, Eleven, Twelve, Thirteen, Fourteen, Fifteen,
//        Sixteen, Seventeen, Eighteen, Nineteen, Twenty, TwentyOne, TwentyTwo,
//        TwentyThree, TwentyFour, TwentyFive, TwentySix, TwentySeven,
//        TwentyEight, TwentyNine, Thirty, ThirtyOne, ThirtyTwo, ThirtyThree,
//        ThirtyFour, ThirtyFive, ThirtySix, DoubleZero
//    }
//    enum Color { Red, Black, Green }

//    class Bin
//    {
//        private readonly Value value;
//        private readonly Color color;

//        public Bin(Value v, Color c)
//        {
//            value = v;
//            color = c;
//        }

//        public override string ToString()
//        {
//            string bin = $"{color}{value}";
//            return bin;
//        }
//        public Value BinValue()
//        {
//            return value;
//        }
//        public Color BinColor()
//        {
//            return color;
//        }

//    }
//}
