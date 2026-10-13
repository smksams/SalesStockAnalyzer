# Sales & Stock – C# Project

## Overview

This project was created to practice and consolidate C# development skills, focusing on:

- Programming logic  
- Object-Oriented Programming (OOP)  
- Clean Architecture principles  
- Unit testing  

The application processes a provided XML file (`Sales_Stock.xml`), extracting and analyzing data related to product sales and inventory.

---

## Artificial Intelligence Usage

### Guidelines

AI should be used as a support tool, not as a shortcut.

Recommended usage:
- Clarifying concepts  
- Reviewing logic and structure  
- Improving documentation  
- Organizing ideas  

Avoid:
- Generating full code solutions  
- Replacing the learning process  

---

## Core Concepts

### Fundamentals
- Programming logic  
- Control flow:
  - `if`, `if-else`
  - `for`, `while`

### Object-Oriented Programming
- Separation of concerns  
- Use of interfaces  
- Modular and organized structure  
- Readable and maintainable code  

### Best Practices
- SOLID principles  
- Clean Code  

---

## Technologies

- Language: C#  
- Testing Framework: NUnit  

---

## Unit Testing

### Concepts Applied
- AAA Pattern (Arrange, Act, Assert)  
- Mocking with `MockRepository`  
- Strict behavior using `MockBehavior.Strict`  

### Goals
- Ensure reliability  
- Improve maintainability  
- Enable safe refactoring  

---

## Project Structure

The project follows a layered architecture, organized by responsibility:

```
/Domain
/Services
/Interfaces
/Infrastructure
/Tests
```

---

## Features

The system reads and processes data from the `Sales_Stock.xml` file, providing the following functionalities:

### Menu Options

1. Quantity of products in stock  
2. Total sales value of products in stock  
3. Best-selling product  
4. Most profitable product  
5. Products that have not been sold  
6. Out-of-stock products  
7. Execute all options  
0. Exit  

---

## Objectives (Module 1 – Core)

This project aims to strengthen:

- Logical reasoning in programming  
- Object-oriented design  
- Application of SOLID principles  
- Writing clean, maintainable code  
- Creating reliable unit tests  
- Participating in weekly code reviews
- Proper use of XML documentation (<summary>) for code readability and maintainability

## Future Improvements (Module 2 – Advanced)

After completing the core module, the following improvements should be considered and implemented:

- Error handling and exception management (invalid XML, unexpected failures)
- Input and data validation (negative values, inconsistent data)
- Handling duplicated products based on business rules (e.g., latest ModificationDate)
- Improved domain modeling and responsibility separation
- Writing more robust unit tests covering edge cases
- Refactoring focused on readability and maintainability
- Basic logging for system operations and errors