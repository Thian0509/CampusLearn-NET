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

Generated: 2025-09-14T18:34:04.537424Z