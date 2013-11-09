using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace GameName1
{
    class Circle
    {
        private int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }        
        private Color color;
        private Texture2D texture;

        public Circle(int sx,int sy, Color c,Texture2D text)
        {
            x = sx;
            y = sy;
            texture = text;
            color = c;
        }


        public void Draw(SpriteBatch sb)
        {
            sb.Draw(texture, new Vector2(x,y), color);
        }
    }
}
