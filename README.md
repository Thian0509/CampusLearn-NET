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

---

<details>
  <summary><b>Assignment 1: Project Plan & Agile Methodology</b></summary>
  <br>
  <p>This assignment focused on the design and planning of CampusLearn™, a peer-to-peer tutor-led learning platform for Belgium Campus students. The purpose of this deliverable was to analyze the system's requirements and select the most appropriate Agile development methodology for its implementation.</p>
  
  <br>
  <h2>Functional Requirements:</h2>
  <ul>
    <li><b>Student Registration & Login:</b> Students can register/sign in using their official student email.</li>
    <li><b>Profile Management:</b> Students can view and update their personal and academic details.</li>
    <li><b>Topic Creation and Subscription:</b> Students can create help topics and subscribe/unsubscribe to topics and tutors.</li>
    <li><b>Tutor Permissions:</b> Approved tutors can respond to topics within their registered modules.</li>
    <li><b>Tutor Responses & Feedback:</b> Tutors can answer questions and provide structured feedback.</li>
    <li><b>Learning Materials:</b> Tutors can upload and manage learning materials (PDF/Video/Audio/Links).</li>
    <li><b>Public Forum:</b> A public space for anonymous questions, replies, and upvoting, with administrator tools.</li>
    <li><b>AI Tutor Assistant:</b> A chatbot handles FAQs and can escalate questions to relevant tutors.</li>
    <li><b>Private Messaging:</b> A secure 1:1 messaging thread is opened when a topic is assigned.</li>
    <li><b>Notifications:</b> Email, SMS, or WhatsApp notifications for key updates.</li>
    <li><b>Device Support:</b> Core features are functional on both mobile and desktop devices.</li>
  </ul>
  
  <h2>Non-Functional Requirements:</h2>
  <ul>
    <li><b>Security & Privacy:</b> Campus email verification, encrypted transport, role-based access, and minimal personal information storage.</li>
    <li><b>Availability:</b> The system must maintain ≥ 99.5% monthly uptime.</li>
    <li><b>Performance:</b> P95 page load < 3s and P95 API latency < 300ms.</li>
    <li><b>Scalability:</b> The system must support ≥ 1,000 concurrent users.</li>
    <li><b>Usability & Accessibility:</b> WCAG 2.1 AA compliant for a consistent user experience.</li>
    <li><b>Reliability:</b> Graceful degradation of the AI assistant and no data loss on failed uploads.</li>
    <li><b>Auditability & Moderation:</b> Forum moderation logs are retained for a minimum of six months.</li>
    <li><b>Mobile Responsiveness:</b> Core features are usable on small screen widths.</li>
  </ul>
  
  <h2>Selected Agile Methodology: Scrum</h2>
  <p><b>Scrum</b> was chosen as the Agile framework for this project. This iterative and incremental approach, which organizes work into short cycles called sprints, is ideal for a project with complex and changing requirements. It emphasizes teamwork, constant feedback, and continuous adaptation, allowing the development team to respond quickly to the evolving needs of students, tutors, and stakeholders.</p>
  
  <h3>Justification:</h3>
  <ul>
    <li><b>Adaptability:</b> Scrum's iterative nature allows the team to incorporate feedback from the lecturer and users at the start of each sprint.</li>
    <li><b>User-Centric Development:</b> The methodology ensures that features are developed and tested early, aligning the final product with actual user needs.</li>
    <li><b>Manageable Workload:</b> Breaking down the large scope into weekly sprints makes the project less overwhelming and ensures a working, testable product is delivered consistently.</li>
    <li><b>Collaboration:</b> Scrum promotes a self-organizing team, which is perfect for a small student project, fostering a greater sense of ownership and boosting morale.</li>
  </ul>
  
  <h3>Scrum Implementation (Team of 5)</h3>
  <ul>
    <li><b>Roles:</b> All 5 group members act as <b>Developers</b>. The roles of <b>Product Owner</b> and <b>Scrum Master</b> are shared on a rotational basis.</li>
    <li><b>Cadence:</b> 1-week sprints, aligned with the weekly assignment deliverables.</li>
    <li><b>Events:</b>
    <ul>
      <li>Sprint Planning: Max 1 hour.</li>
      <li>Daily Stand-ups: ≤ 15 minutes.</li>
      <li>Sprint Review: A demo for the lecturer/stakeholders.</li>
      <li>Sprint Retrospective: 30 minutes.</li>
    </ul>
    </li>
    <li><b>Artefacts:</b>
    <ul>
      <li>Product Backlog: Features derived from the CampusLearn™ brief.</li>
      <li>Sprint Backlog: The selected features for the current sprint.</li>
      <li>Increment: A demo-ready system with new additions each sprint.</li>
    </ul>
    </li>
    <li><b>Definition of Done:</b> A feature is considered "Done" when it is implemented, tested, peer-reviewed, and integrated into the project repository with updated documentation.</li>
    <li><b>Feedback Loop:</b> Feedback from the lecturer and peers at sprint reviews will directly inform the next sprint's backlog, ensuring continuous improvement.</li>
  </ul>
  <p>This structured and adaptable approach provides a strong foundation for a user-centered and efficient platform.</p>
