![STATUS-FINISHED](https://github.com/cauemondek/movie-website/assets/121320616/26322afa-075d-41b7-b9f1-fec1a11a3e0c)

<h1 align="center">ASP.NET API | ToDo List</h1>
<p align="center">A complete API RESTful for a ToDo List with HTTP Methods.</p>

## 📁 How access the project

**You need pull this project with Docker, or download this repository in your machine**

## 🛠️ Open and run the project

**Method 1: Docker (Recommended)**
- *You will need [Docker](https://www.docker.com/get-started/) installed and configured in your system*
- *In the terminal:*
```cs
// Pull the project
docker pull ghcr.io/cauemondek/asp.net-api:latest

// To run the Docker Container
docker run --name dotnet-api-cauemondek -p 8080:8080 -d ghcr.io/cauemondek/asp.net-api:latest
```
- *Now the API is host in port 8080*
- *(You can type `docker stop dotnet-api-cauemondek` in terminal to shutdown the project)*

**Method 2: Download Repository**

- *Download the Reposity Files in Github or use `git clone https://github.com/cauemondek/ASP.NET-API.git` in terminal with GIT installed and configured*
- *You will need [.NET SDK 8.0](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0) installed*
- *In terminal on the project:*
```js
// Run the project
dotnet run

// Will appear your PORT
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5227  <- This is your PORT
```
- *Now the API is host in port mentioned*
- *(You can use `CTRL + C` in terminal to shutdown the project)*

**After configured the project (Downloaded Method or Docker Method)**

- *For acess you will need [Insomnia](https://insomnia.rest/download) or [Postman](https://www.postman.com/)*
- *After this you can make a GET, POST, PUT or Delete Requisition with JSON in this url "http://localhost:{Your PORT}/v1/todos"*
- *For POST example:*
```json
{
    "title": "Wash the dishes"
}
```
- *For GET open your browser in: "http://localhost:{Your PORT}/v1/todos" or make a GET  with this URL*
- *For GET by ID open your browser in: "http://localhost:{Your PORT}/v1/todos/{The Task ID}" or make a GET requisition with this URL*
- *For PUT send a JSON in: "http://localhost:{Your PORT}/v1/todos/{The Id of the Task you want to change}, example:*
```json
{
    "title": "Sweep the floor"
}
// Sending to http://localhost:8080/v1/todos/5 for change the ToDo 5
```
- *For DELETE open your browser in: "http://localhost:{Your PORT}/v1/todos/{The Id of the Task you want to delete} or make a DELETE requisition with this URL*

## 🔨 Built with
- ``C#``
- ``ASP.NET``
- ``Docker``
- ``SQLite``

## ✔ Project features

`✨ Feature 1`: HTTP Methods

`✨ Feature 2`: Create a ToDo Task

`✨ Feature 3`: Edit a ToDo Task

`✨ Feature 4`: Search all or a especific ToDo Task for ID

`✨ Feature 5`: Delete a ToDo Task
