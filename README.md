.NET Core gRPC Client and Service
============

This sample project is created in .NET Core 3.1 to demo creation of gRPC service and client. 

## Get Started

Run gRPC Service first and then run Client to view it communicate with Service. 

Service exposes a single method called GetPerson which takes PersonRequest object as input and returns PersonResponse object as output.

Data folder in service contains the PersonData class which mimics the data coming from some external service like database. In this demo data is hardcoded in in-memory list but it can easily be replaced with a database call.

When creating a client you need to remember to build the solution once proto file is added and also remember to change GrpcServices attribute to Client in Protobut tag in .csproj file. 

 
