# Instrucciones del agente

## Descripcion general del producto
- API de ejemplo en .NET 10 para IA_AstroBooking.
- Aplica arquitectura limpia en 4 capas para separar responsabilidades.
- Usa CQRS para consultas y expone OpenAPI con Swagger.

## Implementacion tecnica

### Tech Stack
- Idioma: C# 13 con .NET 10 (net10.0).
- Framework: ASP.NET Core Web API 10.
- Base de datos: Sin base de datos persistente en esta version.
- Seguridad: HTTPS redirection; sin auth/autorizacion implementada.
- Pruebas: xUnit + Microsoft.NET.Test.Sdk + coverlet.collector.
- Registro de eventos: Logging nativo de ASP.NET Core.

### Flujo de trabajo de desarrollo
```bash
# Configurar el proyecto
dotnet restore IA_AstroBooking.IA_API.slnx

# Construir/Compilar el proyecto
dotnet build IA_AstroBooking.IA_API.slnx

# Ejecutar el proyecto
dotnet run --project IA_AstroBooking.IA_API.API

# Probar el proyecto
dotnet test IA_AstroBooking.IA_API.slnx

# Despliega el proyecto
dotnet publish IA_AstroBooking.IA_API.API -c Release -o ./publish
```

### Estructura de carpetas
```text
|--- AGENTS.md
|--- README.md
|--- LICENSE.md
|--- IA_AstroBooking.IA_API.slnx
|--- IA_AstroBooking.IA_API.API/
|--- IA_AstroBooking.IA_API.Application/
|--- IA_AstroBooking.IA_API.Domain/
|--- IA_AstroBooking.IA_API.Infrastructure/
|--- IA_AstroBooking.IA_API.Application.Tests/
```

## Ambiente
- El codigo y la documentacion deben estar en espanol.
- Las respuestas del chat deben ir en el idioma solicitado por el usuario.
- En la respuesta, priorizar concision sobre gramatica perfecta.
- Este es un entorno de ventana que utiliza la terminal git bash.
- Mi rama predeterminada es main.
