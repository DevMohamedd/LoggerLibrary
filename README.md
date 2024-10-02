# LoggerLibrary
A simple and flexible logging library for .NET that supports logging to text files or Excel sheets. It adheres to SOLID principles, specifically the Dependency Inversion Principle (D), and is designed for easy configuration and extension.

# LoggerLibrary

## Overview

This project is a simple logging library for .NET applications. Depending on the configuration, it enables developers to log messages to either a text file or an Excel sheet. The library is designed to be flexible and extendable, following SOLID principles focusing on the **Dependency Inversion Principle**.

## Features

- **Log to Text File**: Write log messages with timestamps to a specified text file.
- **Log to Excel Sheet**: Write log messages to an Excel file, saving the message along with the timestamp.
- **Flexible Configuration**: Switch between logging to a text file or Excel by simply changing the destination type when creating the logger.

## Technologies

- .NET Framework / .NET Core
- C#
- Microsoft.Office.Interop.Excel (for Excel logging)

## SOLID Principle

This project applies the **Dependency Inversion Principle (D)** from SOLID, ensuring that high-level modules do not depend on low-level modules. Both should depend on abstractions. The `ILogger` interface abstracts the logging mechanism, while `ILogDestination` allows for different logging destinations (e.g., TextFile, Excel).

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/DevMohamedd/LoggerLibrary.git
    ```

2. Open the solution file in Visual Studio or any .NET IDE you choose.

3. Build the project to generate the required `.dll` file.

## Usage

To use the logger in your project:

1. Reference the `LoggerLibrary.dll` in your project.
2. Create an instance of the logger, specifying whether you want to log to a text file or an Excel sheet.

```csharp
// Example of logging to a text file
ILogger logger = LoggerFactory.CreateLogger("textfile", "path/to/your/logfile.txt");
logger.Log("This is a log message.");

// Example of logging into an Excel file
ILogger logger = LoggerFactory.CreateLogger("excel", "path/to/your/logfile.xlsx");
logger.Log("This is a log message.");
```
## Example of a Main Method:
```csharp
class Program
{
    static void Main(string[] args)
    {
        ILogger logger = LoggerFactory.CreateLogger("textfile", "log.txt");
        logger.Log("This is a message to log in a text file.");
        
        // OR for Excel logging
        // ILogger logger = LoggerFactory.CreateLogger("excel", "log.xlsx");
        // logger.Log("This is a message to log in an Excel file.");
    }
}
```
## Contact
For any inquiries or issues, please contact me at mohameddebany255@gmail.com.

### **README Highlights**:
1. **Overview** explains the purpose of the project.
2. **Features** Describe what the logger can do (log to text or Excel).
3. **Installation** gives a step-by-step guide for setting up the project.
4. **Usage** shows code snippets of how to implement the logger in a project.
