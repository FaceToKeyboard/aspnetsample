# An <span>ASP.NET</span> Sample Project

I'm following along with the '[ASP.NET 101](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oW8nviYduHq7bmKode-p8Wy)' video series from Microsoft.

This is my first ever project with C#, and I'm hoping ASP.NET, Blazor, and Razor are analogous enough to the Javascript and MERN stack development I've learned so far to allow me to pick up on it quickly.

![Webpage screenshot](ASPNetSample.jpg)

## My Thoughts

### Through video 10

* I'm coming from Javascript, and I haven't worked with C/C++/Java since university, so coming back to a typed language is interesting. The verbosity can be annoying sometimes, but I do enjoy the extra checking - both from the language, and from myself reading over code and explicitly seeing the types.
* There is a lot of 'magic' happening. I need to keep in mind that this is an entire prescriptive *framework* and not just libraries and methods.
* Annotations feel weird to me. This is not a bad or good thing; just a thing. React and its jsx sugar that mimics HTML felt really elegant. Although, I am learning to enjoy the explicitness of the annotations.
* I may need to learn how to develop an <span>ASP.NET</span> project without using Visual Studio to gain more insight on what's happening.
* The video series is becoming outdated:
	- My VS 2022 v.s. their VS 2019
	- The <span>ASP.NET</span> project template/structure is slightly different - most important difference is app startup now just in [*Program.cs*, and there is no *Startup.cs*](https://docs.microsoft.com/en-us/dotnet/architecture/porting-existing-aspnet-apps/app-startup-differences)

### Through video 12

* Getting the hang of it: .razor pages/files seem analogous to .jsx - just means I need to be prepared to see a mix of HTML and C#
* A couple more signs that the video series is becoming outdated:
	- I couldn't get the modal functionality working properly. The video comments show other people having the same problem. I ended up following Bootstrap's [quick start guide](https://getbootstrap.com/docs/5.1/getting-started/introduction/) to get things working.
	- I also used the latest FontAwesome and [served the assets locally](https://fontawesome.com/v5.15/how-to-use/on-the-web/setup/hosting-font-awesome-yourself)
