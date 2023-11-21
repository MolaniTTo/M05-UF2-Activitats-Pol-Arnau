# Test de Proves Funcionals  i Estructurals



### Exercici 1:
- Enunciat: Crea un programa que demani dos nombres per teclat i validi si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.

### Exercici 2:
- Enunciat: Crea un programa que demani per teclat un la base i l’exponent i retorni la potència.

## Proves Funcionals

### Joc de Proves Ex1:

1. Prova:  
    - Entrada: base 0, exponent 0;
    - Sortida: 0


2. Prova:
    - Entrada: base 0, exponent 10
    - Sortida: 0

3. Prova:
    - Entrada: base 1, exponent 10
    - Sortida: 1

4. Prova:
    - Entrada: base 5, exponent 4
    - Sortida: 625

5. Prova:
    - Entrada: base 10, exponent 12
    - Sortida: -727379968 (Valor límit d'Exponent=11)

6. Prova:
    - Entrada: base 4,5
    - Sortida: Error! Entrada amb decimals no valida per tipus de dades INT



#### Joc de Proves Ex2:


1. Prova:
    - Entrada: num1= 0
    - Sortida: "No es natural:" (Introduir fins que sigui natural)
    - Entrada: num2= 0 
    - Sortida: "No es natural:" (Introduir fins que sigui natural)

2. Prova:
    - Entrada: num1=5
    - Sortida: "Es natural"
    - Entrada: num2=5
    - Sortida: "Es natural" 
    - Sortida: "Son iguals" 

3. Prova:
    - Entrada: num1=10
    - Sortida: "Es natural"
    - Entrada: num2=5
    - Sortida: "Es natural" 
    - Sortida: "El mes gran es el 10" 

4. Prova:
    - Entrada: num1=4
    - Sortida: "Es natural"
    - Entrada: num2=20
    - Sortida: "Es natural" 
    - Sortida: "El mes gran es el 20" 

5. Prova:
    - Entrada: num1=10000000000
    - Sortida: Error! Sobrepassa el valor maxim de INT32 (Valor límit num1=999999999)

6. Prova:
    - Entrada: base 4,5
    - Sortida: Error! Entrada amb decimals no valida per tipus de dades INT


## Proves Estructurals (Unit Testing Pujat al GitHub)
