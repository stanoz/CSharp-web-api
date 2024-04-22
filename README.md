# Star Wars Web Application Project

This project is a web API that shows statistics of Star Wars planets. Developed using C#.

## Project Overview

This project interacts with a public API to retrieve data, which is then transferred to a PostgreSQL database. The project provides an API to modify this data. It also includes a user interface for easier interaction with the system. Additionally, the project generates logs for monitoring and debugging purposes.

## Features

The API provides the following features:

- Planet Management: add, edit, delete, and get planets.

## API Endpoints

1. **Planet Management**:
   - `GET /api/Planet`: Retrieve all planets.
   - `GET /api/Planet/{id}`: Retrieve a specific planet by its ID.
   - `PUT /api/Planet/{id}`: Edit a specific planet by its ID.
   - `POST /api/Planet`: Add a new planet.
   - `DELETE /api/Planet/{id}`: Delete a specific planet by its ID.

