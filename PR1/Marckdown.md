# Test de Proves Funcionals  i Estructurals



### Exercici 1:
- Enunciat: Crea un programa que demani dos nombres per teclat i validi si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.

## Proves Funcionals


#### Joc de Proves Ex1:


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
    - Entrada: num1=4,5
    - Sortida: Error! Entrada amb decimals no valida per tipus de dades INT


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
