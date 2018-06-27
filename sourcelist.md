#Sources Used in This Project#
This document contains some sources used in researching concepts for this application. Some code examples are used as-is, others are modified beyond recognition to work with this particular application. The list is simply a reference to return to the point of origin at a later point in time.
This document contains some sources used in researching concepts for this application. Some code examples are used as-is, others are modified beyond recognition to work with this particular application, and others are ignored completely. The list is simply a reference to return to the point of origin at a later point in time.

**HotKey Registration**
- https://bloggablea.wordpress.com/2007/05/01/global-hotkeys-with-net/
- http://codesamplez.com/development/wpf-hotkeys-c-sharp
- https://msdn.microsoft.com/en-us/library/windows/desktop/ms646309(v=vs.85).aspx
- https://github.com/mrousavy/Hotkeys/blob/master/Hotkeys/ !!

**Hide window on close**
- https://stackoverflow.com/questions/638942/wpf-hide-on-close
- https://stackoverflow.com/questions/2329978/the-calling-thread-must-be-sta-because-many-ui-components-require-this

**Create a Windows Service**
- https://docs.microsoft.com/en-us/dotnet/framework/windows-services/walkthrough-creating-a-windows-service-application-in-the-component-designer
- https://docs.microsoft.com/en-us/dotnet/framework/windows-services/introduction-to-windows-service-applications

** Install Service without User Account**
- https://stackoverflow.com/a/2253066

** Delete/Uninstall Service**
- https://docs.microsoft.com/en-us/previous-versions/windows/it-pro/windows-server-2012-R2-and-2012/cc742045(v=ws.11) (Make sure Services.msc is closed or it will "hang" the uninstall...)

** WIX installer to allow creating installer that installs and registers services **
- http://wixtoolset.org/
- https://marketplace.visualstudio.com/items?itemName=RobMensching.WixToolsetVisualStudio2017Extension

<<<<<<< HEAD
** Dock a window to the AppBar **
- https://github.com/mgaffigan/WpfAppBar
=======
** Host a WCF Service inside a Managed Windows Service **
*** This will be used to allow me to build a WPF/XAML application that the user can interact with, and allow it to communicate directly with the background TimeTrak service ***
- https://docs.microsoft.com/en-us/dotnet/framework/wcf/feature-details/how-to-host-a-wcf-service-in-a-managed-windows-service
- https://docs.microsoft.com/en-us/dotnet/framework/wcf/how-to-host-a-wcf-service-in-a-managed-application

** Allow users to specify a URL for a web service or local service **
- http://www.diogonunes.com/blog/calling-a-web-method-in-c-without-a-service-reference/
- https://stackoverflow.com/a/5036342/5517386
- https://docs.microsoft.com/en-us/dotnet/framework/wcf/specifying-an-endpoint-address
>>>>>>> 70a268876fdb625f6bc61b1165847d15eddaf732

** App to App Communication **
- https://docs.microsoft.com/en-us/windows/uwp/app-to-app/
