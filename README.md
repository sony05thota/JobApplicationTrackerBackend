# Job Application Tracker

This project consists of a **backend** built with ASP.NET Core Web API and a frontend developed using Angular16. 
Do not forget to install EF in your machine and connect to your local SQL database
****In your  appsettings.json/localsettings do not forget to add "ConnectionStrings" with your server and DB name and any credentials if required

"ConnectionStrings": {
        "DefaultConnection": "Server=YOURServerName;Database=JobApplicationTrackerDb;"
    },


- **Backend**: 
  - The backend is a RESTful API that uses **ASP.NET Core Web API.
  - The backend uses **Entity Framework Core** with sqlserver database.
  - The API URL is configurable through the `environment.ts` file in the Angular.

- **Frontend**: 
  - The frontend is built using Angular 16+.
  - The frontend uses HttpClient to communicate with the backend API.
  - The user interface is responsive, with a simple and clean table to display the list of job applications.
  - The application supports pagination and uses Angular Material for a formal design.

  ## Assumptions
- The backend and frontend are running on localhost on default ports (https://localhost:7178 for backend and http://localhost:4200 for frontend).

The Job Application data is simple and has attributes like Company Name, Position, Status, and Date Applied.