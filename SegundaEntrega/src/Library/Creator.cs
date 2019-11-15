//--------------------------------------------------------------------------------
// <copyright file="Creator.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ExerciseOne;

namespace Library
{
    /// <summary>
    /// NOMBRE: Creator
    /// DESCRIPCION: Esta clase llama a los metodos de la clase CreatorHelper y crea la cadena de Pipes And Filters.
    /// PATRON CREATOR: el builder crea las instancias de los pipes and filters ya que es quien va a hacer uso de los mismos
    /// de forma cercana, cumple una de las condiciones necesarias para ser quien crea los objetos.
    /// </summary>
    public class Creator
    {
        private static Dictionary<string, List<string>> pagesUnity = new Dictionary<string, List<string>>();
        private List<Tag> listTags = new List<Tag>();

        public static Dictionary<string, List<string>> PagesUnity
        {
            get
            {
                return Creator.pagesUnity;
            }

            set
            {
                Creator.pagesUnity = value;
            }
        }

        /// <summary>
        /// crea la cadena de pipes and filters.
        /// </summary>
        public void Create()
        {
            CreatorHelper creatorHelper = new CreatorHelper(@"test.xml");
            this.listTags = creatorHelper.GetListTags();

            // creamos un pipeNull
            IPipe pipeNull = new PipeNull();

            // creamos instancias de todos los filtros que nos interecen
            IFilterConditional filterLevel = new FilterLevel();
            IFilterConditional filterScreen = new FilterScreen();
            IFilterConditional filterButtonNextPage = new FilterButtonNextPage();

            // IFilterConditional filterExit = new FilterExit();
            IFilterConditional filterButtonSound = new FilterButtonSound();
            IFilterConditional filterButtonCheck = new FilterButtonCheck();
            IFilterConditional filterImage = new FilterImage();
            IFilterConditional filterLetter = new FilterLetter();
            IFilterConditional filterDragAndDropSource = new FilterDragAndDropSource();
            IFilterConditional filterDragAndDropDestination = new FilterDragAndDropDestination();
            IFilterConditional filterWord = new FilterWord();

            // creamos instancias de todos los pipeSerial que vayamos a utilizar
            // IPipe pipe11 = new PipeConditional(filterExit, pipeNull, pipeNull);
            IPipe pipeFilterImage = new PipeConditional(filterImage, pipeNull, pipeNull);
            IPipe pipeFilterWorld = new PipeConditional(filterWord, pipeNull, pipeFilterImage);
            IPipe pipeFilterDragAndDropDestination = new PipeConditional(filterDragAndDropDestination, pipeNull, pipeFilterWorld);
            IPipe pipeFilterDragAndDropSource = new PipeConditional(filterDragAndDropSource, pipeNull, pipeFilterDragAndDropDestination);
            IPipe pipeFilterLetter = new PipeConditional(filterLetter, pipeNull, pipeFilterDragAndDropSource);
            IPipe pipeFilterButtonCheck = new PipeConditional(filterButtonCheck, pipeNull, pipeFilterLetter);
            IPipe pipeFilterButtonSound = new PipeConditional(filterButtonSound, pipeNull, pipeFilterButtonCheck);
            IPipe pipeFilterButtonNextPage = new PipeConditional(filterButtonNextPage, pipeNull, pipeFilterButtonSound);
            IPipe pipeFilterScreen = new PipeConditional(filterScreen, pipeNull, pipeFilterButtonNextPage);
            IPipe pipeFilterLevel = new PipeConditional(filterLevel, pipeNull, pipeFilterScreen);

            foreach (Tag tag in this.listTags)
            {
                Visitor visitor = pipeFilterLevel.Send(tag);
                if (visitor != null)
                {
                    visitor.Visit(Singleton<World>.Instance);
                }
            }
        }
    }
}