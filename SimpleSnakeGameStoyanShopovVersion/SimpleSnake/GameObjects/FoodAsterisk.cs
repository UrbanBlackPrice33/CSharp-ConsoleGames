using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodAsterisk : Food
    {
        public FoodAsterisk(Wall wall) 
            : base(wall, '*', 1)
        {
        }
    }
}
