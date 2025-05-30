# Election Commission of Pakistan (ECP) - Database Management System

## 📋 Project Overview

This project is a **Database Management System (DBMS)** for the **Election Commission of Pakistan (ECP)**. The goal is to build a relational database and a basic GUI (using C# Windows Forms and Oracle Database) to manage and maintain data related to elections in Pakistan. The system supports core functionalities such as managing voters, candidates, constituencies, polling stations, election schedules, vote tracking, and results compilation.

This project reflects the real-world responsibilities of the ECP, ensuring transparency, fairness, and integrity in the electoral process.

---

## 🏛️ Background

The **Election Commission of Pakistan (ECP)** is an autonomous body responsible for:
- Organizing and supervising national and provincial elections
- Delimiting constituencies
- Maintaining electoral rolls
- Enforcing election laws
- Ensuring transparent and peaceful democratic processes

You can learn more about the ECP at the official site: [https://www.ecp.gov.pk](https://www.ecp.gov.pk)

---

## 🧱 Database Schema

The system consists of the following main tables:

| Table Name             | Description |
|------------------------|-------------|
| `Voters`               | Stores registered voter information |
| `Candidates`           | Contains election candidates and their party details |
| `Constituencies`       | Electoral constituency data |
| `PollingStations`      | Polling station info mapped to constituencies |
| `ElectionSchedule`     | Details of upcoming or past elections |
| `Votes`                | Vote casting records (manual voting) |
| `ElectionResults`      | Results summary per candidate and constituency |
| `PoliticalParties`     | Information about political parties |
| `ElectionOfficials`    | Officials involved in election administration |

---

## ✅ Core Features Implemented

- View, Insert, Update, Delete Constituency records (via Windows Forms)
- Display all constituencies in a DataGridView
- UI panel toggling based on user actions
- Oracle database connectivity using `Oracle.ManagedDataAccess.Client`

> Other modules (voters, candidates, polling stations, etc.) are designed and can be implemented in similar ways as future enhancements.

---

## 💡 Technologies Used

- **C#** (.NET Framework, Windows Forms)
- **Oracle Database 11g/12c**
- **Oracle.ManagedDataAccess.Client** (ADO.NET for Oracle)
- **SQL** (DDL & DML)
- Visual Studio for GUI development

---

## 🚀 Getting Started

### Prerequisites
- Oracle Database installed and configured (`localhost:1521/xe`)
- Visual Studio with .NET Framework
- Oracle.ManagedDataAccess NuGet package installed

### Running the Application
1. Clone this repository
2. Open the `.sln` file in Visual Studio
3. Ensure Oracle Database is running
4. Run the project (`Form1.cs` is the main form with UI logic)
5. Use the interface to manage constituencies and visualize data

---

## 📖 Future Improvements

- Add complete CRUD support for all tables (Voters, Candidates, etc.)
- Implement role-based login system (Admin, Voter, Official)
- Integrate Form 45 and Form 47 data handling
- Add support for Online/Overseas voting
- Export election results to PDF/Excel

---

## 📄 License

This project is for academic use only and not affiliated with the official Election Commission of Pakistan.


