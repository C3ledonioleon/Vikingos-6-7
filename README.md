4. Pregunta teórica:
Aparecen los castillos, que son un nuevo posible objetivo a invadir además de las aldeas y capitales. ¿Pueden agregarse sin modificar código existente? Explicar cómo agregarlo. Justificar conceptualmente.

Sí, se pueden agregar castillos sin modificar el código existente, esto es posible porque todas las invasiones se manejan con la clase abstracta Lugar, y la expedición trabaja con una lista de ese tipo ,gracias a la herencia y el polimorfismo se puede crear un nuevo tipo de lugar sin cambiar las clases que ya existen.
Para agregar un castillo solo habría que crear una nueva clase que herede de Lugar e implemente sus métodos.

Conceptualmente, esto cumple con el principio Open/Closed, que dice que el sistema debe estar abierto a extenderse pero cerrado a modificaciones. Es decir, podemos agregar nuevas clases sin cambiar el código que ya funciona.

