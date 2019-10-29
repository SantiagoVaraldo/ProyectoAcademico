using System;
using System.Collections.Generic;

/// <summary>
/// NOMBRE: GeneralEngine
/// DESCRIPCION: Motor general del juego, es quien va a pasar a la siguiente pantalla cuando sea necesario
/// SRP: su unica responsabilidad es mostrar la pagina siguiente, su unica razon de cambio es modificar a que pagina
/// se quiere ir.
/// OBSERVER: decidimos aplicar este patron para que el motor general no necesite estar preguntandole a los motores
/// particulares cuando debera cambiar de pagina, simplemente se suscribe a los diferentes "mini motores"
/// y cuando se necesite cambiar de pantalla estos le notificaran al motor general.
/// </summary>

namespace Library
{
         public class GeneralEngine : IObserver
         {
             /// <summary>
             /// metodo que actualiza la pagina, pasa a la siguiente pantalla
             /// </summary>
             public void Update()
             {
                 // pasar a la siguienet pagina
             }
         }
}