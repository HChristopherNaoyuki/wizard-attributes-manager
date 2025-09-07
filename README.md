# Wizard Attributes Manager

## Table of Contents

1. [Overview](#overview)
2. [System Architecture](#system-architecture)
3. [Project Structure](#project-structure)
4. [Installation Guide](#installation-guide)
5. [Usage Manual](#usage-manual)
6. [Features](#features)
7. [Technology Stack](#technology-stack)
8. [Development Notes](#development-notes)
9. [Documentation](#documentation)
10. [Notes](#notes)
11. [Disclaimer](#disclaimer)

## Overview

**Wizard Attributes Manager** is a C# console application that manages and displays the attributes of various wizards. 
It allows users to manage wizard information, including their names, houses, wands, ages, and magic power. 
The application uses a **wizard-object-oriented model** with **indexers** to access and modify wizard data efficiently. 
This tool demonstrates best practices in object-oriented programming and error handling.

This project was developed to manage and display wizard attributes in a clean and structured way, allowing easy extension 
to add more attributes or wizards in the future.

## System Architecture

The system follows a simple **three-layer architecture**:

1. **Program Layer (UI Layer)**: This layer interacts with the user, displays output, and handles the interaction between the user and the solution logic.

2. **Solution Layer**: This layer contains the business logic that processes data, interacts with the wizard objects, and formats the output to be displayed on the screen.

3. **Model Layer (Wizard Class)**: The `Wizard` class encapsulates all attributes (e.g., name, house, wand, age, magic power) and provides access to them through **indexers**.

## Project Structure

The project is structured into three main parts:

* `Program.cs`: Entry point for the application. It creates a `Solution` instance and calls methods to display wizard data.
* `Solution.cs`: Contains the logic to manage and display wizard attributes.
* `Wizard.cs`: Contains the model for the Wizard, including their attributes and indexers for easy access and modification.

```plaintext
wizard-attributes-manager/
├── Program.cs
├── Solution.cs
└── Wizard.cs
```

## Installation Guide

To get started with **Wizard Attributes Manager**, follow the steps below:

### 1. Clone the Repository

First, clone the repository to your local machine:

```bash
git clone https://github.com/HChristopherNaoyuki/wizard-attributes-manager.git
```

### 2. Open the Project in Visual Studio

1. Open **Visual Studio** (or your preferred C# IDE).
2. Go to **File** → **Open** → **Project/Solution**.
3. Select the `wizard-attributes-manager` folder you cloned earlier.
4. Open the solution file.

### 3. Build the Project

Once the project is loaded in Visual Studio, build the project:

1. In the **Solution Explorer**, right-click on the solution and select **Build**.

### 4. Run the Application

After building the project, press **Ctrl+F5** to run the application. The console window will display the wizard information in the specified format.

## Usage Manual

### 1. Running the Application

Once the application is running, you will see wizard attributes printed to the console for various wizards. The information will be displayed in the following format:

```
Wizard 1
===================================================
Name: Harry Potter
House: Gryffindor
Wand: Holly, Phoenix Feather, 11 inches
Age: 17
Magic Power: 100
===================================================
```

The program prints similar information for other wizards as well (e.g., Ron Weasley, Hermione Granger, and Albus Dumbledore).

### 2. Modifying Wizard Information

The program can be extended easily. If you want to modify wizard attributes or add new 
wizards, simply update the `Program.cs` file with new wizard data. The `Solution.cs` handles 
all the logic for managing wizard information.

## Features

* **Wizard Data Management**: The application stores and displays various attributes for each wizard.
* **Indexing**: It uses **indexers** to easily access and modify wizard attributes by both index and name.
* **Error Handling**: The application includes proper exception handling to manage potential errors during data retrieval or input.
* **Simple User Interface**: The program outputs wizard data in a simple and structured format.

## Technology Stack

The following technologies and libraries are used in this project:

* **C# 7.0**: The programming language used to develop this application.
* **.NET Framework**: The framework used for building and running the C# application.
* **Visual Studio**: The IDE used for development.

## Development Notes

* **Object-Oriented Design**: The `Wizard` class follows object-oriented principles and provides methods to retrieve and update attributes.
* **Indexers**: The `Wizard` class makes use of indexers to allow data to be accessed by both index and attribute name.
* **Error Handling**: The `Solution.cs` class catches exceptions and provides feedback to the user if something goes wrong.

## Documentation

The project is designed to be extensible and easy to maintain. You can refer to the 
code comments throughout the project to understand the logic and flow of the application.

The project can be expanded by adding more wizards, attributes, or methods to manage the wizard data. 
To add new wizards, simply update the `Program.cs` to call `Solution.DisplayWizardInfo()` with new details.

## Notes

* This project was created for learning and demonstrating object-oriented programming practices, including the use of indexers, constructors, and exception handling.
* The `Wizard` class currently handles a few basic attributes, but you can easily extend it to include more features, such as spells, strengths, weaknesses, etc.

## DISCLAIMER

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY 
IN THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES 
OF THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE 
PROJECT DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED 
ACCORDINGLY TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO 
THE APPLICATION (FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES 
THAT MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. 
IF YOU ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM 
SILENTLY OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST 
OR OPEN AN ISSUE ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN 
BE ADDRESSED APPROPRIATELY BY THE MAINTAINERS OR CONTRIBUTORS.

---
