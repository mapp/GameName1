using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

namespace GameName1
{
    public class MyColor
    {
        public enum Val
        {
            Red = 0,
            Orange = 1,
            Yellow = 2,
            Green = 3,
            Blue = 4,
            Purple = 5,
            White = 6
        }

        Val current;

        public MyColor(Val v)
        {
            current = v;
        }

        Val changeColor(Val v)
        {
            if (current == Val.White || withinOne(v))
                current = v;
            else if (v == opposite())
                current = Val.White;
            else
                current = average(v);

            return current;
        }

        public Boolean withinOne(Val v)
        {
            return Math.Abs((int)current - (int)v) <= 1;
        }

        public Val opposite()
        {
            return (Val)(((int)current - (int)Val.White / 2) % (int)Val.White);
        }

        public Val average(Val v)
        {
            return (Val)(((int)current + (int)v) / 2);
        }

        public override String ToString()
        {
            String s;

            switch (current)
            {
                case Val.Red:
                    s = "RED";
                    break;
                case Val.Orange:
                    s = "ORANGE";
                    break;
                case Val.Yellow:
                    s = "YELLOW";
                    break;
                case Val.Green:
                    s = "GREEN";
                    break;
                case Val.Blue:
                    s = "BLUE";
                    break;
                case Val.Purple:
                    s = "PURPLE";
                    break;
                default:
                    s = "WHITE";
                    break;
            }

            return s;
        }

        public static Val parseColor(String s)
        {
            Val v;

            switch (s)
            {
                case "RED":
                    v = Val.Red;
                    break;
                case "ORANGE":
                    v = Val.Orange;
                    break;
                case "YELLOW":
                    v = Val.Yellow;
                    break;
                case "GREEN":
                    v = Val.Green;
                    break;
                case "BLUE":
                    v = Val.Blue;
                    break;
                case "PURPLE":
                    v = Val.Purple;
                    break;
                default:
                    v = Val.White;
                    break;
            }

            return v;
        }

    }
}
