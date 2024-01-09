 Tourism and Travel System
Overview
Welcome to the  Tourism System repository. This system serves as the backend for a travel application targeting Egyptian visitors. The project is initially built as a simple free tourism directory for Cairo places, applying the Minimum Viable Product (MVP) approach. The goal is to provide enough features to prove the concept, with plans to extend and enhance functionality in future iterations.

Technology Stack
ASP.NET Core APIs: These APIs act as a set of endpoints to interface with the upper layer, providing data serialization in JSON output.

Data Access Layer (DAL): Utilizes .NET Entity Framework to define and manipulate the system database.

Database: MS SQL Server 2019 is used as the backend database.

Frontend (Not Included yet):

Mobile App: Developed with Flutter and Dart for end users. JSON is deserialized to facilitate data handling.
Web Application: Built with ASP.NET Core using the MVC pattern, serving as the system backend. This layer handles business logic, services, admin CMS, rules, and more.
Rest APIs: The system includes a set of RESTful APIs, providing a persistence layer and interacting with the database.

Setup Instructions
Clone the Repository:

bash
Copy code
git clone https://github.com/MostafaAli22/FasahnyBackEnd
cd ctourism-Travel-System-Backend
Database Setup:

Create a new MS SQL Server database.
Update the connection string in the appsettings.json file.
Run Migrations:

bash
Copy code
dotnet ef database update
Run the Application:

bash
Copy code
dotnet run
The application will be accessible at http://localhost:5000 (or another specified port).

API Endpoints
Endpoint 1: /api/Places

Get list of all places 
Endpoint 2: /api/Places/1

Get details for place ID=1 
>>

Contributing
We welcome contributions to enhance and expand the Cairo Places Tourism System. If you would like to contribute, please follow our Contribution Guidelines.

License
This project is licensed under the MIT License.

Contact
For inquiries or support, please contact Mostafa Ali at mostafa.aeg@gmail.com.
