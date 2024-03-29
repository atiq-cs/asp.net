**Listings**  
- [Earlier revision log](https://github.com/atiq-cs/asp.net/blob/dev/main/old-code/RevisionLog.md)

Static assets from 2014-02 are added in pertinent dir.

#### Site Design and Requirement Analysis
- Every page should have ability to handle social interactions.
- At minimum, commenting feature should be implemented.
- There will be a page for feedback about the site.
- Twitter and facebook links should be added so that people can like, share and comment.
- Web hosting offer pages should be added.


*How to put comments on cshtml file?*  
Use '@',

    @* <h1>@ViewBag.Title.</h1> *@


**Google Analytics**  
For the main web app, we add GA tracking code just before `</body>` tag of file: 'Views/Shared/_Layout.cshtml'.


**Fav Icon Documentation**
Seems like fav icon concepts needs some further update.
- [MSFT - Customizing the Site Icon](https://learn.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer/samples/gg491740\(v=vs.85\))
- [MSFT - Internet Explorer for Developers](https://learn.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer)


**Changes from history**  

Previous favicon linking on Layout,  

```html
<head>
  <meta charset="utf-8" />
  <title>@ViewBag.Title - SAOS Cloud App</title>
  <link href="~/saos_favicon.ico.ico" rel="shortcut icon" type="image/x-icon" />
  @*<link rel="shortcut icon" href="~/saos_favicon.ico" />*@
  <meta name="viewport" content="width=device-width" />
  @Styles.Render("~/Content/css")
  @Scripts.Render("~/bundles/modernizr")
</head>
```


Showing brand logo on Title section,

```html
<body>
    <header>
        <div class="content-wrapper">
            <div class="float-left">
                @* <p class="site-title">@Html.ActionLink("your logo here", "Index", "Home")</p>*@
                <img src="@Url.Content("~/Images/qubit_logo_01.png")">
            </div>
            <div class="float-right">
                @*<section id="login">
                    @Html.Partial("_LoginPartial")
                </section>*@
                <nav>
                    <ul id="menu">
                        <li>@Html.ActionLink("Home", "Index", "Home")</li>
                        <li><a href="https://note.iqubit.xyz">Blog</a></li>
                        <li>@Html.ActionLink("About", "About", "Home")</li>
                        <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                    </ul>
                </nav>
            </div>
        </div>
    </header>
    ... ...
    ... ...
</body>
```


Previous resume controller,

```csharp
public class ResumeController : Controller
{
  //
  // GET: /resume/

  /*public ActionResult Index()
  {
    return View();
  }*/

  public string Index()
  {
    return "<html>"+
      "<title>"+
      "Resume of Md. Atiqur Rahman"+
      "</title>"+
      "<body><p align=\"center\"><a href=\"http://saoslab.com/Downloads/SA_Resume_latex.pdf\">Download original</a><br /><br />" +
      "<iframe src="+"http://docs.google.com/viewer?url=http%3A%2F%2Fsaoslab.com%2FDownloads%2FSA_Resume_latex.pdf&embedded=true"+
      " width=\"1024\" height=\"3900\" style=\"border: none;\"></iframe></p></body></html>";
  }
}
```
  
*Note the external URL pdf preview using G Docs*!

### Web.Config Changes
**URL Rewrites**  

How to redirect using IIS Rewrite Module,

To redirect old.saoslab.com/* and www.old.saoslab.com/* to new URL,

    <rule name="Redirect old saos" stopProcessing="true">
      <match url=".*" />
      <conditions>
        <add input="{HTTP_HOST}" pattern="^old\.saoslab\.com$" />
      </conditions>
      <action type="Redirect" url="https://saoslab.com/{R:0}" />
    </rule>
    <rule name="Redirect www old saos" stopProcessing="true">
      <match url=".*" />
      <conditions>
        <add input="{HTTP_HOST}" pattern="^www.old\.saoslab\.com$" />
      </conditions>
      <action type="Redirect" url="https://saoslab.com/{R:0}" />


Match URL always gives relative URL. This is why we need HTTP HOST condition


Rewrite Rule Code Snippets, 2013,

redirect subdomain `tech.saosx.com/*` to `https://saosx.com/tech/*` and same for `blog.saosx.com/*`,

```asp
<system.webServer>
  <rewrite>
    <rules>
    <rule name="Redirect tech subdomain" stopProcessing="true">
      <match url=".*" />
      <conditions>
        <add input="{HTTP_HOST}" pattern="^tech.saosx.com$" />
      </conditions>
      <action type="Redirect" url="https://saosx.com/tech/{R:0}" />
    </rule>
    <rule name="Redirect blog subdomain" stopProcessing="true">
      <match url=".*" />
      <conditions>
        <add input="{HTTP_HOST}" pattern="^blog.saosx.com$" />
      </conditions>
      <action type="Redirect" url="https://saosx.com/tech/{R:0}" />
      </rule>
    </rules>
  </rewrite>
  <validation validateIntegratedModeConfiguration="false"/>
  <modules runAllManagedModulesForAllRequests="true"/>
</system.webServer>
```

This is the URL Rewrite used on azure site. Redirects both http and https successfully,

    <?xml version="1.0"?>
    <configuration>
        <system.webServer>
            <rewrite>
                <rules>
                    <rule name="Redirection enabled" stopProcessing="true">
                        <match url="(.*)" />
                        <conditions>
                            <add input="{HTTP_HOST}" pattern="^sa-blog\.azurewebsites\.net$" />
                        </conditions>
                        <action type="Redirect" url="http://tech.saoslab.com/{R:1}" redirectType="Permanent" />
                    </rule>
                </rules>
            </rewrite>
        </system.webServer>
    </configuration>


Redirecting `tech.saoslab.com/*` to `sa-blog.azurewebsites.net/*`,

**Refs**  
- http://www.iis.net/learn/extensions/url-rewrite-module/url-rewrite-module-configuration-reference#Rule_pattern_syntax
- http://weblogs.asp.net/owscott/url-rewrite-protocol-http-https-in-the-action


And, here's earlier example with the Area blog version haing a virtual directory, also look at [G Doc - Area blog 2012-01-14](https://docs.google.com/document/d/1Gf35hZrX0bzfWGuT8uMB8ECUUi8oexywuMYzK4UiNE4)

    <rewrite>
      <rules>
        <rule name="Redirect tech sub" stopProcessing="true">
          <match url=".*" />
          <conditions>
            <add input="{HTTP_HOST}" pattern="^tech.saosx.com$" />
          </conditions>
          <action type="Redirect" url="https://saosx.com/tech/{R:0}" />
        </rule>
        <rule name="Redirect blog sub" stopProcessing="true">
          <match url=".*" />
          <conditions>
            <add input="{HTTP_HOST}" pattern="^blog.saosx.com$" />
          </conditions>
          <action type="Redirect" url="https://saosx.com/tech/{R:0}" />
        </rule>
      </rules>


To azure blog, rewrite URL,

    <rewrite>
      <rules>
        <rule name="Rewrite to article.aspx">
          <match url="^tech.saoslab.com(.*)" />
          <action type="Rewrite" url="sa-blog.azurewebsites.net/{R:1}" />
        </rule>
      </rules>
    </rewrite>

Redirect,

    <rewrite>
      <rules>
        <rule name="Redirect tech sub" stopProcessing="true">
          <match url="tech\.saoslab\.com(.*)	" />
          <conditions>
            <add input="{HTTP_HOST}" pattern="^tech.saoslab.com$" />
          </conditions>
          <action type="Redirect" url="sa-blog.azurewebsites.net/{R:0}" />
        </rule>
      </rules>


For mvc4,  
Change first line,

    <?xml version="1.0"?>” to “<?xml version="1.0" encoding="UTF-8"?>

Correct page version

    <add key="webpages:Version" value="2.0.0.8"/>

Add after this line,

    <add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="GET,HEAD,POST,DEBUG,PUT,DELETE,PATCH,OPTIONS" type="System.Web.Handlers.TransferRequestHandler" preCondition="integratedMode,runtimeVersionv4.0"/>
      </handlers>

Following lines,

    <directoryBrowse enabled="false" />
    <defaultDocument>
        <files>
            <clear />
            <add value="default.aspx" />
            <add value="index.aspx" />
        </files>
    </defaultDocument>


For mvc3,  

**Turn debug off**  
Change from

    <compilation debug="true" targetFramework="4.0">

to

    <compilation targetFramework="4.0">

And, change this,

    <add name="ApplicationServices"
      connectionString="data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|aspnetdb.mdf;User Instance=true"
      providerName="System.Data.SqlClient" />

Add Default pages,

          <add namespace="System.Web.WebPages" />
        </namespaces>
      </pages>
    </system.web>

    <system.webServer>
      <validation validateIntegratedModeConfiguration="false" />
      <modules runAllManagedModulesForAllRequests="true" />
          <directoryBrowse enabled="false" />
          <defaultDocument>
              <files>
                  <clear />
                  <add value="default.aspx" />
                  <add value="index.aspx" />
              </files>
          </defaultDocument>
    </system.webServer>

Version control: maintain web app versions,  
Change,  

    <add key="webpages:Version" value="1.0.0.0"/>

To

    <add key="webpages:Version" value="1.0.0.7"/>


**Other Site Dependencies**  
Consider other site dependencies during deployment:
- These two directories should be upload to the site separately
  - images
  - Downloads

Outgoing links,

My own other sites depend on some links from this site. 
https://code.google.com/p/pingguin/ used to link to,

    https://saoslab.com/images/PingStory02.jpg
    https://saoslab.com/images/PingGuin01.png
    https://saoslab.com/images/PingGuin02.png
    https://saoslab.com/images/PingGuin03.png

Linked on my email signature,

    https://saoslab.com/images/SA_Cox06_crop.jpg

Changing it to 'SA_Signature_Pic_149x149.jpg'


