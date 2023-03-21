**Listings**  
- [Earlier revision log](https://github.com/atiq-cs/asp.net/blob/dev/main/old-code/RevisionLog.md)


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