# Simple Example

From the repository root, run the AppHost project with command `dotnet run --project .\testrc2.AppHost\testrc2.AppHost.csproj`

To use an earlier version of the .NET SDK, like .NET 9, update global.json:

```json
{
  "sdk": {
    "version": "9.0.306",
    "rollForward": "disable"
  }
}
```

and also update testrc2.AppHost.csproj so it targets net9.0.