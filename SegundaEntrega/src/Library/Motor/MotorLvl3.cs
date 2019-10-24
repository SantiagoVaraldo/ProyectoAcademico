using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
         public class MotorLvl3 : IObservable
         {
                  private List<ButtonCheck> correctList = new List<ButtonCheck>();
                  private int ClickNum; 
                  private List<IObserver> observers = new List<IObserver>();
                  public void Check(ButtonCheck buttonCheck)
                  {
                           ClickNum += 1;
                           if (buttonCheck.Check)
                           {
                                    this.correctList.Add(buttonCheck);
                           }
                           if ((ClickNum % 2) == 0)
                           {
                                    if (this.correctList.Count == 2)
                                    {
                                             buttonCheck.Screen.levelCompleted();
                                             foreach (IObserver observer in this.observers)
                                             {
                                                    observer.Update();
                                             }
                                    }
                                    else
                                    {
                                        this.correctList.Clear();
                                    }
                           }
                  }
                  public void Subscribe(IObserver observer)
                  {
                           if (!observers.Contains(observer))
                           {
                                    observers.Add(observer);
                           }
                  }

                  public void Unsubscribe(IObserver observer)
                  {
                           if (observers.Contains(observer))
                           {
                                    this.observers.Remove(observer);
                           }
                  }

         }
}