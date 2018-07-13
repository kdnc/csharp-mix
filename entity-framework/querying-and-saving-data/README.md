Create and update a database if necessary that's going to match the data context that it finds in our project.
	- cd in to KdncCSharpApp\src\Services\App\Kdnc.App.Repository project location
	- Execute command
		dotnet ef database update

Add migrations
	- cd in to KdncCSharpApp\src\Services\App\Kdnc.App.Repository project location
	- Execute command
		dotnet ef migrations add InitialDb

Update the database according to the migrations in the project.
	- cd in to KdncCSharpApp\src\Services\App\Kdnc.App.Repository project location
	- Execute command
		dotnet ef database update
