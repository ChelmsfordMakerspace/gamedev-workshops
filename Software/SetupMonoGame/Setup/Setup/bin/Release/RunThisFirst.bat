@echo off
IF EXIST  C:\Windows\Microsoft.NET\Framework\v4.0.* ( 
echo You have .Net 4.0 installed. Setup will continue 
) ELSE ( 
echo You have not got .Net 4.0 installed, setup will do this now. 
Prereq\dotNetFx40_Full_x86_x64.exe
)
setup.exe