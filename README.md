# Dr. Sillystringz's Factory
#### By Mike Wilkes
#### A C# MVC application for a factory manager to view and manage lists of the factory's engineers and machines
<img src="./Dr__Sillystringz.jpg" alt="Image of the factory" width="500" /><br>

## Technologies Used

- C#
- ASP.NET Core MVC
- MySQL
- Razor
- HTML
- Git

## Description

This is a web application that creates a website using the MVC framework and a MySQL database to manage and display data. It is designed for a factory manager to view and manage lists of the factory's engineers and machines. It allows you to select an engineer to view a list of the machines they are licensed to use, and likewise you can select a machine and view all engineers that may work on it. Users can also add, edit, and delete engineers and machines from the database.
## Setup instructions
- Clone this repository and open in VS Code
- Create a .gitignore file in the project folder with the contents:<br>
  `obj`<br>
  `bin`<br>
  `appsettings.json`<br>
  `launchSettings.json`<br>
  `.DS_Store`<br>

- Navigate to the Factory directory
- Create an appsettings.json file with the following contents, replacing the values inside brackets [] with your own:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

In order to use dotnet-ef, you also need to install the Microsoft.EntityFrameworkCore.Design package. Within Factory folder of the app, run the following command:
```
$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
* Run database migrations to create the needed database tables:
`dotnet ef database update`

- In a terminal window, run:
  - `dotnet restore`
  - `dotnet build`
  - `dotnet run`
- You may be asked to enter your system password
- In a web browser, navigate to https://localhost:5001/ if it does not open automatically.

## Known Bugs
None at this time.

## Project Roadmap
Future features could include:
* Multiple specific details rather just a details or hire date field (e.g. dates of machine purchase and training, specifiying department/production line, etc.)
* Styling

## License

MIT License

Copyright (c) _2023_ _Mike Wilkes_