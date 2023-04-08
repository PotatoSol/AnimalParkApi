# _Animal Shelter Api_

#### By _**Michael Sol**_

#### _An Api for viewing animals being housed at a hypothetical Animal Shelter_

## Technologies Used

* _C#_
* _Dotnet 6_
* _SQL_
* _Entity Framework Core_
* _Swagger_
* _Api Versioning_

## Description

_Allows a user to view information about animals available at a hypothetical Animal Shelter.  Animals have a name, species, age, and ID_

## Setup/Installation Requirements

* _Navigate to the GitHub_
* _Clone the Repo_
* _Open the project using VS Code_
* _Open a new terminal_
* _In the terminal, navigate to 'AnimalParkApi/AnimalShelter'_ 
* _Create an appsettings.json file_
* _Include the following lines in it:_

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=7277;database=animal_shelter_api_db;uid=[YOUR-USER-HERE];pwd=[YOUR-PW-HERE];"
  }
}

* _Run the following commands:_
* _'dotnet ef database update'_
* _'dotnet restore'_
* _'dotnet watch run'_

* _Access the api via browser: https://localhost:7277/swagger/index.html_

* _Endpoints:_

* _V1:_

>GET https://localhost:7277/v1/animals

>GET https://localhost:7277/v1/animals/{id}

>GET https://localhost:7277/v1/Animals?species={species}

>POST https://localhost:7277/v1/animals

>PUT https://localhost:7277/v1/animals/{id}

>DELETE https://localhost:7277/v1/animals/{id}

* _V2:_

>GET https://localhost:7277/v2/animals

>GET https://localhost:7277/v2/animals/{id}

>GET https://localhost:7277/v2/Animals?species={species}

>GET https://localhost:7277/v2/Animals?age={int}

>GET https://localhost:7277/v2/Animals?species={species}&age={int}

>POST https://localhost:7277/v2/animals

>PUT https://localhost:7277/v2/animals/{id}

>DELETE https://localhost:7277/v2/animals/{id}


## Known Bugs

*_None_

## License

_Contact Michael with any problems_

Copyright (c) _2/24/23_ _Michael Sol_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.