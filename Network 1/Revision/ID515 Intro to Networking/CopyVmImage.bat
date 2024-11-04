@echo off
rem Generic Copy Script - Copies specified resources between folders with additional checks and cleanup options

rem Revisions:
rem Revision 0.3 - Internalisation of DELETE variable to overwrite existing content (13/07/2015, C. Frantz)
rem Revision 0.2 - Adaptation as generic copying script (21/04/2015, C. Frantz)
rem Revision 0.1 - Initial revision (19/02/2015, C. Frantz)

rem PARAMETERS

rem generic human-readable description of copied content
SET CONTENT_DESCRIPTION=VMware Image
SET SOURCE_DRIVE=L:
rem SOURCE_MIDFIX can be empty. If filled, add leading and tailing backslashes in folder definitions (ie. \ at start and end)
SET SOURCE_MIDFIX=\Virtual Machines\IN515\
rem Actual folder to be copied. No need to specify slashes.
SET IMAGE_FOLDER=Wireshark
SET TARGET_DRIVE=D:
rem TARGET_FOLDER can be empty. If filled, add leading and tailing backslashes in folder definitions (ie. \ at start and end)
SET TARGET_FOLDER=\IN515_VMs\
rem Set to 1 to overwrite target without asking (e.g. spring cleaning) - default should be 0
SET DELETE=0

rem CLEAN UP TARGET IF NECESSARY

if %DELETE% == 1 (goto delete) ELSE (goto end)

:delete
echo Deleting original target data ...
if EXIST %TARGET_DRIVE%%TARGET_FOLDER%%IMAGE_FOLDER% (goto actuallyDelete) ELSE (goto end)
goto end

:actuallyDelete
rd %TARGET_DRIVE%%TARGET_FOLDER%%IMAGE_FOLDER% /s /q

:end

rem PERFORM ACTUAL COPYING

rem Tests for network drive
IF EXIST %SOURCE_DRIVE% (GOTO yes)

:no
echo Could not find Drive %SOURCE_DRIVE% (Software). 
echo Check that network shares have been properly initialised at startup.
echo If not, open Windows Explorer, type \\op.ac.nz in the Address field on top of the window and press Enter.
echo You should then see the NETLOGON folder. Enter that and doubleclick on the file OTek-Logon.vbs. That should restore all your network shares. Once successful, you can rerun this script.
pause
exit


:yes
echo Copying %CONTENT_DESCRIPTION% %IMAGE_FOLDER% to path %TARGET_DRIVE%%TARGET_FOLDER%%IMAGE_FOLDER%. 
echo Note that this can take a few minutes!
xcopy /K /R /E /I /S /C /H "%SOURCE_DRIVE%%SOURCE_MIDFIX%%IMAGE_FOLDER%" "%TARGET_DRIVE%%TARGET_FOLDER%%IMAGE_FOLDER%"

echo %CONTENT_DESCRIPTION% copied. It is now ready for use.
echo ======================================================================
echo You can find the %CONTENT_DESCRIPTION% under %TARGET_DRIVE%%TARGET_FOLDER%%IMAGE_FOLDER%
echo ======================================================================
echo Press key to close the window.
pause
