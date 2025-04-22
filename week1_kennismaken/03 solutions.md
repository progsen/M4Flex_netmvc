- maak in `M4FlexNetMVC` een nieuwe directory:
    - `solutions`
    
## project maken
- open je terminal/cmd
    - ga naar je `solutions` directory
    - type `dotnet new sln`

        > ![](img/newsln.PNG)

## build?

- probeer nu dotnet build
    > ![](img/nobuild.PNG)
    
- lees:
    ```
    dat werkt niet? waarom?

    - omdat deze solution nog geen projecten heeft
    - die gaan we toevoegen
    ```

## project

- maak in `solutions` een nieuwe directory:
    - `subproject`
        - maak daar met dotnet new console een project aan
- controlleer of je dit hebt
    > ![](img/checksln.PNG)

## toevoegen

- voeg het project toe
    > ![](img/toevoegen.PNG)

- bouw nu met dotnet build

- run nu met het volgende commando:
    > ![](img/runsln.PNG)

## Klaar?


- commit & push naar je repo voor dit vak
