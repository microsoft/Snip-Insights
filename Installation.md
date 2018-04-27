# Installation

## Requirements

* Windows 10
* .Net Framework
* WPF libraries

## Installation process

You can fork the project in the github repository of [SnipInsights](https://github.com/Microsoft/Snip-Insights).

Then navigate to the code location on your Windows 10 machine and double click the solution file `SnipInsight.sln`.

From there, select the C# project file `SnipInsight.csproj`. You should now be able to build and run the solution. 

The next step to test the AI features is to generate API keys for each AI service. Go to the the [Azure portal](https://ms.portal.azure.com/), create and account or login if you already have one and generate and API keys for each functionnality you want to use. You can now paste each key in the settings panel of the application.

Congratulations! You should now have a fully working application to get started. Have fun testing the project and thank you for your contribution! 

## Troubleshooting

> No project is selected for compilation

Make sure you have selected the Debug configuration and are building the project correctly.

> I can't run the project

You are most likely missing libraries. Right click on the SnipInsight project and select *Install missing packages* if that option is available.

> I don't see the fields to paste my API keys on the settings panel

That is because you have not yet enabled AI assistance. Please enable it first and then enter your API keys.