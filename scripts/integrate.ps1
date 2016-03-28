$baseDir = Resolve-Path ..
$scriptsDir = "$baseDir\scripts"
$sourceDir = "$baseDir\source"
$nugetCommand = "$sourceDir\.nuget\NuGet.exe"
$solutionFile = "$sourceDir\froko.csprojSetup.Sample.sln"

& $scriptsDir\clean.ps1	
& $nugetCommand restore $solutionFile

msbuild $solutionFile /target:Rebuild /p:Configuration=Release