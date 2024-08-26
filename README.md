
# ShassiWPF Project

Project is based on given task: UÏduotis_nr1.

First project Idea was based on clean architecture with custom data seeding, code first approach and TDD. Due to project scaling and requirement mismatch new project was created - ShassiWPF.

Old project URL: `https://github.com/nojuslau/Harness-WPF.git`

# Problems

* Due to strange pathing at runtime, program couldn't find SqlLite DB - for convenience changed to postgreSQL.

* `ApplicationDbContextFactory.cs` and `ApplicationDbContext.cs` have connection string configurations. In `ApplicationDbContext.cs` it should not be required to override connection string configuration, but without it program crashes. 

# Setup

* Copy repository
* Start postgreSQL server
* Inside project directory use command: `dotnet ef database update`
* Start project

# Configurations
* Default Connection string:
    * `Host=localhost;Port=5432;Database=harness;Username=postgres;Password=admin;Include Error Detail=true`

# Results
![incorrect](https://github.com/user-attachments/assets/b67cddb6-a011-4d18-89ad-8fbc8e8a7d3c)

# Task
[UÏduotis_nr1.pdf](https://github.com/user-attachments/files/16745436/UIduotis_nr1.pdf)
