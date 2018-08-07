% Wait command

# Description
The wait command will allow to delay execution of external processes
on command line, e.g. from batch / bash scripts

# Motivation
There are plenty "standard" methods to delay command line execution
like using SLEEP, PAUSE or TIMEOUT commands or even obusing PING.
All of them did not work appropriately in a batch file that
was executed in a background / service process in Windows environment.

This one worked!

# Build
## C#
See Microsoft's documents on compiling C# programmes and compile
wait.cs to wait.exe

# Usage
wait <NumberOfSeconds>
  
