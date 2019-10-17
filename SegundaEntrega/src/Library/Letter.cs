using System;
using Proyecto.Common;

namespace Library
{
    public class Letter : Element, IButton
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
        public void Action(IMainViewAdapter adapter)
        {
            //adapter.hacer_algo
        }
        public override void Render(IMainViewAdapter adapter)
        {
            string buttonId = adapter.CreateButton((int)this.PositionX, (int)this.PositionY, (int)this.Width, (int)this.Length, "#BC2FA864", null);
            //adapter.SetImage(buttonId, this.ImagePath);
        }
    }
}