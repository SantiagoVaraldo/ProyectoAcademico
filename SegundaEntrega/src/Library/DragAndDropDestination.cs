using System;

namespace Library
{
    public class DragAndDropDestination : Element
    {
        public DragAndDropDestination(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}