# TaskDesk

Aplicación de escritorio WinForms para gestionar tareas por usuario.

Características
- Registro e inicio de sesión de usuarios (hash de contraseña SHA-256).
- Creación, edición y eliminación de tareas.
- Marcar tareas como completadas / incompletas.
- Listado de tareas incompletas y tareas completadas por usuario.

Requisitos
- Windows
- .NET 8 SDK
- SQL Server (p. ej. SQL Express)
- Visual Studio 2022/2024 (recomendado) o `dotnet` CLI

Instalación y ejecución
1. Abrir la solución `TaskDesk.sln` en Visual Studio y ejecutar la aplicación.
   - O usar la CLI desde la carpeta del proyecto:
     ```bash
     cd TaskDesk
     dotnet build
     dotnet run
     ```

Base de datos
La conexión está definida en `TaskDesk\Data\Database.cs` en la constante `connectionString`.
Ejemplo actual (ajústalo a tu entorno):

```
Server=Abel\SQLEXPRESS;Database=TaskDeskDB;Trusted_Connection=True;TrustServerCertificate=True;
```

Crea la base de datos y tablas necesarias con el siguiente script SQL:

```sql
CREATE DATABASE TaskDeskDB;
GO
USE TaskDeskDB;
GO

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME2 NOT NULL,
    Name NVARCHAR(100) NULL,
    Surnames NVARCHAR(200) NULL
);

CREATE TABLE Tasks (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    Priority INT NOT NULL DEFAULT 0,
    DueDate DATETIME2 NULL,
    UserId INT NOT NULL,
    Completed BIT NOT NULL DEFAULT 0,
    CONSTRAINT FK_Tasks_Users FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE
);
```

Uso
- Registrar una cuenta desde la pantalla de registro.
- Crear nuevas tareas con el botón correspondiente.
- Doble clic sobre una tarea para editarla.
- Marcar como completada o eliminar desde la lista.
- Ver tareas completadas desde el enlace "Completadas".

Notas de desarrollo
- Repositorio: `TaskDesk` (WinForms, C# 12, .NET 8)
- Repositorio de datos: `TaskDesk\Data\Database.cs`
- Repositorios: `TaskDesk\Repositories\UserRepository.cs`, `TaskDesk\Repositories\TaskRepository.cs`
- Modelos: `TaskDesk\Models`

Contribuciones
Abrir issues o crear pull requests en el repositorio. Revisar primero la configuración de la base de datos y cadena de conexión.

