<<<<<<< HEAD
# Blazor-User-Experience

## Overview of the project:

The project aims to develop a web application using Blazor for the frontend and .NET 8 for the backend API, with SQL Server 2022 as the database. The application will feature user registration, login, and a dashboard 
accessible after login. Key features include form validation, secure password storage, OTP mechanism for registration, and user photo upload.

## Tools Utilized in this project

| Content                | Link                                                                        |
| -------------------    | ----------------------------------------------------------------------------|
| Microsoft SQL SERVER   | [Click here](https://www.microsoft.com/en-in/sql-server/sql-server-downloads)    |
| Visual Studio Code 2022| [Click here ](https://visualstudio.microsoft.com/downloads/)   
| DotNet 8               | [Click here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
| PostMan                | [Click here](https://www.postman.com/downloads/)  

## Features

### User Management:

- Registration, logIn.
- Profile management (Image, details)

## Technologies Used

- Frontend: Blazor (Blazor WebAssembly for client-side rendering)
- Backend: .NET 8 Web API
- Database: SQL Server 2022

## Archietecture
-The frontend will be developed using Blazor WebAssembly for its capability to run client-side in the browser. The backend will consist of a .NET 8 Web API, providing 
 RESTful endpoints for user registration, login, and fetching user details. SQL Server 2022 will be used to store user data.


## Instructions for setting up and running the project locally:

1. **Software and dependencies installation:**
   
   - Install .NET 8 SDK for backend development.
   - Install Blazor WebAssembly for frontend development.
   - Create Blazor Web App from Visual Studio Code 2022.
   - Choose Auto(Server and WebAssembly) for the server-side and client-side architecture
   - Set up SQL Server 2022 locally or connect to an existing instance.
   
3. **Setting up the SQL Server database:**
   
   - Create a database named 'UserDB' (or any preferred name).
   - Run the SQL script provided in the project repository to create the necessary tables (users table, etc.).
   - Configure the database connection string in the backend API project's appsettings.json file.
   - To run the project Click on the "Start Without Debugging(Ctrl + F5).

4. **Additional configuration steps or prerequisites:**

   - Set environment variables for any sensitive information such as API keys or database credentials.
   - Ensure that the necessary packages and dependencies are installed using the package manager console (dotnet restore).


## Cloning the repository and installing dependencies entails fetching a local copy of the project codebase from the remote Git repository and configuring the requisite software components.

1. **Clone the repository:**

    ```bash
    git clone https://github.com/0Rohit2022/BlazorUserExperience.git
    ```
2. **Install dependencies or packages:**

    ```bash
    BCrypt.Net-Core
    Blazored.SessionStorage
    Microsoft.EntityFrameWorkCore
    Microsoft.AspNetCore
    etc..
    ```

📺🐦🔧📊🔍🚀
