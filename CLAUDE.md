# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Structure
- The project is organized into several main folders:
  - source/: Contains the core serialization libraries
  - samples/: Contains various sample applications and demos
  - tests/: Contains unit and benchmark tests

## Common Commands
- Build: Use `dotnet build` to compile all projects
- Test: Use `dotnet test` to run all unit tests
- Benchmark: Use `dotnet run --project <test-project>` to run benchmarks for specific serialization libraries

## Key Components
- Core Data SerializationMarshalling.Formatters: Contains various serialization formatters (binary and text)
- ReportGenerator: A tool used for generating reports on serialization performance

Note that the project uses multiple test runners (MSTest, NUnit, XUnit) for different platforms.