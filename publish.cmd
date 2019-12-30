set DEST=.\src\content\
if exist %DEST% rd /q /s %DEST%
md %DEST%
dotnet publish .\blazorapp -o %DEST%
xcopy %DEST%clientside\dist\*.* %DEST% /s
rd /q /s %DEST%clientside\
