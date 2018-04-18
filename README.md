
# LUIS Samples

Welcome to the Language Understanding ([LUIS](https://azure.microsoft.com/en-us/services/cognitive-services/language-understanding-intelligent-service/)) samples repository. LUIS allows your application to understand what a person wants in their own words. LUIS uses machine learning to allow developers to build applications that can receive user input in natural language and extract meaning from it.

## Create your Azure LUIS service

Use the `Deploy to Azure` button to quickly create an Azure LUIS service. You get one free LUIS service per account. The free service has a sku of `F0`. The basic tier has a sku of `S0`.

[![Create LUIS Service on Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

## Examples by language

|Example| CSharp | Java | Node.js | Javascript | Python | PHP | Ruby| JSON | 
| -- | :--: | :--: | :--: | :--: | :--: | :--: | :--: | :--: |
|[*Bot Integration sample - hotel finder](./bot-integration-samples/hotel-finder/) |  ✔ | | ✔ |||||
|[Bot Integration sample - HomeAutomation](./documentation-samples/tutorial-web-app-bot) |  ✔ | | ✔ |||||
|[Bot Integration sample - HomeAutomation & Application Insights](./documentation-samples/tutorial-web-app-bot-application-insights) | ✔  | | ✔ |||||
|[Add an utterance to app model](./documentation-samples/authoring-api-samples/) | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ | ✔ ||
|[Send utterance to endpoint](./documentation-samples/endpoint-api-samples/) | ✔ | ![Docker](./media/docker-logo.png) | ![Docker](./media/docker-logo.png) | ✔ | ✔ | ✔ | ✔ ||
|[Azure function to LUIS endpoint](./examples/azure-function-endpoint/) | ✔ ||||||||
|[Backup all apps in Subscription](./examples/backup/) | |  |✔||||||
|[Build app programmatically](examples/build-app-programmatically-csv) | |  |✔||||||
|[Upload utterances from query log](./examples/demo-upload-example-utterances/demo-Upload-utterances-from-querylog) | |  |✔||||||
|[Upload utterances from exported app](./examples/demo-upload-example-utterances/demo-upload-utterances-from-exported-luis-app/) | |  |✔||||||
|[Add list entity](./documentation-samples/tutorial-list-entity/) | |  |✔||||||
|[*Notes app sample ](./examples/notes-app/) | ✔  | | ![Docker](./media/docker-logo.png) |||||
|[App model definition - Bookflight](./documentation-samples/Examples-BookFlight/) |||||||| ✔ |
|[App model definition - Colors](./documentation-samples/Examples-Colors/) |||||||| ✔ |
|[App model definition - IoT](./documentation-samples/examples-IoT) |||||||| ✔ |
|[Phrase lists](./examples/phrase_list) | |  ||||||✔|
|[Bing Spell Check](./examples/bing-spell-check) | |  ||✔|||||
|[Azure function with application insights](./examples/azure-function-application-insights-endpoint) |✔ |  |||||||
|[Botframework v4 - endpoint](./examples/botframework/v4/Nodejs/endpoint-query)|||Typescript||||

\* = example demonstrates complete cycle: create, train, publish, query

## Examples by usage

|Example|Demonstrates|
|--|--|
|[Bot Integration sample - hotel finder](./bot-integration-samples/hotel-finder/) |Bot Framework SDK, Create-Train-Publish-Query |
|[Bot Integration sample - HomeAutomation](./documentation-samples/tutorial-web-app-bot) |Web app bot |
|[Bot Integration sample - HomeAutomation & Application Insights](./documentation-samples/tutorial-web-app-bot-application-insights) |Web app bot, Application Insights |
|[Add an utterance to app model](./documentation-samples/authoring-api-samples/) |Authoring API |
|[Send utterance to endpoint](./documentation-samples/endpoint-api-samples/) |Endpoint API, Public app |
|[Azure function to LUIS endpoint](./examples/azure-function-endpoint/) |Endpoint API |
|[Backup all apps in Subscription](./examples/backup/) |Authoring API |
|[Build app programmatically](examples/build-app-programmatically-csv) |Authoring API |
|[Upload utterances from query log](./examples/demo-upload-example-utterances/demo-Upload-utterances-from-querylog) |Authoring API |
|[Upload utterances from exported app](./examples/demo-upload-example-utterances/demo-upload-utterances-from-exported-luis-app/) |Authoring API |
|[Notes app sample ](./examples/notes-app/) |Create-Train-Publish-Query, Prebuilt domain |
|[App model definition - Bookflight](./documentation-samples/Examples-BookFlight/) |Hierarchical entity, Composite entity, List entity, datetimeV2 prebuilt entity, number prebuilt entity, upload labeled utterance|
|[App model definition - Colors](./documentation-samples/Examples-Colors/) |Phrase list feature|
|[App model definition - IoT](./documentation-samples/examples-IoT) |Prebuilt domain|
|[Phrase lists](./examples/phrase_list) |Phrase list feature, Hierarchical entity, datetimeV2 prebuilt entity, number prebuilt entity |
|[Bing Spell Check](./examples/bing-spell-check) |Public App |
|[Azure function with application insights](./examples/azure-function-application-insights-endpoint) |Azure function, Application Insights |
|[Add list entity](./documentation-samples/tutorial-list-entity/) |List entity, train, query|
|[Botframework v4 - endpoint](./examples/botframework/v4/Nodejs/endpoint-query)|Uses NPM package botframework-luis, version 4.0.0-alpha2|

## Interactive app
Ask LUIS to turn on the lights in this [interactive demonstration](https://azure.microsoft.com/en-us/services/cognitive-services/language-understanding-intelligent-service/).

## References

* [LUIS Docs](https://docs.microsoft.com/azure/cognitive-services/LUIS/)
* [Azure docs search](https://docs.microsoft.com/search/index?search=LUIS)
* [Authoring API V2 docs](https://aka.ms/luis-authoring-api)
* [Endpoint API V2 docs](https://aka.ms/luis-endpoint-apis)
* [LUIS .Net SDK](https://github.com/Azure/azure-sdk-for-net/tree/psSdkJson6/src/SDKs/CognitiveServices/dataPlane/Language)
* [Bot Framework](https://docs.microsoft.com/bot-framework/)
* [Bot Builder Samples](https://github.com/Microsoft/BotBuilder-Samples)
* [Azure REST API Specifications](https://github.com/Azure/azure-rest-api-specs/tree/master/specification/cognitiveservices/data-plane/LUIS): LUIS swagger files
* BotBuilder v4, [Nodejs](https://github.com/Microsoft/botbuilder-js), [.Net](https://github.com/Microsoft/botbuilder-dotnet). Coming soon: Python & Java
* BotBuilder v4 LUIS libraries: [Nodejs](https://www.npmjs.com/package/botframework-luis) NPM package, [.Net](https://www.nuget.org/packages/Microsoft.Bot.Builder.Ai/) NuGet package
* [Azure RSS for 'LUIS'](https://docs.microsoft.com/api/search/rss?search=LUIS&locale=en-us)


## Videos

* [Introduction to LUIS](https://aka.ms/luis-intro-video)
* [Advanced learning with LUIS](https://www.youtube.com/watch?v=39L0Gv2EcSk)
* [Channel 9 Deep Dive into LUIS and Chatbots](https://channel9.msdn.com/Blogs/MVP-Azure/Cognitive-Services-Episode-3-Deep-dive-into-LUIS-and-Chatbots)

## LUIS with Bot framework Blog
* [blog.botframework.com](https://blog.botframework.com/category/luis/)

## Related Microsoft Projects

* [Prebuilt entity recognizer](https://github.com/Microsoft/Recognizers-Text)
* [Azure Code Samples for LUIS](https://azure.microsoft.com/resources/samples/?sort=0&term=Luis)
* [Universal Language Intelligence Service - Nodejs](https://github.com/Microsoft/Universal-Language-Intelligence-Service): A wrapper for the Microsoft LUIS cognitive that provides universal language support (after training) using the bing translate api
* [Microsoft Cognitive Services control for Microsoft Bot Builder - C# & Nodejs](https://github.com/Microsoft/BotBuilder-CognitiveServices): The cognitive services control makes consuming different Microsoft Cognitive Services easy for bots developed using Microsoft Bot Builder SDK. The control is available for C# and Node.js SDKs.
* [Activate Azure with Intelligent Apps - C#](https://github.com/Microsoft/intelligent-apps): Fabrikam Investment Bank Customer Service uses LUIS
* [LUIS Console Application Sample - C#](https://github.com/Azure-Samples/Cognitive-Services-LUIS-Console-Application)
* [Adaptive Cards](https://github.com/Microsoft/AdaptiveCards/)
* [Octobot from the Sandbox](https://docs.microsoft.com/sandbox/demos/octobot)

## Community Projects
If you find a open-source project or sample using LUIS, submit a PR for the [community-projects.md](community-projects.md) file.

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

