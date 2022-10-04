$prefix = Read-Host "Please enter a unique prefix for the resources"
$subscription = "PG-Sandbox-01"
$location = "eastus2"
$resourceGroup = "AZ-RG-perfettif-Sandbox-01"
$storageAccountName = -join($prefix, "sa")
$servicePlanName = -join($prefix, "plan")
$functionAppName = -join($prefix, "app")
$vmName = -join($prefix, "vm")
$vmImage = "MicrosoftVisualStudio:visualstudio2022:vs-2022-comm-latest-ws2022:2022.09.21"


$subscriptions = az login

$subscription = az account set `
    --subscription $subscription

$storageAccount = az storage account create `
    --name $storageAccountName `
    --resource-group $resourceGroup `
    --location $location `
    --sku Standard_LRS       

#az storage account keys list -g $resourceGroup -n $storageAccountName

$appServicePlan = az appservice plan create `
    -g $resourceGroup `
    -n $servicePlanName `
    --sku S1 `
    --location $location

$functionApp = az functionapp create `
    -g $resourceGroup `
    -p $servicePlanName `
    -n $functionAppName `
    -s $storageAccountName `
    --os-type Windows `
    --functions-version 3

$vm = az vm create `
    -n $vmName `
    -g $resourceGroup `
    -l $location `
    --image $vmImage `
    --public-ip-sku Standard `
    --nsg-rule RDP `
    --authentication-type password `
    --admin-username pgcandidate `
    --size Standard_DS4_v2