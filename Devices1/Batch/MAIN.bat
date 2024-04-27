:: Main.BAT
:: To do all the questions in Batch Script File Assignment
:: Logan J. Olding 1000126286
:: Platforms and Devices Bachelor IT year 1 2024

@echo off

echo This bat only fully works in admin mode.
echo Question 1
echo echo
echo Output my name to screen
echo. 
echo Logan J. Olding 
echo. 
pause
echo Question 2
echo output file name to screen
echo %~nx0
echo %~dpnx0
echo %~n0
pause
echo question 3,4,5,6
echo if, if not, mkdir
echo make the dirs/folders if they do not already exist
if exist "C:\My Batch Script File Assignment" (
echo Batchscript Already Exists
echo.
)
if not exist "C:\My Batch Script File Assignment" (
mkdir "C:\My Batch Script File Assignment"
echo Made Batchscript
echo.
)
pause
if exist "C:\My Batch Script File Assignment\Input" (
echo Input Already Exists
echo.
)
if not exist "C:\My Batch Script File Assignment\Input" (
mkdir "C:\My Batch Script File Assignment\Input"
echo Made Input
echo.
)
pause
if exist "C:\My Batch Script File Assignment\Processing" (
echo Processing Already Exists
echo.
)
if not exist "C:\My Batch Script File Assignment\Processing" (
mkdir "C:\My Batch Script File Assignment\Processing"
echo Made Processing
echo.
)
pause
if exist "C:\My Batch Script File Assignment\Output" (
echo Output Already Exists
echo.
)
if not exist "C:\My Batch Script File Assignment\Output" (
mkdir "C:\My Batch Script File Assignment\Output"
echo Made Output
echo.
)
echo DIR MODIFICATION FINISHED
pause
echo question 7
echo dir + syntax
echo list hidden files in the root of C and output to file in input subfolder
echo Input Data Start
echo.
dir C:\ /aH-D > "C:\My Batch Script File Assignment\Input\Input Data.txt"
echo Input Data Done
pause
echo question 8
echo back up input data onto the root of C + .bak extension
echo xcopy + syntax + echo statement to override it asking for paranoia reasons
echo copy start
echo f | xcopy /f /y /s /z "C:\My Batch Script File Assignment\Input\Input Data.txt" "C:\Input Data.bak"
echo copy fin
pause
echo question 9
echo cd
echo go to c:\
echo moving to C:\
cd C:\
echo Moved to C:\
echo Displaying contents of current location
dir
echo question 10 
echo PATH, path
echo update path to include processing subfolder then display search path
echo.
echo Path stuff
echo.
echo processing PATH
PATH=%PATH%;"C:\My Batch Script File Assignment\Processing"
echo processing path added
path
echo question 11
echo include time hello world and the ">" symbol
echo cls, %date%, %time%, syntax again
echo.
echo Clearing Text
pause
cls
echo Date and Time: %date% %time%
echo Hello World
echo ^>
echo.
pause
echo question 12,13
echo start, cmd, color, &, echo, wmic,
echo make 2 windows with custom colored text and background and display winows version number on one.
start cmd /k "color 24&echo test message"
start cmd /k "color f1&echo Windows&wmic os get version"
echo.
pause
echo question 14
echo dir + syntax
echo list all folders in system32 in alphabetical order and output to file in output folder.
echo.
echo Output DIR start
dir C:\WINDOWS\System32 /aD /on > "C:\My Batch Script File Assignment\Output\Batch Script File Output Data.txt"
echo Output DIR end
echo.
pause
echo question 15
echo dir + syntax
echo list all text files in C: drive that names with 7 or less characters and append to output file.
echo.
echo Append Output TXT start
dir c:\???????.txt /s /w >> "C:\My Batch Script File Assignment\Output\Batch Script File Output Data.txt"
echo Append Output TXT end
echo question 16
echo rmdir
echo nuke batchscriptassignment folder
echo.
echo deleting MyBatchScriptFileAssignment Folder
pause
rmdir /s "C:\My Batch Script File Assignment"
echo.
echo question17
echo netsh
echo dump network config to screen
echo dumping network config
pause
netsh dump
echo.
echo question 18
echo make local user a local group and add user to group.
echo net + syntax
echo.
echo creating bob
net user "Bob" "password" /add
echo creating awesome users
net localgroup "Awesome Users" /add
echo adding bob to awesome users
net localgroup "Awesome Users" "Bob" /add
echo question 19
echo net + syntax
echo delete group and user
echo.
echo removing bob and awesome users
pause
net localgroup "Awesome Users" "Bob" /delete
net localgroup "Awesome Users" /delete
net user "Bob" /delete
pause
echo question 20
echo schtasks, cmd, mkdir, syntax
echo schedule a task at 10pm every sunday to chkdsk and output to a file on the desktop
echo scheduling task
::SCHTASKS /Create /SC weekly /D SUN /TN MyWeeklyCHKDSK /ST 22:00 /TR "C:\Windows\System32\chkdsk.exe  >> "%userprofile%\Desktop\chkdskResults.txt"
SCHTASKS /Create /RL HIGHEST /SC weekly /D SUN /TN MyWeeklyCHKDSK /ST 22:00 /TR "cmd /k mkdir C:\chkdskloglocation&chkdsk C: > C:\chkdskloglocation\chkdskResults.txt"
::SCHTASKS /Create /RL HIGHEST /sc ONCE /sd 01/01/1910 /st 00:00 /TN MyWeeklyCHKDSK /TR "cmd /k chkdsk C: > %UserProfile%\Desktop\chkdskResults.txt" ::You would think this works but it doesnt just gives cant find path error so unless I can hardcode the exact desktop location it wont work. + if onedrive backup is on (which it is by default) then everythin will be pathing to that instead which is doubly bad. the only method I can think of that works is opening a powershell and doing something odd like $dir = [Environment]::GetFolderPath("Desktop") which should work but I cant be bothered doing more spaghetti at this point
::SCHTASKS /TN MyWeeklyCHKDSK /TR "C:\Windows\System32\chkdsk.exe  >> "%userprofile%\Desktop\chkdskResults.txt" /Create /sc ONCE /sd 01/01/1910 /st 00:00
echo task successfully scheduled
pause