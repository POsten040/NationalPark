#  National Park Api

#### By _**Patrick Osten**_

![](ReadMeAssets/recording.gif)

## Description
- This application was made as part of the Epicodus Coding bootcamp coursework.
- It allows users to make api calls that return a list from a database of national parks or state parks with full CRUD functionality.

!["Picture of pine trees"](ReadMeAssets/pines.jpg)

## Setup/Installation Requirements

<details>

Software Requirements
* An up to date internet browser 
* <a href="https://dotnet.microsoft.com/download">.NET Core</a> 
* Code editor such as <a href="https://code.visualstudio.com/">Visual Studio Code</a>
* <a href="https://dev.mysql.com/downloads/workbench/">MySQL Workbench</a>
* <a href="https://www.postman.com/downloads/">Postman</a> (Optional)

Install Dotnet Script
* In the terminal, run this command `dotnet tool install -g dotnet-script`

Open by Downloading or Cloning
* From this link <https://github.com/POsten040/ParkServiceApi>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository with `git clone `

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `Library` directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=parkapi;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

</details>

## Launching the Application
* Navigate to the ParkService.Soliution/ParkServiceApi directory and type `dotnet restore` into the terminal
* Then, in the same project folder, type `dotnet ef database update` to create the database. 
* To open in your browser type `dotnet run` 

## Api Documentation
* View Swagger Docs by running the application and going to this URL: `http://localhost:5000/swagger/index.html`
  - See [Swagger](https://swagger.io/tools/swagger-ui/) for more info on using the Swagger UI
<br>
* EndPoints Structure:
  - GET /api/{component} 
    - returns all components
  - GET /api/{component}/?{Property} = {search string} 
    - returns specific components based on search string
  - GET /api/{component}/{id}
    - return specific component based on id 
  - POST /api/{component}
    - create new component
  - PUT /api/{component}/{id}
    - alters specific component based on id
  - DELETE /api/{component}/{id}
    - removes component from database

<details>
<summary><strong>Specific Endpoints</strong></summary>

* EndPoints for National Parks:
  - GET /api/nationalparks 
    - returns all national parks
  - GET /api/nationalparks/?Region = {search string} 
    - returns specific national parks based on region
  - GET /api/nationalparks/?Name = {search string} 
    - returns specific national parks based on name
  - GET /api/nationalparks/{id}
    - return specific national parks based on id 
  - POST /api/nationalparks
    - create new national parks
  - PUT /api/nationalparks/{id}
    - alters specific national parks based on id
  - DELETE /api/nationalparks/{id}
    - removes national park from database based on id

* EndPoints for State Parks:
  - GET /api/stateparks 
    - returns all state parks
  - GET /api/stateparks/?Name = {search string} 
    - returns specific state parks based on Name
  - GET /api/stateparks/{id}
    - return specific state parks based on id 
  - POST /api/stateparks
    - create new state parks
  - PUT /api/stateparks/{id}
    - alters specific state parks based on id
  - DELETE /api/stateparks/{id}
    - removes state park from database based on id
    <br>
</details>

| Example Query                                              | Type Of Request | Expected OutPut                                                                                                                                                                                                      |
|------------------------------------------------------------|-----------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `https://localhost:5000/api/nationalparks/1`           | GET             | ` {     "nationalParkId": 1,     "name": "YellowStone",     "region": "Mid-West" } `                                                                                                                           |
| `http://localhost:5000/api/nationalparks/?Region=East-Coast` | GET             | `[     {         "nationalParkId": 3,         "name": "Blue Ridge",         "region": "East-Coast"     },     {         "nationalParkId": 4,         "name": "Patrick's Park",         "region": "East-Coast"     } ]` |
|                                                            |                 |                                                                                                                                                                                                                      |
* NOTE - CORS in enable in this Api and accepts cross origin resource sharing with one specific URL ""http://www.contoso.com". This was for learning purposes and should not affect the normal operation of the Api.
## User Stories
<details>

| User Stories                                                                                                                                                                                                                                                               |   |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---|
| The application should let users look up a list of national parks.                                                                                                                               |   |                                                                                                    
</details>
<br>
## Known Bugs

-none

## Support and contact details

Patrick Osten at <posten.coding@gmail.com> 

## Technologies Used

* C#
* Postman
* Entity Framework Core
* MySql Workbench
* .NET Core
* Swagger
* CORS

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Patrick Osten_**