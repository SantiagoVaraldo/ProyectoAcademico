using System;

namespace Library
{
    public class Letter : Button
    {
        public Letter(string Name, int PositionY, int PositionX, int Length, int Width,Screen Screen, string ImagePath, bool Right)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
            this.Right = Right;
        }
        private bool right;
        public bool Right
        {
            get 
            {
                return this.right;
            }
            set 
            {
                this.right = value;        
            }
        }
    }
}