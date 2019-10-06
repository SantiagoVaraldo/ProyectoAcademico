using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using ExerciseOne;
using Proyecto.Common;

namespace Library
{
    public static class Render
    {
        public static void renderImage(Image image, IMainViewAdapter adapter)
        {
            string imageId = adapter.CreateImage(-(1024 / 2 - (int)image.PositionX / 2), -(768 / 2 - (int)image.PositionY / 2), (int)image.Width, (int)image.Length);
            adapter.SetImage(imageId, image.ImagePath);
        }
        public static void renderButton(Button button, IMainViewAdapter adapter)
        {
            //string buttonId = adapter.CreateButton(button.PositionX, button.PositionY, (int)button.Width, (int)button.Length, "#BC2FA864", null);
            //adapter.SetImage(buttonId, button.ImagePath);
        }
    }
}