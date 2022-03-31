using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodHash : Food
    {
        public FoodHash(Wall wall) 
            : base(wall, '#', 3)
        {
        }
    }
}
