```
~/Projects/segfault $ ./build.sh 
MSBuild version 17.4.0+18d5aef85 for .NET
  Determining projects to restore...
  All projects are up-to-date for restore.
  Library -> /home/user/Projects/segfault/Library/bin/Release/net7.0/linux-x64/Library.dll
  Library -> /home/user/Projects/segfault/lib/

[nix-shell:~/Projects/segfault]$ gdb a.out 
GNU gdb (GDB) 12.1
Copyright (C) 2022 Free Software Foundation, Inc.
License GPLv3+: GNU GPL version 3 or later <http://gnu.org/licenses/gpl.html>
This is free software: you are free to change and redistribute it.
There is NO WARRANTY, to the extent permitted by law.
Type "show copying" and "show warranty" for details.
This GDB was configured as "x86_64-unknown-linux-gnu".
Type "show configuration" for configuration details.
For bug reporting instructions, please see:
<https://www.gnu.org/software/gdb/bugs/>.
Find the GDB manual and other documentation resources online at:
    <http://www.gnu.org/software/gdb/documentation/>.

For help, type "help".
Type "apropos word" to search for commands related to "word"...
Reading symbols from a.out...
(gdb) r
Starting program: /home/lontivero/Projects/segfault/a.out 
[Thread debugging using libthread_db enabled]
Using host libthread_db library "/nix/store/9xfad3b5z4y00mzmk2wnn4900q0qmxns-glibc-2.35-224/lib/libthread_db.so.1".

Program received signal SIGSEGV, Segmentation fault.
0x0000000000514625 in S_P_CoreLib_System_Runtime_CompilerServices_ClassConstructorRunner_Cctor__GetCctor ()
(gdb) bt
#0  0x0000000000514625 in S_P_CoreLib_System_Runtime_CompilerServices_ClassConstructorRunner_Cctor__GetCctor ()
#1  0x00000000004e9248 in S_P_CoreLib_System_Runtime_CompilerServices_ClassConstructorRunner__EnsureClassConstructorRun ()
#2  0x00000000004e91d9 in S_P_CoreLib_System_Runtime_CompilerServices_ClassConstructorRunner__CheckStaticClassConstructionReturnNonGCStaticBase ()
#3  0x000000000051b84d in Library_WabiSabi_Native_NativeInterface__TestSegfault ()
#4  0x0000000000404c6c in main () at Main/main.c:20
(gdb) 
```
