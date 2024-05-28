# Employee Management System File Descriptions

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
