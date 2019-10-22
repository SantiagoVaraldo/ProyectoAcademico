using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
         public class MotorLvl1 : IMotor
         {
                  public List<string> listPages { get; set; }
                  
                  public MotorLvl1(List<string> listpages)
                  {
                           this.Adapter = adapter;
                           this.listPages = listpages;
                  }
                  public void Check(Letter letter)
                  {
                           if (letter.Right)
                           {
                                   

                           }
                           else
                           {
                                    Console.WriteLine($"Esa no es la letra correcta, vuelve a intentar");
                           }
                  }
                  public void Sound(ButtonSound buttonSound)
                  {
                      
                  }

         }
}
