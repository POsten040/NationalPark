#  National Park Api

#### By _**Patrick Osten**_

![](ReadMeAssets/recording.gif)

## Description
- This application was made as part of the Epicodus Coding bootcamp coursework.
- It allows users to make api calls that return a list of national parks with full CRUD functionality.

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
* 

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

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Patrick Osten_**