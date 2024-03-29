﻿## ASP.NET Core Project

This project was developed as a learning experience, so I used RepositoryPattern Generic.

## Requirements
SDK net6.0 and MongoDB Server

## Build and Run

To run this project enter the root directory and run `dotnet build` && `dotnet run`

## Run With `docker compose`

Enter the root directory and run

1 - Build the updated image aspnet-core `docker compose build`

2 - Run docker-compose.yml `docker compose up -d`

## Run with `docker run`
This image requires a [MongoDB](https://hub.docker.com/_/mongo) instance with volume and linked to a Docker Network
```bash
docker network create backend
```
```bash
docker volume create api_mongo_data
```
```bash
docker run -d -v api_mongo_data:/data/db -p 27017:27017 --network backend --name my-mongodb mongo
```

## How to build and start a image exposure on port 5000 for HTTP
```bash
docker build -t api .
```
```bash
docker run -dp 5000:80 --env-file=".env" --network backend api
```

If you set the environment variable ASPNETCORE_ENVIRONMENT to Develpment, [Swagger UI](https://swagger.io/tools/swagger-ui/) will be enabled, this will help you read the API documentation.

You can also set the environment variable ASPNETCORE_ENVIRONMENT for Production to disable [Swagger UI](https://swagger.io/tools/swagger-ui/).

Try in browser: http://localhost:5000/swagger/index.html