all: cleanup restore build run
run-tests: cleanup restore build tests

cleanup:
	dotnet clean src/devWarsztaty-ScoringService
	dotnet clean test/devWarsztaty-ScoringService.Tests
	dotnet clean test/devWarsztaty-ScoringService.IntegrationTests

restore:
	dotnet restore src/devWarsztaty-ScoringService
	dotnet restore test/devWarsztaty-ScoringService.Tests
	dotnet restore test/devWarsztaty-ScoringService.IntegrationTests

build:
	dotnet build src/devWarsztaty-ScoringService
	dotnet build test/devWarsztaty-ScoringService.Tests
	dotnet build test/devWarsztaty-ScoringService.IntegrationTests

run:
	dotnet run -p src/devWarsztaty-ScoringService/devWarsztaty-ScoringService.csproj

tests:
	dotnet test test/devWarsztaty-ScoringService.Tests/devWarsztaty-ScoringService.Tests.csproj
	dotnet test test/devWarsztaty-ScoringService.IntegrationTests/devWarsztaty-ScoringService.IntegrationTests.csproj