# SlidelyFormApp

SlidelyFormApp is a Windows Forms application developed in Visual Basic using Visual Studio. This application allows users to create,view and delete form submissions. The submissions include details like Name, Email, Phone Number, GitHub Repository Link, and Stopwatch Time.

## Features

- **Create New Submission**: Users can fill in the details and submit a new form.
- **View Submissions**: Users can navigate through the submitted forms using "Previous" and "Next" buttons.
- - **Delete Submissions**: Remove any unwanted submissions.

## Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- NuGet package manager

## Setup and Installation

1. **Clone the Repository**:
   
   ```bash
   git clone https://github.com/yourusername/SlidelyFormApp.git
   cd SlidelyFormApp
   ```
3. **Open the Solution**:
   - Open Visual Studio.
   - Go to File -> Open -> Project/Solution.
   - Select SlidelyFormApp.sln from the cloned repository.
4. **Restore NuGet Packages**:
   - Go to Tools -> NuGet Package Manager -> Package Manager Console.
   - Run the following command:

   ```bash
   Update-Package -reinstall
   ```
5. **Build the Solution**:
   -Go to Build -> Build Solution or press Ctrl + Shift + B.


## Running the Application

1. **Start the Backend Server**:
   -Ensure the backend server is running (see backend server setup instructions in the backend's README).
2. **Run the Application**:
   -Press F5 or go to Debug -> Start Debugging to run the application.

## User Interface

**Main Form**

The Main Form is the entry point of the application. It provides buttons to navigate to the Create Submission Form and the View Submissions Form.

View Submissions:
-Button: Click the "View Submissions" button.
-Shortcut: Press Ctrl + V.
-Action: Opens the View Submissions form, displaying the first submission if available.

Create New Submission:
-Button: Click the "Create New Submission" button.
-Shortcut: Press Ctrl + N.
-Action: Opens the Create Submission form.

<img width="402" alt="main form" src="https://github.com/ArchitKayal/SlidelyFormApp/assets/59079120/6ce59744-6b90-4fe6-8ef0-0c5b61bb47f2">

**Create Submission Form**

<img width="402" alt="image" src="https://github.com/ArchitKayal/SlidelyFormApp/assets/59079120/751ef560-ce30-4a7f-9658-c1d70b6f6ace">

**View Submission Form**

<img width="402" alt="image" src="https://github.com/ArchitKayal/SlidelyFormApp/assets/59079120/adb40b8f-65e6-4356-8609-2f84915522be">


