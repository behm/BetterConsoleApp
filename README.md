# BetterConsoleApp

## Overview
This repo is the output of following along with the YouTube video link below.  The goal of the video is to create a console application that has Configuration, Dependency Injection and Logging (with Serilog).

[.NET Core Console App with Dependency Injection, Logging, and Settings](https://www.youtube.com/watch?v=GAOCe-2nXqc&t=318s) by Tim Corey

## Getting Started

1. Create a new .NET Core Console Application either by using Visual Studio or the dotnet CLI command 

   dotnet new console -o ConsoleUI

2. Add the following NuGet packages

    - Add Microsoft.Extensions.Hosting
    - Add Serilog.Extensions.Hosting
    - Add Serilog.Settings.Configuration
    - Serilog.Sinks.Console (or whichever sink you'd like to use)

3. Add applicaiton code for whatever you'd like your app to do
