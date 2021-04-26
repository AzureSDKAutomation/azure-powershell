<!-- region Generated -->
# Az.Portal
This directory contains the PowerShell module for the Portal service.

---
## Status
[![Az.Portal](https://img.shields.io/powershellgallery/v/Az.Portal.svg?style=flat-square&label=Az.Portal "Az.Portal")](https://www.powershellgallery.com/packages/Az.Portal/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.2.3 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Portal`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
    - $(this-folder)/../../tools/SwaggerCI/readme.azure.noprofile.md
    - $(this-folder)/../../../azure-rest-api-specs/specification/portal/resource-manager/readme.md
try-require:
    - $(this-folder)/../../../azure-rest-api-specs/specification/portal/resource-manager/readme.powershell.md
```
