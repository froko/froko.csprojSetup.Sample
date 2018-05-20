. ".\environment.ps1"

class Project {
    $name
    $path
    $solutionFile
    $testProjectFile

    Project($name, $path, $solutionFile) {
        $this.name = $name
        $this.path = $path
        $this.solutionFile = "$path\$solutionFile"
        $this.testProjectFile = "$path\TestProject.csproj"
    }
}

$mylibrary = [Project]::new("MyLibrary", "$baseDir\source", "froko.csprojSetup.Sample.sln")

$projects = $mylibrary