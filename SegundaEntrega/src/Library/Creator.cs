using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using ExerciseOne;

/// <summary>
/// NOMBRE: Creator
/// 
/// DESCRIPCION: Esta clase llama a los metodos de la clase CreatorHelper y crea la cadena de Pipes And Filters.
/// 
/// PATRON CREATOR: el builder crea las instancias de los pipes and filters ya que es quien va a hacer uso de los mismos
/// de forma cercana, cumple una de las condiciones necesarias para crear los objetos.
/// </summary>

namespace Library
{
    public class Creator
    {
        public static World world;
        private List<Tag> listtags = new List<Tag>();

        /// <summary>
        /// crea la cadena de pipes and filters 
        /// </summary>
        public void Create()
        {
            CreatorHelper creatorhelper = new CreatorHelper(@"test.xml");
            this.listtags = creatorhelper.GetListTags();

            // creamos un pipeNull
            IPipe pipenull = new PipeNull();

            // creamos instancias de todos los filtros que nos interecen
            IFilterConditional filterworld = new FilterWorld();
            IFilterConditional filterlevel = new FilterLevel();
            IFilterConditional filterscreen = new FilterScreen();
            IFilterConditional filterbuttonnextpage = new FilterButtonNextPage();
            IFilterConditional filterbuttonsound = new FilterButtonSound();
            IFilterConditional filterbuttoncheck = new FilterButtonCheck();
            IFilterConditional filterimage = new FilterImage();
            IFilterConditional filterletter = new FilterLetter();
            IFilterConditional filterDragAndDropSource = new FilterDragAndDropSource();
            IFilterConditional filterDragAndDropDestination = new FilterDragAndDropDestination();
            IFilterConditional filterword = new FilterWord();

            // creamos instancias de todos los pipeSerial que vayamos a utilizar
            //IPipe pipeserial7 = new PipeSerial(filtertwitter,pipenull);
            IPipe pipe10 = new PipeConditional(filterimage, pipenull, pipenull);
            IPipe pipe9 = new PipeConditional(filterword, pipenull, pipe10);
            IPipe pipe8 = new PipeConditional(filterDragAndDropDestination, pipenull, pipe9);
            IPipe pipe7 = new PipeConditional(filterDragAndDropSource, pipenull, pipe8);
            IPipe pipe6 = new PipeConditional(filterletter, pipenull, pipe7);
            IPipe pipe5 = new PipeConditional(filterbuttoncheck, pipenull, pipe6);
            IPipe pipe4 = new PipeConditional(filterbuttonsound, pipenull, pipe5);
            IPipe pipe3 = new PipeConditional(filterbuttonnextpage, pipenull, pipe4);
            IPipe pipe2 = new PipeConditional(filterscreen, pipenull, pipe3);
            IPipe pipe1 = new PipeConditional(filterlevel, pipenull, pipe2);
            IPipe pipe0 = new PipeConditional(filterworld, pipenull, pipe1);

            foreach (Tag tag in listtags)
            {
                pipe0.Send(tag);
            }

        }
    }
}