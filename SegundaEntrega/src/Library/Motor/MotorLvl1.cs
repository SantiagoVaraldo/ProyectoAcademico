using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class MotorLvl1 : IMotor
    {
        public void Check(Letter letter)
        {
            if (letter.Right)
            {
                letter.Screen.levelCompleted();
            }
            else
            {
                //mensaje de error que le erro.
            }
        }
        public void Sound(ButtonSound buttonSound)
        {

        }

    }
}
