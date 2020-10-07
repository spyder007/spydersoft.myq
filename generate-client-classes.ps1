
$sep = [IO.Path]::DirectorySeparatorChar

$outFolder = ".$($sep)openapiclient"

& npx @openapitools/openapi-generator-cli generate -g csharp-netcore -o "$outFolder" -i ".$($sep)spec$($sep)myq-v5.1.yaml" --additional-properties=packageName=spydersoft.myq

Remove-Item -Recurse ".$($sep)Api" -ErrorAction SilentlyContinue 
Remove-Item -Recurse ".$($sep)Client" -ErrorAction SilentlyContinue 
Remove-Item -Recurse ".$($sep)Model" -ErrorAction SilentlyContinue 


Write-Host "Copying files to .\src\api"
Copy-Item "$outfolder$($sep)src$($sep)spydersoft.myq$($sep)Api$($sep)" ".$($sep)spydersoft.myq$($sep)Api" -Recurse -Force
Copy-Item "$outfolder$($sep)src$($sep)spydersoft.myq$($sep)Client$($sep)" ".$($sep)spydersoft.myq$($sep)Client" -Recurse -Force
Copy-Item "$outfolder$($sep)src$($sep)spydersoft.myq$($sep)Model$($sep)" ".$($sep)spydersoft.myq$($sep)Model" -Recurse -Force

