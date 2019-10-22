using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
         public class MotorLvl3 : IMotor
         {
                  public List<string> listPages { get; set; }
                  private IMainViewAdapter adapter;
                  public IMainViewAdapter Adapter
                  {
                           get
                           {
                                    return this.adapter;
                           }
                           set
                           {
                                    this.adapter = value;
                           }
                  }
                  public MotorLvl3(IMainViewAdapter adapter, List<string> listpages)
                  {
                           this.Adapter = adapter;
                           this.listPages = listpages;
                  }
                  public void Check(ButtonCheck buttonCheck)
                  {
                           int Count;
                           if (buttonCheck.Check && Count = 1)
                           {
                                    this.adapter.ShowPage(this.listPages[10]);
                           }
                           else if (!buttonCheck.Check && Count = 1)
                           {
                                    this.adapter.Debug($"Esas no son las correctas, vuelve a intentar");
                                    Count = 0;
                           }
                           else if (buttonCheck.Check)
                           {
                                    this.adapter.Debug($"Selecciona una imagen más");
                                    Count = 1;
                           }
                  }
                  public void Sound(ButtonSound buttonSound)
                  {
                      this.adapter.PlayAudio(buttonSound.SoundPath);
                  }

         }
}
