# Student Task Tracker

A modern Task Management Web Application built using ASP.NET Core Blazor and SQLite.

## Features

- User Authentication (Signup/Login)
- Multi-user Task Management
- Add, Edit, Delete Tasks
- Task Completion Tracking
- Completed & Pending Filters
- Task Search Functionality
- Dark Mode Support
- SweetAlert Validation Messages
- SQLite Database Integration
- Responsive UI using Bootstrap

---

## Technologies Used

- ASP.NET Core Blazor (.NET 8)
- Entity Framework Core
- SQLite
- Bootstrap 5
- SweetAlert2
- C#
- Razor Components

---

## Project Structure

```text
StudentTaskTracker
│
├── Components
├── Data
├── Models
├── Services
├── Migrations
├── wwwroot
├── Program.cs
├── appsettings.json
├── studenttasks.db
└── Dockerfile
```

---

## Database

This project uses SQLite database.

Database file:

```text
studenttasks.db
```

Tables:
- Users
- Tasks

---

## Authentication

Users can:
- Create account using Email & Password
- Login securely
- Manage their own tasks independently

Each user can only view their own tasks.

---

## Task Features

- Add new tasks
- Edit task title, due date, and priority
- Delete tasks
- Mark tasks as completed
- Undo completed tasks
- Search tasks
- Filter:
  - All
  - Completed
  - Pending

---

## UI Features

- Responsive design
- Modern card-based UI
- Dark mode toggle
- SweetAlert popup validation
- Clean Bootstrap styling

---

## Setup Instructions

### 1. Clone Repository

```bash
git clone https://github.com/Nuthan-27/StudentTaskTracker.git
```

---

### 2. Open Project

Open in:
- Visual Studio 2022

---

### 3. Restore Packages

```bash
dotnet restore
```

---

### 4. Run Application

```bash
dotnet run
```

---

## Default Framework

```text
.NET 8
```

---

## NuGet Packages

- Blazored.LocalStorage
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Tools

---

## Screenshots

### Login Page
- Email validation
- Password visibility toggle

### Task Dashboard
- Add Task
- Search Task
- Task Filters
- Statistics Cards
- Dark Mode

---

## Future Enhancements

- Email Notifications
- Task Categories
- Task Priority Sorting
- Calendar Integration
- Cloud Database Hosting
- JWT Authentication

---

## Author

Nuthan A M

GitHub:
https://github.com/Nuthan-27

---

## License

This project is developed for learning and educational purposes.
