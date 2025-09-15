# CampusLearn™ – Project 1 Physical Class Representation (.NET 8)

Clean Architecture skeleton matching your UML. MongoDB is used to align with Assignment 2. Swagger enabled.

## How to run
1. Ensure MongoDB is reachable (Atlas or local). Update `src/CampusLearn.Api/appsettings.json`.
2. Open `CampusLearn.sln` in **Visual Studio 2022** or VS Code with C# Dev Kit.
3. Set startup project to **CampusLearn.Api** and F5.

### Endpoints
- `POST /api/users/register` { name, email, password, role }
- `POST /api/topics` { creatorUserId, title, description, moduleCode }
- `POST /api/topics/question` { topicId, studentId, content, isAnonymous }
- `POST /api/topics/respond` { topicId, questionId, userId, content }
- `GET /api/topics/latest?take=10`

## Mapping to UML
- `User` (base) with `Student`, `Tutor`, `Admin` derived classes.
- Core entities: `Topic`, `Question`, `Response`, `Resource`.
- Communications: `Forum` (skeleton), `PrivateMessage` (POCO), `NotificationService` (interface).
- AI Assistant: `IAIChatbot` interface.

## Notes
- Keep passwords hashed (SHA256 placeholder).
- Add auth later using JWT and role-based policies.
- Repository & Service layers wired via DI.

---

# CampusLearn Project Architecture
This project is structured using a Clean Architecture approach, with each component serving a distinct purpose. The separation of concerns makes the codebase more organized, maintainable, and testable.

## CampusLearn.Api
This is the presentation layer and the entry point of the application. It's responsible for handling incoming web requests (like HTTP requests from a browser or another service) and exposing the application's functionality. This project contains the controllers that define the web API endpoints and references the Application project to access the business logic.

## CampusLearn.Application
This is the application layer. It contains the core business logic, use cases, and application-specific rules. It defines the operations the application can perform, such as "create a course" or "enroll a student," and orchestrates the flow of data between the other layers. This layer depends on the Domain and Infrastructure projects to perform its tasks.

## CampusLearn.Domain
This is the domain layer or the core of the application. It contains the essential business entities (like Student or Course), value objects, and business rules that are independent of any specific technology. This project is at the center of the architecture and has no dependencies on the other projects, ensuring it remains focused on the business problem.

## CampusLearn.Infrastructure
This is the infrastructure layer. It handles all the technical details and external dependencies. This includes code for interacting with a database, external services, file systems, or other third-party libraries. This layer is referenced by the Application project to perform tasks like data persistence and by the API project for specific infrastructure-related concerns.