</details>

---

<details>
  <summary><b>Assignment 2: Database Design & Implementation</b></summary>
  <br>
  <p>This assignment focused on designing and implementing a database schema for CampusLearn™, a peer-to-peer learning platform. The process involved defining key business rules, applying normalization principles, creating an Entity-Relationship Diagram (ERD), and transforming the conceptual design into a practical database schema using MongoDB.</p>
  
  <br>
  <h2>Business Rules & Normalization</h2>
  
  <h3>Normalization Principles Applied</h3>
  
  <ul>
    <li>
      <b>First Normal Form (1NF):</b> Each table has a primary key and all columns contain a single, atomic value. Repeating groups were eliminated by creating separate tables (e.g., <code>StudentSubscriptions</code> and <code>TutorAssignments</code>).
    </li>
    <li>
      <b>Second Normal Form (2NF):</b> All non-key attributes are fully dependent on their respective primary key. This prevents partial dependencies in tables with composite keys.
    </li>
    <li>
      <b>Third Normal Form (3NF):</b> Transitive dependencies have been removed. For example, a separate <code>Modules</code> table was created to ensure that non-key attributes (like <code>ModuleDepartment</code>) are directly dependent on the primary key, and only the primary key.
    </li>
  </ul>
  
  <h3>Document Model</h3>
  <p>Since MongoDB is a document-based database, the design also uses denormalization to optimize for common query patterns. The schema is a set of interrelated collections, with business rules mapped to either reference-based relationships or embedded document structures. Key collections include <code>users</code> (for students and tutors), <code>tutorApprovals</code>, <code>topics</code>, <code>posts</code>, <code>privateThreads</code>, and <code>notifications</code>. JSON Schema validators enforce domain integrity, while unique and compound indexes enforce entity and referential integrity.</p>
  
  <br>
  <h2>Schema Implementation</h2>
  <p>The CampusLearn™ schema was implemented in MongoDB Atlas, with JSON Schema validators, unique indexes, and sample data to demonstrate its functionality and integrity.</p>
  
  <h3>Validators and Domain Integrity</h3>
  <p>Validators were used to enforce data types, field requirements, and format rules. For example, the <code>users</code> collection requires <code>fullName</code>, <code>email</code>, <code>role</code>, and <code>createdAt</code>, with a regular expression validator to ensure emails are from the correct Belgium Campus domain.</p>
  
  <h3>Indexes and Entity Integrity</h3>
  <p>Unique indexes were used to enforce entity integrity. For instance, a unique index on <code>users.email</code> prevents duplicate user registrations. Composite indexes, such as on <code>{tutorId, moduleId}</code> in the <code>tutorApprovals</code> collection, ensure that each tutor-module pairing is unique.</p>
  
  <h3>CRUD Demonstration</h3>
  <h4>Create</h4>
<pre><code>db.users.insertOne({
  fullName: "Demo Student",
  email: "demo@student.belgiumcampus.ac.za",
  role: "STUDENT",
  yearOfStudy: 1,
  createdAt: new Date()
});</code></pre>
  
  <h4>Read</h4>
<pre><code>db.users.find({ role: "STUDENT" }, { fullName: 1, email: 1 });</code></pre>
  
  <h4>Update</h4>
<pre><code>db.topics.updateOne(
  { title: "Help with ERD for CampusLearn" },
  { $set: { status: "ASSIGNED" } }
);</code></pre>
  
  <h4>Delete</h4>
<pre><code>db.materials.deleteOne({ title: "ERD Cheat-Sheet" });</code></pre>
  
  <h3>Aggregation Queries</h3>
  <p>Two aggregation pipelines were demonstrated to validate complex relationships and support advanced queries.</p>
  
  <h4>Topics with creator + module:</h4>
<pre><code>db.topics.aggregate([
  { $sort: { createdAt: -1 } },
  { $limit: 5 },
  { $lookup: { from: "users", localField: "creatorId", foreignField: "_id", as: "creator" } },
  { $set: { creator: { $first: "$creator.fullName" } } },
  { $lookup: { from: "modules", localField: "moduleId", foreignField: "_id", as: "module" } },
  { $set: { module: { $first: "$module.code" } } },
  { $project: { title: 1, status: 1, creator: 1, module: 1 } }
]);</code></pre>
  
  <h4>Trending forum posts:</h4>
<pre><code>db.forumPosts.aggregate([
  { $lookup: { from: "forumVotes", localField: "_id", foreignField: "postId", as: "votes" } },
  { $set: { score: { $sum: "$votes.vote" } } },
  { $sort: { score: -1, createdAt: -1 } },
  { $limit: 5 },
  { $project: { threadId: 1, snippet: { $substrBytes: ["$body", 0, 120] }, score: 1 } }
]);</code></pre>
  
  <br>
  <h2>Conclusion</h2>
  <p>The CampusLearn™ database schema, designed with a balance of normalization and denormalization, provides a stable and scalable foundation for the platform. Through the implementation of JSON Schema validators and unique indexes, and the demonstration of CRUD operations and aggregation queries, the design proves its capability to handle real-world operations while maintaining data integrity and efficiency.</p>
</details>
