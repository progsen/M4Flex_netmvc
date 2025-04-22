## Stad toevoegen

- lees:
```
- we gaan nu kijken of we de voorspelling met een stad kunnen uitbreiden\
- hiervoor moeten we het model aanpassen
```

## Model aanpassen:

- maak onder weerapi een nieuwe directory aan:
    - Models

- zoek `WeatherForecast.cs` en zet die in Models

- open nu `WeatherForecast.cs`
    - pas de namespace aan naar:
        > ![](img/namespace.PNG)

- run je solution
    - lees de fout!

- open `Controllers/WeatherForecastController.cs`
    > ![](img/weatherctrl.PNG)
    - voeg daar een using aan toe:
        > ![](img/models.PNG)
    
- run!
    - nu doet die het wel

## stad toevoegen

- open nu `WeatherForecast.cs` weer
    - pas die aan voeg een string City toe:
        > ![](img/stad.PNG)
- run en kijk hoe je json terugkomt
    > ![](img/null.PNG)

- zorg nu door `WeatherForecastController.cs` aan te passen dat overal amsterdam komt te staan
    > ![](img/amsterdam.PNG)


## Klaar?


- commit & push naar je repo voor dit vak
