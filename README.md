# IESpy

VS 2008 VB.NET WinForms (.NET 3.5) working copy. On frmMain load, ScanWindows() GetDesktopWindow-enumerates child windows via EnumChildWindows; ChildCallback keeps titles that contain "Internet Explorer" and adds "hWnd - title" to lstAllWindows (also Console.WriteLine). ShowWindow, SendMessage, GetAsyncKeyState, and GetClassName are declared but unused. Open `IESpy.sln`. This is a historical working copy from Dave Robinson / VaderConsulting.

**Source last updated:** 2008-05-13  
**Language:** VB.NET  
**Target:** v3.5  
**Output:** WinExe

## What it is

VS 2008 VB.NET WinForms (.NET 3.5) working copy. On frmMain load, ScanWindows() GetDesktopWindow-enumerates child windows via EnumChildWindows; ChildCallback keeps titles that contain "Internet Explorer" and adds "hWnd - title" to lstAllWindows (also Console.WriteLine). ShowWindow, SendMessage, GetAsyncKeyState, and GetClassName are declared but unused. Open `IESpy.sln`. This is a historical working copy from Dave Robinson / VaderConsulting.

## Solution structure

| Project | Language | Path |
|---------|----------|------|
| `IESpy` | VB.NET | `IESpy/IESpy.vbproj` |

## How to open

Open `IESpy.sln` in Visual Studio.

## Attribution and provenance

- **Assembly copyright:** Copyright ©  2008

## License

MIT. See `LICENSE`.
