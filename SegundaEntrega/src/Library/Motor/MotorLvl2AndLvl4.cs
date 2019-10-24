using System;
using Proyecto.Common;
using System.Collections.Generic;

namespace Library
{
         public class MotorLvl2AndLvl4 : IObservable
         {
                  private List<Word> listWords = new List<Word>();
                  private List<IObserver> observers = new List<IObserver>();
                  public void Check(Word word)
                  {
                           if (!this.listWords.Contains(word))
                           {
                                    if (word.PositionY == word.Destination.PositionY & word.PositionX == word.Destination.PositionX)
                                    {
                                             this.listWords.Add(word);
                                    }
                           }
                           else
                           {
                                    if (word.PositionY != word.Destination.PositionY || word.PositionX != word.Destination.PositionX)
                                    {
                                             this.listWords.Remove(word);
                                    }
                           }
                           if (this.listWords.Count == 4)
                           {
                                    word.Screen.levelCompleted();
                                    foreach (IObserver observer in observers)
                                    {
                                             observer.Update();
                                    }
                           }
                  }

                  public void Subscribe(IObserver observer)
                  {
                           if (!this.observers.Contains(observer))
                           {
                                    this.observers.Add(observer);
                           }
                  }

                  public void Unsubscribe(IObserver observer)
                  {
                           if (this.observers.Contains(observer))
                           {
                                    this.observers.Remove(observer);
                           }
                  }

         }
}