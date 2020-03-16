# _Car Dealership_

#### _ASP.NET MVC practice for Epicodus_, _Mar. 16 2020_

#### By _**Michelle Morin, Alyssa Colistro**_

## Description

_This application is a car dealership tracker, to keep track of cars for sale on a used car lot. We refactored an existing ASP.NET Core MVC project to replace a static list storing all cars with a database._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application creates an instance of a Car | Car newCar = new Car() | new Car object created |
| Application returns makemodel, price, miles, and message associated with a car | newCar.MakeModel | "Subaru Outback" |
| Application sets a makemodel, price, miles, and message for a Car | Car newCar = new Car("Subaru Outback", 1000, 200000, "good for Oregon"); | newCar.Miles = 200000 |
| Application adds all new instances of Car to a database | Car newCar = new Car("Subaru Outback", 1000, 200000, "good for Oregon") | newCar is added to cars table of car_dealership schema |
| Application returns all cars in the database | Car.GetAll() | List<Car> returned | 
| Application returns cars matching certain search parameters (max price and max mileage) | user enters maximum price and maximum mileage | application returns list of cars matching search parameters |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/CarDealership.Solution``
* ``cd CarDealership.Solution``

_Confirm that you have navigated to the CarDealership.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd CarDealership``
* ``dotnet restore``
* ``dotnet build``
* ``dotnet run`` or ``dotnet watch run``

_Test this application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``cd CarDealership.Tests``
* ``dotnet restore``
* ``dotnet test``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _dotnet script_
* _MSTest_
* _MySQL_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Alyssa Colistro_**