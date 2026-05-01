# TemplateTemplateIdRenameService

A list of all methods in the `TemplateTemplateIdRenameService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description     |
| :------------------------------------------ | :-------------- |
| [RenameTemplateAsync](#renametemplateasync) | Rename template |

## RenameTemplateAsync

Rename template

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/rename`

**Parameters**

| Name       | Type                  | Required | Description       |
| :--------- | :-------------------- | :------- | :---------------- |
| input      | RenameTemplateRequest | ✅       | The request body. |
| templateId | string                | ✅       |                   |
| accept     | string                | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var input = new RenameTemplateRequest(Optional<string?>.Of("<string>"));

var response = await client.TemplateTemplateIdRename.RenameTemplateAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
