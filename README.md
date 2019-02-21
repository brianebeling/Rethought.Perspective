# Rethought.Perspective

**.Net Standard Library** for the [Perspective API](https://www.perspectiveapi.com/). The Perspective API can be used to analyze messages
based on certain models, like toxicity. 

## Installation

#### [Rethought.Perspective](https://www.nuget.org/packages/Rethought.Perspective/)

## Using the library

To be able to make calls to the API you need to instantiate a client to work with. That should be done like this:
```csharp
var client = PerspectiveClientFactory.Create(new HttpClient(), "YourToken");
```
then you can start making requests by doing:
```csharp
var response = await client.AnalyzeCommentAsync("This is stupid!", builder => builder.WithModel(Model.Toxicity | Model.ToxicitySevere));
```

This will return a response with the respective properties for Toxicity, SevereToxicity and Spam populated. The other models will be null.

For reference how the response is structured please utilize the [Perspective API reference](https://github.com/conversationai/perspectiveapi/blob/master/api_reference.md/).


## Documentation

Documentation will be available in a GitHub Wiki. This ReadMe is only a temporary solution.
