# TemplateTemplateIdDocumentsService

A list of all methods in the `TemplateTemplateIdDocumentsService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description            |
| :------------------------------------------------------ | :--------------------- |
| [GetTemplateDocumentsAsync](#gettemplatedocumentsasync) | Get template documents |

## GetTemplateDocumentsAsync

Get template documents

- HTTP Method: `GET`
- Endpoint: `/template/{template_id}/documents`

**Parameters**

| Name       | Type   | Required | Description |
| :--------- | :----- | :------- | :---------- |
| templateId | string | ✅       |             |
| accept     | string | ✅       |             |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using Alohi.Signplus;
using Alohi.Signplus.Config;

var config = new SignplusConfig{};

var client = new SignplusClient(config);

var response = await client.TemplateTemplateIdDocuments.GetTemplateDocumentsAsync("template_id", "application/json");

Console.WriteLine(response);
```
