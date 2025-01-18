
# Challenge Back-end | Python - Megapix

## IMPORTANTE
El challenge esta echo en .NET 9 (C#) mostrando asi otra manera de hacerlo con otro lenguaje y Framework

## Descripción General

El desafío consiste en crear una API REST utilizando Django y Django REST Framework para gestionar información de países obtenida desde un API externo.

## Requisitos

### Tarea Programada
- Ejecutar automáticamente cada 1 hora.
- Consumir el endpoint público: [https://restcountries.com/v3.1/all?fields=name,flags,capital,population,continents,timezones,area,latlng](https://restcountries.com/v3.1/all?fields=name,flags,capital,population,continents,timezones,area,latlng).
- Guardar los datos en una tabla relacional `countries`.
- Validar los datos antes de almacenarlos.
- Manejar errores si el API no está disponible.
- Evitar la duplicación de datos.
- Manejo de concurrencia para evitar ejecuciones simultáneas (opcional).

### Endpoint REST
- Listar datos almacenados en la base de datos mediante el método GET.
- Paginación habilitada (sin autenticación).
- Opciones de filtrado o consulta por ID (opcional).
- Optimización para grandes volúmenes de datos (opcional).

### Consideraciones Técnicas
- Aplicación dockerizada.
- Base de datos relacional PostgreSQL.
- Dependencia externa única: API de `restcountries.com`.

---

## Pasos para Ejecutar el Proyecto

### Requisitos Previos
1. Descargar e instalar [Docker](https://www.docker.com/) (si no lo tienes instalado).
2. Asegurarse de que los puertos 5432, y 8080/8181 estén libres.

### Instrucciones
1. Clonar el repositorio:
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   cd <NOMBRE_DEL_REPOSITORIO>
   ```

2. Construir y levantar los contenedores:
   ```bash
   docker compose up -d --build
   ```

3. Esperar a que Docker indique que todos los contenedores están activos.

4. El servicio en segundo plano llenará la base de datos con datos en un intervalo de una hora.

5. Verificar el endpoint REST accediendo a:
   ```
   http://localhost:8080/api/country
   ```

   - Los datos estarán paginados en grupos de 10 registros.

---

## Notas
- El comando `docker compose up -d --build` creará todos los contenedores, volúmenes y redes necesarios:
  - Servicio de PostgreSQL.
  - NET 9.
- La base de datos se inicializará automáticamente y las migraciones necesarias se aplicarán al iniciar.

¡Disfruta del desarrollo y la prueba de este proyecto!
