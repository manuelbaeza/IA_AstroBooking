#  Instrucciones para crear agentes

## Rol
Actúa como un ingeniero de software

## Tarea
Crea un conjunto de instrucciones para que los agentes de IA comprendan el proyecto.

## Contexto
Browse and read the project files to gather context.

### Plantilla de instrucciones
Asegúrese de que el archivo sea corto (<= 100 sentencias) y las sentencias cortas (<= 100 caracteres).
Sigue esta plantilla y guárdala en formato Markdown como archivo 'AGENTES.md'.

````markdown
# Instrucciones del agente

## Descripción general del producto
- {¿De qué trata el producto? Explícalo en 2 o 3 frases cortas.}

## Implementación técnica

### Tech Stack
- Idioma: **{idioma y versión}**
- Framework: **{framework y versión}**
- Base de datos: **{database}**
- Seguridad: **{estrategia de seguridad}**
- Pruebas: **{framework de pruebas}**
- Registro de eventos: **{herramienta de registro de eventos}**

### Flujo de trabajo de desarrollo
```bash
# Configurar el proyecto
# Construir/Compilar el proyecto
# Ejecutar el proyecto
# Probar el proyecto
# Despliega el proyecto
```

### Estructura de carpetas
```text

|--- AGENTS.md
|--- README.md
|--- LICENCE.md
|--- {other_files}
|--- {other_folders}/
```

## Ambiente
- El código y la documentación deben estar en español.
- Las respuestas del chat deben estar en el idioma del mensaje que se le solicitó al usuario.
- En la respuesta, sacrifique la gramática en aras de la concisión.
- Este es un entorno de ventana que utiliza la terminal git bash.
- Mi rama predeterminada es `main`.
````

## Pasos a seguir:
1. **Descripción general del producto**: 
    - Resume el producto en 2-3 sentencias cortas.
2. **Implementación técnica**:
    - Tecnologías utilizadas: Enumere las principales tecnologías utilizadas.
    - Flujo de trabajo de desarrollo: Comandos para configurar, compilar, ejecutar, probar y desplegar.
    - Estructura de carpetas: Describa las carpetas y archivos principales.
    - Entorno: Enumere los detalles relevantes del entorno y copie la sección predeterminada.
3. **Escribe las instrucciones**:
    - Sigue la plantilla y sé conciso.

## Lista de verificación de salida:
- [] El resultado debe ser un archivo Markdown llamado `AGENTS.md`