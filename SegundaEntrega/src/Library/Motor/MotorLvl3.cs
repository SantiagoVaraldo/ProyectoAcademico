using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class MotorLvl3 : IMotor
    {
        public void Check(ButtonCheck buttonCheck, ButtonCheck buttonCheck2)
        {
            if (buttonCheck.Check & buttonCheck2.Check)
            {
                buttonCheck.Screen.levelCompleted();
            }
            else
            {
                //mensaje que le erro
            }
            
        }
        public void Sound(ButtonSound buttonSound)
        {
           
        }

    }
}
