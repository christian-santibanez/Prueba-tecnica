# InventoryAPI - [Christian Santibáñez Martínez]

API para gestión de inventario con .NET 9, PostgreSQL y Entity Framework Core.

![Texto alternativo](https://github.com/christian-santibanez/Prueba-tecnica/blob/master/InventoryAPI/Prueba_Tecnica.png?raw=true)

## Requisitos
- .NET 9 SDK
- PostgreSQL +14

## Instalación
1. Clona el repositorio:
   ```bash
   git clone https://github.com/christian-santibanez/Prueba-tecnica.git
   
2. Configura la base de datos

Crea una base de datos en PostgreSQL llamada InventoryDB.

Actualiza la cadena de conexión en appsettings.json:
    
    "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=5432;Database=InventoryDB;User Id=postgres;Password=tu_contraseña;"
    }

3. Aplica las migraciones:
    
    dotnet ef database update
    
4. Ejecuta la API:
    
    dotnet run
    
Endpoints
Accede a Swagger en: https://localhost:[PUERTO]/swagger.


GET	        /api/productos	    Lista productos paginados 

POST	    /api/productos	    Crea un producto

GET	        /api/categorias	    Lista categorías

## Estructura del Proyecto

Controllers: Manejo de endpoints.

Services: Lógica de negocio.

Repositories: Acceso a datos (Patrón Repository).

Models: Entidades de la base de datos.

Migrations: Scripts de EF Core.

## Licencia

MIT
