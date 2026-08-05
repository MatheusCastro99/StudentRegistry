# StudentRegistry

A Windows Forms application for managing student records with secure teacher authentication and academic performance tracking.

## Overview

StudentRegistry is a .NET 10 desktop application designed for educators to efficiently manage student information. It provides a secure login system, comprehensive student record management, and automated reporting of top academic performers.

## Features

- **Secure Authentication** - Teacher login with credential validation and attempt limiting (5 attempts maximum)
- **Student Management** - Create, read, update, and delete student records
- **Academic Tracking** - Monitor student GPA and enrollment information
- **Award Recognition** - Automatically identify and export the highest-performing student record
- **Session Management** - Maintains session context for authenticated users
- **Real-Time Data Binding** - Dynamic updates to student data grid
- **Persistent Storage** - Export student award data to text files

## Requirements

- **.NET**: 10.0 or later
- **Visual Studio**: 2026 or later (Community Edition or higher)
- **OS**: Windows (Windows Forms requirement)
- **C#**: 14.0

## Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/MatheusCastro99/StudentRegistry.git
   cd StudentRegistry
   ```

2. **Open in Visual Studio**
   - Open `StudentRegistry.slnx` in Visual Studio

3. **Build the solution**
   - Select **Build** > **Build Solution** (Ctrl+Shift+B)

4. **Run the application**
   - Click **Start** (F5) to launch the application

## Usage

### Login
1. Launch the application
2. Enter valid teacher credentials in the login dialog
3. You have 5 attempts before the application closes
4. Upon successful login, the main window displays

### Managing Students
- **Add Student**: Click the "Add Student" button to create a new record
- **Edit/Delete Student**: Select a student row and click "Edit/Delete" to modify or remove the record
- **View Students**: Active students display in the data grid below the toolbar

### Award Recognition
- Click the **"Student Award"** button to identify the student with the highest GPA
- Award information is saved to `StudentAwards/award.txt`
- File includes student name and GPA

### Logout
- Click the **"Log Out"** button to return to the login screen and clear the session

## Project Structure

```
StudentRegistry/
├── Views/
│   ├── MainView.cs           # Main application window
│   ├── LogInView.cs          # Teacher authentication dialog
│   ├── AddView.cs            # Student creation form
│   └── EditDelView.cs        # Student edit/delete form
├── Models/
│   ├── User.cs               # Base user class
│   ├── Teacher.cs            # Teacher model
│   ├── Student.cs            # Student model
│   └── Months.cs             # Enrollment month enum
├── Components/
│   ├── MockData.cs           # Sample data initialization
│   └── SessionContext.cs     # Session management
├── StudentAwards/            # Award export directory
└── StudentRegistry.slnx      # Solution file
```

## Data Models

### Student
- **ID** - Unique identifier
- **First Name** - Student first name
- **Last Name** - Student last name
- **GPA** - Grade point average
- **Month of Admission** - Enrollment month (enum)

### Teacher
- **Username** - Unique teacher identifier
- **Password** - Authentication password

## Technologies Used

- **Framework**: .NET 10
- **UI**: Windows Forms
- **Language**: C# 14.0
- **Data Binding**: System.ComponentModel.BindingList
- **File I/O**: System.IO.StreamWriter

## Contributing

Contributions are welcome! Please feel free to fork the repository and submit pull requests for any improvements.

## License

This project is part of the MSSA PCAD21 curriculum assignments.

---

**Repository**: [GitHub - MatheusCastro99/StudentRegistry](https://github.com/MatheusCastro99/StudentRegistry)
