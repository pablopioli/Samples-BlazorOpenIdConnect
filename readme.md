This is a sample on how host a Blazor WebAssembly app in an ASP.NET Core app that acts like a static host. 

Uses https://github.com/sotsera/sotsera.blazor.oidc to implement OpenId Connect authentication.

The idea is to test ways to distribute apps that can replace a desktop app without using Electron. For example a single file autoextract executable that launches a Blazor app in the system browser.

Use publish.cmd to publish the Blazor app inside the ASP.Net core project.
