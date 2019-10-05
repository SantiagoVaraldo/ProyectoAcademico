namespace Library
{
         public class Create
         {


                  // creamos un pipeNull
                  IPipe pipenull = new PipeNull();
                  IPipe pipe = new Pipe();

                  // creamos instancias de todos los filtros que nos interecen
                  IFilterConditional filterworld = new FilterWorld();
                  IFilterConditional filterlevel = new FilterLevel();
                  IFilterConditional filterscreen = new FilteScreen();
                  IFilterConditional filterbutton = new FilterButton();
                  IFilterConditional filterimage = new FilterImage();

                  // creamos instancias de todos los pipeSerial que vayamos a utilizar
                  //IPipe pipeserial7 = new PipeSerial(filtertwitter,pipenull);
                  IPipe pipe5 = new Pipe(conditionalfilter, pipeserial4, pipeserial5); // en este caso se sobrescribe la imagen guardada ya que estoy usando el mismo filtersave con el mismo path
                  IPipe pipe4 = new Pipe(FilterImage, pipeserial4, pipeserial5);
                  IPipe pipe3 = new Pipe(FilterButton, pipeserial4, pipeserial5);
                  IPipe pipe2 = new Pipe(FilteScreen, pipeserial4, pipeserial5);
                  IPipe pipe1 = new Pipe(FilterLevel, pipeserial4, pipeserial5);
                  IPipe pipe0 = new Pipe(FilterWorld, pipeserial4, pipeserial5);

                  // enviamos la imagen al primer pipeSerial
                  pipeserial.Send(pic);
         }
}
