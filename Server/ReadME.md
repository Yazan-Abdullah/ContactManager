# Blazor Contact Manager

This project is a Blazor WebAssembly Progressive Web App (PWA) that allows users to perform CRUD operations on a contact list. It's built with .NET 6 and features sorting capabilities, in-memory data storage, and offline access.

## Features

- **Create**: Add new contacts with validation to ensure all required fields are filled.
- **Read**: View a list of all contacts on the main page with options to see detailed views.
- **Update**: Edit existing contact information using a form populated with the contact's current details.
- **Delete**: Remove contacts with confirmation prompts to prevent accidental deletions.
- **Sort**: Organize the contact list by various fields such as First Name and Last Name in both ascending and descending orders.
- **Offline Access**: Access and interact with the application even without an internet connection.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Ensure you have the following installed:
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- An IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) with the C# extension.

### Installation

1. **Clone the Repository**

    ```bash
    git clone https://github.com/Yazan-Abdullah/ContactManager.git
    cd ContactManager
    ```

2. **Navigate to the Project Directory**

    ```bash
    cd ContactManager
    ```

3. **Run the Application**

    ```bash
    dotnet run
    ```

    This will start the application on `https://localhost:7089/`. Open this URL in a web browser to interact with the application.

## Usage

The application's interface is straightforward:
- Use the **Add New Contact** button to create a new contact.
- Click on any contact name to view more details.
- Use the edit and delete buttons alongside each contact to modify or remove entries.
- Sort the list by clicking on the column headers.
