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
2. **Open the Solution**:
   - Open Visual Studio.
   - Go to File -> Open -> Project/Solution.
   - Select SlidelyFormApp.sln from the cloned repository.
3. **Restore NuGet Packages**:
   - Go to Tools -> NuGet Package Manager -> Package Manager Console.
   - Run the following command:
   ```bash
   Update-Package -reinstall
   ```
4. **Build the Solution**:
   -Go to Build -> Build Solution or press Ctrl + Shift + B.
