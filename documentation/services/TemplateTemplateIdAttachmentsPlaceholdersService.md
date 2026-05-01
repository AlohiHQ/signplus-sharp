# TemplateTemplateIdAttachmentsPlaceholdersService

A list of all methods in the `TemplateTemplateIdAttachmentsPlaceholdersService` service. Click on the method name to view detailed information about that method.

| Methods                                                                             | Description                                                     |
| :---------------------------------------------------------------------------------- | :-------------------------------------------------------------- |
| [SetTemplateAttachmentsPlaceholdersAsync](#settemplateattachmentsplaceholdersasync) | Placeholders to be set, completely replacing the existing ones. |

## SetTemplateAttachmentsPlaceholdersAsync

Placeholders to be set, completely replacing the existing ones.

- HTTP Method: `PUT`
- Endpoint: `/template/{template_id}/attachments/placeholders`

**Parameters**

| Name       | Type                                      | Required | Description       |
| :--------- | :---------------------------------------- | :------- | :---------------- |
| input      | SetTemplateAttachmentsPlaceholdersRequest | ✅       | The request body. |
| templateId | string                                    | ✅       |                   |
| accept     | string                                    | ✅       |                   |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;
using Alohi.Signplus.Models;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var placeholdersItem = new SetTemplateAttachmentsPlaceholdersRequestPlaceholders(Optional<string?>.Of("string"), Optional<string?>.Of("string"), Optional<bool?>.Of(false), Optional<bool?>.Of(false), Optional<string?>.Of("string"), Optional<string?>.Of("string"));
var placeholders = new List<SetTemplateAttachmentsPlaceholdersRequestPlaceholders>() { placeholdersItem };
var input = new SetTemplateAttachmentsPlaceholdersRequest(Optional<List<SetTemplateAttachmentsPlaceholdersRequestPlaceholders>?>.Of(placeholders));

var response = await client.TemplateTemplateIdAttachmentsPlaceholders.SetTemplateAttachmentsPlaceholdersAsync(input, "template_id", "application/json");

Console.WriteLine(response);
```
