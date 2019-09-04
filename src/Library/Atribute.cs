using System;

/*----------------------------------------------------------------------------------------------------------------------------
NOMBRE: Atribute.
DESCRIPCION: esta clase se encarga de crear objetos con los atributos del codigo HTML.
PATRON EXPERT:
SRP: esta clase presenta una unica responsabilidad que es crear los objetos, su unica razon de cambio es
     modificar la manera de crear objetos atributos.
COLABORACIONES: no colabora con ninguna otra clase.

------------------------------------------------------------------------------------------------------------------------------
 */

namespace ExerciseOne
{
    public class Atribute
    {
        public string Clave;
        public string Valor;
        public Atribute (string clave, string valor)
        {
            this.Clave = clave;
            this.Valor = valor;
        }
    }
}
