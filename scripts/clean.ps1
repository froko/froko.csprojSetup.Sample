$baseDir = Resolve-Path ..
$sourceDir = "$baseDir\source"
$nugetDir = "$baseDir\nuget"

Get-Childitem $sourceDir -Include bin, obj -Recurse | 
Where {$_.psIsContainer -eq $true} | 
Foreach-Object { 
	Write-Host "deleting" $_.fullname
	Remove-Item $_.fullname -Force -Recurse -ErrorAction SilentlyContinue
}

Write-Host "deleting" $nugetDir	
Remove-Item $nugetDir -Force -Recurse -ErrorAction SilentlyContinue	