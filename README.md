# Template F# Project on .NET Core

Created: 2016-08-14

This project template is based on
https://docs.microsoft.com/en-us/dotnet/articles/fsharp/getting-started-netcore

Observe that .NET Core SDK is in Preview and F# is in alpha for .NET Core.

## Commands

```sh
dotnet restore
dotnet build
dotnet run
dotnet test
```

## Run the App

From `src/App`, execute

```sh
dotnet restore
dotnet build
dotnet run Hello World
```

The arguments `Hello` and `World` will be passed to the 
main application `Program.fs`.

## Run the test

From `test/Tests`, execute 

```sh
dotnet restore
dotnet build
dotnet test
```

This will temporarily fail on macOS. There is an issue 
[here](https://github.com/xunit/xunit/issues/859) to track this


