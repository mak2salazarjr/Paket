﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A dependency manager for .NET with support for NuGet packages and git repositories.")>]
[<assembly: AssemblyVersionAttribute("3.13.3")>]
[<assembly: AssemblyFileVersionAttribute("3.13.3")>]
[<assembly: AssemblyInformationalVersionAttribute("3.13.3")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "3.13.3"
    let [<Literal>] InformationalVersion = "3.13.3"