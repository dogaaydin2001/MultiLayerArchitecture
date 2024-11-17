# Multi-Layer Architecture Project 🏗️

This project implements a **Multi-Layer Architecture** using C#. It demonstrates how to build scalable, maintainable, and modular software applications by separating concerns into distinct layers. The architecture follows best practices for software development, ensuring clarity and flexibility.

---

## Features ✨

- **Data Layer**  
  - Handles data persistence and retrieval.  
  - Simulated with in-memory data storage (or extendable for database integration).  

- **Business Layer**  
  - Encapsulates business logic and core operations.  
  - Acts as an intermediary between the data layer and presentation layer.  

- **Presentation Layer**  
  - Provides a user interface through a console-based application.  
  - Handles user inputs and displays output.  

- **Utility Layer**  
  - Includes helper classes and functions for validations and common operations.  

---

## Project Structure 🏗️

The project is divided into the following layers:

1. **Presentation Layer**  
   - Manages user interaction via console menus.  
   - Displays output and collects input from the user.  

2. **Business Layer**  
   - Implements application logic such as validations, calculations, and processing.  
   - Serves as a bridge between the presentation and data layers.  

3. **Data Layer**  
   - Contains repositories and methods for data management.  
   - Responsible for storing and retrieving data from in-memory storage (or databases in future integrations).  

4. **Models**  
   - Defines the data structure of the application, such as `User`, `Product`, etc.  
   - Represents real-world entities with properties and methods.  

5. **Utility Layer**  
   - Provides reusable components such as validators and formatters.  

---

## Key Concepts Demonstrated 📚

- **Separation of Concerns:**  
  Ensures each layer has a single responsibility.  

- **Scalability:**  
  Modular structure allows for easy extension or replacement of layers.  

- **Testability:**  
  Isolated logic in the business layer simplifies unit testing.  

- **Maintainability:**  
  Well-defined boundaries between layers make the application easy to update and debug.  

---

## How to Run 🚀

### Prerequisites
- Install [.NET SDK](https://dotnet.microsoft.com/download).  

### Steps to Run
1. Clone the repository:  
   ```bash
   git clone https://github.com/dogaaydinn/MultiLayerArchitecture.git

2. Open the solution file in Visual Studio or your preferred C# IDE.
3. Build the solution to restore dependencies and ensure there are no errors.
4. Run the application:
Through the IDE, press the run/debug button.
Or, execute from the terminal:
   ```bash
    dotnet run
## Usage 📖
### Menu Navigation
Upon running the application, you'll see a main menu allowing you to:

- Manage entities such as users, products, or other relevant data (customizable).
- View, add, update, and delete records.
- Perform operations defined in the business layer (e.g., calculations or validations).
### Data Validation
- Input data is validated before being processed.
- Custom error messages guide users when invalid input is entered.

### Contribution 🤝
Contributions are welcome! Here's how you can help:

1. Fork the repository.
2. Create a feature branch:
   ```bash
    git checkout -b feature/your-feature-name
3. Commit your changes and push them to your fork.
4.Open a pull request with a detailed description of your changes.

### License 📜
This project is licensed under the MIT License. You are free to use, modify, and distribute this project as per the terms of the license.


