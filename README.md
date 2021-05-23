# XAML Islands for .NET 5

This project is a port of XAML Islands to .NET 5.
Original source code comes from [Windows Toolkit](https://github.com/windows-toolkit/Microsoft.Toolkit.Win32). Some parts and controls are removed to keep this project small and concentrate on core thing.

## What is working?
- UWP controls from Windows.UI.Xaml namespace
- MapControl (Windows Toolkit)
- Custom controls (C++/WinRT project)

## What doesn't work?
- Custom controls (C# UWP project)

## How to crate private build of CsWinRT
There is a [bug](https://github.com/microsoft/CsWinRT/issues/597) in CsWinRT that won't let you compile WindowsSDKContracts project. A workaround is in repository: https://github.com/nesherhh/CsWinRT, branch: nesherhh/eventhandler. Clone it, run "Developer Command Prompt for VS..." and run "**build.cmd x64 release 1.2.5.49999 1.2.5-private.1 1.2.0.1**" inside src directory. This will build CsWinRT nuget package and put it in **src\\_build\x64\release\cswinrt\bin** directory. Now open nuget.config file inside XamlIslandsNET5 solution and change the value for "CsWinRT Offline" key to point to the directory where CsWinRT nuget package is. Now you can compile XamlIslandsNET5 solution.
