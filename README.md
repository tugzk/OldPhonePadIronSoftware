# OldPhonePadIronSoftware

Implementation for old phone pad coding challange by Iron Software.

## Problem Statement

![Old Mobile Keypad](https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Telephone-keypad2.svg/300px-Telephone-keypad2.svg.png)

Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
Each button has a number to identify it and pressing a button multiple times will cycle 
through the letters on it allowingeach button to represent more than one letter.
For example, pressing 2 once will return ‘A’ but pressing twicein succession will return ‘B’.
You must pause for a second in order to type two characters from the same button after each 
other: “222 2 22” -> “CAB”.

## 🚀 Prerequisites

Before cloning and building the project, ensure you have the following installed:

### **1️ Install .NET 9 SDK**

- Download and install **.NET 9 SDK** from [Microsoft's official website](https://dotnet.microsoft.com/en-us/download).
- Verify installation by running:
 
	  dotnet --version

### **2 Install Git**

- Download and install **Git** from [Git's official website](https://git-scm.com/downloads).

## 🏃 How to run code 

### Clone Repo

	git clone https://github.com/tugzk/OldPhonePadIronSoftware.git
	cd move-to-cloned-directory/OldPhonePadIronSoftware

## 🛠️ Building and Running the Project
- Option 1: Using Visual Studio 2022
		Open Visual Studio 2022.
		Click on "Open a project or solution".
		Navigate to the cloned folder and open the .sln file.
		Set the startup project (if applicable).
		Click Build → Build Solution (Ctrl+Shift+B).
		Run the application by clicking Start (F5 for debug mode).
	
- Option 2: Using Visual Studio Code
		Open VS Code.
		Install the following extensions:
		C# Dev Kit (ms-dotnettools.csdevkit)
		C# (ms-dotnettools.csharp)
		Open the cloned folder:
		
		code .
		
	Restore dependencies:

		dotnet restore

	Build the project:

		dotnet build

	Run the project:

		dotnet run

# Unit Tests

The project contains unit tests to verify the correctness of the implementation. To run the tests right click the test project and click, 
'Run Tests' or execute the following command:
		
		dotnet test
	
The tests were built using the XUnit framework.
