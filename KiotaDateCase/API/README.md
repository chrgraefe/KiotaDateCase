# Step for setup

## install Kiota

dotnet tool install --global Microsoft.OpenApi.Kiota

## generate client

call via Pwsh in folder "\API"

kiota generate `
 --language csharp `
 --namespace-name Example.Endpoint `
 --exclude-backward-compatible `
 --output .\geratedCode `
 --additional-data false `
 --serializer none `
 --deserializer none `
 --openapi "api.yaml"