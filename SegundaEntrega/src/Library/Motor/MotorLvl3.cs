using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
    public class MotorLvl3 : IMotor
    {
        public void CheckWon(Screen screen)
        {
            //consigue los 6 buttonchecks de la screen
            List<ButtonCheck> buttonList = new List<ButtonCheck>();
            List<ButtonCheck> checkedList = new List<ButtonCheck>();

            foreach (Element e in screen.ListaElement)
            {
                if (e is ButtonCheck)
                {

                    buttonList.Add((ButtonCheck)e);
                
                }
            }
            
            //consigue los 2 button check que tienen que estar seleccionados
            foreach (ButtonCheck btn in buttonList)
            {
                if (btn.Check)
                {
                    checkedList.Add(btn);
                }
            }

            bool won = false;
            //si hay 2 seleccionados
            if (checkedList.Count == 2)
            {
                won = true;

                foreach (ButtonCheck button in checkedList)
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
                screen.levelCompleted();
            }
            else
            {
                //mensaje que le erro

                foreach (ButtonCheck button in buttonList)
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
