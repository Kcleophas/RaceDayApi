# 🏁 RaceDay Event Management API
## Programming 2B – Part 2 Portfolio of Evidence (POE)

---

## 👨‍🎓 Student Information

| Detail | Information |
|----------|-------------|
| Student Name | Kezia Cleophas |
| Student Number | ST10483194 |
| Module | Programming 2B |
| Assessment | Part 2 Portfolio of Evidence |
| Project | RaceDay Event Management API |


---

# 📖 Project Overview

The RaceDay Event Management API was developed as Part 2 of the Programming 2B Portfolio of Evidence (POE). The project demonstrates the implementation of a RESTful Web API using ASP.NET Core and Entity Framework Core.

The purpose of the system is to provide race event organisers and participants with a platform for managing race events, categories, enrolments, race results, and user accounts.

The application incorporates database management, authentication, CRUD operations, API documentation, unit testing, and Continuous Integration (CI/CD) using GitHub Actions.

This project demonstrates practical software development skills including database design, API development, testing, version control, and deployment automation.

---

# 🎯 Part 2 Requirements Implemented

# ⭐ Key Features

- User Registration
- User Login
- Event Management
- Category Management
- Participant Enrolments
- Race Results
- Swagger API Documentation
- Unit Testing
- GitHub Actions CI/CD

---

# 🛠 Technologies Used

## Development Tools

- Visual Studio 2026
- SQL Server Management Studio
- GitHub Desktop
- GitHub Actions

---

# 🚀 Development Process

## Create the ASP.NET Core Web API

The project was created using the ASP.NET Core Web API template in Visual Studio.

The solution was organised into:

- Controllers
- Models
- DTOs
- Services
- Data
- Migrations

---

## Configure the Database

Entity Framework Core was configured using SQL Server.

Database migrations were generated and applied to create the required database tables.

Commands used:

```powershell
Add-Migration InitialCreate
Update-Database
```

---

## Create Models

The following models were created:

### User
Stores organiser and participant information.

### Category
Stores race categories.

### Event
Stores race event information.

### Enrolment
Stores participant registrations for events.

### Result
Stores race results and finishing positions.

---

## Create DTOs

DTOs (Data Transfer Objects) were implemented to separate API requests from database entities.

Examples include:

- RegisterDTO
- LoginDTO
- EventDTO
- CategoryDTO
- EnrolmentDTO
- ResultDTO

---

## Create Controllers

Controllers were developed to expose REST API endpoints.

Implemented controllers include:

- AuthController
- UsersController
- EventsController
- CategoriesController
- EnrolmentsController
- ResultsController

---

## Implement Authentication

Authentication functionality was implemented to allow users to:

- Register accounts
- Log into the system
- Access RaceDay API functionality

Endpoints:

```http
POST /api/Auth/register
POST /api/Auth/login
```

---

# 📋 API Endpoints

## Authentication

```http
POST /api/Auth/register
POST /api/Auth/login
```

## Categories

```http
GET /api/Categories
POST /api/Categories
DELETE /api/Categories/{id}
```

## Events

```http
GET /api/Events
GET /api/Events/{id}
POST /api/Events
DELETE /api/Events/{id}
```

## Enrolments

```http
GET /api/Enrolments
POST /api/Enrolments
```

## Results

```http
GET /api/Results
POST /api/Results
```

## Users

```http
GET /api/Users
```

---

# 📸 Evidence of Successful Implementation

## Swagger Documentation

Swagger UI was used to document and test all API endpoints during development.

![Swagger UI](https://github.com/Kcleophas/RaceDayApi/blob/main/RaceDay.Api/Screenshoots/Swagger%20UI.png)

**Figure 1:** Swagger documentation displaying all implemented API endpoints including Authentication, Categories, Events, Enrolments, Results, and Users.

---

## Unit Testing

Unit testing was implemented using xUnit to verify application functionality.

### Benefits of Unit Testing

- Improves reliability
- Detects bugs early
- Verifies functionality
- Supports maintainability

![Unit Tests](https://github.com/Kcleophas/RaceDayApi/blob/main/RaceDay.Api/Screenshoots/Unit%20Test.png)

**Figure 2:** Successful execution of all unit tests showing 5 tests passed and 0 failures.

---
### Swagger Benefits

- Endpoint testing
- API documentation
- Request validation
- Faster debugging

---

## GitHub Actions Continuous Integration

GitHub Actions was configured to automatically:

1. Restore project dependencies
2. Build the application
3. Execute unit tests

whenever code is pushed to the repository.

Workflow file location:

```text
.github/workflows/dotnet.yml
```

![GitHub Actions](https://github.com/Kcleophas/RaceDayApi/blob/main/RaceDay.Api/Screenshoots/GitHub%20Actions.png)

**Figure 3:** Successful GitHub Actions workflow execution showing a completed CI/CD pipeline.

---

# 🧪 Unit Testing

The project includes automated tests using xUnit.

Tests cover:

- User Registration
- User Login
- Event Creation
- Event Deletion
- Validation Logic

Run tests using:

```bash
dotnet test
```

Expected Result:

```text
5 Tests Passed
0 Failed
```

---

# 📂 Project Structure

```text
RaceDayApi
│
├── Controllers
├── Models
├── DTOs
├── Services
├── Data
├── Migrations
├── Screenshots
│   ├── Swagger UI.png
│   ├── Unit Test.png
│   └── GitHub Actions.png
│
├── Program.cs
├── appsettings.json
├── README.md
└── RaceDay.sln
```

---

# ⚙ Running the Application

## Clone the Repository

```bash
git clone https://github.com/Kcleophas/RaceDayApi.git
```

## Open the Solution

Open the project in Visual Studio.

## Restore Packages

```bash
dotnet restore
```

## Apply Database Migrations

```powershell
Update-Database
```

## Run the Application

```bash
dotnet run
```

## Launch Swagger

```text
https://localhost:7067/swagger
```

Swagger will automatically display all available endpoints.

---

# 🔄 Continuous Integration (CI/CD)

GitHub Actions was implemented to automate:

- Dependency Restoration
- Application Build
- Unit Testing

This ensures code quality and verifies that the application builds successfully whenever changes are pushed to GitHub.

---

# 🎥 Video Demonstration

A complete demonstration of the RaceDay Event Management API can be viewed below:

🔗 **YouTube Demonstration:**

[Watch the RaceDay Part 2 Demonstration](PASTE-YOUR-YOUTUBE-LINK-HERE)

The demonstration includes:

- Project Overview
- Database Design
- Authentication
- Swagger Testing
- Event Management
- Category Management
- Enrolments
- Results
- Unit Testing
- GitHub Repository
- GitHub Actions Workflow

---

# 🔗 GitHub Repository

Repository Link:

https://github.com/Kcleophas/RaceDayApi

---


## 🏆 Conclusion

The RaceDay Event Management API was successfully developed using ASP.NET Core Web API, Entity Framework Core, SQL Server, Swagger UI, xUnit, GitHub, and GitHub Actions.

The project demonstrates the successful implementation of RESTful API principles, database integration, authentication, testing, and continuous integration practices. All core requirements for Programming 2B Part 2 have been completed and validated through testing and automated builds.

This project successfully satisfies the requirements of Programming 2B Part 2 and demonstrates practical software development skills using modern Microsoft technologies.
