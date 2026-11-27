# Migraciones

Se generan con:

```bash
cd backend
dotnet ef migrations add Inicial -p src/ScrumMate.Infrastructure -s src/ScrumMate.Api -o Persistence/Migrations
```

Nunca edites una migración ya fusionada en `develop`; crea una nueva.
