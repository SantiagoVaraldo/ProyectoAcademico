# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png"> 

## Facultad de Ingeniería y Tecnologías
### Programación II

# :warning: ¡Atención!
Ten en cuenta que esta bibllioteca es un *"work in progress"* :construction: y podrá ser modificada durante el transcurso del semestre. Esto puede ser por bugs o por solicitudes de cambios de parte tuya o de tus compañeros. 
Si deseas informar de un bug o solicitar una nueva funcionalidad a la biblioteca, necesaria para tu proyecto final, podrás hacerlo a través de issues de GitHub. Simplemente crea un nuevo issue indicando si es un bug o un feature y le daremos el seguimiento adecuado. :smile:

# Biblioteca de Unitiy para proyecto
Para que puedas mostrar de forma gráfica tu modelo de objetos, hemos desarrollado esta biblioteca de Unity. Para usar la biblioteca deberás instalar Unity (versión 2019.10.1 o superior), y te permitirá utilizar las funcionalidades de Unity sin tener que ser un experto en esa plataforma.

También proveemos una biblioteca llamada Common, que contiene las interfaces necesarias para interactuar con Unity, pero sin consumir directamente objetos provistos por Unity. 
Verás que es muy sencillo utilizarla. Solamente tienes que implementar la interfaz IBuilder, la cual recibe un IMainViewAdapter. 
Este Adapter es quien tendrá todos los métodos para agregar elementos e interactuar con la interfaz gráfica. Será responsaabilidad del Builder invocar el método correcto para instanciar tu mundo!

No te preocupes si no está claro aún. En la clase haremos una demo de cómo utilizar esto! 
