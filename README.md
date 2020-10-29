## REQUISITOS

.NET 3.1
SqlLocalDB SQL SERVER
SQL Server
Visual Studio 2019
EntityFrameworkCore SQLite 3.1.9
EntityFrameworkCore SQL Server 3.1.9
EntityFrameworkCore Tools 3.1.9
EntityFrameworkCore 3.1.9

## Pasos instalacion

1.- generar el servidor `sqllocaldb create "NEORIS"`

2.- Descargar el proyecto y abrirlo en visual studio
    Ir a Herramientas
    Administrador de paquetes NuGet
    Consola del Administrador de paquetes
    
3.-  Una ves en consola generamos las migraciones de la base de datos 
      `Add-Migration DbInit`
      
      `Update-Database`

4.- Compilamos el proyecto y esta listo para usarse

Si no se puede generar la migracion de la base de datos favor de verificar el archivo appsettings.json que es donde esta la conexión
