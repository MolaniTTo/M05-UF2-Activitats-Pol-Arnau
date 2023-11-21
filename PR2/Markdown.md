# Test de Proves Funcionals  i Estructurals


### Exercici 2:
- Enunciat: Crea un programa que demani per teclat un la base i l’exponent i retorni la potència.

## Proves Funcionals

### Joc de Proves Ex2:

Clases Validas:
    - Input 1: -2147483648, 5, 2147483647
        - Valors límit: -2147483648, 2147483647
    - Input 2: -2147483648, 10, 2147483647
        - Valors límit: -2147483648, 2147483647

Clases Invalidas:
    - Input 1: -2147483649, -5, -2147483648
        - Valors límit: 1, -2147483647
    - Input 2: 0, -10, -2147483647
        - Valors límit: 0, -2147483647

## Proves Estructurals (Unit Testing Pujat al GitHub)

1. Prova:
    - Entrada: base 5, exponent 2
    - Sortida: 25
2. Prova:  
    - Entrada: base 0, exponent 0;
    - Sortida: 0
