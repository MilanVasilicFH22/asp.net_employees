# Employee Management System File Descriptions

## Overview Basics
This is an ASP.NET Core Web Application built using the Model View Controller (MVC) design pattern. It provides functionalities for managing employee data, including creating, reading, updating, and deleting employee records.

Start in Visual Basic an ASP.NET Core Web Application (Model View Controller) Project.

## Supported Platforms

The application supports the following platforms:

- C#
- Linux
- macOS
- Windows
- Cloud
- Dienst
- Web

## Database

The application uses SQLite as its database system. The configuration for the database connection can be found in the `appsettings.json` file. By default, the connection string is set to use a local SQLite database file named `test1.db`.

## Testing

The application includes unit tests for the `Person` class, ensuring its methods and properties function correctly. The tests are written using the `unittest` framework and are located in the `test_person.py` file. These tests cover the following functionalities:

- Initialization of a `Person` object.
- Retrieval of the forename and surname.
- Celebration of a birthday, which increments the age.
- Adding job titles to the `jobs` list.

## Controllers

### HomeController.cs
- **Namespace**: `EmployeeManagement.Controllers`
- **Purpose**: Handles requests for the home and error pages.
- **Key Methods**:
  - `Index()`: Returns the home page view.
  - `Privacy()`: Returns the privacy policy page view.
  - `Error()`: Returns the error page view with error details.

### EmployeeController.cs
- **Namespace**: `EmployeeManagement.Controllers`
- **Purpose**: Manages CRUD operations for employees.
- **Key Methods**:
  - `Index()`: Retrieves and displays a list of all employees.
  - `Delete(int id)`: Deletes an employee by ID.
  - `Create() [GET]`: Returns the view for creating a new employee.
  - `Create(Employee employee) [POST]`: Handles the form submission for creating a new employee.

## Models

### Employee.cs
- **Namespace**: `EmployeeManagement.Models`
- **Purpose**: Defines the Employee entity.
- **Properties**:
  - `int ID`: The unique identifier for an employee.
  - `string Prename`: The first name of an employee.
  - `string Lastname`: The last name of an employee.

### ErrorViewModel.cs
- **Namespace**: `EmployeeManagement.Models`
- **Purpose**: Model for error handling.
- **Properties**:
  - `string? RequestId`: The request identifier.
  - `bool ShowRequestId`: Indicates whether the request identifier should be shown.

## Data

### EmployeeContext.cs
- **Namespace**: `EmployeeManagement.Data`
- **Purpose**: Database context for managing employee data using Entity Framework Core.
- **Key Components**:
  - `DbSet<Employee> Employees`: Represents the Employees table in the database.
  - `OnModelCreating(ModelBuilder modelBuilder)`: Configures the model and maps the `Employee` entity to the `Employee` table.

## Configuration

### appsettings.json
- **Purpose**: Configuration file for logging and database connections.
- **Key Sections**:
  - `Logging`: Configuration for logging levels.
  - `AllowedHosts`: Specifies the hosts allowed to access the application.
  - `ConnectionStrings`: Contains the connection string for the `EmployeeContext` database.

## Views

### index.cshtml
- **Purpose**: View for listing all employees.

### Create.cshtml
- **Purpose**: View for creating a new employee.

### Details.cshtml
- **Purpose**: View for displaying employee details.
