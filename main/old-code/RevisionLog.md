For date records of few earlier commits, 'site-aspnet-2014-02',

    Added two screenshots of solaris for comp.unix.solaris group posting
    Jan 31, 2015 at 10:19 AM

    Out of file hosting directories added
    Jan 26, 2015 at 4:30 PM


    Only change is compilation with .Net 4.5.1
    Jan 26, 2015 at 2:12 PM


Earlier revision log,

    r1
      First build which only contains slight modifications to the default template.
      css files and other styles are not modified
    r2
      main page change
      blog link changed to tech.saos instead of saos.co.in/tech
      added page for Atiq
      site.css changed
      name refactoring from P01_SAOS to SAOS
      
    r3
      Correction of broken links and lots of refactoring, files renamed

    r4
      More renamed fix for sln, project files csproj included
      
    r5
      Added images/
        PingGuin01.png
        PingGuin02.png
        PingGuin03.png
        PingStory02.jpg
        SA_Signature_Pic01.jpg

      "SA_Cox06_crop.jpg" has to be changed to "SA_Signature_Pic_149x149.jpg" in html signature
      
      Added downloads
      This revision is for testing if dir likes images come in output deployment package.

    r6
      images and Downloads directories are not included by default in the deployment package we're moving them to other dirs
      Resume file SA_Resume_latex.pdf added to the download section

      Code Snippets.docx added
      Site caption changed to "Atiq Operating System: welcome to SAOS"
      Spelling correction under Shutdown Timer, some descriptions changed
      Changed ©-SAOS (Site Pre-beta) 2012 to SAOS © 2014
      From Atique page
        File cluster link removed
        fixed msdn link
        Resume section added, link added
      Remove link from logo banner
      Controller atiq added to add resume page http://saos.co.in/atiq
      
    r7
      renamed publishing profile to saos_deploy_test.pubxml & saos_deploy_test.pubxml.user; location
        SAOS_Main_VS\Properties\PublishProfiles
        
        
    r8
      Adapting ASP .Net MVC 4
      Changing controllers
      
      MVC 4 has following pages with controller, kept them, replaced contents
        Home
        About
        Contact
      
      Removed register login
      Fixed css, changed logo
      Lots of file structure change
      Have to compute the difference and have to apply it
      Replaced favicon
      Added atiqController.cs
      Have to add resource from all php previous sites
      Title changed in shared Layout: <title>@ViewBag.Title - SAOS Cloud App</title>
      Blog link added both on shared Layout <li><a href="http://tech.saos.co.in">Blog</a></li> and in About page
      
      * deployment test: checking if this revision actually contains all files to successfully build and deploy this application
      
      Technical doc added
      reve_email_address_png added
      Assembly name changed to SAOS from MVC4Test
      Lots of error when changing to target framework changed .Net 4. back in .net framework 4.5
      Deployment successful with .Net 4.5
      favicon has to be checked by uploading
        generated ico using http://www.xiconeditor.com/
        if it does not work then replace
          <link rel="shortcut icon" href="~/favicon.ico" />
          with
          <link rel="shortcut icon" href="http://www.saos.co.in/favicon.ico" />

      mistakenly we have deployed this revision as r9

    r9
      All saos.co.in has been refactored to saoslab.com inside the project
      google analytics tracking code udpated
