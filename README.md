
# Dynamic Database Viewer in C# (.NET)

## Overview

This project is a dynamic database viewer application developed in C# using the .NET Framework. It leverages dynamic coding techniques to provide flexibility and adaptability for different database environments. By modifying the connection string, the application seamlessly integrates with any supported database.

The current setup is configured for SQL Server Express 2022.

## Features

- **Dynamic Connection String**: Easily adaptable to SQL Server Express 2022 by updating the connection string.
- **Table Discovery**: Automatically retrieves all table names from the connected SQL Server Express 2022 database.
- **Dynamic UI Generation**: Creates buttons dynamically for each table, allowing users to interact with database tables directly.
- **Data Visualization**: Displays the content of a selected table in the center of the form upon button click.
  
### Dual Button Modes:
- **Mode 1**: Utilizes only the View and Controller layers, bypassing the Model layer.
- **Mode 2**: Implements a full MVC (Model-View-Controller) architecture, incorporating a Service layer for enhanced modularity and maintainability.

## Technologies Used

- **Programming Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Database Support**: SQL Server Express 2022 (via connection string configuration)

## Usage Instructions

1. Update the connection string in the configuration file to point to your SQL Server Express 2022 instance.
2. Run the application to dynamically generate buttons for all available tables in the connected database.
3. Click on any table button to display its contents in the main view.
4. Choose between the two button modes for different architectural approaches:
   - **Mode 1**: Direct interaction without the Model layer.
   - **Mode 2**: Full MVC with a Service layer.

## Architecture

### Mode 1 (Controller and View Only)
- Minimalistic approach for quick table data rendering.
- Suitable for simpler use cases with limited functionality.

### Mode 2 (MVC with Service)
- Implements a structured design for scalability and modularity.
- Leverages the Model for data representation, Controller for business logic, View for UI, and Service for abstraction of database operations.

## Future Improvements

- Enhance UI/UX for better usability and visualization.
- Add support for more database operations like filtering, sorting, and editing records.
- Implement logging and error handling mechanisms.
- Integrate authentication and role-based access control for secure usage.

## License

This project is distributed under the apache 2.0 License.
