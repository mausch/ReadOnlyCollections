$ErrorActionPreference = "Stop"
dotnet pack -c Release -o ..\.nuget
echo "Testing .NET 3.5"
dotnet run --project Tests\Tests.csproj --framework net35
echo "Testing .NET 4.6.2"
dotnet run --project Tests\Tests.csproj --framework net462
echo "Testing .NET 5.0"
dotnet run --project Tests\Tests.csproj --framework net5.0
echo "Testing .NET 6.0"
dotnet run --project Tests\Tests.csproj --framework net6.0