# Módulo C (Ezequiel). Se construye desde la raíz del repo: docker build -f backend/Dockerfile .
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY backend/ ./backend/
RUN dotnet restore backend/src/ScrumMate.Api/ScrumMate.Api.csproj
RUN dotnet publish backend/src/ScrumMate.Api/ScrumMate.Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
COPY prompts/ ./prompts/
ENV ASPNETCORE_URLS=http://+:8080 \
    Ollama__RutaPrompts=/app/prompts
EXPOSE 8080
USER app
ENTRYPOINT ["dotnet", "ScrumMate.Api.dll"]
