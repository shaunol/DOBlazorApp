# BlazorApp

* Use Docker to create a PostgreSQL database

```
docker run -d --name blazorapp-postgres -e POSTGRES_PASSWORD=password -p 5432:5432 postgres
```

* Run the application to create and fill the database with test data