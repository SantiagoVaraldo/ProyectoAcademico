using System;

/// <summary>
/// 
/// </summary>

namespace Library
{
    public class Palabra : DragAndDropItem
    {
        public Palabra(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}