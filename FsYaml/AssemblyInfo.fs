﻿namespace global

open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

[<assembly: AssemblyTitle("FsYaml")>]
[<assembly: AssemblyDescription("Type safe Yaml library for F#.")>]
[<assembly: Guid("6852C155-6DAA-4CC2-B44A-BD83B23D17C0")>]

[<assembly: AssemblyVersion("2.0.2.0")>]
[<assembly: AssemblyFileVersion("2.0.2.0")>]

// NOTE: nuget pack uses this as its nuget version
[<assembly: AssemblyInformationalVersion("2.0.2-mjcustom2")>]

[<assembly: InternalsVisibleTo("FsYaml.Tests")>]
()
