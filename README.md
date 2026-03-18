# Vikingos - Sistema de Expediciones

## Descripción del Proyecto

Este proyecto consiste en una aplicación en C# que modela el comportamiento de los vikingos y sus expediciones, teniendo en cuenta su organización social, tipos de vikingos y los distintos lugares que pueden invadir.

El sistema permite simular expediciones, evaluar si valen la pena y repartir el botín obtenido entre los vikingos participantes.

---

## Conceptos Implementados

* Programación Orientada a Objetos (POO)
* Herencia
* Polimorfismo
* Clases abstractas
* Encapsulamiento
* Composición y agregación

---

## Modelo del Sistema

### Vikingos

Los vikingos pueden ser de dos tipos:

* **Soldados**
* **Granjeros**

Todos los vikingos:

* Pertenecen a una **casta**
* Pueden participar en expediciones
* Poseen una cantidad de **oro**

#### Productividad

Un vikingo es productivo si:

* **Soldado**: tiene más de 20 vidas cobradas y al menos 1 arma
* **Granjero**: tiene suficientes hectáreas (mínimo 2 por hijo)

---

### Castas Sociales

Existen tres castas:

* **Jarl**
* **Karl**
* **Thrall**

Cada casta define:

* Si un vikingo puede ir a una expedición
* Cómo asciende en la escala social

#### Ascensos

* Jarl → Karl

  * Soldado: +10 armas
  * Granjero: +2 hijos y +2 hectáreas
* Karl → Thrall
* Thrall → no asciende

---

### Lugares a Invadir

Los vikingos pueden invadir:

#### Aldea

* Botín: cantidad de crucifijos
* Vale la pena si tiene al menos 15 monedas de oro

#### Aldea Amurallada

* Igual que una aldea
* Requiere una cantidad mínima de vikingos

#### Capital

* Botín: depende de los defensores y un factor de riqueza
* Vale la pena si se obtienen al menos 3 monedas de oro por vikingo

---

### Expediciones

Una expedición:

* Contiene vikingos y lugares
* Solo permite subir vikingos que cumplan condiciones
* Evalúa si vale la pena
* Calcula el botín total
* Reparte el oro entre los vikingos

---

## Funcionamiento General

1. Se crean vikingos con su casta correspondiente
2. Se agregan a la expedición si cumplen las condiciones
3. Se agregan lugares a invadir
4. Se evalúa si la expedición vale la pena
5. Se realiza la expedición:

   * Se calcula el botín total
   * Se reparte equitativamente entre los vikingos

---

## Decisiones de Diseño

* El atributo **Oro** se encuentra en la clase base `Vikingo` ya que todos los vikingos participan en expediciones y reciben parte del botín.
* Se utiliza **polimorfismo** para calcular el botín y determinar si vale la pena invadir un lugar.
* Las **castas** encapsulan la lógica de ascenso y reglas de participación.
* Se aplica **herencia** para diferenciar tipos de vikingos y lugares.

---

## Posibles Mejoras

* Agregar interfaz gráfica o menú interactivo
* Implementar persistencia de datos (archivos o base de datos)
* Agregar nuevos tipos de lugares (castillos, fortalezas)
* Mejorar validaciones y manejo de errores

---

## Autor

Trabajo práctico desarrollado en C# como ejercicio de modelado orientado a objetos.

---

4. Pregunta teórica:
Aparecen los castillos, que son un nuevo posible objetivo a invadir además de las aldeas y capitales. ¿Pueden agregarse sin modificar código existente? Explicar cómo agregarlo. Justificar conceptualmente.

Sí, se pueden agregar castillos sin modificar el código existente, esto es posible porque todas las invasiones se manejan con la clase abstracta Lugar, y la expedición trabaja con una lista de ese tipo ,gracias a la herencia y el polimorfismo se puede crear un nuevo tipo de lugar sin cambiar las clases que ya existen.
Para agregar un castillo solo habría que crear una nueva clase que herede de Lugar e implemente sus métodos.