(**
---
title: Source Line, File, Directory Identifiers
description: These all respect the #line directive (See [Compiler Directives](/other-concepts/compiler.html)).
keywords: number
---

Current line number
 *)
printfn "__LINE__ is %s" __LINE__

(**
Full path of the source file directory
 *)
printfn "__SOURCE_DIRECTORY__ is %s" __SOURCE_DIRECTORY__

(**
Filename (no path) of the source file
 *)
printfn "__SOURCE_FILE__ is %s" __SOURCE_FILE__
