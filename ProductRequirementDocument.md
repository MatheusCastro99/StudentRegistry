# Learning Management System
	- Mini learning Management System for Teachers and Students
	- .NET 10, Winforms, CRUD, MVC with no controllers (No DB or Server Requests)
	- Custom Data Types
		-> Classes: User, Teacher, Student, Address
		-> Enum: Months

## Solution Structure
```b
- Dependencies
- Models
	-> User
	-> Teacher
	-> Student
- Components
	-> Months
	-> Address
	-> MockData
-Views
	-> MainView
	-> AddViewPop
	-> EditDelViewPop
	-> LogInViewPop
- README.md
- Program.cs
```

## Workflow
```b
- User start at MainView with all buttons and data not visible, except Log In button
- Log In Pop up accepting username and pass will decide user role
- AuthenticateUser and initiate SessionContext methods
- From there, data and options become visible accordingly
- User choices:
	-> Add / Delete students to class
	-> Save Student with highest GPA to txt file (generateBestStudentAward)
	-> Add / Edit Grades
	-> ...
```

### Planned Development: 4 Hours w/ mock data

