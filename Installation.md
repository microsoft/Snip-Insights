# Installation

## Requirements

* Windows 10
* .Net Framework
* WPF libraries

## Installation process

You can fork the project in the github repository of [SnipInsights](https://github.com/Microsoft/Snip-Insights).

Then navigate to the code location on your Windows 10 machine and double click the solution file `SnipInsight.sln`.

From there, select the C# project file `SnipInsight.csproj`. You should now be able to build and run the solution. 

The next step to test the AI features is to generate API keys for each AI service (listed below). Go to the the [Azure portal](https://ms.portal.azure.com/), create an account or login if you already have one and generate API keys for each functionality you want to use. 

To add the keys to Snip-Insights, Build and Start the application.  Once running, click/tap the Settings icon in the toolbar.  Scroll down until you find the "Cognitive Services, Enable AI assistance" toggle, and toggle it to the On position.  You should now see the Insight Service Keys section.

- Entity Search - Create new Entity Search Cognitive Service.  Once created, you can display the keys.  Select one and paste into "Settings"
- Image Analysis - In Azure, create a **Computer Vision API ** Cognitive Service and use it's key.
- Image Search - In Azure, create a **Bing Search v7 API** Cognitive Service and use it's key.
- Text Recognition - You can use the same key as used in Image Analysis.  Both Image Analysis and Text Recognition use Computer Vision API.
- Translator - Use the **Translator Text API** Cognitive Service.
- Content Moderator - Use the **Content Moderator API** Cognitive Service.
- LUIS Key - Use the **Language Understanding** Cognitive Service.

For the LUIS App ID, you will need to create a Language Understanding application in the Language Understanding Portal ([https://luis.ai](https://luis.ai))

You can now paste each key in the settings panel of the application.

Congratulations! You should now have a fully working application to get started. Have fun testing the project and thank you for your contribution! 

## Troubleshooting

> No project is selected for compilation

Make sure you have selected the Debug configuration and are building the project correctly.

> I can't run the project

You are most likely missing libraries. Right click on the SnipInsight project and select *Install missing packages* if that option is available.

> I don't see the fields to paste my API keys on the settings panel

That is because you have not yet enabled AI assistance. Please enable it first and then enter your API keys.