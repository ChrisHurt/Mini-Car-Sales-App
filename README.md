
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


# Mini Car Sales App

<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation) <!-- * [Usage](#usage) -->
* [Roadmap](#roadmap)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project

A coding challenge supplied by Carsales.com to produce a C# MVC Full Stack Application.

### Built With
* [Bootstrap](https://getbootstrap.com)
* [React](https://reactjs.org/)
* [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/3.0)


<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

-- Pending Finalisation of the project

### Installation

-- Pending Finalisation of the project

<!-- ROADMAP -->
## Roadmap 04/10

### Sprint 1 -- Completed 06/10/19
UI Implementation - Part 1 of 2
- Build a nav bar featuring 2 links: 'Home' and 'View Vehicles'
- Build a home page with a drop-down menu to select 'Create Car'
- Build a create car page with a form listing all relevant properties(vehicle type, make, model, engine, doors, wheels and body type) except for id - this will be handled separately

### Sprint 2 -- Completed 06/10/19
Build models to represent Vehicles and Cars
- Vehicles have:
  - make
  - model
  - vehicleType
- Cars extend the properties of a Vehicle and have
  - engine
  - doors
  - wheels
  - bodyType

### Sprint 3
Implement a method to read and write Vehicle and Car data to the Hard Drive
- I am currently considering XML Serialization with reference to [https://docs.microsoft.com/en-us/dotnet/standard/serialization/examples-of-xml-serialization](https://docs.microsoft.com/en-us/dotnet/standard/serialization/examples-of-xml-serialization) and [https://stackoverflow.com/questions/2347642/deserialize-from-string-instead-textreader](https://stackoverflow.com/questions/2347642/deserialize-from-string-instead-textreader)

### Sprint 4
Build C# API endpoints
- POST request: Create a car
- GET  request: Get data of all cars

### Sprint 5
UI Implementation - Part 2 of 2
- Extend the create car page form to make a post request to create the car
- Build a view vehicles page with a get request for all car data and present it in a table

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact

Chris Hurt - chrishcoding@gmail.com

Project Link: [https://github.com/ChrisHurt/Mini-Car-Sales-App](https://github.com/ChrisHurt/Mini-Car-Sales-App)


<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [README template - othnieldrew](https://github.com/othneildrew/Best-README-Template)


[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=flat-square
[license-url]: https://github.com/ChrisHurt/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/christopher-hurt/
<!-- [product-screenshot]: images/screenshot.png -->