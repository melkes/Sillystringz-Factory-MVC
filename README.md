# Dr. Sillystringz's Factory
#### By Mike Wilkes
#### A C# MVC application for a factory manager to view and manage lists of the factory's engineers and machines

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

- If you do not have MySQL Workbench, download it [here](https://dev.mysql.com/downloads/workbench/), install, and open.
- Clone this repository
### In MySQL Workbench:
- In the Navigator > Administration window, select Data Import/Restore.

- In Import Options select Import from Self-Contained File.

- Select the mike_wilkes.sql file from this repository

- Under Default Schema to be Imported To, select the New button.

- Enter a name for this database, eg mike_wilkes.
- Click Ok.
- Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
### In VS Code:
- Open this directory
- Create a .gitignore file in the project folder with the contents:
  `obj`<br>
  `bin`<br>
  `appsettings.json`

- Navigate to the HairSalon directory
- Create an appsettings.json file with the following contents, replacing the values inside brackets [] with your own:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

- In a terminal window, run:
  - `dotnet restore`
  - `dotnet build`
  - `dotnet run`
- You may be asked to enter your system password
- In a web browser, navigate to https://localhost:5001/

## Known Bugs

The application is not currently functional because the views are not completed, and possibly something to do with ASP.NET Core development certificates.

## License

MIT License

Copyright (c) _2023_ _Mike Wilkes_