# Prueba práctica de C# — Versión A: Biblioteca

**Duración:** 3 horas
**Puntuación máxima:** 10 puntos

Desarrolla una aplicación de consola en C# para gestionar las publicaciones de una biblioteca. La aplicación permitirá consultar publicaciones, realizar búsquedas y aplicar filtros utilizando programación orientada a objetos.

## Ejercicios

### 1. Proyecto y control de versiones (0,75 puntos)

Crea un proyecto de consola en C# e inicializa un repositorio Git con un archivo `.gitignore` adecuado para .NET. Desarrolla cada ejercicio de implementación en una rama independiente, utilizando nombres descriptivos con el prefijo `feature/`. Realiza al menos un commit por rama y fusiona cada rama con `main` antes de comenzar el siguiente ejercicio. Conserva las ramas y el historial.

### 2. Modelo de clases (1 punto)

Una biblioteca gestiona tres tipos de publicaciones: libros, revistas y cómics.

Todas las publicaciones tienen un título y un año de publicación. Además:

- Los libros tienen un autor.
- Las revistas tienen un número de edición.
- Los cómics tienen un dibujante.

Diseña las clases necesarias utilizando **herencia y una clase base abstracta**, con las propiedades y tipos de datos adecuados.

### 3. Polimorfismo (1,25 puntos)

Todas las publicaciones deberán disponer de un método `ObtenerDescripcion()` que devuelva una cadena con su información. Declara este método como abstracto en la clase base e impleméntalo en las clases hijas mediante `override`.

Cada tipo de publicación deberá mostrar su información común y específica.

### 4. Colección de publicaciones (0,75 puntos)

Crea una única colección que permita almacenar diferentes tipos de publicaciones. Inicialízala con al menos cinco objetos:

- 2 libros.
- 2 revistas.
- 1 cómic.

Recorre la colección y muestra la descripción de todas las publicaciones utilizando el método desarrollado anteriormente.

### 5. Búsqueda de publicaciones (1 punto)

Implementa un método que permita buscar una publicación por su título:

- La búsqueda no distinguirá entre mayúsculas y minúsculas.
- Si se encuentra, mostrará su descripción.
- Si no se encuentra, mostrará un mensaje indicándolo.

La colección y el título buscado deberán recibirse mediante parámetros. **No utilices LINQ.**

### 6. Filtrado de publicaciones (1,25 puntos)

**A. Filtrado por año (0,75 puntos).** Implementa un método que reciba la colección y un año y muestre las publicaciones posteriores a ese año. Si no hay coincidencias, muestra un mensaje.

**B. Filtrado por tipo (0,5 puntos).** Implementa un método que reciba la colección y muestre únicamente los libros, utilizando el operador `is`.

Ambas operaciones deberán trabajar sobre la colección existente y estar implementadas en métodos independientes. **No utilices LINQ.**

### 7. Estadísticas de publicaciones (1 punto)

Implementa un método que reciba la colección y muestre:

- Número total de publicaciones.
- Número de libros.
- Número de revistas.
- Número de cómics.

Ejemplo de salida:

```text
=== ESTADÍSTICAS ===
Total publicaciones: 5
Libros: 2
Revistas: 2
Cómics: 1
```

Los resultados deberán calcularse recorriendo la colección, sin utilizar LINQ ni escribir manualmente las cantidades.

### 8. Menú interactivo (1,25 puntos)

Crea un menú de consola:

```text
=== BIBLIOTECA ===
1. Ver todas las publicaciones
2. Buscar publicación
3. Filtrar por año
4. Mostrar libros
5. Ver estadísticas
0. Salir
```

El menú deberá repetirse hasta seleccionar `0`, utilizando `while` y `switch`. Cada opción deberá ejecutar el método correspondiente, reutilizando la colección existente.

**Importante:** los métodos de los ejercicios anteriores deberán poder ejecutarse y comprobarse directamente desde `Program.cs`, aunque el menú no esté implementado o no funcione correctamente. El menú se evalúa por separado.

### 9. Validación de entradas (1 punto)

Valida las entradas numéricas mediante `int.TryParse()` y controla:

- Introducir texto en lugar de un número.
- Seleccionar opciones del menú inexistentes.
- Introducir años negativos.

Las entradas incorrectas deberán mostrar un mensaje informativo sin finalizar inesperadamente la aplicación. Estas validaciones pueden probarse desde el menú o mediante llamadas directas desde `Program.cs` cuando corresponda.

### 10. Pruebas de funcionamiento (0,75 puntos)

Ejecuta la aplicación y aporta capturas que demuestren:

- Listado de publicaciones.
- Búsqueda correcta y búsqueda sin resultados.
- Filtrado por año y por tipo.
- Estadísticas.
- Control de una entrada incorrecta.

**Las pruebas podrán realizarse mediante el menú o invocando directamente los métodos desde `Program.cs`.** No es obligatorio tener el menú terminado para demostrar el funcionamiento de los ejercicios anteriores.

## Indicaciones

- Puedes utilizar .NET 8 o .NET 10.
- No utilices LINQ en las búsquedas, filtros o estadísticas.
- No se requieren bases de datos ni persistencia en archivos.
- Se permite consultar apuntes, ejercicios anteriores y documentación; no se permite utilizar inteligencia artificial ni comunicarse con compañeros.
- Realiza los commits y merges progresivamente. Si un ejercicio queda incompleto, puedes integrar sus avances y continuar con el siguiente.

### Evaluación independiente de los ejercicios

Cada ejercicio se evaluará según su funcionamiento y los requisitos especificados, independientemente de que otros ejercicios estén incompletos. La ausencia de un menú funcional no impedirá obtener la puntuación correspondiente a las clases, métodos, búsquedas, filtros o estadísticas correctamente implementados. Se valorarán las soluciones parciales que demuestren el cumplimiento de alguno de los requisitos de cada ejercicio.

## Entrega

Entrega en Classroom **un único archivo ZIP** que contenga:

- El proyecto completo, incluyendo la carpeta `.git` y el archivo `.gitignore`, pero sin las carpetas `bin` ni `obj`. Los cambios desarrollados deberán estar integrados en `main`.
- Una carpeta `evidencias` con las **capturas obligatorias** de las pruebas solicitadas en el ejercicio 10. Puedes organizarlas como imágenes o en un documento Word o PDF.
- Opcionalmente, observaciones, incidencias o documentación complementaria, por ejemplo en un archivo `README.md` u otro `.md`.

La documentación complementaria es opcional y **no sustituye las capturas obligatorias** de las pruebas.