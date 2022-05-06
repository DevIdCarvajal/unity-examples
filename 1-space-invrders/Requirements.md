# Space InVRders (Unity Version)

## Elementos (Objetos)

- Nave
  - Misil
- Escudo
- Invasor
  - Misil

## Lógica de juego (Scripts)

- Nave
  - Mover izquierda
    - Cuando (evento) el jugador pulsa la tecla de ir a la izquierda
    - Si (condición) no está en el límite izquierdo
  - Mover derecha
    - Cuando el jugador pulsa la tecla de ir a la derecha
    - Si no está en el límite derecho
  - Disparar misil
    - Cuando el jugador pulsa la tecla de disparo
  - Destruirse
    - Cuando es impactada por un misil

- Misil
  - Bajar
    - Si fue disparado por un invasor
  - Subir
    - Si fue disparado por la nave del jugador
  - Impactar
    - Cuando colisiona con el jugador, otro misil o una nave

- Escudo
  - Destruirse
    - Cuando es impactado por un misil

- Invasor
  - Mover izquierda
    - Si pasa cierto tiempo
    - Si va en esa dirección
    - Si no está en el límite izquierdo
  - Mover derecha
    - Si pasa cierto tiempo
    - Si va en esa dirección
    - Si no está en el límite derecho
  - Bajar
    - Si está en el límite izquierdo o derecho
  - Disparar misil
    - Si pasa cierto tiempo
  - Destruirse
    - Cuando es impactado por un misil

## Referencias

https://www.thingiverse.com/thing:3647
https://docs.unity3d.com/Manual/3D-formats.html
https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
https://gamedevbeginner.com/how-to-move-objects-in-unity/
https://thiscodedoesthis.com/how-to-destroy-a-gameobject-on-collision-in-unity/
