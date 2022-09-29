# AircraftDetailsAPI_Core
## A web API made using ASP.NET Core including search feature.

If you want details about an aircraft, you can search with it's manufacturer, it's name, it's model etc.
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
 

| Main URL  | [https://aircraft-api.herokuapp.com](https://aircraft-api.herokuapp.com) |
|-----------|--------------------------------------------------------------------------|


| /api/aircraft               | To get the details of all the aircrafts.                |
|-----------------------------|---------------------------------------------------------|
| /api/aircraft/{searchWord}  | To get details of aircraft(s) matching your search word.|
                                              
