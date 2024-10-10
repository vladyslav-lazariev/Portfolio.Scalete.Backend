# Back-end API for [Scalete's front-end project "Portfolio"](https://github.com/Scalete/new_portfolio)

Backend API for managing portfolio data. Developed using ASP.NET Core and Entity Framework Core.

## Technologies

- ASP.NET Core 7.0
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI
- AutoMapper

## Main features

- ✨ Project management
- 📊 Skill management
- 💼 Experience management
- 📬 Contact form

## Installation and launch

1. Clone the repository
```bash
git clone https://github.com/vladyslav-lazariev/Portfolio.Scalete.Backend.git
```

2. Configure the connection string in `appsettings.json`

3. Apply migrations
```bash
dotnet ef database update
```

4. Run the project
```bash
dotnet run
```

The API will be available at `https://localhost:5001`

## API Documentation

Swagger documentation is available at `/swagger` after the project launch.

## Development

This project is developed as part of a portfolio system for web developer [Scalete](https://github.com/Scalete). The API provides backend functionality for the frontend part of his portfolio. You can find the project at the following link: [GitHub Repository](https://github.com/Scalete/new_portfolio).

## License

MIT

## Author

Vladyslav Lazariev
