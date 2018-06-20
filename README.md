## Learning dotnet user-secrets Tools

1. Create dotnet console project with command
```
mkdir learning-user-secrets
cd learning-user-secrets
dotnet new console
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.UserSecrets
```

2. Add UserSecretsId node to learning-user-secrets.csproj
```
<UserSecretsId>4270b588-c2ce-4c08-91bb-58aa1901134c</UserSecretsId>
```

3. Add new user secret
```
dotnet user-secrets ConnectionString server=localhost;dabase=test;
```

4. Check user secrets
```
dotnet user-secrets list
```

5. Get Secrets in program.cs
```
var builder = new ConfigurationBuilder();
builder.AddUserSecrets<Program>();
var configuration = builder.Build();
Console.WriteLine(configuration["ConnectionString"]);
```

6. run
```
dotnet run
```

7. output
```
Hello World!
server=localhost
```