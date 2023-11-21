# Test de Proves Funcionals  i Estructurals



### Exercici 1:
- Enunciat: Crea un programa que demani dos nombres per teclat i validi si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.

## Proves Funcionals

Clases Validas:
    - Input 1: 1, 5, 2147483647
        - Valors límit: 1, 2147483647
    - Input 2: 1, 10, 2147483647
        - Valors límit: 1, 2147483647

Clases Invalidas:
    - Input 1: 0, -5, -2147483648
        - Valors límit: 0, -2147483648
    - Input 2: 0, -10, -2147483648
        - Valors límit: 0, -2147483648

## Proves Estructurals (Unit Testing Pujat al GitHub)

1. Prova:
    - Entrada: 5
    - Sortida: "Es natural"

2. Prova:
    - Entrada: 0
    - Sortida: "No es natural:" (Introduir fins que sigui natural)

3. Prova:
    - Entrada: num1=5
    - Sortida: "Es natural"
    - Entrada: num2=10
    - Sortida: "Es natural" 
    - Sortida: "El mes gran es el segon" 

4. Prova:
    - Entrada: num1=10
    - Sortida: "Es natural"
    - Entrada: num2=5
    - Sortida: "Es natural" 
    - Sortida: "El mes gran es el primer" 

5. Prova:
    - Entrada: num1=5
    - Sortida: "Es natural"
    - Entrada: num2=5
    - Sortida: "Es natural" 
    - Sortida: "Són iguals" 
