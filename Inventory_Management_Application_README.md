# Inventory Management Application Using Visual Studio

A C# Windows Forms inventory management application built in Microsoft Visual Studio. The system provides a desktop interface for managing products, sales, customers, sales transactions, and users through basic CRUD operations.


## Overview

This project is a desktop-based inventory management system designed for small business or academic use. It uses Windows Forms for the user interface and SQL Server LocalDB for data storage. The application starts with a database connection screen, verifies user login credentials, and then allows the user to insert, update, delete, and view records from different inventory-related tables.

## Features

- Windows Forms desktop interface.
- SQL Server LocalDB database connectivity.
- User login and verification.
- Main menu for selecting system operations.
- Insert records into inventory tables.
- Update existing records.
- Delete records.
- Show/view stored records.
- Manage product information.
- Manage sales information.
- Manage customer information.
- Manage sales transaction information.
- Manage user information.
- Display useful database information such as customer count, product/sales details, sorted products, and total revenue.

## Technology Stack

- **Language:** C#
- **Framework:** .NET Framework 4.8.1
- **UI:** Windows Forms
- **IDE:** Microsoft Visual Studio
- **Database:** SQL Server LocalDB / `.mdf` database file
- **Database Library:** `System.Data.SqlClient`

## Main Modules

### 1. Connection Module

The application starts from the connection form. It attempts to connect to the LocalDB database and then moves to the login verification screen.

Main files:

```text
Program.cs
Welcome.cs
DBconnection.cs
```

### 2. Login / Verification Module

The verification form checks username and password values from the `Users` table. If the credentials are valid, the user is allowed to continue to the main menu.

Main file:

```text
Verify.cs
```

### 3. Main Menu Module

The main menu allows users to choose what operation they want to perform:

- Insert records
- Update records
- Delete records
- Show records
- Return to login

Main file:

```text
ChoseFunction.cs
```

### 4. Insert Module

The insert section allows new data to be added into:

- Products
- Sales
- Customers
- Sales Transactions
- Users

Main files:

```text
ChoseTabINS.cs
insPRO.cs
insSALE.cs
insCUST.cs
insSATRAN.cs
insUSER.cs
```

### 5. Update Module

The update section allows existing data to be modified in:

- Products
- Sales
- Customers
- Sales Transactions
- Users

Main files:

```text
ChoseTabUPD.cs
updPRO.cs
updSALE.cs
updCUST.cs
updSATRAN.cs
updUSER.cs
```

### 6. Delete Module

The delete section allows records to be removed from:

- Products
- Sales
- Customers
- Sales Transactions
- Users

Main files:

```text
ChoseTabDEL.cs
delPRO.cs
delSALE.cs
delCUST.cs
delSATRAN.cs
delUSER.cs
```

### 7. Show Records Module

The show section displays saved database records for:

- Products
- Sales
- Customers
- Sales Transactions
- Users

Main files:

```text
ChoseTabSHOW.cs
showPRO.cs
showSALE.cs
showCUST.cs
showSATRAN.cs
showUSER.cs
```

## Project Structure

```text
Inventory-Management-Application-using-visual-studio/
  Inventory Management Application.sln
  Inventory Management Application.csproj
  Program.cs
  App.config
  DBconnection.cs
  Welcome.cs
  Verify.cs
  ChoseFunction.cs
  ChoseTabINS.cs
  ChoseTabUPD.cs
  ChoseTabDEL.cs
  ChoseTabSHOW.cs
  insPRO.cs
  insSALE.cs
  insCUST.cs
  insSATRAN.cs
  insUSER.cs
  updPRO.cs
  updSALE.cs
  updCUST.cs
  updSATRAN.cs
  updUSER.cs
  delPRO.cs
  delSALE.cs
  delCUST.cs
  delSATRAN.cs
  delUSER.cs
  showPRO.cs
  showSALE.cs
  showCUST.cs
  showSATRAN.cs
  showUSER.cs
  Resources.resx
  Settings.settings
```

The repository also contains some generated build output files such as `.exe`, `.pdb`, `.cache`, and compiled `.resources` files. These are not required when building from source because Visual Studio can regenerate them.

## Database

The project uses SQL Server LocalDB with a local `.mdf` database file.

Current connection string pattern used in source code:

```text
Server=(localdb)\mssqllocaldb;
Database=C:\USERS\LOVEE\DOCUMENTS\STUDENTS.MDF;
Integrated Security=True;
```

Before running the project on a different computer, update the database file path in:

```text
DBconnection.cs
Verify.cs
```

The expected database tables include:

- `Product`
- `Sales`
- `Customers`
- `SalesTrans`
- `Users`

## Prerequisites

- Windows operating system.
- Microsoft Visual Studio.
- .NET Framework 4.8.1.
- SQL Server LocalDB.
- A valid `.mdf` database file with the required tables.

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/eesha2111/Inventory-Management-Application-using-visual-studio.git
```

2. Open the project folder.

3. Open the solution file in Visual Studio:

```text
Inventory Management Application.sln
```

4. Update the LocalDB connection string if the database file path is different on your computer.

5. Build the solution:

```text
Build > Build Solution
```

6. Run the application:

```text
Press F5
```

## Application Flow

```text
Start Application
  ↓
Connect to Database
  ↓
Login / Verify User
  ↓
Open Main Menu
  ↓
Choose Insert, Update, Delete, or Show
  ↓
Perform Operation on Selected Table
  ↓
Return to Menu or Exit
```

## Usage Guide

1. Launch the application from Visual Studio or by running the executable.
2. Click the connection button to connect with the LocalDB database.
3. Enter valid username and password.
4. Choose the required operation from the main menu.
5. Select the table/module, such as Product, Sales, Customer, Sales Transaction, or User.
6. Enter the required data.
7. Submit the form to insert, update, delete, or view records.

## Notes for Developers

- The project uses Windows Forms event-driven programming.
- Database operations are handled mainly through `DBconnection.cs`.
- SQL queries are currently written directly inside C# methods.
- The connection string is hard-coded and should be updated before deployment.
- For better production usage, parameterized SQL queries and a configurable connection string are recommended.

## Future Improvements

- Move the database connection string to `App.config`.
- Add full database schema or SQL script to the repository.
- Add stronger password handling.
- Improve form validation.
- Add search and filtering options.
- Add stock alerts for low quantity products.
- Add reports for sales and revenue.
- Remove generated build/cache files from the repository.
- Add a `.gitignore` file for Visual Studio projects.

## Disclaimer

This project is intended for learning, academic, and demonstration purposes. It can be improved further before being used in a real business environment.
