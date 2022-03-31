using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class FoodDolar : Food
    {
        public FoodDolar(Wall wall) 
            : base(wall, '$', 2)
        {
        }
    }
}
