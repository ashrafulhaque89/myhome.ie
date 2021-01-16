# A Simple CRUD API built with C# .NET Core 3.1 replicating Myhome.ie API

You will need Microsoft Visual Studio to run this solution project or you can use any editor of your choice if you have minimum .net core 3.1 installed in your Windows/MAC/Linux machine. The API uses SQL Lite Database which will be built automatically upon running the application for the first time and some data will be seeded automatically.

This API has full CRUD functionalities with 2 endpoints: 
1. api/home : Shows list of Properties
2. api/home/id : Shows Property by Id

- To run the app, use - dotnet run - command in the CLI
- To delete a Property by Id, send HttpDelete request to https://localhost:5001/api/home/id
- To add new Property, copy following **JSON** structure and make HttpPost request to https://localhost:5001/api/home/

JSON
----

```json
{
    "PropertyId" : 4292232,
    "GroupLogoUrl" : "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
    "BedsString" : "2 beds",
    "Price" : 395000,
    "SizeStringMeters" : 52.95,
    "DisplayAddress" : "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2",
    "PropertyType" : "Apartment",
    "BerRating" : "D2",
    "MainPhoto" : "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
    "Photo" : "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
}
```
- To update Property list, take above sturcture and make HttpPut call to https://localhost:5001/api/home/
- If any field is EMPTY or NULL you can leave it blank. The API has been designed in a way to omit NULL values from the query result.

Working demo of API in Azure : https://myhome-ie.azurewebsites.net/api/home
---
Swagger : https://myhome-ie.azurewebsites.net/swagger/index.html
---
Working demo of API in Docker Container : https://myhome-ie.herokuapp.com/api/home
---
Swagger : https://myhome-ie.herokuapp.com/swagger/index.html
---

To test the API using Swagger simply type "dotnet watch run" from the API directory and you will be redirected to the Swagger UI!

You can also manually redirect to swagger from here while running from your IDE : https://localhost:5001/swagger/index.html
In the web as working demo : https://myhome-ie.herokuapp.com/swagger/index.html & https://myhome-ie.azurewebsites.net/swagger/index.html

A Swagger screenshot given below:

![Console App output](https://github.com/ashrafulhaque89/myhome.ie/blob/master/Swagger.png)

You can either run Unit Test From Visual Studio or Vistual Studio Code : 

![Console App output](https://github.com/ashrafulhaque89/myhome.ie/blob/master/Unit_test.png)
