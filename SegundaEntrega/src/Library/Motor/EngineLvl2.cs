using System;
using Proyecto.Common;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: EngineLvl2
/// DESCRIPCION: Motor encargado de la logica del nivel 2.
/// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 2, su unica razon de 
/// cambio es modificar la logica de este nivel.
/// EXPERT: es el experto en conocer una lista de observers por lo que va a ser quien le notifique al GeneralEngine
/// cuando se completa el nivel 2.
/// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
/// IObservable ya que es de tipo IObservable,colabora con IEngineDropable ya que tambien es de ese tipo, 
/// colabora con la clase Word ya que es el elemento con el que va a realizar la logica.
/// COMENTARIOS: buscamos la manera de hacer un poco mas generico el metodo check de este motor, la idea era 
/// cambiar el numero fijo "4" en la linea 61, por el atributo de tipo int "CantDestination", no logramos hacerlo funcionar. 
/// </summary>

namespace Library
{
         public class EngineLvl2 : IObservable, IEngineDropable
         {
                  private List<Word> listWords = new List<Word>();
                  private List<IObserver> observers = new List<IObserver>();
                  private int CantDestination;

                  /// <summary>
                  /// metodo que establece que la pantalla fue superada y se lo notifica al Observer
                  /// </summary>
                  /// <param name="word"> Word que fue clickeado </param>
                  public void NextLevel(Word word)
                  {
                           word.Screen.levelCompleted();
                           foreach (IObserver observer in observers)
                           {
                                    observer.Update();
                           }
                  }

                  /// <summary>
                  /// verifica que se haya superado el nivel
                  /// </summary>
                  /// <param name="word"> Word clickeado </param>
                  public void Check(Word word)
                  {
                           ObtainCantDestination(word);

                           if (!this.listWords.Contains(word))
                           {
                                    this.AddWord(word);
                           }
                           else
                           {
                                    this.RemoveWord(word);
                           }
                           if (this.listWords.Count == 4)
                           {
                                    this.NextLevel(word);
                           }
                  }

                  public void ObtainCantDestination(Word word)
                  {
                           foreach (Element element in word.Screen.ListaElement)
                           {
                                    if (element is BlankSpace)
                                    {
                                             this.CantDestination += 1;
                                    }
                           }
                  }

                  /// <summary>
                  /// metodo que agrega un objeto Word a la lista si tiene la misma posicion que su destination
                  /// </summary>
                  /// <param name="word"> Word para agregar </param>
                  public void AddWord(Word word)
                  {
                           if (word.CheckPosition()) //word.PositionY == word.Destination.PositionY & word.PositionX == word.Destination.PositionX
                           {
                                    this.listWords.Add(word);
                                    word.Destination.Fill();
                           }
                  }

                  /// <summary>
                  /// metodo que elimina un objeto Word de la lista si no tiene la misma posicion que su destination
                  /// </summary>
                  /// <param name="word"> Word a eliminar </param>
                  public void RemoveWord(Word word)
                  {
                           if (word.PositionY != word.Destination.PositionY || word.PositionX != word.Destination.PositionX)
                           {
                                    this.listWords.Remove(word);
                                    word.Destination.Unfill();
                           }
                  }

                  /// <summary>
                  /// metodo que agrega un IObserver a la lista de Observers
                  /// </summary>
                  /// <param name="observer"> observer para agregar </param>
                  public void Subscribe(IObserver observer)
                  {
                           if (!this.observers.Contains(observer))
                           {
                                    this.observers.Add(observer);
                           }
                  }

                  /// <summary>
                  /// metodo que elimina un IObserver de la lista de Observers
                  /// </summary>
                  /// <param name="observer"> observer a eliminar </param>
                  public void Unsubscribe(IObserver observer)
                  {
                           if (this.observers.Contains(observer))
                           {
                                    this.observers.Remove(observer);
                           }
                  }
         }
}