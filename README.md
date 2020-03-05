# PBNET

PBNET is a tool that understands your PowerBuilder application and converts it to a ASP.NET Core web application that uses frameworks such as Angular, CSS, and Typescript.

This tool has the ability to process the source code to generate C#, Angular, HTML, and CSS files.

Instead of manually rewriting an entire application, we help you by automating this process using PBNET. This reduces costs, risks and time, while keeping the existing business logic intact.

For more details you can go to our [website](https://www.mobilize.net/powerbuilder) or check our documentation at https://docs.mobilize.net/



# PowerBuilder to .Net Core Hello World Sample App

This repo contains the source code and binaries for the PBNetHelloWorld app.

This app just shows a Powerbuilder Window with a datawindow that implements a simple todo list.

The sample was migrated with our [tools](https://mobilize.net/powerbuilder) to a ASP.NET Core web app with an Angular FrontEnd.



# How to Build

If you want to build this app:

- BackEnd: you can use the 
```
cd MigratedSolution
dotnet build
```

- FrontEnd: you can use the 
```
cd MigratedSolution\sampleSite\sampleSite-angular
yarn
ng build
```

# Code Structure

When you migrate your app from Powerbuilder to ASP.NET core you will have:
- WebSite application based on the original app `pbt`
- A class library for each Powerbuilder `pbl`
- An angular application which whil will generate an angular module with the ui elements from each `pbl`


# Running the app directly from your browser

If you do not want to install anything but still wnat to take a look at migrated application your can open the application using the link below:

[![Open in Gitpod](https://gitpod.io/button/open-in-gitpod.svg)](https://gitpod.io/#https://github.com/MobilizeNet/PBNetHelloWorld)

