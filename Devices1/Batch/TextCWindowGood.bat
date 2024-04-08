0</* :
@echo off
  setlocal
    echo Some batch code here...
    cscript /nologo /e:jscript "%~f0" "Warning!"
    pause
    echo Another batch code...
    cscript /nologo /e:jscript "%~f0" "All done!"
    pause
  endlocal
exit /b*/0;
(function(msg) {
   with (new ActiveXObject('Internet.HHCtrl')) {
      TextPopup(msg, 'Lucida Console, 23', 1, 1, 1, 1);
      WScript.Sleep(1500);
   }
}(
   WScript.Arguments.length !== 1 ?
   WScript.Quit(1) : WScript.Arguments.Unnamed(0)
));
