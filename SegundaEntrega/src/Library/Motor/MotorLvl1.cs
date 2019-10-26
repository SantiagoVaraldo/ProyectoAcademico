using System;
using Proyecto.Common;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: MotorLvl1
/// 
/// DESCRIPCION: Motor encargado de la logica del nivel 1
/// 
/// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 1, su unica razon de cambio es modificar
/// la logica del nivel.
/// 
/// COLABORACIONES: colabora con la interfaz IObserver ya que conoce una lista de IObservers, colabora con la interfaz
/// IObservable ya que es de tipo IObservable, Colabora con la clase Letter ya que es el elemento con el que va a 
/// realizar la logica.
/// </summary>

namespace Library
{
         public class MotorLvl1 : IObservable
         {
                  private List<IObserver> observers = new List<IObserver>();

                  /// <summary>
                  /// checkea que sea la letra correcta
                  /// </summary>
                  /// <param name="letter"> letra la cual fue clickeada </param>
                  public void Check(Letter letter)
                  {
                           if (letter.Right)
                           {
                                    this.NextLevel(letter);
                           }
                           else
                           {
                                    //mensaje de error que le erro.
                           }
                  }

                  /// <summary>
                  /// metodo que establece que la pantalla fue superada y se lo notifica al Observer
                  /// </summary>
                  /// <param name="letter"> letra que fue clickeada </param>
                  public void NextLevel(Letter letter)
                  {
                           letter.Screen.levelCompleted();
                           foreach (IObserver observer in observers)
                           {
                                    observer.Update();
                           }
                  }

                  /// <summary>
                  /// metodo que agrega un IObserver a la lista de Observers
                  /// </summary>
                  /// <param name="observer"> observer a agregar </param>
                  public void Subscribe(IObserver observer)
                  {
                           if (!observers.Contains(observer))
                           {
                                    observers.Add(observer);
                           }
                  }

                  /// <summary>
                  /// metodo que elimina un IObserver de la lista de Observers
                  /// </summary>
                  /// <param name="observer"> observer a eliminar </param>
                  public void Unsubscribe(IObserver observer)
                  {
                           if (observers.Contains(observer))
                           {
                                    this.observers.Remove(observer);
                           }
                  }

         }
}
