using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Monogame1
{
    public class Player
    {
        private Point position;
        public Point Position => position;
        public Player(int x, int y) //constructor que dada a as +osições guarda a sua posição
        {
            position = new Point(x, y);
        }
    }
}
