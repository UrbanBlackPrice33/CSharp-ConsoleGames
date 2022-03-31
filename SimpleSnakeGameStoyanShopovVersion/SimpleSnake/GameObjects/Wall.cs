﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {

        private const char WallSymbol = '\u25a0';
        public Wall(int leftX, int topY)
            :base(leftX,topY)
        {
            this.InitializeWall();
        }

        private void InitializeWall()
        {
            this.InitializeHorizontal(0);
            this.InitializeHorizontal(this.TopY);

            this.InitializeVertical(0);
            this.InitializeVertical(this.LeftX);
        }

        private void InitializeVertical(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(leftX, topY, WallSymbol);
            }
        }

        private void InitializeHorizontal(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, topY, WallSymbol);
            }
        }
    }
}
