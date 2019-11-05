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
    /// de forma cercana, cumple una de las condiciones necesarias para crear los objetos.
    /// </summary>
    public class Creator
    {
        private static World world;
        private static List<string> listPages = new List<string>(); // agregue esto
        private List<Tag> listTags = new List<Tag>();

        public static World World
        {
            get
            {
                return Creator.world;
            }

            set
            {
                Creator.world = value;
            }
        }

        public static List<string> ListPages
        {
            get
            {
                return Creator.listPages;
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
            IFilterConditional filterWorld = new FilterWorld();
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
            IPipe pipe10 = new PipeConditional(filterImage, pipeNull, pipeNull);
            IPipe pipe9 = new PipeConditional(filterWord, pipeNull, pipe10);
            IPipe pipe8 = new PipeConditional(filterDragAndDropDestination, pipeNull, pipe9);
            IPipe pipe7 = new PipeConditional(filterDragAndDropSource, pipeNull, pipe8);
            IPipe pipe6 = new PipeConditional(filterLetter, pipeNull, pipe7);
            IPipe pipe5 = new PipeConditional(filterButtonCheck, pipeNull, pipe6);
            IPipe pipe4 = new PipeConditional(filterButtonSound, pipeNull, pipe5);
            IPipe pipe3 = new PipeConditional(filterButtonNextPage, pipeNull, pipe4);
            IPipe pipe2 = new PipeConditional(filterScreen, pipeNull, pipe3);
            IPipe pipe1 = new PipeConditional(filterLevel, pipeNull, pipe2);
            IPipe pipe0 = new PipeConditional(filterWorld, pipeNull, pipe1);

            foreach (Tag tag in this.listTags)
            {
                pipe0.Send(tag);
            }
        }
    }
}