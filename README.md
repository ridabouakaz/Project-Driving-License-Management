🚗 Driving License Management System

A complete desktop application for managing driving license applications, testing, issuance, renewal, and driver records, built with C# (.NET Windows Forms) using a clean multi-layer architecture (UI + Business Layer + Data Access Layer).

📌 Overview

The system manages all stages of the driving license lifecycle:

Person records

License applications

Local & international licenses

Theory / Vision / Street tests

License issuance & renewal

Payments & fees

User management

Activity tracking

The project follows best practices, separating responsibilities across multiple layers for cleaner maintainability and scalability.

🏗️ Architecture

The project uses a classic and clean 3-Tier Architecture:

📁 DrivingLicense
 ┣ 📁 UI (Presentation Layer)
 ┣ 📁 BusinessLayer (BLL)
 ┣ 📁 DataAccessLayer (DAL)
 ┣ 📁 GlobalClasses
 ┗ 📁 Properties

1. Presentation Layer (UI)

Contains all Windows Forms pages:

Persons management

Applications

Driving tests

License issuance

License renewal

Drivers list

Reports & search pages

User login & user management

The UI is clean, uses UserControls, and communicates only with the Business Layer.

2. Business Layer (BLL)

Handles the system’s logic and rules.

Categories include:

clsPerson

clsApplication

clsLocalDrivingLicenseApplication

clsDriver

clsLicense

clsTestType / clsTestAppointment

clsUser

enum ActiveStatus / enum IssueReason

This layer:

Validates data

Applies business rules (e.g., cannot issue license without passing all tests)

Coordinates between DAL and UI

Encapsulates logic such as:

Getting person details

Checking test status

Calculating expiration dates

Linking applications to licenses

Permission handling

3. Data Access Layer (DAL)

Handles all interactions with the database:

SQL CRUD functions

Stored procedures calls

Data retrieval for views

Mapping data tables to objects in the BLL

Example objects:

clsPersonData

clsLicenseData

clsApplicationData

🔑 Main Features
✔ Person Management

Add / edit persons

Upload photos

Full personal info

Search by ID / national number

✔ Driving License Applications

Local license applications

Linked to person records

Fees, notes, and status

✔ Driving Tests

Vision test

Theory test

Practical street test

Test appointments

Pass/fail logic

Prevent issuing license without all passes

✔ License Issuance

Auto-generated expiration date

Issue reason (New, Renew, Replacement)

Active / inactive status

Linking license to driver

✔ License Renewal & Replacement

Damage

Lost license

Expired license

✔ Drivers Management

A driver can hold multiple licenses

Tracking history of licenses

✔ Users & Permissions

Login

CreatedByUserID

Role-based logic

✔ Search & Reports

Search licenses

Search applications

Print or export results

🗄 Database Structure (General Overview)

Your project uses tables such as:

Persons

Applications

LocalDrivingLicenseApplications

TestTypes

TestAppointments

Licenses

Drivers

Users

Views such as:

LocalDrivingLicenseApplications_View

DriversLicenses_View

🧪 Best Practices Used

3-Tier architecture

Clean separation of UI, logic, and data

Enums for status and reason

Nullable checks

Business logic encapsulated in classes

Consistent naming

Reusable UserControls

Centralized database access

🚀 How to Run the Project

Open the solution in Visual Studio

Restore NuGet packages if used

Configure your SQL Server connection string

Run database scripts

Launch the application

📄 Future Improvements

Migrate UI to WPF or MAUI

Add JWT authentication for API version

Add dashboards and analytics

Add unit tests

Add cloud database support

💼 Author

Reda Bouakaz
Software Engineer • C# Developer
Driving License Management System (Educational / Training Project)
