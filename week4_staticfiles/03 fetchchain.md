
## fetch chaining

- lees:
    ```
    1) Eerst halen we de view 
    De view wordt een template. Deze string bewaren we en gebruiken we voor ELKE stage in de json

    2) Nadat we de view hebben opgehaald gaan we de json ophalen

    3) voor elke stage in de json gaan we de template gebruiken om een nieuw stuk html toe te voegen
    ```

- laten we even wat functions maken:
    > ![](img/funcs.PNG)

## GetStageJsonData aanroepen

- ga naar je fetch 
    - maak van :
        > ![](img/text.PNG)
    - het volgende:
        > ![](img/funccall.PNG)

## fetch json
- maak in de function GetStageJsonData een fetch naar Stage (de StageController)
    - gebruik niet .text() maar .json()
    - log de json response:
        > ![](img/json.PNG)

- test of je de json in je console ziet:
    > ![](img/logged.PNG)

## json naar html

- ga naar GetStageJsonData
    - verander de code naar:
        > ![](img/forloop.PNG)

- bijna klaar, nu nog de html maken:
    > ![](img/replace.PNG)
    - lees:
    ```
    Zie je die replace? dat we de zelf verzonnen tag #BedrijfsNaam# vervangen met de echte data?
    ```
    - maak het af en zet de StageVergoeding en Stad er ook bij

## test!

- test en controlleer:
    > ![](img/controle.PNG)

## style

- style het geheel iets beter (eigen invulling):
    > ![](img/extrastyle.PNG)


## Klaar?

- commit naar je repo voor dit vak