# Aplicacion pii_2019_2_equipo9

### El problema planteado por las compañeras de psicopedagogía fue el siguiente:

Deberiamos crear una aplicacion, especialmente para IOS, que conste con dos grandes categorias, ANIMALES y COMIDA.
cada una de estas categoria debera de contar con cuatro niveles de tres pantallas cada uno, para poder explicar mejor la 
tematica y el funcionamiento de esta aplicacion, empezaremos por contarles cada uno de estos cuatro niveles.



**nivel 1**
Este primer nivel consta de nueve letras del abecedario y un boton de sonido, el boton de sonido le indicara al usuario el sonido de una de las letras que se encuentran en pantalla, el usuario debera indicar cual cree que es la letra correcta, en caso de que seleccione la letra correcta, pasara a la pantalla numero dos del nivel uno, cada nivel consta de tres pantallas con el mismo funcionamiento. En caso de que la letra seleccionada por el usuario sea incorrecta, se le debera de notificar y permitirle volver a intentarlo hasta que lo logre.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*Letter* para representar las nueve letras 

*ButtonSound* para representar el boton con el sonido




**nivel 2**
Este segundo nivel consta de una imagen y de diferentes silabas entre las que se encuentran las correctas para formar la palabra que 
describe la imagen. El usuario deberá arrastrar las silabas en el orden correcto para formar la palabra, este tendra intentos ilimitados 
hasta lograr formar correctamente la palabra. Una vez que logro completar la palabra correctamente, pasara a la pantalla dos del nivel dos, nuevamente, este nivel consta de tres pantallas, es decir de tres instancias similares del mismo desafio.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*Image* para representar la imagen que describe la palabra a formar

*word* para representar cada una de las "palabras", en este caso silabas



**nivel 3**
En este tercer nivel se deberan mostrar seis imagenes variadas, de esas seis imagenes, dos deberan estar relacionadas(por ejemplo un frasco de miel y una abeja). En este desafio, el usuario debera seleccionar las dos imagenes que esten relacionadas, en caso de que seleccione dos imagenes no relacionadas, se le notificara y se le permitira seguir intentando hasta que logre seleccionar las correctas, en este caso pasara a la segunda pantalla de este nivel.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*ButtonCheck* para representar las seis imagenes que el usuario debera seleccionar 



**nivel 4** 
La logica y funcionalidad de este cuarto nivel es muy similar al segundo, este nivel consta de varias imagenes y de varias palabras, lo que el usuario debera hacer es arrastrar las palabras en el orden correcto para formar una frase(las imagenes estan simplemente para ayudar al usuario a reconocer las palabras). Una vez que el usuario logre armar la frase pasara a la pantalla numero dos.
Una vez que el usuario logre superar este cuarto desafío, se le preguntara si desea salir del juego o volver a jugar.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*Image* para representar las imagenes 

*word* para representar cada una de las palabras que el usuario debera usar



### Comentarios generales sobre decisiones de diseño

Los patrones de diseño mas importantes que hemos utilizado para desarrollar esta app son los siguientes:

*Chain of Responibility*, en una primera instancia nosotros debiamos de poder crear nuestro modelo con los objetos correspondientes
a partir de un archivo XML, para esto decidimos tomar como ejemplo el ejercicio de Pipes And Filters visto en clase, de esta manera
enviar cada Tag del XML por la cadena de Pipes filtrando los mismos, una vez que el Tag sea filtrado, se creara la instancia de la clase
que corresponda. La principal ventaja de utilizar este patron de diseño es el cumplimiento con el principio OCP, este patron permite que tu codigo este abierto a la extencion pero cerrado a la modificacion, simplemente agregando nuevos filtros en nuestro caso, se podrian
agregar otras tareas sin necesidad de modificar los filtros existentes.

*Visitor*, decidimos utilizar este patron a la hora de crear las instancias de nuestros objetos, para crear un objeto de tipo *Element*
por ejemplo, debiamos acceder a la lista de niveles de nuestro objeto *World* para encontrar el ultimo *Level* de la lista,
posteriormente debiamos acceder a la lista de pantallas de ese ultimo *Level* para encontrar la ultima *Screen* de la lista, de este  modo poder crear nuestro objeto de tipo *Element* que pertenece a esa ultima *Screen*. Como se puede ver, en este caso estamos rompiendo con la *Ley de Demeter* ya que un objeto dado esta accediendo a objetos indirectos que no deberia de conocer. Como solucion a este problema decidimos utilizar el patron *Viditor*, la idea de este patron es poder crear un objeto *Visitor* que acceda a cada uno de los objetos, que acceda al *World*, luego al ultimo *Level* y finalmente a la ultima *Screen*, de esta manera ninguno de los objetos estaria accediendo a objetos indirectos. Al igual que el patron mencionado anteriormente, el patron *Visitor* tiene entre sus ventajas el cumplimiento de los principios OCP y SRP.

*Observer*. Una vez terminamos de crear nuestro modelo del juego procedimos a crear el motor del juego, para esto decidimos aplicar el patron *Observer*, para esto creamos dos interfaces, *IObserver* e *IObservable*, luego creamos un motor general el cual se va a subscibir a cada uno de los motores individuales, de este modo, cada vez que uno de los motores individuales determina que el nivel fue completado, se le notificara al motor general el cual tiene la responsabilidad de pasar al siguiente nivel, de este modo evitamos la necesidad de que el motor general tenga que estar preguntando constantemente a los motores individuales si el nivel fue completado. Nuevamente una de las ventajas de aplicar este patron es el cumplimiento con el principio de OCP ya que podriamos agregar nuevos subscriptores para realizar nuevas tareas sin la necesidad de modificar las clases existentes.







