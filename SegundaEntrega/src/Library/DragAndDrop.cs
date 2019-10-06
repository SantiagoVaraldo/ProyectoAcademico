using System;

/// <summary>
/// NOMBRE: DragAndDrop.
/// 
/// DESCRIPCION: Esta clase se encarga de conocer toda la informacion pertinente a los elementos DragAndDrop
/// es de tipo Element.
/// 
/// PATRON EXPERT: Esta clase cumple con el patron Expert, porque es experta en conocer la informacion
/// pertinente para nuestros requisitos de crear objetos DragAndDrop.
/// 
/// SRP: Esta clase cumple con SRP porque, presenta una unica responsabilidad que es conocer la informacion
/// de DragAndDrop, su unica razon de cambio es modificar los datos que guardamos sobre DragAndDrop.
/// 
/// HERENCIA: al igual que la clase Image y Button, esta clase hereda de la clase ancestra Element
/// 
/// COLABORACIONES: Colabora con la clase Element y Screen ya que un DragAndDrop debe pertenecer a una Screen 
/// y es de tipo Element.
/// 
/// ACLARACION: creamos la estructura de la clase Dropable por si la llegamos a utilizar en el futuro, hay un nivel   
/// en el que las compañeras que nos encargaron la app nos dieron la libertad de elegir entre arrastrar el objeto hacia
/// el lugar indicado o "clickear" como si fuese una especie de boton y que aparezca donde queramos
/// </summary>

namespace Library
{
    public class DragAndDrop : Element
    {
        public DragAndDrop(string Name, int PositionY, int PositionX, int Length, int Width, Screen Screen, string ImagePath)
        :base(Name, PositionY, PositionX, Length, Width, Screen, ImagePath)
        {
        }
    }
}
