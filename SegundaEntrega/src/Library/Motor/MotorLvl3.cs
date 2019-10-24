using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class MotorLvl3 : IMotor
    {
        public void CheckWon(Screen screen)
        {
            //consigue los 2 buttonchecks que tienen que estar selected
            List<ButtonCheck> buttonList = new List<ButtonCheck>();
            foreach (Element e in screen.ListaElement)
            {
                if (e is ButtonCheck & e.Check)
                {
                    buttonList.Add(e);
                }
            }

            bool won = false;
            //si hay 2 seleccionados
            if (buttonList.Count == 2)
            {
                won = true;

                foreach (ButtonCheck button in list)
                {   
                    //si los 2 seleccionados no estan bien
                    if (!button.Check)
                    {
                        won = false;
                    }
                }
            }

            if (won)
            {
                button.Screen.levelCompleted();
            }
            else
            {
                //mensaje que le erro

                foreach (ButtonCheck button in list)
                {   
                    button.Unselect();
                }
            }

        }

        public void Sound(ButtonSound buttonSound)
        {

        }

    }
}
