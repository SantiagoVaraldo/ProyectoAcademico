using System;

namespace Library
{
    public class DragAndDropSource : Element
    {
        public DragAndDropSource(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}