
# 🚗 Driving License Management System (DVLD)

A comprehensive Windows desktop application for managing driving license issuance, renewals, and international permits. Built with C# .NET and SQL Server.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

## 📋 Table of Contents
- [Features](#features)
- [Project Structure](#project-structure)
- [Technology Stack](#technology-stack)
- [Installation](#installation)
- [Modules](#modules)
- [Database Schema](#database-schema)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## ✨ Features

### 👥 People Management
- Complete person registration with personal details
- Person search and filtering capabilities
- Personal information updates and management
- Photo storage and management

### 🪪 License Management
- **Local Licenses**: New issuance, renewals, replacements
- **International Licenses**: International driving permit processing
- License detention and release management
- License classes and categories management

### 📝 Application Processing
- **Local Driving License Applications**
- **International License Applications**
- **License Renewal Applications**
- **Replace Lost/Damaged License Applications**
- **Release Detained License Applications**

### 🧪 Tests Management
- Driving test types configuration
- Test appointments scheduling
- Test results management
- Test fees calculation

### 👤 Driver Management
- Driver record creation and maintenance
- License history tracking
- Driver status monitoring

### 🔐 User Management
- User accounts management
- Role-based access control
- User permissions configuration
- Authentication and authorization

## 📁 Complete Project Structure

```
DVLD/
├── 📂 DVLD-BusinessLayer/                 # Business Logic Layer
│   ├── clsPerson.cs                       # Person entity management
│   ├── clsLicense.cs                      # License operations
│   ├── clsApplication.cs                  # Application processing
│   ├── clsDriver.cs                       # Driver management
│   ├── clsUser.cs                         # User authentication
│   ├── clsInternationalLicense.cs         # International licenses
│   └── clsTest.cs                         # Test management
│
├── 📂 DVLD-DataAccessLayer/               # Data Access Layer
│   ├── clsDataAccess.cs                   # Database connection wrapper
│   ├── clsDataAccessSettings.cs           # Connection configuration
│   └── StoredProcedures/                  # SQL stored procedures
│
├── 📂 DVLD-PresentationLayer/             # Presentation Layer
│   ├── 📂 Applications/                   # Application Management
│   │   ├── 📂 Control/                    # Application controls
│   │   ├── 📂 International License/      # International license apps
│   │   ├── 📂 Local Driving License/      # Local license applications
│   │   ├── 📂 Renew Local License/        # License renewal apps
│   │   ├── 📂 ReplaceLostOrDamagedLicense/ # Replacement applications
│   │   └── 📂 Release Detained License/   # License release apps
│   │
│   ├── 📂 ApplicationTypes/               # Application types management
│   │
│   ├── 📂 Drivers/                        # Driver management
│   │   ├── Driver registration forms
│   │   └── Driver history views
│   │
│   ├── 📂 Licenses/                       # License Management
│   │   ├── 📂 Control/                    # License controls
│   │   ├── 📂 Detain License/             # License detention
│   │   ├── 📂 International Licenses/     # International licenses
│   │   └── 📂 Local Licenses/             # Local licenses management
│   │
│   ├── 📂 Main/                           # Main application forms
│   │   ├── Main dashboard
│   │   ├── Login forms
│   │   └── Navigation
│   │
│   ├── 📂 People/                         # People Management
│   │   ├── 📂 Control/                    # Person controls
│   │   ├── Person registration forms
│   │   └── Person search and edit forms
│   │
│   ├── 📂 Tests/                          # Tests Management
│   │   ├── 📂 TestTypes/                  # Test types configuration
│   │   ├── Test scheduling forms
│   │   └── Test results entry forms
│   │
│   ├── 📂 Users/                          # User Management
│   │   ├── 📂 Control/                    # User controls
│   │   ├── User registration forms
│   │   └── User permissions forms
│   │
│   └── GlobalClasses.cs                   # Global utilities and helpers
│
└── 📂 DatabaseScripts/                    # Database creation scripts
```

## 🛠 Technology Stack

### Backend & Database
- **C# .NET Framework** - Core application logic
- **SQL Server** - Database management system
- **ADO.NET** - Data access technology
- **Stored Procedures** - Database operations

### Frontend & UI
- **Windows Forms** - Desktop application framework
- **Syncfusion Controls** - Enhanced UI components
- **GDI+** - Custom graphics and reporting

### Architecture
- **3-Tier Architecture** (Presentation, Business, Data Access)
- **Layered Architecture** - Separation of concerns
- **Repository Pattern** - Data access abstraction

## 📥 Installation

### Prerequisites
- Windows 7/10/11
- .NET Framework 4.8 or later
- SQL Server 2012 or later
- Visual Studio 2019 or later

### Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ridabouakaz/Project-Driving-License-Management.git
   cd Project-Driving-License-Management
   ```

2. **Database Configuration**
   - Run the database creation scripts in `DatabaseScripts/`
   - Update connection string in `clsDataAccessSettings.cs`:
   ```csharp
   public static string ConnectionString = "Server=.;Database=DVLD;User Id=sa;Password=your_password;";
   ```

3. **Build and Run**
   - Open `DVLD.sln` in Visual Studio
   - Restore NuGet packages
   - Build solution (Ctrl + Shift + B)
   - Run application (F5)

4. **Default Login**
   - Username: `admin`
   - Password: `admin123`

## 🏗 Modules Overview

### 🔹 People Module
- Person registration and management
- Personal information storage
- Search and filter functionality
- Photo management

### 🔹 Applications Module
- **Local Driving License**: New license applications
- **International License**: International permit applications  
- **Renew Local License**: License renewal processing
- **Replace Lost/Damaged License**: Replacement requests
- **Release Detained License**: License release from detention

### 🔹 Licenses Module
- Local licenses management
- International licenses processing
- License detention and release
- License status tracking

### 🔹 Tests Module
- Test types configuration
- Test appointments management
- Test results recording
- Test fees management

### 🔹 Drivers Module
- Driver registration
- Driver history tracking
- License association management

### 🔹 Users Module
- User account management
- Role-based permissions
- Authentication system

## 🗃 Database Schema

### Core Tables
- **Persons** - Personal information storage
- **Applications** - All types of license applications
- **Licenses** - Local driving licenses
- **InternationalLicenses** - International driving permits
- **Drivers** - Driver information
- **Users** - System users
- **Tests** - Driving test records
- **TestTypes** - Test categories and configurations

## 🚀 Usage

### For System Administrators
- Manage all system modules
- Configure application settings
- Manage users and permissions
- Generate comprehensive reports

### For License Officers
- Process license applications
- Issue and renew licenses
- Manage international permits
- Handle license replacements

### For Test Officers
- Schedule driving tests
- Record test results
- Manage test appointments
- Update test status

### For End Users
- Apply for new licenses
- Renew existing licenses
- Request international permits
- Track application status

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the project
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Development Guidelines
- Follow C# coding conventions
- Use meaningful names for variables and methods
- Add XML comments for public methods
- Test all changes thoroughly

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Support & Contact

- Developer: Rida Bouakaz
- Project Link: [https://github.com/ridabouakaz/Project-Driving-License-Management](https://github.com/ridabouakaz/Project-Driving-License-Management)

## 🙏 Acknowledgments

- Syncfusion for providing excellent UI components
- Microsoft for .NET Framework and SQL Server
- All contributors and testers

---

**⭐ If you find this project useful, please give it a star!**
```
