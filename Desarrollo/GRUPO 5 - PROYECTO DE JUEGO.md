GRUPO 5 - PROYECTO DE JUEGO 

 

GRUPO FORMADO POR: 

 

    1. Iker 

    2. Verónica 

    3. Dani V. 

    4. Rafa 
 
    5. Alejandro 

 

_______________________________________________________________________ 

 

1. ENTORNO. OPCIONES: 


       CREACIÓN DE ESCENARIO DESDE CERO EN BLENDER (APLICAR COLISIONES). EXPORTACIÓN A UNITY 


 

2. CONTROL DEL JUGADOR 

       TERCERA PERSONA 


 

3. MECÁNICAS.


       Añadir sonido ambiente 

       Añadir timeline. Construir cutscene 

       Añadir collider que desencadene la cutscene 

       Configuración de detección que desencadena evento: encender luz o activar audio clip 

       Al hacer clic en x botón se hace un auto apuntado al enemigo más cercano (REVISAR)  

       Creación de “portales” 


_______________________________________________________________________  

--- DATOS --- 

- 3 niveles (3 fragmentos de foto) 1º foto (no se visualiza nada en concreto) 2º foto (se ve al personaje principal en ella) 3º foto (ve a su hija que es lo que le dan ganas de vivir) 

- 1 boss final (24 golpes para derrotar) 

- Los pequeños aparecerán continuamente con intervalos de tiempo entre 18s y 33s (3 golpes para derrotar)  

- Todos los enemigos contaran con un rango en el que si te acercas a él atacará. 

- Cada escenario tiene un color, Granaja (Naranja/Amarillo), Casa (Verde), Hospital (Azul Claro) 




--- DESARROLLO ---

-Cuando el juego comienza se ve un fondo blanco y se escucha un estallido, luego apareces en un mundo de wireframe (alambre) en el interior de un toroide, pero con una intersección en uno de los lados. 

Se debe escapar de este espacio y para ello debe seguir las indicaciones de una voz que ayuda en la recolección de partes de una foto, empezando cuando entras en la intersección, la cual te lleva al primer nivel. 

 

Nivel 1 - Granja: Se empieza con una animación en la que se cae del cielo por la intersección y al caer se ve una granja con un establo de caballos, en la que hay seres geométricos pequeños que representan animales de granja los cuales te atacarán. 

La parte de la fotografía se encuentra en el centro del establo, cuando la consigues y vayas a salir del establo aparecerá una intersección en el suelo y caerás pasando al siguiente nivel. 

La primera fotografía se encuentra en el centro del establo 

Nivel 2 - Casa: Apareces en la puerta de la casa del protagonista, es una casa amplia; en esta hay seres geométricos abstractos complicaran el encontrar el pedazo de fotografía, esta se encuentra en la habitación de la hija del protagonista (Encima de la cama) en el último piso. Tras conseguirla y salir de la habitación no hay pasillo y solo el vació, y el protagonista cae por este, apareciendo de repente en el siguiente nivel. 

 

Nivel 3 - Hospital: Apareces en la recepción de un hospital, aquí hay un laberinto de habitaciones, hasta que llegas en la habitación número “33” la cual es en la que se encuentra el protagonista, al llegar a esta, todos los objetos de la habitación se hacen pequeños excepto las paredes que se hacen grandes, del centro aparece el boss final, cuando lo derrotas de este aparece el pedazo de fotografía faltante. 

Cuando consigues la foto completa apareces en el escenario del inicio y sucede el final del juego 




 

4. FINAL DE JUEGO: 

Para acabar el juego se deben recolectar las 3 partes de la fotografía analógica, encontrando las dos primeras y tras derrotar al boss. 

Cuando se logra recuperar la foto, se abre una puerta que se encuentra en el centro del toroide viéndose como un árbol con la copa simétrica de los dos extremos,  

Si no se consigue las 3 fotografías no se podrá salir, hasta que lo derroten los enemigos, y se pierde la partida, y vuelves a empezar. 

 

 _______________________________________________________________________ 

PLAN DE TRABAJO: 

 

    (6 de febrero) 

    8 de febrero 

    13 de febrero 

    15 de febrero 

    20 ENTREGAR 

 _______________________________________________________________________ 
 

TAREAS QUE DESEMPEÑA CADA MIEMBRO DEL EQUIPO: 

 

Para pasar al siguiente nivel tiene que tener cada fragmento de foto 

El ataque es con golpes. El Controller necesita una animación de golpear. Los enemigos también golpean. 

Hasta que no consigues cada fragmento en cada nivel no puedes avanzar.  

El personaje tiene 3 vidas y muere al recibir 3 golpes. 
