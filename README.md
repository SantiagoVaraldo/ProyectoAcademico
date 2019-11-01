# Aplicacion pii_2019_2_equipo9

### El problema planteado por las compañeras de psicopedagogía fue el siguiente:
Deberiamos crear una aplicacion, especialmente para IOS, que conste con dos grandes categorias, ANIMALES y COMIDA.
cada una de estas categoria debera de contar con cuatro niveles de tres pantallas cada uno, para poder explicar mejor la 
tematica y el funcionamiento de esta aplicacion, empezaremos por contarles cada uno de estos cuatro niveles.

**nivel 1**
Este primer nivel consta de nueve letras del abecedario y un boton de sonido, el boton de sonido le indicara al usuario el sonido de una de
las letras que se encuentran en pantalla, el usuario debera indicar cual cree que es la letra correcta, en caso de que seleccione la letra
correcta, pasara a la pantalla numero dos del nivel uno, cada nivel consta de tres pantallas con el mismo funcionamiento. En caso de que la letra 
seleccionada por el usuario sea incorrecta, se le debera de notificar y permitirle volver a intentarlo hasta que lo logre.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:
*Letter* para representar las nueve letras 
*ButtonSound* para representar el boton con el sonido

**nivel 2**
Este segundo nivel consta de una imagen y de diferentes silabas entre las que se encuentran las correctas para formar la palabra que 
describe la imagen. El usuario deberá arrastrar las silabas en el orden correcto para formar la palabra, este tendra intentos ilimitados 
hasta lograr formar correctamente la palabra. Una vez que logro completar la palabra correctamente, pasara a la pantalla dos del nivel dos, 
nuevamente, este nivel consta de tres pantallas, es decir de tres instancias similares del mismo desafio.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:
*Image* para representar la imagen que describe la palabra a formar
*word* para representar cada una de las "palabras", en este caso silabas

**nivel 3**
En este tercer nivel se deberan mostrar seis imagenes variadas, de esas seis imagenes, dos deberan estar relacionadas(por ejemplo un frasco
de miel y una abeja). En este desafio, el usuario debera seleccionar las dos imagenes que esten relacionadas, en caso de que seleccione dos 
imagenes no relacionadas, se le notificara y se le permitira seguir intentando hasta que logre seleccionar las correctas, en este caso
pasara a la segunda pantalla de este nivel.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:
*ButtonCheck* para representar las seis imagenes que el usuario debera seleccionar 

**nivel 4** 
La logica y funcionalidad de este cuarto nivel es muy similar al segundo, este nivel consta de varias imagenes y de varias palabras, lo que 
el usuario debera hacer es arrastrar las palabras en el orden correcto para formar una frase(las imagenes estan simplemente para ayudar 
al usuario a reconocer las palabras). Una vez que el usuario logre armar la frase pasara a la pantalla numero dos.
Una vez que el usuario logre superar este cuarto desafío, se le preguntara si desea salir del juego o volver a jugar.

Para diseñar el modelo de este nivel utilizamos las siguientes clases:
*Image* para representar las imagenes 
*word* para representar cada una de las palabras que el usuario debera usar

### Comentarios generales sobre decisiones de diseño







