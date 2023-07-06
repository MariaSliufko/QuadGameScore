
# QuadGameScore App

QuadGameScore is a Blazor application built with ASP.NET Core Blazor and Blazorise Component Library. It is designed to keep track of the score in a 4-event competition. The application allows users to manage players, events, and assign scores to players for specific events. At the end of the competition, the app determines the winners and displays them on a final screen.

## Technologies Used

- C#
- .NET Core 6.0
- Blazor (ASP.NET Core Blazor)
- Blazorise Component Library
- Visual Studio (IDE)
- Microsoft.EntityFrameworkCore.InMemory (Database)

## Functionality

The QuadGameScore app provides the following functionality:

- Player Management:
  - Add a new player with a name and age.
  - Remove an existing player.

- Event Management:
  - Add a new event (game).
  - Remove an existing event.

- Score Assignment:
  - Assign scores to players for specific events.

- Competition Completion:
  - Calculate the winners based on the overall scores.
  - Display the top 3 players on a final screen.

## Database

The application uses the Microsoft.EntityFrameworkCore.InMemory database provider for storing data in memory. This allows for quick and easy development and testing without the need for an external database setup.

## Getting Started

To run the QuadGameScore app, follow these steps:

1. Install the latest version of Visual Studio (or any preferred IDE) and .NET Core 6.0 SDK.
2. Clone the repository: `git clone https://github.com/your-username/QuadGameScore.git`
3. Open the project in Visual Studio.
4. Build and run the application.

## Project Structure

The project follows a standard Blazor project structure:

- `Pages`: Contains the Blazor pages for player management, event management, score assignment, and the final screen.
- `Data`: Contains the data access layer and repository for interacting with the in-memory database.
- `Models`: Contains the data models for players, events, and scores.
- `Services`: Contains additional services and utilities used in the application.

## Contributing

Contributions to the QuadGameScore app are welcome. If you find any bugs, have suggestions for improvements, or would like to add new features, please feel free to open an issue or submit a pull request.

## License

The QuadGameScore app is released under the [MIT License](https://opensource.org/licenses/MIT).

## Acknowledgments

- Blazor Documentation: [ASP.NET Core Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/)
- Blazorise Component Library: [Blazorise](https://blazorise.com/)
- Microsoft.EntityFrameworkCore.InMemory: [Microsoft.EntityFrameworkCore.InMemory](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.InMemory)

---

