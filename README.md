# Event Registration System

This project is a web-based Event Registration System developed using ASP.NET Core Razor Pages, C#, and SQLite with Entity Framework Core. It is designed to efficiently manage events and student registrations, providing a seamless and responsive user experience.

## Overview

The application enables users to perform full CRUD (Create, Read, Update, Delete) operations for events and manage student registrations. Students can be registered for specific events with their essential details, such as name, ID, and email. The system ensures data persistence through a SQLite database, managed via Entity Framework Core, and features a clean, responsive user interface built with the standard ASP.NET Core Razor Pages template.

## Key Features

* **Event Management**: Complete CRUD functionality for events.
    * **Create**: Add new events with details like title, date, and description.
    * **Read**: View a list of all available events.
    * **Update**: Edit the details of existing events.
    * **Delete**: Remove events from the system.
* **Student Registration**:
    * Register students for events with their Name, Student ID, and Email.
    * View the list of students registered for each event.
* **Responsive UI**: A user-friendly and responsive interface that works on various devices, built with the ASP.NET Core Razor Pages template.
* **Data Persistence**: All data is stored in a **SQLite** database, ensuring that information is saved reliably.
* **Asynchronous Operations**: Utilizes asynchronous data handling to ensure the application is fast and responsive, preventing UI freezes during database operations.
* **Page-Based Routing**: Simple and intuitive navigation using the Razor Pages routing model.
* **Database Migrations**: Managed by **Entity Framework Core** to easily update the database schema as the application evolves.

## Technology Stack

* **Framework**: ASP.NET Core Razor Pages
* **Language**: C#
* **Database**: SQLite
* **ORM**: Entity Framework Core
* **Development Environment**: Visual Studio Code

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download) (Version compatible with the project)
* [Visual Studio Code](https://code.visualstudio.com/)
* [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) extension

### Installation & Setup

1.  **Clone the repository:**
    ```sh
    git clone [https://github.com/gvraghav1729/Event-Registration.git](https://github.com/gvraghav1729/Event-Registration.git)
    cd Event-Registration
    ```

2.  **Restore .NET dependencies:**
    This command will download and install all the necessary packages defined in the project file.
    ```sh
    dotnet restore
    ```

3.  **Update the database:**
    Entity Framework Core migrations are used to set up the database schema. Run the following command to apply the migrations and create the SQLite database file.
    ```sh
    dotnet ef database update
    ```

4.  **Run the application:**
    This command will build and run the project.
    ```sh
    dotnet run
    ```

5.  **Access the application:**
    Open your web browser and navigate to `https://localhost:5001` or `http://localhost:5000` (the port may vary; check the terminal output).

## Usage

Once the application is running, you can perform the following actions:

* **View Events**: The home page will display a list of all created events.
* **Create an Event**: Click on the "Create New" button on the events page to add a new event.
* **Edit/Delete an Event**: From the event list, you will find options to edit or delete each event.
* **Register a Student**: Select an event and you will find an option to register a new student for that event. You'll need to provide the student's name, ID, and email.

## Database Migrations

The database schema is managed using Entity Framework Core migrations. When you make changes to the model classes (in the `Models` folder), you need to create a new migration and apply it to the database.

* **To create a new migration:**
    ```sh
    dotnet ef migrations add YourMigrationName
    ```
* **To apply the migration to the database:**
    ```sh
    dotnet ef database update
    ```

This project was developed and tested in **Visual Studio Code**, showcasing proficiency in full-stack web development, from backend logic and database integration to frontend presentation.
