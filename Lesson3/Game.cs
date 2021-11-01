using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public class Game
    {
        public int HP { get; set; }

        public Game(Types types)
        {
            SetHP(types);
        }

        private void SetHP(Types types)
        {
            switch (types)
            {
                case Types.Easy: HP = 100;
                    break;
                case Types.Medium: HP=50;
                    break;
                case Types.Hard: HP = 25;
                    break;
                default:
                    break;
            }
        }
    }
}
