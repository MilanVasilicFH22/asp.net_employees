Employee Management System
Overview
This project is an Employee Management System built using ASP.NET Core MVC and Entity Framework Core. It provides basic CRUD (Create, Read, Update, Delete) functionalities to manage employee records.

Table of Contents
Prerequisites
Installation
Configuration
Usage
Project Structure
Contributing
License
Prerequisites
.NET 6.0 SDK
Entity Framework Core
A database system (SQLite is used in this project)
Installation
Clone the repository:

bash
Code kopieren
git clone https://github.com/your-username/employee-management-system.git
cd employee-management-system
Restore the dependencies:

bash
Code kopieren
dotnet restore
Update the database:

bash
Code kopieren
dotnet ef database update
Run the application:

bash
Code kopieren
dotnet run
Configuration
The application uses an appsettings.json file for configuration settings. Below is the configuration used for database connection and logging:

json
Code kopieren
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "EmployeeContext": "Data Source=test1.db"
  }
}
Ensure you have the correct connection string for your database.

Usage
After running the application, you can perform the following actions through the web interface:

View Employees: Navigate to /Employee to see the list of all employees.
Add Employee: Click on "Create New" to add a new employee.
Edit Employee: Click on "Edit" next to an employee to update their details.
Delete Employee: Click on "Delete" next to an employee to remove them.
Project Structure
Controllers

HomeController.cs: Handles requests for the home and error pages.
EmployeeController.cs: Manages CRUD operations for employees.
Models

Employee.cs: Defines the Employee entity.
ErrorViewModel.cs: Model for error handling.
Data

EmployeeContext.cs: Database context for managing employee data using Entity Framework Core.
Views

Home
Index.cshtml: Home page view.
Privacy.cshtml: Privacy policy page view.
Employee
Index.cshtml: View for listing all employees.
Create.cshtml: Form for creating a new employee.
Details.cshtml: View for displaying employee details.
Configuration

appsettings.json: Configuration file for logging and database connections.
