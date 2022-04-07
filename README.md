# XAML Islands for .NET 5

This project is a port of XAML Islands to .NET 5.
Original source code comes from [Windows Toolkit](https://github.com/windows-toolkit/Microsoft.Toolkit.Win32). Some parts and controls are removed to keep this project small and concentrate on core thing.

## What is working?
- UWP controls from Windows.UI.Xaml namespace
- MapControl (Windows Toolkit)
- Custom controls (C++/WinRT project)
- Custom controls (C# .NET 5 + Generic.xaml in C++/WinRT project)

## What doesn't work?
- Custom controls (C# UWP project)
- Custom controls (C# .NET 5 + Generic.xaml in .NET 5 project)

## How to compile XAML Islands
- Compile CsWinRT private build (see 'How to create a private build of CsWinRT')
- Restore with '**msbuild /t:restore XamlIslandsNET5NoSamples.sln**' then '**nuget restore XamlIslandsNET5NoSamples.sln**'
- Compile XAML Islands projects using '**msbuild /t:Pack /p:Platform=x64 /p:Configuration=Release -m XamlIslandsNET5NoSamples.sln**'
- Open Samples.sln and run CustomControlsWPFApp project

If you make any changes in CustomControls make sure to change the version number in CustomControls.csproj and update nuget package version. 

## How to create a private build of CsWinRT
There is a [bug](https://github.com/microsoft/CsWinRT/issues/597) in CsWinRT that won't let you compile WindowsSDKContracts project. A workaround is in repository: https://github.com/nesherhh/CsWinRT, branch: nesherhh/eventhandler. Clone it, run "Developer Command Prompt for VS..." and run "**build.cmd x64 release 1.2.5.49999 1.2.5-private.1 1.2.0.1**" inside src directory. This will build CsWinRT nuget package and put it in **src\\_build\x64\release\cswinrt\bin** directory. Now open nuget.config file inside XamlIslandsNET5 solution and change the value for "CsWinRT Offline" key to point to the directory where CsWinRT nuget package is. Now you can compile XamlIslandsNET5 solution.
