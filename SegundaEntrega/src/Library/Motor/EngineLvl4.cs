//--------------------------------------------------------------------------------
// <copyright file="EngineLvl4.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Proyecto.Common;

namespace Library
{
    /// <summary>
    /// NOMBRE: EngineLvl4
    /// DESCRIPCION: Motor encargado de la logica del nivel 4.
    /// SRP: la unica responsabilidad de esta clase es hacer la logica del nivel 4, su unica razon de
    /// cambio es modificar la logica de este nivel.
    /// EXPERT: es el experto en conocer una lista de observers por lo que va a ser quien le notifique al GeneralEngine
    /// cuando se completa el nivel 4.
    /// COLABORACIONES: colabora con IEngineDropable ya que tambien es de ese tipo,
    /// colabora con la clase Word ya que es el elemento con el que va a realizar la logica. Ademas colabora
    /// con la clase OneAdapter.
    /// </summary>
    public class EngineLvl4 : IEngineDropable
    {
        private List<Word> listWords = new List<Word>();
        private int countDestinations = 0;

        /// <summary>
        /// metodo que establece que la pantalla fue superada y se lo notifica al Observer.
        /// </summary>
        /// <param name="word"> word que fue arrastrado. </param>
        /// <returns> retorna true si se paso de nivel y false en caso contrario. </returns>
        public bool NextLevel(Word word)
        {
            if (this.listWords.Count == this.countDestinations)
            {
                word.Screen.LevelCompleted();
                Singleton<GeneralEngine>.Instance.Update();

                this.Reset(word.Screen);
                return true;
            }

            return false;
        }

        /// <summary>
        /// metodo que resetea el estado del nivel, coloca los elementos de la pantalla en su estado de origen.
        /// </summary>
        /// <param name="screen"> Screen reseteada. </param>
        public void Reset(Screen screen)
        {
            this.listWords.Clear();
            this.countDestinations = 0;
            foreach (Element element in screen.ElementList)
            {
                if (element is Word)
                {
                    ((Word)element).Destination.Unfill();
                    OneAdapter.Adapter.Center(((Word)element).ItemId, ((Word)element).Source.SourceCellImageId);
                }

                screen.LevelUncompleted();
            }
        }

        /// <summary>
        /// verifica que se haya superado el nivel.
        /// </summary>
        /// <param name="word"> Word clickeado. </param>
        public void Check(Word word)
        {
            if (this.countDestinations == 0)
            {
                this.ObtainCantDestination(word.Screen);
            }
        }

        /// <summary>
        /// obtiene la cantidad de elementos de tipo BlankSpace que hay en la pantalla.
        /// </summary>
        /// <param name="screen"> Screen en la que se calcula. </param>
        public void ObtainCantDestination(Screen screen)
        {
            int num = 0;
            foreach (Element element in screen.ElementList)
            {
                if (element is BlankSpace)
                {
                    num += 1;
                }
            }

            this.countDestinations = num;
        }

        /// <summary>
        /// metodo que agrega un objeto Word a la lista si tiene la misma posicion que su destination.
        /// </summary>
        /// <param name="word"> Word para agregar. </param>
        public void AddWord(Word word)
        {
            if (!this.listWords.Contains(word))
            {
                this.listWords.Add(word);
                word.Destination.Fill();
            }
        }

        /// <summary>
        /// metodo que elimina un objeto Word de la lista si no tiene la misma posicion que su destination.
        /// </summary>
        /// <param name="word"> Word a eliminar. </param>
        public void RemoveWord(Word word)
        {
            if (this.listWords.Contains(word))
            {
                this.listWords.Remove(word);
                word.Destination.Unfill();
            }
        }
    }
}