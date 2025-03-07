# MyMvcApp

MyMvcApp is an ASP.NET Core MVC application.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) 3.1 or later
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/MyMvcApp.git
    cd MyMvcApp
    ```

2. Restore the dependencies:
    ```sh
    dotnet restore
    ```

### Running the Application

1. Build the project:
    ```sh
    dotnet build
    ```

2. Run the project:
    ```sh
    dotnet run
    ```

3. Open your browser and navigate to `https://localhost:5001`.

### Project Structure

- `Controllers/` - Contains the MVC controllers.
- `Models/` - Contains the data models.
- `Views/` - Contains the Razor views.
- `wwwroot/` - Contains static files.

### Database Configuration

The database context is configured in [`AppDbContext`](Models/AppDdContext.cs). Update the connection string in `appsettings.json` as needed.

### License

This project is licensed under the MIT License.
