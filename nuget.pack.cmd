@echo off
set /p VERSION=What version are you building?

if exist ".\releases\%VERSION%" (
	echo **** ERROR ****
	echo %VERSION% already exists
	goto END
)

set OUT=releases\%VERSION%

.\Library\NuGet\nuget.exe pack Fluqi.nuspec -OutputDirectory %OUT%

echo Sign into NuGet account and upload the nuspec file manually.

:END

