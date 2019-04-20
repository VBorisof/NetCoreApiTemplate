# NetCore Api Template

This is a project template for a dotnet-core web API.

Projects generated using this template will have the following structure (some minor parts omitted):

```
/
|__Controllers -- Application endpoints defined here.
|
|__Forms       -- Request forms are defined here.
|
|__ViewModels  -- Request responses are defined here.
| 
|__Data
|   |__Models  -- Application models are defined here. 
|   |    |__ IModelBase, ModelBase -- Base model interface.
|   |
|   |__IRepository -- Interface for storing and manipulating IModelBase derivatives.
|   |__IUnitOfWork -- Interface for storing and manipulating repositories.
|
|__Services
    |__Shared
        |__ServiceOperationResult -- Generic service result 
```

Install from NuGet: https://www.nuget.org/packages/VBorisof.NetCoreApiTemplate