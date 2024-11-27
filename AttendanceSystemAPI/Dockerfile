FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /src
COPY . .
ENTRYPOINT ["dotnet", "AttendanceSystemAPI.dll"]
COPY AttendanceSystemAPI/AttendanceSystemAPI.csproj AttendanceSystemAPI/
RUN dotnet build "AttendanceSystemAPI/AttendanceSystemAPI.csproj" -c Release -o /app
EXPOSE 5279