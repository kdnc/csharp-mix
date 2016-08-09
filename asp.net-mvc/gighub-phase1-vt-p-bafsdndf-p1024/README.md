# Gig Hub - Phase 1
<br/>
## Table of Contents
**[Resource location](#resource-location)**  
**[Overview](#overview)**  
**[Tested environment](#tested-environment)**    
**[Additional development steps followed](#additional-development-steps-followed)**   
**[Deployment details](#deployment-details)**    

## Resource location

Resource - [Pluralsight] Become a Full-stack .NET Developer Fundamentals (May 25, 2016)

## Overview

- An ASP.NET web application to create, view and follow gigs.
- Following are the important course content
	- 02 Extracting Core Use Cases from Requirements
	- 03 Planning the First Iteration
	- 04 Building a Model Using Code-first Workflow
	- 05 Building a Form with Bootstrap
	- 06 Saving Data
	- 07 Implementing Validation
	- 08 Preventing Common Web Application Vulnerabilities
	- 09 Moving Towards a Beautiful Design
	- 10 Usability Best Practices
	- 11 Extending ASP.NET Identity Users
	- 12 Creating Beautiful and Precise Designs with CSS
	- 13 Implementing a Use Case from Top to Bottom
	- 14 Implementing Secondary Use Cases

## Tested environment

### IDEs used

- Visual Studio 2015

### Operating system

- Windows 10

## Additional development steps followed

### Entity Framework

- Code first workflow

	1. Open `Nuget Package Manager` -> `Package Manager Console` and issue following commands
	2. Enable migrations
	
			enable-migrations

	3. Scaffold the next migration based on changes you have made to your model since the last migration was created
	
			add-migration CreateGigTable
			add-migration CreateGigTable -force

	4. Apply any pending migrations to the database

			update-database

## Deployment details

1. `cd` into the `chapter-14-full-stack-fundamentals\After` folder to find the completed project.
2. Open the .sln file with Visual Studio 2015
3. Hit F5