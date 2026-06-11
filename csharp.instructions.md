---
description: Instrucciones de desarrollo para el proyecto IA_AstroBooking en C#.
applyTo: **/*.cs
---
# Instrucciones de Desarrollo C# - IA_AstroBooking

## Convenciones de Código

### Nomenclatura
- **Clases y Métodos**: PascalCase (ej: `GetNameQuery`, `ExecuteAsync`)
- **Variables locales y parámetros**: camelCase (ej: `nameInfo`, `cancellationToken`)
- **Constantes**: UPPER_SNAKE_CASE o PascalCase (ej: `MAX_RETRIES`, `DefaultTimeout`)
- **Interfaces**: PascalCase con prefijo `I` (ej: `INameProvider`, `INameRepository`)

### Estructura de Código
- Organiza el código en 4 capas: API, Application, Domain, Infrastructure
- Cada clase debe tener una única responsabilidad (SRP)
- Usa `async/await` para operaciones asincrónicas
- Siempre proporciona `CancellationToken` en métodos async

## Patrones Arquitectónicos

### CQRS (Command Query Responsibility Segregation)
- **Queries**: Consultas de solo lectura en `Application/Features/[Feature]/Queries/`
- **Commands**: Operaciones que modifican estado en `Application/Features/[Feature]/Commands/`
- Implementa handlers que manejen la lógica de negocio

### Capas
- **Domain**: Contratos (`INameInfo.cs`), Entidades (`NameInfo.cs`)
- **Application**: Lógica de negocio, CQRS, Abstracciones
- **Infrastructure**: Implementación de repositorios y servicios externos
- **API**: Controllers, endpoints REST

## Testing

### Convenciones xUnit
- Estructura: `Arrange`, `Act`, `Assert`
- Nombre: `MethodName_Scenario_ExpectedResult()`
- Ubicación: `IA_AstroBooking.IA_API.Application.Tests/Features/[Feature]/`

Ejemplo:
```csharp
[Fact]
public async Task GetName_WithValidInput_ReturnsNameInfo()
{
    // Arrange
    var query = new GetNameQuery("test");
    
    // Act
    var result = await handler.Handle(query, CancellationToken.None);
    
    // Assert
    Assert.NotNull(result);
}
```

## Comandos de Desarrollo

### Build & Run
```bash
dotnet build IA_AstroBooking.IA_API.slnx
dotnet run --project IA_AstroBooking.IA_API.API
dotnet test IA_AstroBooking.IA_API.slnx
dotnet publish IA_AstroBooking.IA_API.API -c Release -o ./publish
```

## Seguridad
- HTTPS redirection activado en producción
- Validar entrada en Controllers
- Usar DTOs para transferencia de datos

## Documentación
- Código y comentarios en español
- Usar XML comments para métodos públicos (`/// <summary>`)
- Mantener README.md actualizado
