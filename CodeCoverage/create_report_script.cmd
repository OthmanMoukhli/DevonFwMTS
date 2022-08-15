:: runs commands to test and generate code coverage report 
:: use terminal to run script
cd %~dp0 
cd..
set "projectPath=%CD%"
cd %projectPath%\Templates\WebAPI\Devon4Net.Test 
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude="[xunit.*]*" /p:CoverletOutput="%projectPath%\CodeCoverage\test_result\coverage.cobertura.xml"
reportgenerator "-reports:%projectPath%\CodeCoverage\test_result\coverage.cobertura.xml" "-targetdir:%projectPath%\CodeCoverage\report"
start %projectPath%\CodeCoverage\report\index.html
