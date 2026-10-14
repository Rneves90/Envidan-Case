# Envidan assignment - Answers



## Assignment 1



The SOLID principles that were more relevant for me to apply in this solution where:



- Open/Closed Principle
  - New shapes (like Hexagon, Rectangle, etc) can be added without modifying existing code
  - ShapeComparator works with any shape implementing the interface—no changes needed

- Dependency Inversion Principle
  - The ShapeComparator is decoupled from concrete shapes through the interface

- Single Responsibility Principle
  - Clear separation between shape calculation and comparison logic.

## Assignment 2
**Singleton**

It ensures that a class has only one instance over the application lifetime. It allows a controlled access to a shared resource, preventing conflicting operations. Used it for settings manager, dabatase connections and loging services.

**Factory**

It's used to concentrate the decision of which object to build (and which specific logic to apply), to one single place, while also decoupling it from the business logic.
i.e: Used in file validators, file exporters.
If a new option is added in the future, the effort is concentrated in adding the option and ONLY updating the factory.

**Repository Pattern**

It allows to create dedicated repositories by entity/domain and with that the business logic does not needs to know anything about queries.

It facilitates mocking the database for unit tests.

