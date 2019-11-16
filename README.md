# Aplicacion pii_2019_2_equipo9

### El problema planteado por las compañeras de psicopedagogía fue el siguiente:

Deberiamos crear una aplicacion que contenga con dos grandes categorias, ANIMALES :elephant: y COMIDA :apple:.
Cada una de estas categorias deberá de contar con cuatro niveles de tres pantallas cada uno, para poder explicar mejor la 
tematica y el funcionamiento de esta aplicación, empezaremos por contarles cada uno de estos cuatro niveles.

### Video presentando el funcionamiento del juego


[![Mira el video](https://img.youtube.com/vi/_Oe1G7H2f9E/hqdefault.jpg)](https://youtu.be/_Oe1G7H2f9E)

**Nivel 1**
Este primer nivel consta de nueve letras del abecedario y un botón de sonido, el botón de sonido le indicara al usuario el sonido de una de las letras que se encuentran en pantalla, el usuario debera indicar cual cree que es la letra correcta, en caso de que seleccione la letra correcta, pasara a la pantalla numero dos del nivel uno, cada nivel consta de tres pantallas con el mismo funcionamiento. En caso de que la letra seleccionada por el usuario sea incorrecta, se le debera de notificar y permitirle volver a intentarlo hasta que lo logre.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*Letter* Para representar las nueve letras :a:.

*ButtonSound* Para representar el boton con el sonido :speaker:.






**Nivel 2**
Este segundo nivel consta de una imagen y de diferentes silabas entre las que se encuentran las correctas para formar la palabra que 
describe la imagen. El usuario deberá arrastrar las silabas en el orden correcto para formar la palabra, este tendra intentos ilimitados 
hasta lograr formar correctamente la palabra. Una vez que logro completar la palabra correctamente, pasara a la pantalla dos del nivel dos, nuevamente, este nivel consta de tres pantallas, es decir de tres instancias similares del mismo desafio.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*Image* Para representar la imagen que describe la palabra a formar.

*word* Para representar cada una de las "palabras", en este caso silabas.






**Nivel 3**
En este tercer nivel se deberan mostrar seis imagenes variadas, de esas seis imagenes, dos deberan estar relacionadas (por ejemplo un frasco de miel :honey_pot: y una abeja :honeybee:). En este desafio, el usuario debera seleccionar las dos imagenes que esten relacionadas, en caso de que seleccione dos imagenes no relacionadas, se le notificara y se le permitira seguir intentando hasta que logre seleccionar las correctas, en este caso pasara a la segunda pantalla de este nivel.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*ButtonCheck* Para representar las seis imagenes que el usuario debera seleccionar.






**Nivel 4** 
La lógica y funcionalidad de este cuarto nivel es muy similar al segundo, este nivel consta de varias imagenes y de varias palabras, lo que el usuario debera hacer es arrastrar las palabras en el orden correcto para formar una frase (las imágenes estan simplemente para ayudar al usuario a reconocer las palabras). Una vez que el usuario logre armar la frase pasara a la pantalla numero dos.
Una vez que el usuario logre superar este cuarto desafío, se le dara la oportunidad de volver a jugar.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:

*Image* Para representar las imagenes.

*word* Para representar cada una de las palabras que el usuario debera usar.






### Comentarios generales sobre decisiones de diseño

Los patrones de diseño mas importantes que hemos utilizado para desarrollar esta app son los siguientes:

*Chain of Responibility*, en una primera instancia nosotros debiamos de poder crear nuestro modelo con los objetos correspondientes
a partir de un archivo XML, para esto decidimos tomar como ejemplo el ejercicio de Pipes And Filters visto en clase, de esta manera
enviar cada Tag del XML por la cadena de Pipes filtrando los mismos, una vez que el Tag sea filtrado, se creara una instancia de la clase Visitor correspondiente con el Tag. La principal ventaja de utilizar este patron de diseño es el cumplimiento con el principio OCP, este patron permite que tu codigo este abierto a la extencion pero cerrado a la modificacion, simplemente agregando nuevos filtros en nuestro caso, se podrian agregar otras tareas sin necesidad de modificar los filtros existentes.

*Visitor*, decidimos utilizar este patron a la hora de crear las instancias de nuestros objetos, para crear un objeto de tipo *Element*
por ejemplo, debiamos acceder a la lista de niveles de nuestro objeto *World* para encontrar el ultimo *Level* de la lista,
posteriormente debiamos acceder a la lista de pantallas de ese ultimo *Level* para encontrar la ultima *Screen* de la lista, de este  modo poder crear nuestro objeto de tipo *Element* que pertenece a esa ultima *Screen*. Como se puede ver, en este caso estamos rompiendo con la *Ley de Demeter* ya que un objeto dado esta accediendo a objetos indirectos que no deberia de conocer. Como solucion a este problema decidimos utilizar el patron *Visitor*, la idea de este patron es poder crear un objeto *Visitor* que acceda a cada uno de los objetos, que acceda al *World*, luego al ultimo *Level* y finalmente a la ultima *Screen*, de esta manera ninguno de los objetos estaria accediendo a objetos indirectos. Al igual que el patron mencionado anteriormente, el patron *Visitor* tiene entre sus ventajas el cumplimiento de los principios OCP y SRP.

*Singleton*. Hemos utilizado este patron para poder instanciar y utilizar objetos que necesariamente existe una y solo una instancia de los mismos. Por ejemplo, en nuestro juego vamos a tener una unica instancia de *World* al igual que una sola instancia para cada uno de los motores implementados. Al crear una instancia de estos objetos por medio del patron *Singleton*, este nos crea la instancia del objeto en caso de que no exista, y nos devuelve la instancia ya existente en caso de que exista.









