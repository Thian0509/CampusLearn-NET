# CampusLearn™ – Project 1 Physical Class Representation (.NET 8)

Clean Architecture skeleton matching your UML. MongoDB is used to align with Assignment 2. Swagger enabled.

---

<Details>
  <summary><b>How to run</b></summary>
  <ol>
    <li>Ensure MongoDB is reachable (Atlas or local). Update `src/CampusLearn.Api/appsettings.json`.</li>
    <li>Open `CampusLearn.sln` in **Visual Studio 2022** or VS Code with C# Dev Kit.</li>
    <li>Set startup project to **CampusLearn.Api** and F5.</li>
  </ol>
</Details>

---

<details>
    <summary><b>Endpoints</b></summary>
    <ul>
        <li><code>POST /api/users/register</code> { name, email, password, role }</li>
        <li><code>POST /api/topics</code> { creatorUserId, title, description, moduleCode }</li>
        <li><code>POST /api/topics/question</code> { topicId, studentId, content, isAnonymous }</li>
        <li><code>POST /api/topics/respond</code> { topicId, questionId, userId, content }</li>
        <li><code>GET /api/topics/latest?take=10</code></li>
    </ul>
</details>

---

<details>
    <summary><b>Mapping to UML</b></summary>
    <ul>
        <li><code>User</code> (base) with <code>Student</code>, <code>Tutor</code>, <code>Admin</code> derived classes.</li>
        <li>Core entities: <code>Topic</code>, <code>Question</code>, <code>Response</code>, <code>Resource</code>.</li>
        <li>Communications: <code>Forum</code> (skeleton), <code>PrivateMessage</code> (POCO), <code>NotificationService</code> (interface).</li>
        <li>AI Assistant: <code>IAIChatbot</code> interface.</li>
    </ul>
</details>

---

<details>
    <summary><b>Notes</b></summary>
    <ul>
        <li>Keep passwords hashed (SHA256 placeholder).</li>
        <li>Add auth later using JWT and role-based policies.</li>
        <li>Repository & Service layers wired via DI.</li>
    </ul>
</details>

---

<details>
    <summary><b>CampusLearn Project Architecture</b></summary>
    <p>This project is structured using a Clean Architecture approach, with each component serving a distinct purpose. The separation of concerns makes the codebase more organized, maintainable, and testable.</p>
    <ul>
        <li>
            <strong>CampusLearn.Api</strong>: <br> This is the presentation layer and the entry point of the application. It's responsible for handling incoming web requests (like HTTP requests from a browser or another service) and exposing the application's functionality. This project contains the controllers that define the web API endpoints and references the Application project to access the business logic.
        </li>
        <li>
            <strong>CampusLearn.Application</strong>: <br> This is the application layer. It contains the core business logic, use cases, and application-specific rules. It defines the operations the application can perform, such as "create a course" or "enroll a student," and orchestrates the flow of data between the other layers. This layer depends on the Domain and Infrastructure projects to perform its tasks.
        </li>
        <li>
            <strong>CampusLearn.Domain</strong>: <br> This is the domain layer or the core of the application. It contains the essential business entities (like Student or Course), value objects, and business rules that are independent of any specific technology. This project is at the center of the architecture and has no dependencies on the other projects, ensuring it remains focused on the business problem.
        </li>
        <li>
            <strong>CampusLearn.Infrastructure</strong>: <br> This is the infrastructure layer. It handles all the technical details and external dependencies. This includes code for interacting with a database, external services, file systems, or other third-party libraries. This layer is referenced by the Application project to perform tasks like data persistence and by the API project for specific infrastructure-related concerns.
        </li>
    </ul>
</details>
