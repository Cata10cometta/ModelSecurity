# 🔐 ModelSecurity

API REST desarrollada con **ASP.NET Core** para la gestión de usuarios, roles, permisos y autenticación, implementando una arquitectura por capas y buenas prácticas de desarrollo de software.

El proyecto integra autenticación mediante **JWT**, gestión de roles y permisos, recuperación de contraseña por correo electrónico, auditoría de operaciones y persistencia de datos mediante **Entity Framework Core y SQL Server**.

---

## 📌 Características principales

* 🔑 Autenticación mediante JWT
* 👤 Gestión de usuarios
* 🧑‍💼 Gestión de roles
* 🔐 Gestión de permisos
* 📋 Gestión de formularios y módulos
* 🔄 Asignación de roles a usuarios
* 🛡️ Control de acceso
* 📧 Recuperación de contraseña mediante correo electrónico
* 🔒 Encriptación segura de contraseñas
* 📝 Registro de auditoría de operaciones
* 🗑️ Eliminación lógica de registros
* 🗄️ Migraciones con Entity Framework Core
* 📖 Documentación de API mediante Swagger
* 🐳 Configuración para ejecución mediante Docker

---

## 🏗️ Arquitectura

El proyecto está organizado siguiendo una arquitectura por capas para separar responsabilidades y facilitar el mantenimiento y escalabilidad de la aplicación.

```text
ModelSecurity
│
├── Business
│   ├── Implements
│   ├── Interfaces
│   └── Services
│
├── Data
│   ├── Implements
│   └── Interfaces
│
├── Entity
│   ├── Context
│   ├── DDL
│   ├── Dtos
│   ├── Enums
│   ├── Migrations
│   └── Model
│
├── Utilities
│   ├── Exceptions
│   ├── Helpers
│   ├── Interfaces
│   ├── Jwt
│   ├── Mail
│   └── Mappers
│
└── Web
    ├── Controllers
    ├── ServiceExtension
    ├── Dockerfile
    └── Program.cs
```

### Capas

**Business**
Contiene la lógica de negocio y las interfaces de los servicios.

**Data**
Gestiona el acceso y persistencia de información mediante Entity Framework Core.

**Entity**
Contiene las entidades, DTOs, enumeraciones, contexto de base de datos y migraciones.

**Utilities**
Contiene componentes reutilizables como helpers, JWT, correo electrónico, excepciones y mapeos.

**Web**
Contiene la API REST, controladores, configuración de servicios y configuración de la aplicación.

---

## 🛠️ Tecnologías utilizadas

| Tecnología            | Uso                            |
| --------------------- | ------------------------------ |
| C#                    | Lenguaje de programación       |
| .NET / ASP.NET Core   | Desarrollo de la API           |
| Entity Framework Core | ORM y acceso a datos           |
| SQL Server            | Base de datos                  |
| JWT                   | Autenticación                  |
| BCrypt                | Protección de contraseñas      |
| AutoMapper            | Mapeo de entidades y DTOs      |
| FluentValidation      | Validación de datos            |
| Swagger / OpenAPI     | Documentación y pruebas de API |
| Docker                | Contenerización                |
| SMTP                  | Envío de correos               |

---

## 🔐 Autenticación y autorización

La API utiliza **JSON Web Tokens (JWT)** para autenticar las solicitudes.

El flujo general de autenticación es:

```text
Usuario
   │
   ▼
Login
   │
   ▼
Validación de credenciales
   │
   ▼
Generación de JWT
   │
   ▼
Token de acceso
   │
   ▼
Solicitud protegida
   │
   ▼
Autorización
```

El sistema contempla la administración de:

* Usuarios
* Roles
* Permisos
* Formularios
* Módulos
* Relaciones entre usuarios y roles

---

## 📧 Recuperación de contraseña

El sistema incorpora un flujo de recuperación de contraseña mediante correo electrónico.

```text
Solicitud de recuperación
          │
          ▼
Generación de token
          │
          ▼
Envío de correo
          │
          ▼
Enlace de recuperación
          │
          ▼
Nueva contraseña
```

---

## 📝 Auditoría

El sistema registra las operaciones realizadas sobre las entidades, permitiendo mantener un historial de cambios.

Entre las operaciones contempladas se encuentran:

* Creación
* Modificación
* Eliminación

La información de auditoría permite identificar cambios realizados y conservar información relacionada con las operaciones efectuadas en el sistema.

---

## 🗄️ Base de datos

El proyecto utiliza **SQL Server** como sistema gestor de base de datos y **Entity Framework Core** para la persistencia.

Las migraciones se encuentran en:

```text
Entity/Migrations
```

También se incluye el script SQL:

```text
Entity/DDL/DDL sqlServer.sql
```

---

## ⚙️ Requisitos

Antes de ejecutar el proyecto debes tener instalado:

* [.NET SDK](https://dotnet.microsoft.com/download)
* SQL Server
* Git
* Visual Studio, Visual Studio Code o JetBrains Rider

Opcionalmente:

* Docker

---

## 🚀 Instalación

### 1. Clonar el repositorio

```bash
git clone https://github.com/TU-USUARIO/ModelSecurity.git
```

### 2. Entrar al proyecto

```bash
cd ModelSecurity
```

### 3. Restaurar dependencias

```bash
dotnet restore
```

### 4. Configurar la base de datos

Configura la cadena de conexión de SQL Server en la configuración local de la aplicación.

> ⚠️ No publiques contraseñas, claves JWT ni credenciales de correo dentro del repositorio.

Se recomienda utilizar **User Secrets** o variables de entorno para información sensible.

### 5. Aplicar migraciones

```bash
dotnet ef database update
```

### 6. Ejecutar la aplicación

```bash
dotnet run
```

---

## 📖 Swagger

Una vez ejecutada la aplicación, puedes acceder a Swagger desde la URL configurada por ASP.NET Core.

Swagger permite consultar y probar los diferentes endpoints disponibles en la API.

---

## 🐳 Docker

El proyecto incluye configuración para Docker mediante:

```text
Web/Dockerfile
```

Para construir la imagen:

```bash
docker build -t modelsecurity .
```

Y posteriormente ejecutar el contenedor:

```bash
docker run -p 8080:8080 modelsecurity
```

> La configuración de conexión a la base de datos y demás variables de entorno debe ajustarse según el entorno donde se ejecute la aplicación.

---

## 📂 Principales componentes

```text
Usuarios
   │
   ├── Roles
   │     └── Permisos
   │
   └── Autenticación JWT

Formularios
   │
   └── Módulos
         └── Permisos

Auditoría
   │
   └── Registro de operaciones
```

---

## 🎯 Objetivo del proyecto

El objetivo de **ModelSecurity** es desarrollar una API REST que permita gestionar de manera centralizada usuarios, autenticación, roles y permisos, aplicando principios de arquitectura por capas, separación de responsabilidades y buenas prácticas de desarrollo.

---

## 👩‍💻 Autora

**Catalina Cometa**

Proyecto desarrollado con fines académicos y de aprendizaje en desarrollo de software, arquitectura de aplicaciones y seguridad.

---

## 📄 Licencia

Este proyecto se encuentra disponible con fines educativos y de portafolio.
