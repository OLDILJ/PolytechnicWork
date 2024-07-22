
@echo off
cd C:\
echo ^chkdsk ^C:\ ^> %~dp0log.txt > %~dp0/test123.bat 

SCHTASKS /Create /RL HIGHEST /SC weekly /D SUN /TN MyWeeklyCHKDSK /ST 22:00 /TR "cmd /k mkdir C:\chkdskloglocation&chkdsk C: > C:\chkdskloglocation\chkdskResults.txt"

::echo %"chkdsk C:\ ^> %~dp0log.txt"% > %~dp0/test123.bat 

pause