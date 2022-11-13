# AircraftDetailsAPI_Core
## A web API made using ASP.NET Core with search feature.

If you want details of an aircraft, you can search with it's manufacturer, name, model etc.
You will get it's data in JSON 


````JSON

{
        "aircraft": "A350-900",
        "manufacturer": "Airbus",
        "aircraftType": "Passenger",
        "range": "15000km",
        "maxTakeOffWeight": "280000kg",
        "searchTags": [
            "a350",
            "A350",
            "a350-900",
            "A350-900",
            "a350 900",
            "A350 900",
            "a350900",
            "A350900",
            "airbus aircraft",
            "airbus",
            "airbus Aircrafts",
            "Airbus aircrafts"
        ]
    }

````
 
 ## API end points

| Main URL  | https://aircraft-api.herokuapp.com |
|-----------|------------------------------------|


|  /api/aircraft/GetAllAircrafts                   | To get the details of all the aircrafts.                |
|:-------------------------------------------------|:--------------------------------------------------------|
|  /api/aircraft/SearchAircrafts?searchWord=boeing | To get details of aircraft(s) matching your search word.|

## Documentation

[Click Here to see documentation of Aircraft details API](https://aircraft-api.herokuapp.com/swagger/index.html)
                                              
