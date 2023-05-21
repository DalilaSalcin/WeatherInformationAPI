**Weather API / Software Engineering** 

The Weather API is a RESTful service, powered by the OpenWeatherMap service. 

It allows you to retrieve current weather information, next to the forecast and weather history. 

**Prerequisites** 

- Visual Studio ( Community ) 2022 / Version 17.5.5 

- Internet connection to fetch data from providers 

- API Key / From the provider 

- .NET Core Framework 

**Features**  

- Retrieve weather information regarding current weather, forecast, and history
- Provides several weather parameters / Example: temperature, pressure, humidity, etc.
- Can be modified to support several data providers / DarkSky, OpenWeatherMap

**How to start this code locally:** 

**Note :* 
For authorization purposes, there has been a username and password added to the path. 
Info :  
Username: Dalila 
Password: APITest123! 

!Work will be done on WeatherController.cs! 

**Steps:** 

1. Clone this repository or downland project files.
2. Open the project in Visual Studio ( 2022 )
3. Modify API settings regarding your API Key
4. Save the project updates
5. Select the browser of your choice in Visual Studio (E.g. IIS Express ( Microsoft Edge) )
6. Start the service 

**How to use API ( Examples of request paths)**
 

For current weather:  [https://localhost:44391**/**Weather/current?city=xx&username=x&password=y](https://localhost:44391/) 

- xx=Name of the city of your choice / username=Dalila / Password=APITest123!

For forecast  weather:[https://localhost:44391/Weather/forecast?lat=10&lon=9&username=x&password=y](https://localhost:44391/)

- lat = latitude of your city of choice / lon= longitude of your city of choice

For weather history: [https://localhost:44391/Weather/history?cityid=10&username=x&password=y](https://localhost:44391/)

- cityid= id of the city that you choose/ For exaple you can use the following id : 3191281 (Sarajevo)

For weather history, since I was using OpenWeatherMap you will need a special kind of subscription. 

I am student currently, that is the way I got access to the history API Key, so do note that when using this API. 

API Response will be returned in JSON Format. 

**Logging** 

Logging has been implemented in this code. 
Here is the explanation on how to manage it on your device: 

At the beginning of the code, there is a logging method. What you need to do is create a folder on your C:// and change the rest into the name of the folder that you created. 
There all the logging will be done and saved. 

**Postman collection** 

Follow the URL below: 

[https://www.postman.com/dalilasalcin/workspace/weather-api-software-engineering-project/collection/25029667-620de125-7ee9-409e-8866-92b59043dfac?action=share&creator=25029667](https://www.postman.com/dalilasalcin/workspace/weather-api-software-engineering-project/collection/25029667-620de125-7ee9-409e-8866-92b59043dfac?action=share&creator=25029667)

**Contributing** 

Contributions to WeatherInformation Repository regarding Weather API are welcome, if you find any bugs of have improvement suggestions feel free. 

**Contact Information** 

Dalila Salčin (dalilasalcin@hotmail.com) 

Happy coding :) 

Done by:  Dalila Salčin
