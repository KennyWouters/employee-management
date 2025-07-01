# Employees Management API

A RESTful API for managing employees, built with ASP.NET Core 9, Entity Framework Core, and SQL Server. This project provides endpoints to create, read, update, and delete employee records, and is ready for local development with Docker support for the database.

## Features
- CRUD operations for employees
- ASP.NET Core 9 Web API
- Entity Framework Core with SQL Server
- OpenAPI/Swagger documentation
- CORS enabled for frontend integration (default: http://localhost:4200)
- Docker Compose for SQL Server setup

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Docker](https://www.docker.com/products/docker-desktop) (for local SQL Server)

### Setup
1. **Clone the repository:**
   ```bash
   git clone <your-repo-url>
   cd EmployeesManagement
   ```
2. **Start SQL Server with Docker:**
   ```bash
   docker-compose up -d
   ```
   This will start a SQL Server instance on `localhost:1433` with the credentials in `docker-compose.yml`.

3. **Update the connection string (if needed):**
   The default connection string is in `appsettings.Development.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=127.0.0.1,1433;Database=employeesmanagement;User Id=SA;Password=P@ssw0rd!;TrustServerCertificate=True"
   }
   ```

4. **Apply migrations:**
   ```bash
   dotnet ef database update
   ```

5. **Run the API:**
   ```bash
   dotnet run
   ```
   The API will be available at `https://localhost:7025` (or as configured).

6. **OpenAPI/Swagger UI:**
   Visit `https://localhost:7025/swagger` (if enabled in development) to explore and test the API.

## API Endpoints

| Method | Endpoint                  | Description                |
|--------|---------------------------|----------------------------|
| GET    | /api/employee             | Get all employees          |
| GET    | /api/employee/{id}        | Get employee by ID         |
| POST   | /api/employee             | Create a new employee      |
| PUT    | /api/employee/{id}        | Update an employee         |
| DELETE | /api/employee/{id}        | Delete an employee         |

### Example Employee Object
```json
{
  "id": 1,
  "firstName": "John",
  "lastName": "Doe",
  "email": "john.doe@example.com",
  "phoneNumber": "123-456-7890",
  "position": "Developer"
}
```

### Example Requests
#### Get all employees
```http
GET /api/employee
```
#### Get employee by ID
```http
GET /api/employee/1
```
#### Create employee
```http
POST /api/employee
Content-Type: application/json

{
  "firstName": "Jane",
  "lastName": "Smith",
  "email": "jane.smith@example.com",
  "phoneNumber": "555-1234",
  "position": "Manager"
}
```
#### Update employee
```http
PUT /api/employee/2
Content-Type: application/json

{
  "id": 2,
  "firstName": "Jane",
  "lastName": "Smith",
  "email": "jane.smith@company.com",
  "phoneNumber": "555-5678",
  "position": "Senior Manager"
}
```
#### Delete employee
```http
DELETE /api/employee/2
```

## Database
- Uses SQL Server (local via Docker/Podman or your own instance)
- Employee table columns: `Id`, `FirstName`, `LastName`, `Email`, `PhoneNumber`, `Position`

## Project Structure
- `Controllers/` - API controllers
- `Models/` - Data models
- `Repositories/` - Data access layer
- `Data/` - EF Core DbContext
- `Migrations/` - Database migrations

## CORS
CORS is enabled for `http://localhost:4200` by default. Update in `Program.cs` if your frontend runs elsewhere.

## License

