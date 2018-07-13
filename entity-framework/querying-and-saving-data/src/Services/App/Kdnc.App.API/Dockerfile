FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/Services/App/Kdnc.App.API/Kdnc.App.API.csproj src/Services/App/Kdnc.App.API/
COPY src/Services/App/Kdnc.App.Application/Kdnc.App.Application.csproj src/Services/App/Kdnc.App.Application/
COPY src/Services/App/Kdnc.App.Domain/Kdnc.App.Domain.csproj src/Services/App/Kdnc.App.Domain/
COPY src/Services/App/Kdnc.App.Repository/Kdnc.App.Repository.csproj src/Services/App/Kdnc.App.Repository/
RUN dotnet restore
COPY . .
WORKDIR /src/src/Services/App/Kdnc.App.API
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Kdnc.App.API.dll"]
