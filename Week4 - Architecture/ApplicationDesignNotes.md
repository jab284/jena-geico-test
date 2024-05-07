Application Architectural Design and Structures and Patters

* Why use Design Patters / Standard Conventions?
    * Reusability
    * Readability
    * Scalability
    * Modularity
    * Maintainability

* To help structure our application, we are going to organize our applications into Layers.

* Layers -> Roles/Duties that our application needs to accomplish.

* Single Responsibility Principle -> Each aspect of our application should have but one responsibility AND should be the only aspect that 
  manages that said responsibility.


  LAYERS:

    Top Layer
    * Application Layer
        * Developing an interface for the end user to use the presented information 


    Second from Top Layer
    * Presentation Layer
        * Is responsible for Converting Data into a presentable layer
            * Makes data display pretty


    Third from Top Layer
    * Controller Layer
        * Is responsible for handling Application Logic, which includes ideas like processing requests and generating responses.


    Third to Bottom Layer
    * Service Layer
        * Is responsible for performing Business Logic, which includes things like filtering, searching, sorting, validating, etc
          Login - get username and password - then validate it matches credentials provides - yes login -no don't login
          * Would do so upon the data that was retrieved by the Repository Layer.

    Next to Bottom Layer
    * Data Access Layer - Repository Layer
        * Is responsible for data(base) interaction.
          These objects that we create will perform any amount of retrieval, manipulation, destruction to our data.
          * These Objects are referred to as Data Access Object or (DAO)


    Lowest Level
    * Data Layer - Where all data exists.  Typically stored in something like a Database, or perhaps some form of a file system.
        Database - Place to store a set of information
        Cant create database inside console application - it erases at the end of the program.
        * Represented in your Applications through:
            * Models
                * examples: Cars, Users, Courses, Banks Account, Roles, etc

