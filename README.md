Run

```
echo "With open telemetry nuget:" && dotnet run --project ./with_opentelemetry/ && echo "Without open telemetry nuget:" && dotnet run --project ./without_opentelemetry/
```

Expected result:

```
With open telemetry nuget:
Assemblies loaded:
System.Diagnostics.DiagnosticSource, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
Without open telemetry nuget:
Assemblies loaded:
System.Diagnostics.DiagnosticSource, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
```