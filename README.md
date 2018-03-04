# Web Scraper Example
In this example I've created a Web Scraper using `WebBrowser` control. 

It runs the `WebBrowser` control in a background thread and returns `Task<string>`. The usage is easy:

    var content = await WebScraper.BrowserBasedWebScraper.LoadUrl("http://www.example.com");

You can use it in Web and Windows Application. I've added an example for ASP.NET MVC project and another one for Windows Forms project.

The reason of using a `WebBrowser` control instead of `WebClient` or `HttpClient` is, using `WebBrowser` control, you can add a delay after loading the content of WebBrowser control to let the broswer render the site and run scripts after document got ready, then get the content from `DocumentText` property of the `WebBrowser` control. However the delay is not included in example and you can simply add delay yourself. 
